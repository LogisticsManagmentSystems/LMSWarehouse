namespace LMSWarehouse
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Stock");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Dispatch");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Billing");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Warehouse Reports", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Online Reports");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.MenMainMenu = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binLocationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.budgetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeWarehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recieveStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockTakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnEventStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventCollectionReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventDeliveryReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDispatchLabels = new System.Windows.Forms.ToolStripMenuItem();
            this.returnStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockTakeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.putAwayStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pickStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completedPurchaseOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completedSalesOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesRepsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleOutletsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveStockToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.pMainForm = new System.Windows.Forms.Panel();
            this.Outlookbar = new Guifreaks.Navisuite.NaviBar(this.components);
            this.nbStockControl = new Guifreaks.Navisuite.NaviBand(this.components);
            this.pStock = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.imlMainLarge = new System.Windows.Forms.ImageList(this.components);
            this.btnDispatchStock = new System.Windows.Forms.Button();
            this.btnOrderStock = new System.Windows.Forms.Button();
            this.btnViewStock = new System.Windows.Forms.Button();
            this.nbWarehouse = new Guifreaks.Navisuite.NaviBand(this.components);
            this.pWarehouse = new System.Windows.Forms.Panel();
            this.btnCycleCount = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnWHStockT = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPutAway = new System.Windows.Forms.Button();
            this.btnPickOrder = new System.Windows.Forms.Button();
            this.btnWHStockTake = new System.Windows.Forms.Button();
            this.nbLibrary = new Guifreaks.Navisuite.NaviBand(this.components);
            this.pControl = new System.Windows.Forms.Panel();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnBinlocations = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.nbReport = new Guifreaks.Navisuite.NaviBand(this.components);
            this.tvReports = new System.Windows.Forms.TreeView();
            this.imlMainSmall = new System.Windows.Forms.ImageList(this.components);
            this.MenMainMenu.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.Outlookbar.SuspendLayout();
            this.nbStockControl.ClientArea.SuspendLayout();
            this.nbStockControl.SuspendLayout();
            this.pStock.SuspendLayout();
            this.nbWarehouse.ClientArea.SuspendLayout();
            this.nbWarehouse.SuspendLayout();
            this.pWarehouse.SuspendLayout();
            this.nbLibrary.ClientArea.SuspendLayout();
            this.nbLibrary.SuspendLayout();
            this.pControl.SuspendLayout();
            this.nbReport.ClientArea.SuspendLayout();
            this.nbReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenMainMenu
            // 
            this.MenMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.warehouseToolStripMenuItem,
            this.onlineToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenMainMenu.Location = new System.Drawing.Point(0, 0);
            this.MenMainMenu.Name = "MenMainMenu";
            this.MenMainMenu.Size = new System.Drawing.Size(784, 24);
            this.MenMainMenu.TabIndex = 0;
            this.MenMainMenu.Text = "menuStrip1";
            this.MenMainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenMainMenu_ItemClicked);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binLocationsToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.budgetsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // binLocationsToolStripMenuItem
            // 
            this.binLocationsToolStripMenuItem.Name = "binLocationsToolStripMenuItem";
            this.binLocationsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.binLocationsToolStripMenuItem.Text = "Bin Locations";
            this.binLocationsToolStripMenuItem.Click += new System.EventHandler(this.binLocationsToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // budgetsToolStripMenuItem
            // 
            this.budgetsToolStripMenuItem.Name = "budgetsToolStripMenuItem";
            this.budgetsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.budgetsToolStripMenuItem.Text = "Budgets";
            this.budgetsToolStripMenuItem.Click += new System.EventHandler(this.budgetsToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeWarehouseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // changeWarehouseToolStripMenuItem
            // 
            this.changeWarehouseToolStripMenuItem.Name = "changeWarehouseToolStripMenuItem";
            this.changeWarehouseToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.changeWarehouseToolStripMenuItem.Text = "Change Warehouse";
            this.changeWarehouseToolStripMenuItem.Click += new System.EventHandler(this.changeWarehouseToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesOrderToolStripMenuItem,
            this.purchaseOrderToolStripMenuItem,
            this.recieveStockToolStripMenuItem,
            this.stockTakeToolStripMenuItem,
            this.returnEventStockToolStripMenuItem,
            this.eventCollectionReportToolStripMenuItem,
            this.eventDeliveryReportToolStripMenuItem,
            this.dispatchToolStripMenuItem,
            this.toolStripMenuItemDispatchLabels,
            this.returnStockToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // salesOrderToolStripMenuItem
            // 
            this.salesOrderToolStripMenuItem.Name = "salesOrderToolStripMenuItem";
            this.salesOrderToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.salesOrderToolStripMenuItem.Text = "Sales Order";
            this.salesOrderToolStripMenuItem.Click += new System.EventHandler(this.salesOrderToolStripMenuItem_Click);
            // 
            // purchaseOrderToolStripMenuItem
            // 
            this.purchaseOrderToolStripMenuItem.Name = "purchaseOrderToolStripMenuItem";
            this.purchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.purchaseOrderToolStripMenuItem.Text = "Purchase Order";
            // 
            // recieveStockToolStripMenuItem
            // 
            this.recieveStockToolStripMenuItem.Name = "recieveStockToolStripMenuItem";
            this.recieveStockToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.recieveStockToolStripMenuItem.Text = "Recieve Stock";
            this.recieveStockToolStripMenuItem.Click += new System.EventHandler(this.recieveStockToolStripMenuItem_Click);
            // 
            // stockTakeToolStripMenuItem
            // 
            this.stockTakeToolStripMenuItem.Name = "stockTakeToolStripMenuItem";
            this.stockTakeToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.stockTakeToolStripMenuItem.Text = "Stock Take";
            // 
            // returnEventStockToolStripMenuItem
            // 
            this.returnEventStockToolStripMenuItem.Name = "returnEventStockToolStripMenuItem";
            this.returnEventStockToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.returnEventStockToolStripMenuItem.Text = "Return Event Stock";
            this.returnEventStockToolStripMenuItem.Click += new System.EventHandler(this.returnEventStockToolStripMenuItem_Click);
            // 
            // eventCollectionReportToolStripMenuItem
            // 
            this.eventCollectionReportToolStripMenuItem.Name = "eventCollectionReportToolStripMenuItem";
            this.eventCollectionReportToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.eventCollectionReportToolStripMenuItem.Text = "Event Collection Report";
            this.eventCollectionReportToolStripMenuItem.Click += new System.EventHandler(this.eventCollectionReportToolStripMenuItem_Click);
            // 
            // eventDeliveryReportToolStripMenuItem
            // 
            this.eventDeliveryReportToolStripMenuItem.Name = "eventDeliveryReportToolStripMenuItem";
            this.eventDeliveryReportToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.eventDeliveryReportToolStripMenuItem.Text = "Event Delivery Report";
            this.eventDeliveryReportToolStripMenuItem.Click += new System.EventHandler(this.eventDeliveryReportToolStripMenuItem_Click);
            // 
            // dispatchToolStripMenuItem
            // 
            this.dispatchToolStripMenuItem.Name = "dispatchToolStripMenuItem";
            this.dispatchToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.dispatchToolStripMenuItem.Text = "Dispatch";
            this.dispatchToolStripMenuItem.Click += new System.EventHandler(this.dispatchToolStripMenuItem_Click);
            // 
            // toolStripMenuItemDispatchLabels
            // 
            this.toolStripMenuItemDispatchLabels.Name = "toolStripMenuItemDispatchLabels";
            this.toolStripMenuItemDispatchLabels.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItemDispatchLabels.Text = "Dispatch Labels";
            this.toolStripMenuItemDispatchLabels.Click += new System.EventHandler(this.toolStripMenuItemDispatchLabels_Click);
            // 
            // returnStockToolStripMenuItem
            // 
            this.returnStockToolStripMenuItem.Name = "returnStockToolStripMenuItem";
            this.returnStockToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.returnStockToolStripMenuItem.Text = "Return Stock";
            this.returnStockToolStripMenuItem.Click += new System.EventHandler(this.returnStockToolStripMenuItem_Click);
            // 
            // warehouseToolStripMenuItem
            // 
            this.warehouseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockTakeToolStripMenuItem1,
            this.putAwayStockToolStripMenuItem,
            this.pickStockToolStripMenuItem,
            this.completedPurchaseOrdersToolStripMenuItem,
            this.completedSalesOrdersToolStripMenuItem});
            this.warehouseToolStripMenuItem.Name = "warehouseToolStripMenuItem";
            this.warehouseToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.warehouseToolStripMenuItem.Text = "Warehouse";
            // 
            // stockTakeToolStripMenuItem1
            // 
            this.stockTakeToolStripMenuItem1.Name = "stockTakeToolStripMenuItem1";
            this.stockTakeToolStripMenuItem1.Size = new System.Drawing.Size(222, 22);
            this.stockTakeToolStripMenuItem1.Text = "Stock Take";
            // 
            // putAwayStockToolStripMenuItem
            // 
            this.putAwayStockToolStripMenuItem.Name = "putAwayStockToolStripMenuItem";
            this.putAwayStockToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.putAwayStockToolStripMenuItem.Text = "Put Away Stock";
            // 
            // pickStockToolStripMenuItem
            // 
            this.pickStockToolStripMenuItem.Name = "pickStockToolStripMenuItem";
            this.pickStockToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.pickStockToolStripMenuItem.Text = "Pick Stock";
            // 
            // completedPurchaseOrdersToolStripMenuItem
            // 
            this.completedPurchaseOrdersToolStripMenuItem.Name = "completedPurchaseOrdersToolStripMenuItem";
            this.completedPurchaseOrdersToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.completedPurchaseOrdersToolStripMenuItem.Text = "Completed Purchase Orders";
            this.completedPurchaseOrdersToolStripMenuItem.Click += new System.EventHandler(this.completedPurchaseOrdersToolStripMenuItem_Click);
            // 
            // completedSalesOrdersToolStripMenuItem
            // 
            this.completedSalesOrdersToolStripMenuItem.Name = "completedSalesOrdersToolStripMenuItem";
            this.completedSalesOrdersToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.completedSalesOrdersToolStripMenuItem.Text = "Completed Sales Orders";
            this.completedSalesOrdersToolStripMenuItem.Click += new System.EventHandler(this.completedSalesOrdersToolStripMenuItem_Click);
            // 
            // onlineToolStripMenuItem
            // 
            this.onlineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventsToolStripMenuItem,
            this.salesRepsToolStripMenuItem,
            this.saleOutletsToolStripMenuItem});
            this.onlineToolStripMenuItem.Name = "onlineToolStripMenuItem";
            this.onlineToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.onlineToolStripMenuItem.Text = "Online";
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.eventsToolStripMenuItem.Text = "Events";
            this.eventsToolStripMenuItem.Click += new System.EventHandler(this.eventsToolStripMenuItem_Click);
            // 
            // salesRepsToolStripMenuItem
            // 
            this.salesRepsToolStripMenuItem.Name = "salesRepsToolStripMenuItem";
            this.salesRepsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.salesRepsToolStripMenuItem.Text = "Sales Reps";
            this.salesRepsToolStripMenuItem.Click += new System.EventHandler(this.salesRepsToolStripMenuItem_Click);
            // 
            // saleOutletsToolStripMenuItem
            // 
            this.saleOutletsToolStripMenuItem.Name = "saleOutletsToolStripMenuItem";
            this.saleOutletsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saleOutletsToolStripMenuItem.Text = "Sale Outlets";
            this.saleOutletsToolStripMenuItem.Click += new System.EventHandler(this.saleOutletsToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveStockToolToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.adminToolStripMenuItem.Text = "Admin Tool";
            // 
            // moveStockToolToolStripMenuItem
            // 
            this.moveStockToolToolStripMenuItem.Name = "moveStockToolToolStripMenuItem";
            this.moveStockToolToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.moveStockToolToolStripMenuItem.Text = "Move Stock Tool";
            this.moveStockToolToolStripMenuItem.Click += new System.EventHandler(this.moveStockToolToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.versionToolStripMenuItem.Text = "Version 1.1.0.3";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pMainForm);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.Outlookbar);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(784, 556);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(784, 581);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // pMainForm
            // 
            this.pMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMainForm.Location = new System.Drawing.Point(193, 0);
            this.pMainForm.Name = "pMainForm";
            this.pMainForm.Size = new System.Drawing.Size(591, 556);
            this.pMainForm.TabIndex = 1;
            // 
            // Outlookbar
            // 
            this.Outlookbar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Outlookbar.ActiveBand = this.nbReport;
            this.Outlookbar.Controls.Add(this.nbStockControl);
            this.Outlookbar.Controls.Add(this.nbWarehouse);
            this.Outlookbar.Controls.Add(this.nbLibrary);
            this.Outlookbar.Controls.Add(this.nbReport);
            this.Outlookbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Outlookbar.Location = new System.Drawing.Point(0, 0);
            this.Outlookbar.Name = "Outlookbar";
            this.Outlookbar.Size = new System.Drawing.Size(193, 556);
            this.Outlookbar.TabIndex = 0;
            this.Outlookbar.Text = "LMS Navigation";
            this.Outlookbar.VisibleLargeButtons = 5;
            // 
            // nbStockControl
            // 
            this.nbStockControl.BackColor = System.Drawing.SystemColors.Control;
            // 
            // nbStockControl.ClientArea
            // 
            this.nbStockControl.ClientArea.BackColor = System.Drawing.SystemColors.Control;
            this.nbStockControl.ClientArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nbStockControl.ClientArea.Controls.Add(this.pStock);
            this.nbStockControl.ClientArea.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nbStockControl.ClientArea.LayoutStyle = Guifreaks.Navisuite.NaviLayoutStyle.StyleFromOwner;
            this.nbStockControl.ClientArea.Location = new System.Drawing.Point(0, 0);
            this.nbStockControl.ClientArea.Name = "ClientArea";
            this.nbStockControl.ClientArea.Size = new System.Drawing.Size(1, 1);
            this.nbStockControl.ClientArea.TabIndex = 0;
            this.nbStockControl.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbStockControl.LargeImage")));
            this.nbStockControl.LargeImageIndex = 0;
            this.nbStockControl.LayoutStyle = Guifreaks.Navisuite.NaviLayoutStyle.StyleFromOwner;
            this.nbStockControl.Location = new System.Drawing.Point(1, 27);
            this.nbStockControl.Name = "nbStockControl";
            this.nbStockControl.Size = new System.Drawing.Size(0, 0);
            this.nbStockControl.SmallImageIndex = 0;
            this.nbStockControl.TabIndex = 3;
            this.nbStockControl.Text = "Stock Control";
            // 
            // pStock
            // 
            this.pStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pStock.Controls.Add(this.button3);
            this.pStock.Controls.Add(this.btnDispatchStock);
            this.pStock.Controls.Add(this.btnOrderStock);
            this.pStock.Controls.Add(this.btnViewStock);
            this.pStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pStock.Location = new System.Drawing.Point(0, 0);
            this.pStock.Name = "pStock";
            this.pStock.Size = new System.Drawing.Size(1, 1);
            this.pStock.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.ImageKey = "NewClassModuleHH.bmp";
            this.button3.ImageList = this.imlMainLarge;
            this.button3.Location = new System.Drawing.Point(50, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 74);
            this.button3.TabIndex = 3;
            this.button3.Text = "Move Stock";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // imlMainLarge
            // 
            this.imlMainLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlMainLarge.ImageStream")));
            this.imlMainLarge.TransparentColor = System.Drawing.Color.Black;
            this.imlMainLarge.Images.SetKeyName(0, "TaskHH.bmp");
            this.imlMainLarge.Images.SetKeyName(1, "AddTableHH.bmp");
            this.imlMainLarge.Images.SetKeyName(2, "Delete_tableHH.bmp");
            this.imlMainLarge.Images.SetKeyName(3, "NewClassModuleHH.bmp");
            this.imlMainLarge.Images.SetKeyName(4, "PrintRelationshipsHH.bmp");
            this.imlMainLarge.Images.SetKeyName(5, "PropertiesHH.bmp");
            this.imlMainLarge.Images.SetKeyName(6, "MoveToFolderHH.bmp");
            this.imlMainLarge.Images.SetKeyName(7, "ArrangeWindowsHH.bmp");
            this.imlMainLarge.Images.SetKeyName(8, "FullScreenHH.bmp");
            this.imlMainLarge.Images.SetKeyName(9, "NewClassModuleHH.bmp");
            // 
            // btnDispatchStock
            // 
            this.btnDispatchStock.ImageIndex = 2;
            this.btnDispatchStock.ImageList = this.imlMainLarge;
            this.btnDispatchStock.Location = new System.Drawing.Point(50, 185);
            this.btnDispatchStock.Name = "btnDispatchStock";
            this.btnDispatchStock.Size = new System.Drawing.Size(91, 74);
            this.btnDispatchStock.TabIndex = 2;
            this.btnDispatchStock.Text = "Dispatch Stock";
            this.btnDispatchStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDispatchStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDispatchStock.UseVisualStyleBackColor = true;
            this.btnDispatchStock.Click += new System.EventHandler(this.btnDispatchStock_Click);
            // 
            // btnOrderStock
            // 
            this.btnOrderStock.ImageIndex = 1;
            this.btnOrderStock.ImageList = this.imlMainLarge;
            this.btnOrderStock.Location = new System.Drawing.Point(50, 99);
            this.btnOrderStock.Name = "btnOrderStock";
            this.btnOrderStock.Size = new System.Drawing.Size(91, 74);
            this.btnOrderStock.TabIndex = 1;
            this.btnOrderStock.Text = "Receive Stock";
            this.btnOrderStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrderStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOrderStock.UseVisualStyleBackColor = true;
            this.btnOrderStock.Click += new System.EventHandler(this.btnOrderStock_Click);
            // 
            // btnViewStock
            // 
            this.btnViewStock.ImageIndex = 0;
            this.btnViewStock.ImageList = this.imlMainLarge;
            this.btnViewStock.Location = new System.Drawing.Point(50, 12);
            this.btnViewStock.Name = "btnViewStock";
            this.btnViewStock.Size = new System.Drawing.Size(91, 74);
            this.btnViewStock.TabIndex = 0;
            this.btnViewStock.Text = "View Stock";
            this.btnViewStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnViewStock.UseVisualStyleBackColor = true;
            this.btnViewStock.Click += new System.EventHandler(this.btnStockTake_Click);
            // 
            // nbWarehouse
            // 
            // 
            // nbWarehouse.ClientArea
            // 
            this.nbWarehouse.ClientArea.Controls.Add(this.pWarehouse);
            this.nbWarehouse.ClientArea.LayoutStyle = Guifreaks.Navisuite.NaviLayoutStyle.StyleFromOwner;
            this.nbWarehouse.ClientArea.Location = new System.Drawing.Point(0, 0);
            this.nbWarehouse.ClientArea.Name = "ClientArea";
            this.nbWarehouse.ClientArea.Size = new System.Drawing.Size(1, 1);
            this.nbWarehouse.ClientArea.TabIndex = 0;
            this.nbWarehouse.Controls.Add(this.btnPutAway);
            this.nbWarehouse.Controls.Add(this.btnPickOrder);
            this.nbWarehouse.Controls.Add(this.btnWHStockTake);
            this.nbWarehouse.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbWarehouse.LargeImage")));
            this.nbWarehouse.LargeImageIndex = 0;
            this.nbWarehouse.LayoutStyle = Guifreaks.Navisuite.NaviLayoutStyle.StyleFromOwner;
            this.nbWarehouse.Location = new System.Drawing.Point(1, 27);
            this.nbWarehouse.Name = "nbWarehouse";
            this.nbWarehouse.Size = new System.Drawing.Size(0, 0);
            this.nbWarehouse.SmallImageIndex = 0;
            this.nbWarehouse.TabIndex = 17;
            this.nbWarehouse.Text = "Warehouse";
            this.nbWarehouse.Click += new System.EventHandler(this.nbWarehouse_Click);
            // 
            // pWarehouse
            // 
            this.pWarehouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pWarehouse.Controls.Add(this.btnCycleCount);
            this.pWarehouse.Controls.Add(this.button1);
            this.pWarehouse.Controls.Add(this.BtnWHStockT);
            this.pWarehouse.Controls.Add(this.button2);
            this.pWarehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pWarehouse.Location = new System.Drawing.Point(0, 0);
            this.pWarehouse.Name = "pWarehouse";
            this.pWarehouse.Size = new System.Drawing.Size(1, 1);
            this.pWarehouse.TabIndex = 0;
            // 
            // btnCycleCount
            // 
            this.btnCycleCount.ImageIndex = 5;
            this.btnCycleCount.ImageList = this.imlMainLarge;
            this.btnCycleCount.Location = new System.Drawing.Point(50, 19);
            this.btnCycleCount.Name = "btnCycleCount";
            this.btnCycleCount.Size = new System.Drawing.Size(91, 74);
            this.btnCycleCount.TabIndex = 28;
            this.btnCycleCount.Text = "Cycle Count";
            this.btnCycleCount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCycleCount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCycleCount.UseVisualStyleBackColor = true;
            this.btnCycleCount.Click += new System.EventHandler(this.btnCycleCount_Click);
            // 
            // button1
            // 
            this.button1.ImageIndex = 2;
            this.button1.ImageList = this.imlMainLarge;
            this.button1.Location = new System.Drawing.Point(50, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 74);
            this.button1.TabIndex = 27;
            this.button1.Text = "Pick Stock";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnWHStockT
            // 
            this.BtnWHStockT.ImageIndex = 0;
            this.BtnWHStockT.ImageList = this.imlMainLarge;
            this.BtnWHStockT.Location = new System.Drawing.Point(50, 287);
            this.BtnWHStockT.Name = "BtnWHStockT";
            this.BtnWHStockT.Size = new System.Drawing.Size(91, 74);
            this.BtnWHStockT.TabIndex = 25;
            this.BtnWHStockT.Text = "Stock Take";
            this.BtnWHStockT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnWHStockT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnWHStockT.UseVisualStyleBackColor = true;
            this.BtnWHStockT.Click += new System.EventHandler(this.BtnWHStockT_Click);
            // 
            // button2
            // 
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.imlMainLarge;
            this.button2.Location = new System.Drawing.Point(50, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 74);
            this.button2.TabIndex = 26;
            this.button2.Text = "Put Away Stock";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPutAway
            // 
            this.btnPutAway.ImageIndex = 6;
            this.btnPutAway.ImageList = this.imlMainLarge;
            this.btnPutAway.Location = new System.Drawing.Point(50, 200);
            this.btnPutAway.Name = "btnPutAway";
            this.btnPutAway.Size = new System.Drawing.Size(91, 74);
            this.btnPutAway.TabIndex = 5;
            this.btnPutAway.Text = "Put Away Order";
            this.btnPutAway.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPutAway.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPutAway.UseVisualStyleBackColor = true;
            // 
            // btnPickOrder
            // 
            this.btnPickOrder.ImageIndex = 5;
            this.btnPickOrder.ImageList = this.imlMainLarge;
            this.btnPickOrder.Location = new System.Drawing.Point(50, 105);
            this.btnPickOrder.Name = "btnPickOrder";
            this.btnPickOrder.Size = new System.Drawing.Size(91, 74);
            this.btnPickOrder.TabIndex = 4;
            this.btnPickOrder.Text = "Pick Order";
            this.btnPickOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPickOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPickOrder.UseVisualStyleBackColor = true;
            // 
            // btnWHStockTake
            // 
            this.btnWHStockTake.ImageIndex = 0;
            this.btnWHStockTake.ImageList = this.imlMainLarge;
            this.btnWHStockTake.Location = new System.Drawing.Point(50, 12);
            this.btnWHStockTake.Name = "btnWHStockTake";
            this.btnWHStockTake.Size = new System.Drawing.Size(91, 74);
            this.btnWHStockTake.TabIndex = 3;
            this.btnWHStockTake.Text = "Stock Take";
            this.btnWHStockTake.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWHStockTake.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnWHStockTake.UseVisualStyleBackColor = true;
            // 
            // nbLibrary
            // 
            // 
            // nbLibrary.ClientArea
            // 
            this.nbLibrary.ClientArea.Controls.Add(this.pControl);
            this.nbLibrary.ClientArea.LayoutStyle = Guifreaks.Navisuite.NaviLayoutStyle.StyleFromOwner;
            this.nbLibrary.ClientArea.Location = new System.Drawing.Point(0, 0);
            this.nbLibrary.ClientArea.Name = "ClientArea";
            this.nbLibrary.ClientArea.Size = new System.Drawing.Size(1, 1);
            this.nbLibrary.ClientArea.TabIndex = 0;
            this.nbLibrary.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbLibrary.LargeImage")));
            this.nbLibrary.LargeImageIndex = 0;
            this.nbLibrary.LayoutStyle = Guifreaks.Navisuite.NaviLayoutStyle.StyleFromOwner;
            this.nbLibrary.Location = new System.Drawing.Point(1, 27);
            this.nbLibrary.Name = "nbLibrary";
            this.nbLibrary.Size = new System.Drawing.Size(0, 0);
            this.nbLibrary.SmallImageIndex = 0;
            this.nbLibrary.TabIndex = 5;
            this.nbLibrary.Text = "Control Files";
            // 
            // pControl
            // 
            this.pControl.AutoScroll = true;
            this.pControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pControl.Controls.Add(this.btnSuppliers);
            this.pControl.Controls.Add(this.btnCustomers);
            this.pControl.Controls.Add(this.btnBinlocations);
            this.pControl.Controls.Add(this.btnProducts);
            this.pControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pControl.Location = new System.Drawing.Point(0, 0);
            this.pControl.Name = "pControl";
            this.pControl.Size = new System.Drawing.Size(1, 1);
            this.pControl.TabIndex = 0;
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.ImageIndex = 7;
            this.btnSuppliers.ImageList = this.imlMainLarge;
            this.btnSuppliers.Location = new System.Drawing.Point(45, 327);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(91, 74);
            this.btnSuppliers.TabIndex = 20;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSuppliers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.ImageIndex = 8;
            this.btnCustomers.ImageList = this.imlMainLarge;
            this.btnCustomers.Location = new System.Drawing.Point(45, 224);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(91, 74);
            this.btnCustomers.TabIndex = 19;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnBinlocations
            // 
            this.btnBinlocations.ImageIndex = 4;
            this.btnBinlocations.ImageList = this.imlMainLarge;
            this.btnBinlocations.Location = new System.Drawing.Point(45, 122);
            this.btnBinlocations.Name = "btnBinlocations";
            this.btnBinlocations.Size = new System.Drawing.Size(91, 74);
            this.btnBinlocations.TabIndex = 18;
            this.btnBinlocations.Text = "Bin Locations";
            this.btnBinlocations.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBinlocations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBinlocations.UseVisualStyleBackColor = true;
            this.btnBinlocations.Click += new System.EventHandler(this.binLocationsToolStripMenuItem_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.ImageIndex = 3;
            this.btnProducts.ImageList = this.imlMainLarge;
            this.btnProducts.Location = new System.Drawing.Point(45, 19);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(91, 74);
            this.btnProducts.TabIndex = 17;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // nbReport
            // 
            // 
            // nbReport.ClientArea
            // 
            this.nbReport.ClientArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nbReport.ClientArea.Controls.Add(this.tvReports);
            this.nbReport.ClientArea.LayoutStyle = Guifreaks.Navisuite.NaviLayoutStyle.StyleFromOwner;
            this.nbReport.ClientArea.Location = new System.Drawing.Point(0, 0);
            this.nbReport.ClientArea.Name = "ClientArea";
            this.nbReport.ClientArea.Size = new System.Drawing.Size(191, 361);
            this.nbReport.ClientArea.TabIndex = 0;
            this.nbReport.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbReport.LargeImage")));
            this.nbReport.LargeImageIndex = 0;
            this.nbReport.LayoutStyle = Guifreaks.Navisuite.NaviLayoutStyle.StyleFromOwner;
            this.nbReport.Location = new System.Drawing.Point(1, 27);
            this.nbReport.Name = "nbReport";
            this.nbReport.Size = new System.Drawing.Size(191, 361);
            this.nbReport.SmallImageIndex = 0;
            this.nbReport.TabIndex = 7;
            this.nbReport.Text = "Reports";
            this.nbReport.Click += new System.EventHandler(this.nbReport_Click);
            // 
            // tvReports
            // 
            this.tvReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tvReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvReports.ImageIndex = 0;
            this.tvReports.ImageList = this.imlMainSmall;
            this.tvReports.Location = new System.Drawing.Point(0, 0);
            this.tvReports.Name = "tvReports";
            treeNode1.ImageKey = "BringForward.bmp";
            treeNode1.Name = "NodeWStock";
            treeNode1.Text = "Stock";
            treeNode2.ImageKey = "BarCode.bmp";
            treeNode2.Name = "NodeWDispatch";
            treeNode2.Text = "Dispatch";
            treeNode3.ImageIndex = 5;
            treeNode3.Name = "Billing";
            treeNode3.Text = "Billing";
            treeNode4.ImageKey = "ViewThumbnails.bmp";
            treeNode4.Name = "NodeWarehouse";
            treeNode4.Text = "Warehouse Reports";
            treeNode5.ImageKey = "Web.bmp";
            treeNode5.Name = "NodeWeb";
            treeNode5.Text = "Online Reports";
            this.tvReports.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.tvReports.SelectedImageIndex = 0;
            this.tvReports.Size = new System.Drawing.Size(191, 361);
            this.tvReports.TabIndex = 0;
            this.tvReports.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvReports_AfterSelect);
            // 
            // imlMainSmall
            // 
            this.imlMainSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlMainSmall.ImageStream")));
            this.imlMainSmall.TransparentColor = System.Drawing.Color.Fuchsia;
            this.imlMainSmall.Images.SetKeyName(0, "Print.bmp");
            this.imlMainSmall.Images.SetKeyName(1, "ViewThumbnails.bmp");
            this.imlMainSmall.Images.SetKeyName(2, "Web.bmp");
            this.imlMainSmall.Images.SetKeyName(3, "BringForward.bmp");
            this.imlMainSmall.Images.SetKeyName(4, "BarCode.bmp");
            this.imlMainSmall.Images.SetKeyName(5, "PieChart.bmp");
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 605);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.MenMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenMainMenu;
            this.Name = "FrmMain";
            this.Text = "LMS Warehouse Management (1.1.0.9)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MenMainMenu.ResumeLayout(false);
            this.MenMainMenu.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.Outlookbar.ResumeLayout(false);
            this.nbStockControl.ClientArea.ResumeLayout(false);
            this.nbStockControl.ResumeLayout(false);
            this.pStock.ResumeLayout(false);
            this.nbWarehouse.ClientArea.ResumeLayout(false);
            this.nbWarehouse.ResumeLayout(false);
            this.pWarehouse.ResumeLayout(false);
            this.nbLibrary.ClientArea.ResumeLayout(false);
            this.nbLibrary.ResumeLayout(false);
            this.pControl.ResumeLayout(false);
            this.nbReport.ClientArea.ResumeLayout(false);
            this.nbReport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binLocationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recieveStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockTakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Panel pMainForm;
        private System.Windows.Forms.ImageList imlMainLarge;
        private Guifreaks.Navisuite.NaviBar Outlookbar;
        private Guifreaks.Navisuite.NaviBand nbReport;
        private System.Windows.Forms.TreeView tvReports;
        private Guifreaks.Navisuite.NaviBand nbStockControl;
        private System.Windows.Forms.Panel pStock;
        private System.Windows.Forms.Button btnDispatchStock;
        private System.Windows.Forms.Button btnOrderStock;
        private System.Windows.Forms.Button btnViewStock;
        private Guifreaks.Navisuite.NaviBand nbWarehouse;
        private System.Windows.Forms.Panel pWarehouse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnWHStockT;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPutAway;
        private System.Windows.Forms.Button btnPickOrder;
        private System.Windows.Forms.Button btnWHStockTake;
        private Guifreaks.Navisuite.NaviBand nbLibrary;
        private System.Windows.Forms.Panel pControl;
        private System.Windows.Forms.Button btnBinlocations;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.ImageList imlMainSmall;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.ToolStripMenuItem onlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesRepsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleOutletsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem budgetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnEventStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventCollectionReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventDeliveryReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dispatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeWarehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockTakeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem putAwayStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pickStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completedPurchaseOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completedSalesOrdersToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveStockToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDispatchLabels;
        private System.Windows.Forms.ToolStripMenuItem returnStockToolStripMenuItem;
        private System.Windows.Forms.Button btnCycleCount;
    }
}

