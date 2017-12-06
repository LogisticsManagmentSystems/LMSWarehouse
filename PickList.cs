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
    public partial class FrmPickList : Form
    {

        private Wrapper WS = new Wrapper();

        private int WarehouseID;
        private int SetOrderID;
        private int StockQty;
        private int CompanyID;

        public FrmPickList(int fWarehouseID,int fCompanyID)
        {
            WarehouseID = fWarehouseID;
            CompanyID = fCompanyID;
            SetOrderID = 0;
            StockQty = 0;
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                SetOrderID = 0;

                DataSet ds = WS.GetPickOrders(WarehouseID);
                {
                    dgOrder.DataSource = ds.Tables[0];
                    SetOrderID = int.Parse(dgOrder.CurrentRow.Cells[4].Value.ToString());
                }
            }
            catch (Exception e)
            {
                SetOrderID = 0;
                //MessageBox.Show("Could not load orders");

            }
        }

        private void LoadDetail(int OrderID)
        {
            try
            {
                DataSet ds = WS.GetPickItemLis(OrderID,0);
                dgDetail.DataSource = ds.Tables[0];
            }
            catch
            { 

            }
        }

        private void dgOrder_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                SetOrderID = int.Parse(dgOrder.CurrentRow.Cells[4].Value.ToString());
                LoadDetail(SetOrderID);
            }
            catch
            {
                SetOrderID = 0;
            }
        }

        private void toolStripButtonPick_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(dgDetail.CurrentRow.Cells[2].Value.ToString() + ":" + dgDetail.CurrentRow.Cells[9].Value.ToString());
                StockQty = int.Parse(dgDetail.CurrentRow.Cells[3].Value.ToString());
                int PickQty = (int.Parse(dgDetail.CurrentRow.Cells[2].Value.ToString()) - int.Parse(dgDetail.CurrentRow.Cells[9].Value.ToString()));
                if (StockQty > 0)
                {
                    FrmPick FPick = new FrmPick(int.Parse(dgDetail.CurrentRow.Cells[8].Value.ToString()),
                        int.Parse(dgDetail.CurrentRow.Cells[7].Value.ToString()),
                        int.Parse(dgDetail.CurrentRow.Cells[6].Value.ToString()),
                        WarehouseID, PickQty);
                    FPick.ShowDialog();
                    //FrmItemScan ItemScan = new FrmItemScan("PI", CompanyID, WarehouseID, 0, SetOrderID, "Pick Stock");
                    //ItemScan.QtyMax = PickQty;
                    //ItemScan.FromBinID = int.Parse(dgDetail.CurrentRow.Cells[7].Value.ToString());
                    //ItemScan.ShowDialog();
                    
                    //WS.UpdateStockOrderStatus();
                    LoadOrders();
                    LoadDetail(SetOrderID);
                }
                else
                {
                    MessageBox.Show("No stock for this item!");
                }
            }
            catch
            {
                MessageBox.Show("Invalid Item was selected");
            }


        }

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            toolStripBtnGenPickList_Click(sender, e);            
            ExportDatagridviewToExcel(dgDetail, "c:\\temp\\PickList.xls");
            System.Diagnostics.Process.Start("c:\\temp\\PickList.xls");
        }

        public void ExportDatagridviewToExcel(DataGridView dgv, string excelfile)
        {
            int cols;
            //open file
            StreamWriter wr = new StreamWriter(excelfile);

            //Writing Header Information
            wr.Write("Report : Pick List" + "\t");
            wr.WriteLine();
            wr.WriteLine();
            wr.Write("Date : " + DateTime.Now.ToString() + "\t");
            wr.WriteLine();
            wr.Write("Customer : " + dgOrder.CurrentRow.Cells[2].Value.ToString() + "\t");
            wr.WriteLine();
            wr.Write("Order : " + dgOrder.CurrentRow.Cells[1].Value.ToString() + "\t");
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
            for (int i = 0; i < dgv.Rows.Count ; i++)
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

        private void toolStripBtnGenPickList_Click(object sender, EventArgs e)
        {
            DataSet ds = WS.GetStockOrderConsolidated(SetOrderID);

            for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
            {
                int QtyRemain = int.Parse(ds.Tables[0].Rows[x]["QTY"].ToString());
                DataSet pd = WS.GetPickStockBins(int.Parse(ds.Tables[0].Rows[x]["Product_ID"].ToString()), WarehouseID);
                

                for (int y = 0; y < pd.Tables[0].Rows.Count; y++)
                {
                    if (QtyRemain > int.Parse(pd.Tables[0].Rows[y]["Qty"].ToString()))
                    {
                        WS.SetPicklistStockBins(SetOrderID, int.Parse(ds.Tables[0].Rows[x]["Product_ID"].ToString()),
                            int.Parse(pd.Tables[0].Rows[y]["Stock_ID"].ToString()), int.Parse(pd.Tables[0].Rows[y]["Qty"].ToString()));
                        QtyRemain = QtyRemain - int.Parse(pd.Tables[0].Rows[y]["Qty"].ToString());
                    }
                    else if (QtyRemain > 0)
                    {
                        WS.SetPicklistStockBins(SetOrderID, int.Parse(ds.Tables[0].Rows[x]["Product_ID"].ToString()),
                            int.Parse(pd.Tables[0].Rows[y]["Stock_ID"].ToString()), QtyRemain);
                        QtyRemain = 0;

                    }

                }

            }
            LoadDetail(SetOrderID);

        }

        private void toolStripBtnFreePick_Click(object sender, EventArgs e)
        {
            DataSet ds = WS.GetPickItemLis(SetOrderID, 1);
            dgDetail.DataSource = ds.Tables[0];
        }



    }
}
