using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMSWarehouse
{
    public partial class FrmStockMoveOrder : Form
    {
        int CompanyID;
        int WarehouseID;
        string OrderMoveCode;
        string Caption;
        private Wrapper WS = new Wrapper();
        int StockMoveID;

        public FrmStockMoveOrder(int fCompanyID, int fWarehouseID, string fOrderMoveCode, string fCaption)
        {
            CompanyID = fCompanyID;
            WarehouseID = fWarehouseID;
            OrderMoveCode = fOrderMoveCode;
            Caption = fCaption;
            InitializeComponent();
        }

        private void StockMoveOrder_Load(object sender, EventArgs e)
        {
            DataSet ds = WS.GetStockMovement(OrderMoveCode, CompanyID);
            dgStockMove.DataSource = ds.Tables[0];
            
        }

        private void dgStockMove_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                StockMoveID = 0;
                if (int.TryParse(dgStockMove.CurrentRow.Cells["StockMove_ID"].Value.ToString(), out StockMoveID))
                {
                      LoadDetail();
                }
            }
            catch
            {
                StockMoveID = 0;
            }
             
          
        }


        private void LoadDetail()
        {
            DataSet ds = WS.GetStockMovementDetail(StockMoveID);
            dgStockMoveDetail.DataSource = ds.Tables[0];

        }

        private void toolStripButtonExport_Click(object sender, EventArgs e)
        {
            DataSet ds = WS.SetStockOrder(0, WarehouseID, 1, 1, "RET" + StockMoveID.ToString(), CompanyID, "Sale",
             "City Couriers", "6 Koets Street", "Tygerberg Business Park", "Parow", "Bellville South", "7000",
             "Colibri Towelling (W/Cape) (PTY) LTD", "Colibri Towels", "17 Crompton Street", "Strand", "Strand", "7140",
             "RET" + StockMoveID.ToString(), "RET" + StockMoveID.ToString(), "");
            int OrderID = int.Parse(ds.Tables[0].Rows[0]["StockOrder_ID"].ToString());
            WS.SetStockOrderFromMove(StockMoveID, OrderID);


        }

        private void toolStripButtonDispatch_Click(object sender, EventArgs e)
        {
            DataSet ds = WS.SetStockOrder(0, WarehouseID, 1, 1, "RET" + StockMoveID.ToString(), CompanyID, "Sale",
             "City Couriers", "6 Koets Street", "Tygerberg Business Park", "Parow", "Bellville South", "7000",
             "Colibri Towelling (W/Cape) (PTY) LTD", "Colibri Towels", "17 Crompton Street", "Strand", "Strand", "7140",
             "RET" + StockMoveID.ToString(), "RET" + StockMoveID.ToString(), "");
            int OrderID = int.Parse(ds.Tables[0].Rows[0]["StockOrder_ID"].ToString());
            WS.SetStockOrderFromMove(StockMoveID, OrderID);

            frmDispatchItems Dispatch = new frmDispatchItems(CompanyID, WarehouseID,OrderID,"RET" + StockMoveID.ToString());
            Dispatch.ShowDialog();
        }
    }
}
