using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMSWarehouse
{
    public partial class FrmStockTakeItem : Form
    {
        private Wrapper WS = new Wrapper();

        private int StockTakeID;

        public FrmStockTakeItem(int fStockTakeID)
        {
            StockTakeID = fStockTakeID;
            InitializeComponent();
        }


        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResetBin()
        {
            txtBin.Text = "";
            txtItem.Text = "";
            lbScanned.Items.Clear();
            txtBin.Enabled = true;
            txtItem.Enabled = false;
            lblQty.Text = "0";
            txtBin.Focus();

        }

        private void txtBin_KeyUp(object sender, KeyEventArgs e)
        {
            int BinID = 0;

            if (e.KeyValue == 13)
            {
                try
                {
                    BinID = int.Parse(txtBin.Text);
                }
                catch
                {
                    MessageBox.Show("Invalid Bin Code!");
                    return;
                }

                DataSet dt = WS.GetStockTakeList(BinID, StockTakeID);
                if (dt.Tables[0].Rows.Count > 0)
                {
                    lblBin.Text = dt.Tables[0].Rows[0]["BinDescription"].ToString();

                    for (int x = 0; x < dt.Tables[0].Rows.Count; x++)
                    {
                        if (dt.Tables[0].Rows[0]["ItemBarCode"].ToString().Trim() != "")
                        {
                            lbScanned.Items.Add(dt.Tables[0].Rows[x]["ItemBarCode"].ToString());
                        }
                    }

                    lblQty.Text = lbScanned.Items.Count.ToString();
                    txtBin.Enabled = false;
                    txtItem.Enabled = true;
                    txtItem.Focus();
                }
                else
                {
                    MessageBox.Show("Bin not found");
                }

            }
        }

        private void txtItem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (txtItem.Text.Trim() != "")
                {
                    if (lbScanned.Items.Contains(txtItem.Text.Trim()))
                    {
                        MessageBox.Show("Duplicate");
                    }
                    else
                    {
                        WS.AddStockTakeItem(StockTakeID, int.Parse(txtBin.Text), txtItem.Text.Trim());
                        lbScanned.Items.Add(txtItem.Text.Trim());
                        lblQty.Text = lbScanned.Items.Count.ToString();
                    }
                }
                txtItem.Text = "";


            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            ResetBin();
        }
    }
}
