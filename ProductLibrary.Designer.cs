namespace LMSWarehouse
{
    partial class FrmProductLibrary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductLibrary));
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.pGrid = new System.Windows.Forms.Panel();
            this.dgProduct = new System.Windows.Forms.DataGridView();
            this.pDetail = new System.Windows.Forms.Panel();
            this.cbReturn = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.TxtMin = new System.Windows.Forms.TextBox();
            this.txtPacksize = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cbWebSite = new System.Windows.Forms.CheckBox();
            this.txtExDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelB = new System.Windows.Forms.ToolStripLabel();
            this.toolStripcbBrand = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabelC = new System.Windows.Forms.ToolStripLabel();
            this.toolStripcbCategory = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAdjustment = new System.Windows.Forms.ToolStripButton();
            this.btnMakeclothes = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.pGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).BeginInit();
            this.pDetail.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.pGrid);
            this.toolStripContainer.ContentPanel.Controls.Add(this.pDetail);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(926, 619);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(926, 644);
            this.toolStripContainer.TabIndex = 0;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
            // 
            // pGrid
            // 
            this.pGrid.Controls.Add(this.dgProduct);
            this.pGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGrid.Location = new System.Drawing.Point(0, 0);
            this.pGrid.Name = "pGrid";
            this.pGrid.Size = new System.Drawing.Size(926, 396);
            this.pGrid.TabIndex = 2;
            // 
            // dgProduct
            // 
            this.dgProduct.AllowUserToAddRows = false;
            this.dgProduct.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            this.dgProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProduct.Location = new System.Drawing.Point(0, 0);
            this.dgProduct.Name = "dgProduct";
            this.dgProduct.ReadOnly = true;
            this.dgProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProduct.Size = new System.Drawing.Size(926, 396);
            this.dgProduct.TabIndex = 1;
            this.dgProduct.SelectionChanged += new System.EventHandler(this.dgProduct_SelectionChanged);
            // 
            // pDetail
            // 
            this.pDetail.Controls.Add(this.cbReturn);
            this.pDetail.Controls.Add(this.label8);
            this.pDetail.Controls.Add(this.label7);
            this.pDetail.Controls.Add(this.label6);
            this.pDetail.Controls.Add(this.labelp);
            this.pDetail.Controls.Add(this.label5);
            this.pDetail.Controls.Add(this.label4);
            this.pDetail.Controls.Add(this.txtSKU);
            this.pDetail.Controls.Add(this.TxtMin);
            this.pDetail.Controls.Add(this.txtPacksize);
            this.pDetail.Controls.Add(this.txtAmount);
            this.pDetail.Controls.Add(this.cbWebSite);
            this.pDetail.Controls.Add(this.txtExDescription);
            this.pDetail.Controls.Add(this.label3);
            this.pDetail.Controls.Add(this.label2);
            this.pDetail.Controls.Add(this.cbCategory);
            this.pDetail.Controls.Add(this.txtDescription);
            this.pDetail.Controls.Add(this.label1);
            this.pDetail.Controls.Add(this.cbBrand);
            this.pDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pDetail.Location = new System.Drawing.Point(0, 396);
            this.pDetail.Name = "pDetail";
            this.pDetail.Size = new System.Drawing.Size(926, 223);
            this.pDetail.TabIndex = 1;
            // 
            // cbReturn
            // 
            this.cbReturn.AutoSize = true;
            this.cbReturn.Location = new System.Drawing.Point(703, 66);
            this.cbReturn.Name = "cbReturn";
            this.cbReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbReturn.Size = new System.Drawing.Size(81, 17);
            this.cbReturn.TabIndex = 19;
            this.cbReturn.Text = "Return Item";
            this.cbReturn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(91, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "(leave blank for SKU Auto generate)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "SKU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Minimum quantity";
            // 
            // labelp
            // 
            this.labelp.AutoSize = true;
            this.labelp.Location = new System.Drawing.Point(398, 103);
            this.labelp.Name = "labelp";
            this.labelp.Size = new System.Drawing.Size(50, 13);
            this.labelp.TabIndex = 15;
            this.labelp.Text = "Packsize";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Extra Description";
            // 
            // txtSKU
            // 
            this.txtSKU.Location = new System.Drawing.Point(94, 104);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(182, 20);
            this.txtSKU.TabIndex = 12;
            this.txtSKU.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // TxtMin
            // 
            this.TxtMin.Location = new System.Drawing.Point(454, 137);
            this.TxtMin.Name = "TxtMin";
            this.TxtMin.Size = new System.Drawing.Size(182, 20);
            this.TxtMin.TabIndex = 11;
            // 
            // txtPacksize
            // 
            this.txtPacksize.Location = new System.Drawing.Point(454, 100);
            this.txtPacksize.Name = "txtPacksize";
            this.txtPacksize.Size = new System.Drawing.Size(182, 20);
            this.txtPacksize.TabIndex = 10;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(454, 63);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(182, 20);
            this.txtAmount.TabIndex = 9;
            // 
            // cbWebSite
            // 
            this.cbWebSite.AutoSize = true;
            this.cbWebSite.Location = new System.Drawing.Point(719, 25);
            this.cbWebSite.Name = "cbWebSite";
            this.cbWebSite.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbWebSite.Size = new System.Drawing.Size(65, 17);
            this.cbWebSite.TabIndex = 8;
            this.cbWebSite.Text = "Website";
            this.cbWebSite.UseVisualStyleBackColor = true;
            this.cbWebSite.CheckedChanged += new System.EventHandler(this.cbWebSite_CheckedChanged);
            // 
            // txtExDescription
            // 
            this.txtExDescription.Location = new System.Drawing.Point(454, 23);
            this.txtExDescription.Name = "txtExDescription";
            this.txtExDescription.Size = new System.Drawing.Size(182, 20);
            this.txtExDescription.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(94, 64);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(182, 21);
            this.cbCategory.TabIndex = 4;
            this.cbCategory.Leave += new System.EventHandler(this.cbCategory_Leave);
            this.cbCategory.Enter += new System.EventHandler(this.cbCategory_Enter);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(94, 141);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(182, 20);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brand";
            // 
            // cbBrand
            // 
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(94, 27);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(182, 21);
            this.cbBrand.TabIndex = 0;
            this.cbBrand.Leave += new System.EventHandler(this.cbBrand_Leave);
            this.cbBrand.Enter += new System.EventHandler(this.cbBrand_Enter);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.tsBtnDelete,
            this.toolStripSeparator1,
            this.toolStripLabelB,
            this.toolStripcbBrand,
            this.toolStripLabelC,
            this.toolStripcbCategory,
            this.toolStripSeparator2,
            this.toolStripButtonAdjustment,
            this.btnMakeclothes});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(926, 25);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 0;
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.printToolStripButton.Text = "&Print";
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
            // 
            // tsBtnDelete
            // 
            this.tsBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnDelete.Image")));
            this.tsBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDelete.Name = "tsBtnDelete";
            this.tsBtnDelete.Size = new System.Drawing.Size(60, 22);
            this.tsBtnDelete.Text = "Delete";
            this.tsBtnDelete.Click += new System.EventHandler(this.tsBtnDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelB
            // 
            this.toolStripLabelB.Name = "toolStripLabelB";
            this.toolStripLabelB.Size = new System.Drawing.Size(38, 22);
            this.toolStripLabelB.Text = "Brand";
            // 
            // toolStripcbBrand
            // 
            this.toolStripcbBrand.Name = "toolStripcbBrand";
            this.toolStripcbBrand.Size = new System.Drawing.Size(121, 25);
            this.toolStripcbBrand.SelectedIndexChanged += new System.EventHandler(this.toolStripcbBrand_SelectedIndexChanged);
            // 
            // toolStripLabelC
            // 
            this.toolStripLabelC.Name = "toolStripLabelC";
            this.toolStripLabelC.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabelC.Text = "Category";
            // 
            // toolStripcbCategory
            // 
            this.toolStripcbCategory.Name = "toolStripcbCategory";
            this.toolStripcbCategory.Size = new System.Drawing.Size(121, 25);
            this.toolStripcbCategory.SelectedIndexChanged += new System.EventHandler(this.toolStripcbCategory_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonAdjustment
            // 
            this.toolStripButtonAdjustment.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdjustment.Image")));
            this.toolStripButtonAdjustment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdjustment.Name = "toolStripButtonAdjustment";
            this.toolStripButtonAdjustment.Size = new System.Drawing.Size(121, 22);
            this.toolStripButtonAdjustment.Text = "Stock Adjustment";
            this.toolStripButtonAdjustment.Click += new System.EventHandler(this.toolStripButtonAdjustment_Click);
            // 
            // btnMakeclothes
            // 
            this.btnMakeclothes.Image = ((System.Drawing.Image)(resources.GetObject("btnMakeclothes.Image")));
            this.btnMakeclothes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMakeclothes.Name = "btnMakeclothes";
            this.btnMakeclothes.Size = new System.Drawing.Size(103, 22);
            this.btnMakeclothes.Text = "Group Clothes";
            this.btnMakeclothes.Click += new System.EventHandler(this.btnMakeclothes_Click);
            // 
            // FrmProductLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 644);
            this.Controls.Add(this.toolStripContainer);
            this.Name = "FrmProductLibrary";
            this.Text = "Product Library";
            this.Load += new System.EventHandler(this.FrmProductLibrary_Load);
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.pGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).EndInit();
            this.pDetail.ResumeLayout(false);
            this.pDetail.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.Panel pDetail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripcbBrand;
        private System.Windows.Forms.ToolStripComboBox toolStripcbCategory;
        private System.Windows.Forms.ToolStripLabel toolStripLabelB;
        private System.Windows.Forms.ToolStripLabel toolStripLabelC;
        private System.Windows.Forms.TextBox TxtMin;
        private System.Windows.Forms.TextBox txtPacksize;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.CheckBox cbWebSite;
        private System.Windows.Forms.TextBox txtExDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pGrid;
        private System.Windows.Forms.DataGridView dgProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripButton tsBtnDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdjustment;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnMakeclothes;
        private System.Windows.Forms.CheckBox cbReturn;

    }
}