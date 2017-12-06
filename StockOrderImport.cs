using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMSWarehouse
{
    public partial class FrmStockOrderImport : Form
    {
        string OrderType;
        int WarehouseID;
        int CompanyID;
        private Wrapper WS = new Wrapper();
        private ReportViewerPrint Rep = new ReportViewerPrint();

        public FrmStockOrderImport(int fCompanyID, int fWarehouseID, string fOrderType)
        {
            OrderType = fOrderType;
            CompanyID = fCompanyID;
            WarehouseID = fWarehouseID;
            InitializeComponent();
            
        }

        private void LoadDetail(int OrderID)
        {
            DataSet ds = WS.GetStockDetail(OrderID);
            dgOrderDetail.DataSource = ds.Tables[0];

        }

        private void dgOrder_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int OrdID = 0;
                if (int.TryParse(dgOrder.CurrentRow.Cells["StockOrder_ID"].Value.ToString(), out OrdID))
                {
                    LoadDetail(OrdID);
                }
            }
            catch
            {
                int OrdID = 0;
            }
        }

        private void RefreshData()
        {

            DataSet ds = WS.GetInterfaceOrders(WarehouseID, OrderType, DateTime.Now.AddDays(-60));
            if (ds.Tables[0].Rows.Count > 0)
            {
                int OrdID = 0;
                dgOrder.DataSource = ds.Tables[0];
                if (int.TryParse(dgOrder.CurrentRow.Cells["StockOrder_ID"].Value.ToString(), out OrdID))
                {
                    LoadDetail(OrdID);
                }

            }
        }

        private void FrmStockOrderList_Load(object sender, EventArgs e)
        {

        }

        private void FrmStockOrderImport_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void toolStripButtonOpenOrder_Click(object sender, EventArgs e)
        {
            WS.UpdateSetOrderStatus(int.Parse(dgOrder.CurrentRow.Cells["StockOrder_ID"].Value.ToString()), 1);
            RefreshData();
        }

    }
}
