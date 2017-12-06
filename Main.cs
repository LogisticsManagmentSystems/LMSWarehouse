using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMSWarehouse
{
    public partial class FrmMain : Form
    {
        public int CompanyID;
        public int WarehouseID;
        public int UserID;
        public string Version = "1.4.0.0"; //2017/08/07

        private Wrapper WS = new Wrapper();

        public FrmMain()
        {
            UserID = 0;
            CompanyID = 1;
            WarehouseID = 1;
            InitializeComponent();
        }

        private void MenMainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void binLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LMSWarehouse.FrmBinLibrary FBinLibrary = new FrmBinLibrary(CompanyID, WarehouseID);
            ShowForm(FBinLibrary);
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LMSWarehouse.FrmProductLibrary FProductLibrary = new FrmProductLibrary(CompanyID, WarehouseID);
            ShowForm(FProductLibrary);           

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void recieveStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LMSWarehouse.FrmStockPutaway FStockPutaway = new FrmStockPutaway(WarehouseID);
            ShowForm(FStockPutaway);
        }

        private void ShowForm(Form ChildForm)
        {
            for (int x = 0; x < pMainForm.Controls.Count; x++)
            {
                pMainForm.Controls[x].Dispose();
            }
            ChildForm.TopLevel = false;
            ChildForm.Parent = pMainForm;
            ChildForm.Dock = DockStyle.Fill;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Show();
        }

        private void btnOrderStock_Click(object sender, EventArgs e)
        {
            //LMSWarehouse.FrmStockOrder FStockOrder = new FrmStockOrder(1, 1, 0, "Purchase");
            //ShowForm(FStockOrder);
            LMSWarehouse.FrmBackOrder FBackOrder = new FrmBackOrder(CompanyID, WarehouseID, "Purchase");
            ShowForm(FBackOrder);

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Text = "LMS Warehouse Management (" + Version + ")";
            versionToolStripMenuItem.Text = "Version "+Version;

            LMSWarehouse.FrmPassword FPassword = new FrmPassword(CompanyID,UserID,WarehouseID);
            FPassword.ShowDialog();
            UserID = FPassword.UserID;
            WarehouseID = FPassword.WarehouseID;
            CompanyID = FPassword.CompanyID;

            this.Text = "LMS Warehouse Management ("+Version+"): - " + FPassword.WarehouseName;

            if (WS.IsTest())
            {
                this.Text = "TESTING SYSTEM (" + Version + "): - " + this.Text;
            }

            if (UserID == 0)
            {
                Close();
            }
            LoadReports();

        }

        private void btnDispatchStock_Click(object sender, EventArgs e)
        {
            LMSWarehouse.FrmBackOrder FBackOrder = new FrmBackOrder(CompanyID, WarehouseID, "Sale");
            ShowForm(FBackOrder);
        }

        private void btnStockTake_Click(object sender, EventArgs e)
        {
            FrmStockView FStockView = new FrmStockView(CompanyID, WarehouseID);
            ShowForm(FStockView);

        }

        private void LoadReports()
        {
            for (int x = 0; x < tvReports.Nodes.Count; x++)
            {
                for (int i = 0; i < tvReports.Nodes[x].Nodes.Count; i++)
                {
                    //GetDataForNodes
                    DataSet ds = WS.GetGenericReports(tvReports.Nodes[x].Nodes[i].Text, CompanyID);

                    for (int y = 0; y < ds.Tables[0].Rows.Count; y++)
                    {
                        tvReports.Nodes[x].Nodes[i].Nodes.Add(ds.Tables[0].Rows[y]["ReportName"].ToString());                        
                    }
                }
            }
            tvReports.ExpandAll();

        }

        private void tvReports_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvReports.SelectedNode.Level == 2)
            {
                LMSWarehouse.FrmGenericReport FGenericReport = new FrmGenericReport(tvReports.SelectedNode.Text,CompanyID, WarehouseID);
                ShowForm(FGenericReport);                
            }

        }

        private void BtnWHStockT_Click(object sender, EventArgs e)
        {
            LMSWarehouse.FrmStockTake FStockTake = new FrmStockTake(WarehouseID, UserID, 1);
            ShowForm(FStockTake);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FrmItemScan FItemScan = new FrmItemScan("PU",
            //CompanyID, WarehouseID, 0, 0,"Put Away");
            //FItemScan.ShowDialog();
            LMSWarehouse.FrmPutAwayList FPutAwayList = new FrmPutAwayList(WarehouseID);
            ShowForm(FPutAwayList);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LMSWarehouse.FrmPickList FPickList = new FrmPickList(WarehouseID, CompanyID);
            ShowForm(FPickList);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            LMSWarehouse.FrmCustomer FCustomer = new FrmCustomer(CompanyID,"Cust",0);
            ShowForm(FCustomer);
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            LMSWarehouse.FrmCustomer FCustomer = new FrmCustomer(CompanyID, "Sup",0);
            ShowForm(FCustomer);
        }

        private void salesRepsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LMSWarehouse.FrmOnlineSalesRep SalesRep = new FrmOnlineSalesRep(CompanyID);
            ShowForm(SalesRep);
        }

        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LMSWarehouse.FrmOrderEvent Event = new FrmOrderEvent(CompanyID);
            ShowForm(Event);
        }

        private void saleOutletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LMSWarehouse.FrmOnlineOutlet Outlet = new FrmOnlineOutlet(CompanyID);
            ShowForm(Outlet);
        }

        private void budgetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LMSWarehouse.FrmBudget Budget = new FrmBudget(CompanyID);
            ShowForm(Budget);
        }

        private void returnEventStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LMSWarehouse.FrmStockEventReturn Budget = new FrmStockEventReturn(CompanyID,WarehouseID,true);
            ShowForm(Budget);
        }

        private void eventCollectionReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LMSWarehouse.FrmStockEventReturn Budget = new FrmStockEventReturn(CompanyID, WarehouseID, false);
            ShowForm(Budget);

        }

        private void eventDeliveryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LMSWarehouse.FrmStockEventReturn Budget = new FrmStockEventReturn(CompanyID, WarehouseID, false);
            ShowForm(Budget);

        }

        private void dispatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispatch dp = new Dispatch(CompanyID, WarehouseID);
            //frmDispatchItems dp = new frmDispatchItems(CompanyID, WarehouseID);
            ShowForm(dp);
        }

        private void changeWarehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LMSWarehouse.FrmPassword FPassword = new FrmPassword(CompanyID, UserID, WarehouseID);
            FPassword.ShowDialog();
            UserID = FPassword.UserID;
            WarehouseID = FPassword.WarehouseID;
            CompanyID = FPassword.CompanyID;

            this.Text = "LMS Warehouse Management :- " + FPassword.WarehouseName;

            if (WS.IsTest())
            {
                this.Text = "TESTING SYSTEM: - " + this.Text;
            }

            if (UserID == 0)
            {
                Close();
            }
            LoadReports();
        }

        private void salesOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void completedPurchaseOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LMSWarehouse.FrmStockOrderList FOrderList = new FrmStockOrderList(CompanyID, WarehouseID, "Purchase");
            ShowForm(FOrderList);
        }

        private void completedSalesOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LMSWarehouse.FrmStockOrderList FOrderList = new FrmStockOrderList(CompanyID, WarehouseID, "Sale");
            ShowForm(FOrderList);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //FrmStockMove FStockMove = new FrmStockMove(WarehouseID, CompanyID, UserID);
            //ShowForm(FStockMove);

            FrmStockMoveSKU FStockMove = new FrmStockMoveSKU(WarehouseID, CompanyID, UserID);
            ShowForm(FStockMove);            
        }

        private void moveStockToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdminStockMove FStockMove = new FrmAdminStockMove(CompanyID,WarehouseID);
            ShowForm(FStockMove);

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {


        }

        private void toolStripMenuItemDispatchLabels_Click(object sender, EventArgs e)
        {
            FrmDispatchLabels FLabels = new FrmDispatchLabels(CompanyID, WarehouseID);
            ShowForm(FLabels);
        }

        private void returnStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStockMoveOrder FLabels = new FrmStockMoveOrder(CompanyID,WarehouseID, "RT", "Returns" );
            ShowForm(FLabels);
        }

        private void btnCycleCount_Click(object sender, EventArgs e)
        {
            if ((UserID == 1) || (UserID == 14))
            {
                LMSWarehouse.FrmStockTake FStockTake = new FrmStockTake(WarehouseID, UserID, 3);
                ShowForm(FStockTake);
            }
            else
            {
                MessageBox.Show("Insufficient permissions!");
            }

            
        }

        private void nbWarehouse_Click(object sender, EventArgs e)
        {

        }

        private void nbReport_Click(object sender, EventArgs e)
        {

        }






    }
}
