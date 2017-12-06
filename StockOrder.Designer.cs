namespace LMSWarehouse
{
    partial class FrmStockOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockOrder));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripBottom = new System.Windows.Forms.ToolStrip();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.PAddDetail = new System.Windows.Forms.Panel();
            this.btnMore = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSKU = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.POrderDetail = new System.Windows.Forms.Panel();
            this.dgStockItems = new System.Windows.Forms.DataGridView();
            this.pOrder = new System.Windows.Forms.Panel();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSpecialInstruction = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtShipperRef = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustRef = new System.Windows.Forms.TextBox();
            this.lblPrimaryCustomer = new System.Windows.Forms.Label();
            this.cbPrimaryCustomer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtDPostal = new System.Windows.Forms.TextBox();
            this.txtDAddress4 = new System.Windows.Forms.TextBox();
            this.txtDAddress3 = new System.Windows.Forms.TextBox();
            this.txtDAddress2 = new System.Windows.Forms.TextBox();
            this.txtDAddress1 = new System.Windows.Forms.TextBox();
            this.txtDAddressName = new System.Windows.Forms.TextBox();
            this.txtPPostal = new System.Windows.Forms.TextBox();
            this.txtPAddress4 = new System.Windows.Forms.TextBox();
            this.txtPAddress3 = new System.Windows.Forms.TextBox();
            this.txtPAddress2 = new System.Windows.Forms.TextBox();
            this.txtPAddress1 = new System.Windows.Forms.TextBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.txtPAddressName = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOnline = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnNewLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStripBottom.SuspendLayout();
            this.PAddDetail.SuspendLayout();
            this.POrderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStockItems)).BeginInit();
            this.pOrder.SuspendLayout();
            this.toolStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.toolStripBottom);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.PAddDetail);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.POrderDetail);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pOrder);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(655, 485);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(655, 510);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripTop);
            // 
            // toolStripBottom
            // 
            this.toolStripBottom.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSave});
            this.toolStripBottom.Location = new System.Drawing.Point(0, 0);
            this.toolStripBottom.Name = "toolStripBottom";
            this.toolStripBottom.Size = new System.Drawing.Size(88, 25);
            this.toolStripBottom.Stretch = true;
            this.toolStripBottom.TabIndex = 0;
            this.toolStripBottom.Visible = false;
            // 
            // toolStripSave
            // 
            this.toolStripSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSave.Image")));
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(76, 22);
            this.toolStripSave.Text = "Save Line";
            this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
            // 
            // PAddDetail
            // 
            this.PAddDetail.Controls.Add(this.btnMore);
            this.PAddDetail.Controls.Add(this.lblAmount);
            this.PAddDetail.Controls.Add(this.label8);
            this.PAddDetail.Controls.Add(this.txtAmount);
            this.PAddDetail.Controls.Add(this.txtQty);
            this.PAddDetail.Controls.Add(this.label7);
            this.PAddDetail.Controls.Add(this.lblSKU);
            this.PAddDetail.Controls.Add(this.txtDescription);
            this.PAddDetail.Controls.Add(this.txtSKU);
            this.PAddDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PAddDetail.Location = new System.Drawing.Point(0, 400);
            this.PAddDetail.Name = "PAddDetail";
            this.PAddDetail.Size = new System.Drawing.Size(655, 85);
            this.PAddDetail.TabIndex = 2;
            this.PAddDetail.Visible = false;
            // 
            // btnMore
            // 
            this.btnMore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMore.Location = new System.Drawing.Point(259, 16);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(26, 20);
            this.btnMore.TabIndex = 8;
            this.btnMore.Text = "...";
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(338, 51);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Qty";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(387, 48);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 5;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(390, 17);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Description";
            // 
            // lblSKU
            // 
            this.lblSKU.AutoSize = true;
            this.lblSKU.Location = new System.Drawing.Point(50, 20);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Size = new System.Drawing.Size(29, 13);
            this.lblSKU.TabIndex = 2;
            this.lblSKU.Text = "SKU";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(97, 44);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(188, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // txtSKU
            // 
            this.txtSKU.Location = new System.Drawing.Point(97, 17);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(167, 20);
            this.txtSKU.TabIndex = 0;
            this.txtSKU.Leave += new System.EventHandler(this.txtSKU_Leave);
            this.txtSKU.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSKU_KeyUp);
            // 
            // POrderDetail
            // 
            this.POrderDetail.Controls.Add(this.dgStockItems);
            this.POrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.POrderDetail.Location = new System.Drawing.Point(0, 216);
            this.POrderDetail.Name = "POrderDetail";
            this.POrderDetail.Size = new System.Drawing.Size(655, 269);
            this.POrderDetail.TabIndex = 1;
            // 
            // dgStockItems
            // 
            this.dgStockItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStockItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgStockItems.Location = new System.Drawing.Point(0, 0);
            this.dgStockItems.Name = "dgStockItems";
            this.dgStockItems.Size = new System.Drawing.Size(655, 269);
            this.dgStockItems.TabIndex = 0;
            // 
            // pOrder
            // 
            this.pOrder.Controls.Add(this.btnSearchCustomer);
            this.pOrder.Controls.Add(this.label9);
            this.pOrder.Controls.Add(this.txtSpecialInstruction);
            this.pOrder.Controls.Add(this.label6);
            this.pOrder.Controls.Add(this.txtShipperRef);
            this.pOrder.Controls.Add(this.label1);
            this.pOrder.Controls.Add(this.txtCustRef);
            this.pOrder.Controls.Add(this.lblPrimaryCustomer);
            this.pOrder.Controls.Add(this.cbPrimaryCustomer);
            this.pOrder.Controls.Add(this.label5);
            this.pOrder.Controls.Add(this.label4);
            this.pOrder.Controls.Add(this.label3);
            this.pOrder.Controls.Add(this.label2);
            this.pOrder.Controls.Add(this.lblCustomer);
            this.pOrder.Controls.Add(this.txtDPostal);
            this.pOrder.Controls.Add(this.txtDAddress4);
            this.pOrder.Controls.Add(this.txtDAddress3);
            this.pOrder.Controls.Add(this.txtDAddress2);
            this.pOrder.Controls.Add(this.txtDAddress1);
            this.pOrder.Controls.Add(this.txtDAddressName);
            this.pOrder.Controls.Add(this.txtPPostal);
            this.pOrder.Controls.Add(this.txtPAddress4);
            this.pOrder.Controls.Add(this.txtPAddress3);
            this.pOrder.Controls.Add(this.txtPAddress2);
            this.pOrder.Controls.Add(this.txtPAddress1);
            this.pOrder.Controls.Add(this.cbCustomer);
            this.pOrder.Controls.Add(this.txtPAddressName);
            this.pOrder.Controls.Add(this.txtDate);
            this.pOrder.Controls.Add(this.txtReference);
            this.pOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pOrder.Location = new System.Drawing.Point(0, 0);
            this.pOrder.Name = "pOrder";
            this.pOrder.Size = new System.Drawing.Size(655, 216);
            this.pOrder.TabIndex = 0;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchCustomer.Location = new System.Drawing.Point(252, 51);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(24, 20);
            this.btnSearchCustomer.TabIndex = 9;
            this.btnSearchCustomer.Text = "...";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Special Instructions";
            // 
            // txtSpecialInstruction
            // 
            this.txtSpecialInstruction.Location = new System.Drawing.Point(112, 183);
            this.txtSpecialInstruction.Name = "txtSpecialInstruction";
            this.txtSpecialInstruction.Size = new System.Drawing.Size(507, 20);
            this.txtSpecialInstruction.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Shipper Reference";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtShipperRef
            // 
            this.txtShipperRef.Location = new System.Drawing.Point(112, 157);
            this.txtShipperRef.Name = "txtShipperRef";
            this.txtShipperRef.Size = new System.Drawing.Size(142, 20);
            this.txtShipperRef.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Customer Reference";
            // 
            // txtCustRef
            // 
            this.txtCustRef.Location = new System.Drawing.Point(112, 129);
            this.txtCustRef.Name = "txtCustRef";
            this.txtCustRef.Size = new System.Drawing.Size(142, 20);
            this.txtCustRef.TabIndex = 4;
            // 
            // lblPrimaryCustomer
            // 
            this.lblPrimaryCustomer.AutoSize = true;
            this.lblPrimaryCustomer.Location = new System.Drawing.Point(18, 27);
            this.lblPrimaryCustomer.Name = "lblPrimaryCustomer";
            this.lblPrimaryCustomer.Size = new System.Drawing.Size(88, 13);
            this.lblPrimaryCustomer.TabIndex = 21;
            this.lblPrimaryCustomer.Text = "Primary Customer";
            this.lblPrimaryCustomer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbPrimaryCustomer
            // 
            this.cbPrimaryCustomer.FormattingEnabled = true;
            this.cbPrimaryCustomer.Location = new System.Drawing.Point(112, 24);
            this.cbPrimaryCustomer.Name = "cbPrimaryCustomer";
            this.cbPrimaryCustomer.Size = new System.Drawing.Size(142, 21);
            this.cbPrimaryCustomer.TabIndex = 0;
            this.cbPrimaryCustomer.DropDownClosed += new System.EventHandler(this.cbPrimaryCustomer_DropDownClosed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Delivery Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Pickup Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Order Reference";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(55, 54);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(51, 13);
            this.lblCustomer.TabIndex = 15;
            this.lblCustomer.Text = "Customer";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDPostal
            // 
            this.txtDPostal.Location = new System.Drawing.Point(467, 157);
            this.txtDPostal.Name = "txtDPostal";
            this.txtDPostal.Size = new System.Drawing.Size(100, 20);
            this.txtDPostal.TabIndex = 18;
            // 
            // txtDAddress4
            // 
            this.txtDAddress4.Location = new System.Drawing.Point(467, 130);
            this.txtDAddress4.Name = "txtDAddress4";
            this.txtDAddress4.Size = new System.Drawing.Size(152, 20);
            this.txtDAddress4.TabIndex = 17;
            // 
            // txtDAddress3
            // 
            this.txtDAddress3.Location = new System.Drawing.Point(467, 103);
            this.txtDAddress3.Name = "txtDAddress3";
            this.txtDAddress3.Size = new System.Drawing.Size(152, 20);
            this.txtDAddress3.TabIndex = 16;
            // 
            // txtDAddress2
            // 
            this.txtDAddress2.Location = new System.Drawing.Point(467, 76);
            this.txtDAddress2.Name = "txtDAddress2";
            this.txtDAddress2.Size = new System.Drawing.Size(152, 20);
            this.txtDAddress2.TabIndex = 15;
            // 
            // txtDAddress1
            // 
            this.txtDAddress1.AcceptsReturn = true;
            this.txtDAddress1.Location = new System.Drawing.Point(467, 50);
            this.txtDAddress1.Name = "txtDAddress1";
            this.txtDAddress1.Size = new System.Drawing.Size(152, 20);
            this.txtDAddress1.TabIndex = 14;
            // 
            // txtDAddressName
            // 
            this.txtDAddressName.Location = new System.Drawing.Point(467, 23);
            this.txtDAddressName.Name = "txtDAddressName";
            this.txtDAddressName.Size = new System.Drawing.Size(152, 20);
            this.txtDAddressName.TabIndex = 13;
            // 
            // txtPPostal
            // 
            this.txtPPostal.Location = new System.Drawing.Point(289, 157);
            this.txtPPostal.Name = "txtPPostal";
            this.txtPPostal.Size = new System.Drawing.Size(100, 20);
            this.txtPPostal.TabIndex = 12;
            // 
            // txtPAddress4
            // 
            this.txtPAddress4.Location = new System.Drawing.Point(289, 130);
            this.txtPAddress4.Name = "txtPAddress4";
            this.txtPAddress4.Size = new System.Drawing.Size(152, 20);
            this.txtPAddress4.TabIndex = 11;
            // 
            // txtPAddress3
            // 
            this.txtPAddress3.Location = new System.Drawing.Point(289, 103);
            this.txtPAddress3.Name = "txtPAddress3";
            this.txtPAddress3.Size = new System.Drawing.Size(152, 20);
            this.txtPAddress3.TabIndex = 10;
            // 
            // txtPAddress2
            // 
            this.txtPAddress2.Location = new System.Drawing.Point(289, 76);
            this.txtPAddress2.Name = "txtPAddress2";
            this.txtPAddress2.Size = new System.Drawing.Size(152, 20);
            this.txtPAddress2.TabIndex = 9;
            // 
            // txtPAddress1
            // 
            this.txtPAddress1.Location = new System.Drawing.Point(289, 50);
            this.txtPAddress1.Name = "txtPAddress1";
            this.txtPAddress1.Size = new System.Drawing.Size(152, 20);
            this.txtPAddress1.TabIndex = 8;
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(112, 50);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(142, 21);
            this.cbCustomer.TabIndex = 1;
            this.cbCustomer.DropDownClosed += new System.EventHandler(this.cbCustomer_DropDownClosed);
            // 
            // txtPAddressName
            // 
            this.txtPAddressName.Location = new System.Drawing.Point(289, 23);
            this.txtPAddressName.Name = "txtPAddressName";
            this.txtPAddressName.Size = new System.Drawing.Size(152, 20);
            this.txtPAddressName.TabIndex = 7;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(112, 103);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(142, 20);
            this.txtDate.TabIndex = 3;
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(112, 77);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(142, 20);
            this.txtReference.TabIndex = 2;
            // 
            // toolStripTop
            // 
            this.toolStripTop.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.saveToolStripButton,
            this.toolStripButtonOnline,
            this.toolStripBtnNewLine,
            this.toolStripButtonDelete,
            this.toolStripButtonClose});
            this.toolStripTop.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.Size = new System.Drawing.Size(655, 25);
            this.toolStripTop.Stretch = true;
            this.toolStripTop.TabIndex = 0;
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(84, 22);
            this.newToolStripButton.Text = "&New Order";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(84, 22);
            this.saveToolStripButton.Text = "&Save Order";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripButtonOnline
            // 
            this.toolStripButtonOnline.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOnline.Image")));
            this.toolStripButtonOnline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOnline.Name = "toolStripButtonOnline";
            this.toolStripButtonOnline.Size = new System.Drawing.Size(134, 22);
            this.toolStripButtonOnline.Text = "Import Online Order";
            this.toolStripButtonOnline.Click += new System.EventHandler(this.toolStripButtonOnline_Click);
            // 
            // toolStripBtnNewLine
            // 
            this.toolStripBtnNewLine.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.toolStripBtnNewLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnNewLine.Image")));
            this.toolStripBtnNewLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnNewLine.Name = "toolStripBtnNewLine";
            this.toolStripBtnNewLine.Size = new System.Drawing.Size(107, 22);
            this.toolStripBtnNewLine.Text = "Add Order Line";
            this.toolStripBtnNewLine.Click += new System.EventHandler(this.toolStripBtnNewLine_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(118, 22);
            this.toolStripButtonDelete.Text = "Delete Order Line";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripButtonClose
            // 
            this.toolStripButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClose.Image")));
            this.toolStripButtonClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClose.Name = "toolStripButtonClose";
            this.toolStripButtonClose.Size = new System.Drawing.Size(56, 22);
            this.toolStripButtonClose.Text = "Close";
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // FrmStockOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 510);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "FrmStockOrder";
            this.Text = "StockOrder";
            this.Load += new System.EventHandler(this.FrmStockOrder_Load);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStripBottom.ResumeLayout(false);
            this.toolStripBottom.PerformLayout();
            this.PAddDetail.ResumeLayout(false);
            this.PAddDetail.PerformLayout();
            this.POrderDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgStockItems)).EndInit();
            this.pOrder.ResumeLayout(false);
            this.pOrder.PerformLayout();
            this.toolStripTop.ResumeLayout(false);
            this.toolStripTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Panel PAddDetail;
        private System.Windows.Forms.Panel POrderDetail;
        private System.Windows.Forms.Panel pOrder;
        private System.Windows.Forms.DataGridView dgStockItems;
        private System.Windows.Forms.ToolStrip toolStripBottom;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.ToolStrip toolStripTop;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.TextBox txtPAddressName;
        private System.Windows.Forms.Label lblPrimaryCustomer;
        private System.Windows.Forms.ComboBox cbPrimaryCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtDPostal;
        private System.Windows.Forms.TextBox txtDAddress4;
        private System.Windows.Forms.TextBox txtDAddress3;
        private System.Windows.Forms.TextBox txtDAddress2;
        private System.Windows.Forms.TextBox txtDAddress1;
        private System.Windows.Forms.TextBox txtDAddressName;
        private System.Windows.Forms.TextBox txtPPostal;
        private System.Windows.Forms.TextBox txtPAddress4;
        private System.Windows.Forms.TextBox txtPAddress3;
        private System.Windows.Forms.TextBox txtPAddress2;
        private System.Windows.Forms.TextBox txtPAddress1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripBtnNewLine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSKU;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.ToolStripButton toolStripButtonOnline;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtShipperRef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustRef;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSpecialInstruction;
        private System.Windows.Forms.Button btnSearchCustomer;
    }
}