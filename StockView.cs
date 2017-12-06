using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMSWarehouse
{
    public partial class FrmStockView : Form
    {

        int WarehouseID;
        int CompanyID;
        string SKU;
        private Wrapper WS = new Wrapper();
        private ReportViewerPrint Rep = new ReportViewerPrint();

        public FrmStockView(int fCompanyID, int fWarehouseID)
        {
            CompanyID = fCompanyID;
            WarehouseID = fWarehouseID;
            InitializeComponent();
        }

        private void RefreshData()
        {
            dgStockView.AllowUserToResizeColumns = true;
            DataSet ds = WS.GetWarehouseStock(WarehouseID,"full");
            if (ds.Tables[0].Rows.Count > 0)
            {
                dgStockView.DataSource = ds.Tables[0];
            }
        }

        private void FrmStockView_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void toolStripBtnAllocate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to allocate this purchase order to available sales orders?", "Sales order allocation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int OrderAllocated = 0;
                int POStock = int.Parse(dgStockView.CurrentRow.Cells["Qty"].Value.ToString());
                if (POStock > 0)
                {

                    DataSet dsa = WS.GetSKUStockOrderDetail(int.Parse(dgStockView.CurrentRow.Cells["Product_ID"].Value.ToString()));
                    for (int y = 0; y < dsa.Tables[0].Rows.Count; y++)
                    {
                        if (POStock > 0)
                        {
                            if (POStock >= int.Parse(dsa.Tables[0].Rows[y]["QTY"].ToString()))
                            {
                                OrderAllocated = OrderAllocated + 1;

                                WS.SetStockFromPick(WarehouseID, int.Parse(dgStockView.CurrentRow.Cells["Bin_ID"].Value.ToString()), int.Parse(dsa.Tables[0].Rows[y]["QTY"].ToString()),
                                    int.Parse(dsa.Tables[0].Rows[y]["StockOrderDetail_ID"].ToString()));
                                Rep.PrintDN(int.Parse(dsa.Tables[0].Rows[y]["StockOrder_ID"].ToString()));
                                POStock = POStock - int.Parse(dsa.Tables[0].Rows[y]["QTY"].ToString());
                            }
                        }
                    }
                    if (OrderAllocated > 0)
                    {
                        MessageBox.Show(OrderAllocated.ToString() + " Sales Orders were allocated");
                        RefreshData();
                    }
                    else
                        MessageBox.Show("No Sales orders matched the items on this Purchase Order.");

                }
                
            }
        }

        private void toolStripDetail_Click(object sender, EventArgs e)
        {
            FrmItemDetail fItemDetail = new FrmItemDetail(CompanyID, WarehouseID, int.Parse(dgStockView.CurrentRow.Cells["Bin_ID"].Value.ToString()), 
                (int.Parse(dgStockView.CurrentRow.Cells["Product_ID"].Value.ToString())),"");
            fItemDetail.ShowDialog();
        }

        private void dgStockView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SKU = toolStripTextBox1.Text;
            dgStockView.DataSource = null;
            
            DataSet ds1 = new DataSet();
            ds1 = WS.GetWarehouseStock(WarehouseID, SKU);
            
            if (ds1.Tables[0].Rows.Count > 0)
            {
                dgStockView.DataSource = ds1.Tables[0];
            }
            dgStockView.Refresh();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pDetail_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
