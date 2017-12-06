using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMSWarehouse
{
    public partial class FrmPick : Form
    {
        private struct BinItem
        {
            public int BinID, BinQty;
            public string ProductName, BinDescription;
        }
        private Wrapper WS = new Wrapper();

        private int BinID;
        private int ProductID;
        private int OrderDetailID;
        private int WarehouseID;
        private int QTY;
        private string ScanSKU;

        private BinItem Item;


        public FrmPick(int fOrderDetailID, int fBinID, int fProductID, int fWarehouseID, int fQty)
        {
            BinID = fBinID;
            ProductID = fProductID;
            OrderDetailID = fOrderDetailID;
            WarehouseID = fWarehouseID;
            QTY = fQty;
            ScanSKU = "";
            InitializeComponent();
            
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void GetBinData(int fBinID)
        {
            try
            {
                int ItemIndex = -1;
                for (int x = 0; x < dgBins.RowCount; x++)
                {
                    if (BinID.ToString() == dgBins.Rows[x].Cells[0].Value.ToString().Trim())
                    {
                        ItemIndex = x;
                    }
                    Item.ProductName = dgBins.Rows[x].Cells[4].Value.ToString();
                    ScanSKU = dgBins.Rows[x].Cells[5].Value.ToString();
                }
                if (ItemIndex == -1)
                {
                    BinID = 0;
                    Item.BinID = 0;
                    Item.BinDescription = "";
                    Item.BinQty = 0;
                }
                else
                {
                    BinID = int.Parse(dgBins.Rows[ItemIndex].Cells[0].Value.ToString()); ;
                    Item.BinID = int.Parse(dgBins.Rows[ItemIndex].Cells[0].Value.ToString());
                    Item.BinDescription = dgBins.Rows[ItemIndex].Cells[2].Value.ToString();
                    Item.BinQty = int.Parse(dgBins.Rows[ItemIndex].Cells[1].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void LoadFrm()
        {
            try
            {
                DataSet ds = WS.GetBinList(ProductID, "", WarehouseID);
                dgBins.DataSource = ds.Tables[0];
                GetBinData(BinID);

                lblBin.Text = Item.BinDescription;
                lblProduct.Text = ScanSKU + ": " + Item.ProductName;
                if (Item.BinQty < QTY)
                {
                    txtQty.Text = Item.BinQty.ToString();
                }
                else
                {
                    txtQty.Text = QTY.ToString();

                }
            }
            catch
            {
                Item.BinID = 0;
                BinID = 0;

            }
        }

        private void toolStripButtonPick_Click(object sender, EventArgs e)
        {
            try
            {
                int QtyValid = 0;
                if (Item.BinQty < QTY)
                {
                    QtyValid = Item.BinQty;
                }
                else
                {
                    QtyValid = QTY;
                }

                if (int.Parse(txtQty.Text) > QtyValid)
                {
                    MessageBox.Show("Qty is more then Stock in Bin");
                    return;
                }
                else
                {
                    if (BinID > 0)
                    {
                        OrderDetailID = WS.SetStockFromPick(WarehouseID, BinID, int.Parse(txtQty.Text), OrderDetailID);
                    }
                    else
                        if (int.Parse(txtQty.Text) > QtyValid)
                        {
                            MessageBox.Show("Bin Location is not valid");
                            return;
                        }

                    Close();
                }
            }
            catch
            {
                MessageBox.Show("An error occured. Could not pick stock");

            }
        }

        private void FrmPick_Load(object sender, EventArgs e)
        {
            LoadFrm();

        }




    }
}
