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
    public partial class FrmStockOrderList : Form
    {
        string OrderType;
        int WarehouseID;
        int CompanyID;
        private Wrapper WS = new Wrapper();
        private ReportViewerPrint Rep = new ReportViewerPrint();

        public FrmStockOrderList(int fCompanyID, int fWarehouseID, string fOrderType)
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

            if (OrderType.ToUpper() == "SALE")
            {
                toolStripPrint.Visible = true;
            }
            else
            {
                toolStripPrint.Visible = false;
            }

            
            DataSet ds = WS.GetCompleteOrders(WarehouseID, OrderType, DateTime.Now.AddDays(-60));
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

        private void toolStripPrint_Click(object sender, EventArgs e)
        {
            bool ValidOrder = false;
            int OrderID = 0;
            ValidOrder = int.TryParse(dgOrder.CurrentRow.Cells["StockOrder_ID"].Value.ToString(), out OrderID);

            if (ValidOrder)
            {

                Rep.PrintDN(OrderID);


            }
            else
                MessageBox.Show("Sales Order not selected.");
        }

        private void FrmStockOrderList_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void toolStripButtonExport_Click(object sender, EventArgs e)
        {
            Utils ut = new Utils();
            //**************NB Comment out for Colibri*********************************
            //ut.ExportSOORderXMLTT(int.Parse(dgOrder.CurrentRow.Cells["StockOrder_ID"].Value.ToString()));            
            //**************NB Comment out for Tom Tom*********************************
            ut.ExportSOORderXML(int.Parse(dgOrder.CurrentRow.Cells["StockOrder_ID"].Value.ToString()));            
            //MessageBox.Show(ut.ExportLogidata(int.Parse(dgOrder.CurrentRow.Cells["StockOrder_ID"].Value.ToString())));
        }

        private void toolStripButtonDispatch_Click(object sender, EventArgs e)
        {
            frmDispatchItems Dispatch = new frmDispatchItems(CompanyID, WarehouseID,
                int.Parse(dgOrder.CurrentRow.Cells["StockOrder_ID"].Value.ToString()),
                dgOrder.CurrentRow.Cells["OrderReference"].Value.ToString());
            Dispatch.ShowDialog();
        }

        private void toolStripButtonOpenOrder_Click(object sender, EventArgs e)
        {
            WS.UpdateSetOrderStatus(int.Parse(dgOrder.CurrentRow.Cells["StockOrder_ID"].Value.ToString()), 2);
        }

        private void toolStripButtonTrack_Click(object sender, EventArgs e)
        {
            FrmItemDetail fItemDetail = new FrmItemDetail(CompanyID, WarehouseID, 0, 0, dgOrder.CurrentRow.Cells["OrderReference"].Value.ToString());
            fItemDetail.ShowDialog();
        }

        private void btnPRintItems_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = WS.GetOrderBarcodes(dgOrder.CurrentRow.Cells["OrderReference"].Value.ToString());
                dgOrderDetail.DataSource = ds.Tables[0];
                ExportDatagridviewToExcel(dgOrderDetail, "c:\\temp\\PickList.xls");
                System.Diagnostics.Process.Start("c:\\temp\\PickList.xls");
            }
            finally
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

        }


        public void ExportDatagridviewToExcel(DataGridView dgv, string excelfile)
        {
            int cols;
            //open file
            StreamWriter wr = new StreamWriter(excelfile);

            //Writing Header Information
            wr.Write("Report : Order pick list" + "\t");
            wr.WriteLine();
            wr.WriteLine();
            wr.Write("Date : " + DateTime.Now.ToString() + "\t");
            wr.WriteLine();
            wr.Write("Customer : " + dgOrder.CurrentRow.Cells[12].Value.ToString() + "\t");
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
            for (int i = 0; i < (dgv.Rows.Count); i++)
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Utils ut = new Utils();
            ut.ExportSOORderXML(4538);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Utils ut = new Utils();
            ut.ExportSOORderXML(6389);
        }

    }
}
