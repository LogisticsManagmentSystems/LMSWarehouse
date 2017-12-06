using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMSWarehouse
{
    public partial class FrmStockMoveSKU : Form
    {

        int WarehouseID;
        int CompanyID;
        int UserID;
        private Wrapper WS = new Wrapper();

        public FrmStockMoveSKU(int fWarehouseID, int fCompanyID, int fUserID)
        {
            WarehouseID = fWarehouseID;
            CompanyID = fCompanyID;
            UserID = fUserID;
            InitializeComponent();
            LoadStockBins();
        }

        public void LoadStockBins()
        {
            DataSet ds = WS.GetWarehouseStock(WarehouseID, "full");
            if (ds.Tables[0].Rows.Count > 0)
            {
                dgStockBins.DataSource = ds.Tables[0];
            }

            DataSet dm = WS.GetStockMoveType("", CompanyID, WarehouseID);
            cbStockMoveType.DataSource = dm.Tables[0];
            cbStockMoveType.ValueMember = "StockMoveCode";
            cbStockMoveType.DisplayMember = "StockMoveType";
        }

        private void dgStockBins_SelectionChanged(object sender, EventArgs e)
        {

        }



    }
}
