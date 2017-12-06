using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace LMSWarehouse
{
    public partial class FrmAdminStockMove : Form
    {

        private Wrapper WS = new Wrapper();
        private int StockMove;
        private int CompanyID;
        private int WarehouseID;

        public FrmAdminStockMove(int fCompanyID, int fWarehouseID)
        {
            CompanyID = fCompanyID;
            WarehouseID = fWarehouseID;
            InitializeComponent();
        }

        private void toolStripContainer_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMoveStock_Click(object sender, EventArgs e)
        {
            StockMove = int.Parse(txtStockMove.Text);
            AsdjustStock();

        }

        private void AsdjustStock()
        {
            WS.SetStockMoveDetail(StockMove);
            DataSet DL = WS.GetStockMovementPrev(StockMove);
            for (int x = 0; x < DL.Tables[0].Rows.Count; x++)
            {
                WS.SetStockDelFromStockMove(WarehouseID, int.Parse(DL.Tables[0].Rows[x]["Bin_ID"].ToString()), int.Parse(DL.Tables[0].Rows[x]["Qty"].ToString()), int.Parse(DL.Tables[0].Rows[x]["StockMoveDetail_ID"].ToString()));
            }
            DataSet SA = WS.GetStockMovement(StockMove);
            for (int x = 0; x < SA.Tables[0].Rows.Count; x++)
            {
                WS.SetStockAddFromStockMove(WarehouseID, int.Parse(SA.Tables[0].Rows[x]["Bin_ID"].ToString()), int.Parse(SA.Tables[0].Rows[x]["Qty"].ToString()), int.Parse(SA.Tables[0].Rows[x]["StockMoveDetail_ID"].ToString()));
            }


        }


    }
}
