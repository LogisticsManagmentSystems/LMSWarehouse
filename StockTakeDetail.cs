using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMSWarehouse
{
    public partial class FrmStockTakeDetail : Form
    {

        int WarehouseID;
        int StockTakeID;
        int OrderStatusID;
        private Wrapper WS = new Wrapper();



        public FrmStockTakeDetail(int fWarehouseID, int fStockTakeID, int fOrderStatus)
        {
            WarehouseID = fWarehouseID;
            StockTakeID = fStockTakeID;
            OrderStatusID = fOrderStatus;
            
            InitializeComponent();
        }

        private void FrmStockTakeDetail_Load(object sender, EventArgs e)
        {
            DataSet ds = WS.GetStockTakeDetail(StockTakeID);

            dbStockTakeDet.DataSource = ds.Tables[0];
        }

        private void toolStripBtnUpdStock_Click(object sender, EventArgs e)
        {
            if (OrderStatusID == 3)
            {
                MessageBox.Show("This stock take is allready completed");
            }
            else
            {
                WS.SetStockFromStockTake(StockTakeID);
            }
        }

        private void toolStripClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dbStockTakeDet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                Color c;
                if (dbStockTakeDet.Rows[e.RowIndex].Cells["In stock"].Value.ToString().Trim() ==
                    dbStockTakeDet.Rows[e.RowIndex].Cells["StockTake"].Value.ToString().Trim())
                {
                    c = Color.LightGreen;
                }
                else
                {
                    c = Color.Pink;
                }

                e.CellStyle.BackColor = c;
            }
        }
    }
}
