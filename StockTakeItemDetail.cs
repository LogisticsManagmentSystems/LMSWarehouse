using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace LMSWarehouse
{
    public partial class FrmStockTakeItemDetail : Form
    {

        int WarehouseID;
        int StockTakeID;
        int OrderStatusID;
        private Wrapper WS = new Wrapper();

        public FrmStockTakeItemDetail(int fWarehouseID, int fStockTakeID, int fOrderStatus)
        {
            WarehouseID = fWarehouseID;
            StockTakeID = fStockTakeID;
            OrderStatusID = fOrderStatus;
            InitializeComponent();
        }

        private void LoadData()
        {
            DataSet ds = WS.GetStockTakeItems(StockTakeID);
            dbStockTakeDet.DataSource = ds.Tables[0];
        }

        private void StockTakeItemDetail_Load(object sender, EventArgs e)
        {
            LoadData();
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
                if (dbStockTakeDet.Rows[e.RowIndex].Cells["BinDescription"].Value.ToString().Trim() ==
                    dbStockTakeDet.Rows[e.RowIndex].Cells["Previous location"].Value.ToString().Trim())
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

        private void toolStripBtnUpdStock_Click(object sender, EventArgs e)
        {
            if (OrderStatusID == 3)
            {
                MessageBox.Show("This stock take is allready completed");
            }
            else
            {


                DataSet dt = WS.GetStockMoveType("ST", 1, WarehouseID);
                int StockMove = WS.SetStockMove(WarehouseID, 1, DateTime.Now, "Stock Take : " + StockTakeID.ToString(), "ST");

                foreach (DataGridViewRow row in dbStockTakeDet.Rows)
                {
                    if ((row.Cells["BinDescription"].Value.ToString() != row.Cells["Previous location"].Value.ToString()) && (row.Cells["ItemBarCode"].Value.ToString().Trim() != ""))
                    {
                        WS.SetItemTrack(StockMove, row.Cells["ItemBarCode"].Value.ToString().Trim(), int.Parse(row.Cells["BinID"].Value.ToString()));

                    }
                }

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
                WS.SetStockFromStockTake(StockTakeID);
            }



        }

        private void btExportToExcel_Click(object sender, EventArgs e)
        {
            string dt = DateTime.Now.ToString("yyyyMMddhhmm");
            ExportDatagridviewToExcel(dbStockTakeDet, "c:\\temp\\Stocktake" + StockTakeID.ToString()+"-"+dt+ ".xls");
            System.Diagnostics.Process.Start("c:\\temp\\Stocktake" +StockTakeID.ToString()+"-"+dt+ ".xls");
        }


        public void ExportDatagridviewToExcel(DataGridView dgv, string excelfile)
        {
            int cols;
            //open file
            StreamWriter wr = new StreamWriter(excelfile);

            //Writing Header Information
            wr.Write("Report : Stocktake report " +StockTakeID.ToString() +" "+ DateTime.Now.ToString() + "\t");
            wr.WriteLine();
            wr.WriteLine();
            wr.WriteLine();
            wr.WriteLine();
            wr.WriteLine();
            wr.WriteLine();
            //determine the number of columns and write columns to file
            cols = dgv.Columns.Count;
            for (int i = 0; i < cols; i++)
            {
                wr.Write(dgv.Columns[i].Name.ToString().ToUpper() + "\t");
            }

            wr.WriteLine();

            //write rows to excel file
            for (int i = 0; i < (dgv.Rows.Count - 1); i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (dgv.Rows[i].Cells[j].Value != null)
                        wr.Write(dgv.Rows[i].Cells[j].Value + "\t");
                    else
                    {
                        wr.Write("\t");
                    }
                }

                wr.WriteLine();
            }

            //close file
            wr.Close();
        }

    }
}
