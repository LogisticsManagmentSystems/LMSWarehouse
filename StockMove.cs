using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LMSWarehouse
{
    public partial class FrmStockMove : Form
    {

        int WarehouseID;
        int CompanyID;
        int UserID;
        private Wrapper WS = new Wrapper();

        public FrmStockMove(int fWarehouseID, int fCompanyID, int UserIdent)
        {
            WarehouseID = fWarehouseID;
            CompanyID = fCompanyID;
            UserID = UserIdent;
            InitializeComponent();
        }

        private void toolStripContainer_ContentPanel_Load(object sender, EventArgs e)
        {

            DataSet ds = WS.GetStockMoveType("",CompanyID,WarehouseID);
            cbStockMoveType.DataSource = ds.Tables[0];
            cbStockMoveType.ValueMember = "StockMoveCode";
            cbStockMoveType.DisplayMember = "StockMoveType";

        }

        private void toolStripButtonPick_Click(object sender, EventArgs e)
        {
            FrmItemScan FItemScan = new FrmItemScan(cbStockMoveType.SelectedValue.ToString(), 
                CompanyID, WarehouseID, UserID, 0,cbStockMoveType.Text);
            FItemScan.ShowDialog();
        }
    }
}
