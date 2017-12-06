using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMSWarehouse
{
    public partial class FrmStockAdjustment : Form
    {

        public struct StockItem
        {
            public int StocktakeID, BinID, Product_ID, Qty;
            public string SKU;
        }

        public StockItem Prod;

        private int CompanyID;
        private int WarehouseID;
        private int ProductID;
        private Wrapper WS = new Wrapper();


        public FrmStockAdjustment(int fProductD, int fWarehouseID, int fCompanyID)
        {
            CompanyID = fCompanyID;
            WarehouseID = fWarehouseID;
            ProductID = fProductD;
            InitializeComponent();
            LoadData();
            Prod.StocktakeID = 0;
            Prod.Product_ID = 0;
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            try
            {
                DataSet ds = WS.GetStockItem(ProductID, WarehouseID);
                dgStock.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgStock_SelectionChanged(object sender, EventArgs e)
        {
            Prod.BinID = int.Parse(dgStock.CurrentRow.Cells["Bin_ID"].Value.ToString());
            Prod.Product_ID = int.Parse(dgStock.CurrentRow.Cells["Product_ID"].Value.ToString());
            Prod.Qty = int.Parse(dgStock.CurrentRow.Cells["QtyChange"].Value.ToString());
            Prod.SKU = dgStock.CurrentRow.Cells["SKU"].Value.ToString();

            txtBin.Text = dgStock.CurrentRow.Cells["BinDescription"].Value.ToString();
            txtOldStock.Text = dgStock.CurrentRow.Cells["qty"].Value.ToString();
            txtNewStock.Text = dgStock.CurrentRow.Cells["QtyChange"].Value.ToString();


            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (Prod.Product_ID == 0)
            {
                MessageBox.Show("No Stock to adjust");
            }
            else
            {
                int.TryParse(txtNewStock.Text, out Prod.Qty);
                if (Prod.StocktakeID == 0)
                {
                    Prod.StocktakeID = WS.SetStockFromPick(WarehouseID, 1, "ADJUST" + DateTime.Now.ToString("yyyyMMddhhmmss"));
                }

                WS.SetStockTakeDetailAdjust(Prod.StocktakeID, Prod.Product_ID, Prod.SKU, Prod.Qty, Prod.BinID);
                LoadData();
            }
        }

        private void toolStripButtonAdjust_Click(object sender, EventArgs e)
        {
            if (Prod.StocktakeID == 0)
            {
                MessageBox.Show("No Item adjustment was saved");
            }
            else
            {
                WS.SetStockFromStockAdjustment(Prod.StocktakeID);
                Close();
            }
        }
    }
}
