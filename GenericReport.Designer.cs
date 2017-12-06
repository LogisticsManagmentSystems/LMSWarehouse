namespace LMSWarehouse
{
    partial class FrmGenericReport
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
            this.pTop = new System.Windows.Forms.Panel();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.gbReportType = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rdExcel = new System.Windows.Forms.RadioButton();
            this.rdWindows = new System.Windows.Forms.RadioButton();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblPrimaryCustomer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbWarehouse = new System.Windows.Forms.ComboBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.cbPrimaryCustomer = new System.Windows.Forms.ComboBox();
            this.pGrid = new System.Windows.Forms.Panel();
            this.dgResult = new System.Windows.Forms.DataGridView();
            this.pTop.SuspendLayout();
            this.gbReportType.SuspendLayout();
            this.pGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pTop
            // 
            this.pTop.Controls.Add(this.BtnPrint);
            this.pTop.Controls.Add(this.gbReportType);
            this.pTop.Controls.Add(this.lblWarehouse);
            this.pTop.Controls.Add(this.label7);
            this.pTop.Controls.Add(this.label6);
            this.pTop.Controls.Add(this.label5);
            this.pTop.Controls.Add(this.lblCustomer);
            this.pTop.Controls.Add(this.lblPrimaryCustomer);
            this.pTop.Controls.Add(this.label2);
            this.pTop.Controls.Add(this.label1);
            this.pTop.Controls.Add(this.cbWarehouse);
            this.pTop.Controls.Add(this.cbProduct);
            this.pTop.Controls.Add(this.cbCategory);
            this.pTop.Controls.Add(this.cbBrand);
            this.pTop.Controls.Add(this.cbCustomer);
            this.pTop.Controls.Add(this.dtEnd);
            this.pTop.Controls.Add(this.dtStart);
            this.pTop.Controls.Add(this.cbPrimaryCustomer);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(687, 399);
            this.pTop.TabIndex = 18;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Location = new System.Drawing.Point(399, 336);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(176, 23);
            this.BtnPrint.TabIndex = 35;
            this.BtnPrint.Text = "Report";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // gbReportType
            // 
            this.gbReportType.Controls.Add(this.radioButton3);
            this.gbReportType.Controls.Add(this.rdExcel);
            this.gbReportType.Controls.Add(this.rdWindows);
            this.gbReportType.Location = new System.Drawing.Point(399, 39);
            this.gbReportType.Name = "gbReportType";
            this.gbReportType.Size = new System.Drawing.Size(176, 169);
            this.gbReportType.TabIndex = 34;
            this.gbReportType.TabStop = false;
            this.gbReportType.Text = "Report Type";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(28, 115);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(94, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Results to html";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rdExcel
            // 
            this.rdExcel.AutoSize = true;
            this.rdExcel.Location = new System.Drawing.Point(28, 73);
            this.rdExcel.Name = "rdExcel";
            this.rdExcel.Size = new System.Drawing.Size(101, 17);
            this.rdExcel.TabIndex = 1;
            this.rdExcel.Text = "Results to Excel";
            this.rdExcel.UseVisualStyleBackColor = true;
            // 
            // rdWindows
            // 
            this.rdWindows.AutoSize = true;
            this.rdWindows.Checked = true;
            this.rdWindows.Location = new System.Drawing.Point(28, 31);
            this.rdWindows.Name = "rdWindows";
            this.rdWindows.Size = new System.Drawing.Size(86, 17);
            this.rdWindows.TabIndex = 0;
            this.rdWindows.TabStop = true;
            this.rdWindows.Text = "View Results";
            this.rdWindows.UseVisualStyleBackColor = true;
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.AutoSize = true;
            this.lblWarehouse.Location = new System.Drawing.Point(35, 342);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(68, 13);
            this.lblWarehouse.TabIndex = 33;
            this.lblWarehouse.Text = "Warehouse :";
            this.lblWarehouse.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblWarehouse.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Product :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Category :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Brand :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(46, 170);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(57, 13);
            this.lblCustomer.TabIndex = 29;
            this.lblCustomer.Text = "Customer :";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPrimaryCustomer
            // 
            this.lblPrimaryCustomer.AutoSize = true;
            this.lblPrimaryCustomer.Location = new System.Drawing.Point(9, 129);
            this.lblPrimaryCustomer.Name = "lblPrimaryCustomer";
            this.lblPrimaryCustomer.Size = new System.Drawing.Size(94, 13);
            this.lblPrimaryCustomer.TabIndex = 28;
            this.lblPrimaryCustomer.Text = "Primary Customer :";
            this.lblPrimaryCustomer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Date End :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Date Start :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbWarehouse
            // 
            this.cbWarehouse.Enabled = false;
            this.cbWarehouse.FormattingEnabled = true;
            this.cbWarehouse.Location = new System.Drawing.Point(109, 339);
            this.cbWarehouse.Name = "cbWarehouse";
            this.cbWarehouse.Size = new System.Drawing.Size(200, 21);
            this.cbWarehouse.TabIndex = 25;
            this.cbWarehouse.Visible = false;
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(109, 300);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(200, 21);
            this.cbProduct.TabIndex = 24;
            this.cbProduct.Enter += new System.EventHandler(this.cbProduct_Enter);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(109, 260);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(200, 21);
            this.cbCategory.TabIndex = 23;
            this.cbCategory.Enter += new System.EventHandler(this.cbCategory_Enter);
            // 
            // cbBrand
            // 
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(109, 212);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(200, 21);
            this.cbBrand.TabIndex = 22;
            this.cbBrand.Enter += new System.EventHandler(this.cbBrand_Enter);
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(109, 167);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(200, 21);
            this.cbCustomer.TabIndex = 21;
            this.cbCustomer.Enter += new System.EventHandler(this.cbCustomer_Enter);
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(109, 83);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(200, 20);
            this.dtEnd.TabIndex = 20;
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(109, 39);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(200, 20);
            this.dtStart.TabIndex = 19;
            // 
            // cbPrimaryCustomer
            // 
            this.cbPrimaryCustomer.FormattingEnabled = true;
            this.cbPrimaryCustomer.Location = new System.Drawing.Point(109, 126);
            this.cbPrimaryCustomer.Name = "cbPrimaryCustomer";
            this.cbPrimaryCustomer.Size = new System.Drawing.Size(200, 21);
            this.cbPrimaryCustomer.TabIndex = 18;
            this.cbPrimaryCustomer.Enter += new System.EventHandler(this.cbPrimaryCustomer_Enter);
            // 
            // pGrid
            // 
            this.pGrid.Controls.Add(this.dgResult);
            this.pGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGrid.Location = new System.Drawing.Point(0, 399);
            this.pGrid.Name = "pGrid";
            this.pGrid.Size = new System.Drawing.Size(687, 149);
            this.pGrid.TabIndex = 19;
            // 
            // dgResult
            // 
            this.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgResult.Location = new System.Drawing.Point(0, 0);
            this.dgResult.Name = "dgResult";
            this.dgResult.Size = new System.Drawing.Size(687, 149);
            this.dgResult.TabIndex = 0;
            // 
            // FrmGenericReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 548);
            this.Controls.Add(this.pGrid);
            this.Controls.Add(this.pTop);
            this.Name = "FrmGenericReport";
            this.Text = "GenericReport";
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            this.gbReportType.ResumeLayout(false);
            this.gbReportType.PerformLayout();
            this.pGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.GroupBox gbReportType;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rdExcel;
        private System.Windows.Forms.RadioButton rdWindows;
        private System.Windows.Forms.Label lblWarehouse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblPrimaryCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbWarehouse;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.ComboBox cbPrimaryCustomer;
        private System.Windows.Forms.Panel pGrid;
        private System.Windows.Forms.DataGridView dgResult;

    }
}