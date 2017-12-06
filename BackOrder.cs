using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

using ReportEngine.Barcoding;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Data.SqlClient;


namespace LMSWarehouse
{
    public partial class FrmBackOrder : Form
    {

        string OrderType;
        int WarehouseID;
        int CompanyID;

        private ReportViewerPrint Rep = new ReportViewerPrint();
        private Wrapper WS = new Wrapper();

        public FrmBackOrder(int fCompanyID, int fWarehouseID, string fOrderType)
        {
            OrderType = fOrderType;
            CompanyID = fCompanyID;
            WarehouseID = fWarehouseID;
            InitializeComponent();
        }

        private void FBackOrder_Load(object sender, EventArgs e)
        {
            RefreshData();            
        }

        private void LoadDetail(int OrderID)
        {
            DataSet ds = WS.GetStockDetail(OrderID);
            dgOrderDetail.DataSource = ds.Tables[0];

        }

        private void dgOrderDetail_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

        }

        private void dgOrderDetail_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                              
                Color c;
                if (dgOrderDetail.Rows[e.RowIndex].Cells["QTY"].Value.ToString().Trim() ==
                    dgOrderDetail.Rows[e.RowIndex].Cells["QTY Processed"].Value.ToString().Trim())
                {
                    c = Color.LightGreen;
                }
                else
                {
                    c = Color.Pink;
                }

                try
                {
                    if (int.Parse(dgOrderDetail.Rows[e.RowIndex].Cells["QTY Processed"].Value.ToString()) >
                        int.Parse(dgOrderDetail.Rows[e.RowIndex].Cells["QTY"].Value.ToString().Trim()))
                        c = Color.LightGreen;
                }
                catch
                {
                }

                e.CellStyle.BackColor = c;
            }

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

        private void tdBtnNewOrder_Click(object sender, EventArgs e)
        {
            LMSWarehouse.FrmStockOrder FStockOrder = new FrmStockOrder(CompanyID, WarehouseID, 0, OrderType);
            FStockOrder.ShowDialog();
            RefreshData();
        }

        private void tsEditOrder_Click(object sender, EventArgs e)
        {
            int OrdID = 0;
            if (int.TryParse(dgOrder.CurrentRow.Cells["StockOrder_ID"].Value.ToString(), out OrdID))
            {
                LMSWarehouse.FrmStockOrder FStockOrder = new FrmStockOrder(CompanyID, WarehouseID, OrdID, OrderType);
                FStockOrder.ShowDialog();
                RefreshData();
            }
 
        }

        private void RefreshData()
        {

            if (OrderType.ToUpper() == "SALE")
            {
                tsBtnReceiveOrder.Visible = false;
                toolStripButtonRecFloor.Visible = false;
            }

           //SqlDataReader ds = WS.GetIncompleteOrders(WarehouseID, OrderType);
           //DataTable dt = new DataTable();
           // if (ds.HasRows)
           // {
           //     int OrdID = 0;
                
                

           //     dt.Load(ds);
           //     dgOrder.DataSource = dt;
           //     if (int.TryParse(dgOrder.CurrentRow.Cells["StockOrder_ID"].Value.ToString(), out OrdID))
           //     {
           //         LoadDetail(OrdID);
           //     }

           // }
            //Replaced with data reader
            DataSet ds = WS.GetIncompleteOrders(WarehouseID, OrderType);
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

        private void tsBtnReceiveOrder_Click(object sender, EventArgs e)
        {
            string MType = "PO";
            string MDesc = "Purchase Order";
            if (OrderType.ToUpper() == "SALE")
            {
                MDesc = "Sales Order: " + dgOrder.CurrentRow.Cells["OrderReference"].Value.ToString();
                MType = "PI";
            }
            else
            {
                MDesc = "Purchase Order: " + dgOrder.CurrentRow.Cells["OrderReference"].Value.ToString();
                MType = "PO";
            }

            int OrdID = 0;
            if (int.TryParse(dgOrder.CurrentRow.Cells["StockOrder_ID"].Value.ToString(), out OrdID))
            {
                LMSWarehouse.FrmReceiveOrder FReceiveOrder = new FrmReceiveOrder(OrdID);
                FReceiveOrder.ShowDialog();
                RefreshData();
                //FrmItemScan FItemScan = new FrmItemScan(MType, CompanyID, WarehouseID, 0, OrdID, MDesc);
                //FItemScan.ShowDialog();
                //RefreshData();
            }
            else
            {
                MessageBox.Show("No Order was selected");
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            int OrdID = 0;
            if (int.TryParse(dgOrder.CurrentRow.Cells["StockOrder_ID"].Value.ToString(), out OrdID))
            {
                if (dgOrder.CurrentRow.Cells["OrderStatus"].Value.ToString().ToUpper() == "INDUCTED")
                {
                    WS.DeleteStockOrder(OrdID);
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("Processing has already begun on this order and can not be deleted");

                }
            }
        }

        private void toolStripAllocate_Click(object sender, EventArgs e)
        {
            bool ValidOrder = false;
            int OrderID = 0;
            ValidOrder = int.TryParse(dgOrder.CurrentRow.Cells["StockOrder_ID"].Value.ToString(), out OrderID);

            if ((ValidOrder) && (MessageBox.Show("Are you sure you want to allocate this purchase order to available sales orders?", "Sales order allocation", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                int OrderAllocated = 0;
                DataSet dpo = WS.GetStockDetail(OrderID);
                for (int x = 0; x < dpo.Tables[0].Rows.Count; x++)
                {
                    int POStock = int.Parse(dpo.Tables[0].Rows[x]["QTY Processed"].ToString());
                    if (POStock > 0)
                    {

                        if (int.Parse(dpo.Tables[0].Rows[x]["OrderStatus_ID"].ToString()) == 3)
                            POStock = 0;

                        DataSet dsa = WS.GetSKUStockOrderDetail(int.Parse(dpo.Tables[0].Rows[x]["Product_ID"].ToString()));
                        if (dsa.Tables[0].Rows.Count > 0)
                        {
                            WS.SetStockFromPutAway(WarehouseID, 99000000, int.Parse(dpo.Tables[0].Rows[x]["QTY Processed"].ToString()),
                                int.Parse(dpo.Tables[0].Rows[x]["StockOrderDetail_ID"].ToString()));

                        }
                        for (int y = 0; y < dsa.Tables[0].Rows.Count; y++)
                        {
                            if (POStock > 0)
                            {
                                if (POStock >= int.Parse(dsa.Tables[0].Rows[y]["QTY"].ToString()))
                                {
                                    OrderAllocated = OrderAllocated + 1;

                                    WS.SetStockFromPick(WarehouseID, 99000000, int.Parse(dsa.Tables[0].Rows[y]["QTY"].ToString()),
                                        int.Parse(dsa.Tables[0].Rows[y]["StockOrderDetail_ID"].ToString()));
                                    Rep.PrintDN(int.Parse(dsa.Tables[0].Rows[y]["StockOrder_ID"].ToString()));
                                    POStock = POStock - int.Parse(dsa.Tables[0].Rows[y]["QTY"].ToString());
                                }
                            }


                        }
                    }

                }
                if (OrderAllocated > 0)
                    MessageBox.Show(OrderAllocated.ToString() + " Sales Orders were allocated");
                else
                    MessageBox.Show("No Sales orders matched the items on this Purchase Order.");

            }
        }


        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < dgOrder.RowCount; x++)
            {
                dgOrder.Rows[x].Selected = false;
            }
            for (int x = 0; x < dgOrder.RowCount; x++)
            {
                if (dgOrder.Rows[x].Cells["OrderReference"].Value.ToString().ToUpper().Contains(toolStriptxtSearch.Text.ToUpper()))
                {
                    dgOrder.Rows[x].Selected = true;                    
                    int OrdID = 0;                    
                    if (int.TryParse(dgOrder.Rows[x].Cells["StockOrder_ID"].Value.ToString(), out OrdID))
                    {
                        LoadDetail(OrdID);
                    }
                    x = dgOrder.RowCount;
                    
                }
            }
        }

        private void btnImportOrder_Click(object sender, EventArgs e)
        {
            Utils ut = new Utils();

            foreach (string file in Directory.GetFiles(ut.ImportPath, "*.*"))
            {
                string MyFileName = Path.GetFileName(file);
                string fileResult = CheckImportType(MyFileName);
                if (fileResult == "Invalid")
                {
                    MessageBox.Show("Invalid File: " + file);
                    //File.Move(ImportPath + MyFileName, ImportPath + "sts_delete\\" + MyFileName);
                }
                else if (fileResult == "Purchase Order")
                {
                    MessageBox.Show(fileResult);
                    StreamReader xmlReader = new StreamReader(file);

                    string xml = xmlReader.ReadToEnd();
                    MessageBox.Show(ut.ImportPOOrderXML(xml, WarehouseID,CompanyID));

                }
                else if (fileResult == "Sales Order")
                {
                    MessageBox.Show(fileResult);
                    StreamReader xmlReader = new StreamReader(file);

                    string xml = xmlReader.ReadToEnd();
                    MessageBox.Show(ut.ImportSOOrderXML(xml, WarehouseID, CompanyID));

                    //MessageBox.Show(fileResult);
                }                
                else if (fileResult == "Purchase Order XLS")
                {
                    //MessageBox.Show(fileResult);

                    //MessageBox.Show(ut.ImportPOOrderXLS(file, WarehouseID, CompanyID));

                    //MessageBox.Show(fileResult);
                }                
                else if (fileResult == "Sales Order XLS")
                {
                    //MessageBox.Show(fileResult);
                    //StreamReader xmlReader = new StreamReader(file);

                    //string xml = xmlReader.ReadToEnd();
                    //MessageBox.Show(ut.ImportSOOrderXML(xml, WarehouseID, CompanyID));

                    //MessageBox.Show(fileResult);
                }
            }            
        }

        private string CheckImportType(string FileName)
        {
            string Result = FileName.Substring(0, 2);

            if (Result.ToUpper() == "PO")
                Result = "Purchase Order";
            else if (Result.ToUpper() == "SO")
                Result = "Sales Order";
            else
                Result = "Invalid";

            string ExcelResult = FileName.Substring(0, 4);
            if (ExcelResult.ToUpper() == "SERI")
                Result = "Purchase Order XLS";
            else if (ExcelResult.ToUpper() == "TEST")
                Result = "Sales Order XLS";

            return Result;

        }

        private void toolStripButtonRecFloor_Click(object sender, EventArgs e)
        {
            string MType = "PO";
            string MDesc = "Purchase Order";
            if (OrderType.ToUpper() == "SALE")
            {
                MDesc = "Sales Order: " + dgOrder.CurrentRow.Cells["OrderReference"].Value.ToString();
                MType = "PI";
            }
            else
            {
                MDesc = "Purchase Order: " + dgOrder.CurrentRow.Cells["OrderReference"].Value.ToString();
                MType = "POF";
            }

            int OrdID = 0;
            if (int.TryParse(dgOrder.CurrentRow.Cells["StockOrder_ID"].Value.ToString(), out OrdID))
            {
                //LMSWarehouse.FrmReceiveOrder FReceiveOrder = new FrmReceiveOrder(OrdID);
                //FReceiveOrder.ShowDialog();
                //RefreshData();
                FrmItemScan FItemScan = new FrmItemScan(MType, CompanyID, WarehouseID, 0, OrdID, MDesc);
                FItemScan.ShowDialog();
                RefreshData();
            }
            else
            {
                MessageBox.Show("No Order was selected");
            }
        }

        private void toolStripButtonCloseOrder_Click(object sender, EventArgs e)
        {
            WS.UpdateSetOrderStatus(int.Parse(dgOrder.CurrentRow.Cells["StockOrder_ID"].Value.ToString()), 3);
        }

        private void toolStripButtonDetail_Click(object sender, EventArgs e)
        {
            FrmItemDetail fItemDetail = new FrmItemDetail(CompanyID, WarehouseID, 0,0, dgOrder.CurrentRow.Cells["OrderReference"].Value.ToString());
            fItemDetail.ShowDialog();
        }

        private void toolStripButtonInterface_Click(object sender, EventArgs e)
        {
            FrmStockOrderImport fItemDetail = new FrmStockOrderImport(CompanyID, WarehouseID, OrderType);
            fItemDetail.ShowDialog();
            RefreshData();      
        }



        




    }
}
