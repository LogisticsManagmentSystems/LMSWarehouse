using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMSWarehouse
{
    public partial class FrmPutAway : Form
    {

        
        private Wrapper WS = new Wrapper();

        private int WarehouseID;
        private int ProductID;
        private int Qty;
        private int BinID;
        public string SKU;

        public FrmPutAway(int fWarehouseID, int fProductID, int fQty)
        {
            InitializeComponent();
            WarehouseID = fWarehouseID;
            ProductID = fProductID;
            Qty = fQty;
            BinID = 0;
            SKU = "";
            FRefresh();
        }

        private void FRefresh()
        {
            try
            {
                DataSet ds = WS.GetPutStockLine(WarehouseID, ProductID, SKU);
                txtQty.Text = Qty.ToString();
                SKU = ds.Tables[0].Rows[0]["SKU"].ToString();
                lblProduct.Text = SKU + ": " + ds.Tables[0].Rows[0]["ProductDescription"].ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButtonPutAway_Click(object sender, EventArgs e)
        {           
            if (int.TryParse(txtQty.Text, out Qty) && (BinID > 0))
            {
                DataSet dp = WS.GetStockOrderQty(WarehouseID, ProductID);

                int tmpQty = Qty;
                for (int i = 0; i < dp.Tables[0].Rows.Count; i++)
                {
                    int QtyStock = int.Parse(dp.Tables[0].Rows[i]["QTYFinal"].ToString());
                    if (QtyStock > tmpQty)
                    {
                        QtyStock = tmpQty;
                    }

                    if (QtyStock > 0)
                    {
                        WS.SetStockFromPutAway(WarehouseID, BinID, QtyStock, int.Parse(dp.Tables[0].Rows[i]["StockOrderDetail_ID"].ToString()));
                        tmpQty = tmpQty - QtyStock;
                    }
                }
                Close();
            }
            else
            {
                MessageBox.Show("Qty or Bin is not valid.");
            }
        }

        private void cbBin_Enter(object sender, EventArgs e)
        {
            DataSet ds = WS.GetBins(WarehouseID);

            DataRow dr = ds.Tables[0].NewRow();
            dr["Description"] = "Select All";
            dr["BarCode"] = 0;
            ds.Tables[0].Rows.InsertAt(dr, 0);

            cbBin.DataSource = ds.Tables[0];
            cbBin.ValueMember = "BarCode";
            cbBin.DisplayMember = "Description";
        }

        private void cbBin_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BinID = int.Parse(cbBin.SelectedValue.ToString());
            }
            catch
            {
                BinID = 0;
            }
        }


    }
}
