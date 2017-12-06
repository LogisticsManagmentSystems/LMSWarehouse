namespace LMSWarehouse
{
    partial class FrmStockMoveSKU
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockMoveSKU));
            this.tsContainer = new System.Windows.Forms.ToolStripContainer();
            this.dgStockBins = new System.Windows.Forms.DataGridView();
            this.pDetail = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.Label();
            this.txtExpiry = new System.Windows.Forms.Label();
            this.txtSKU = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.Label();
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cbFilter = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStriptxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMoveStock = new System.Windows.Forms.ToolStripButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBinDescription = new System.Windows.Forms.Label();
            this.txtBin = new System.Windows.Forms.Label();
            this.cbDestinationBin = new System.Windows.Forms.ComboBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.cbStockMoveType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tsContainer.ContentPanel.SuspendLayout();
            this.tsContainer.TopToolStripPanel.SuspendLayout();
            this.tsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStockBins)).BeginInit();
            this.pDetail.SuspendLayout();
            this.toolStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsContainer
            // 
            // 
            // tsContainer.ContentPanel
            // 
            this.tsContainer.ContentPanel.Controls.Add(this.dgStockBins);
            this.tsContainer.ContentPanel.Controls.Add(this.pDetail);
            this.tsContainer.ContentPanel.Size = new System.Drawing.Size(760, 367);
            this.tsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsContainer.Location = new System.Drawing.Point(0, 0);
            this.tsContainer.Name = "tsContainer";
            this.tsContainer.Size = new System.Drawing.Size(760, 392);
            this.tsContainer.TabIndex = 2;
            this.tsContainer.Text = "toolStripContainer1";
            // 
            // tsContainer.TopToolStripPanel
            // 
            this.tsContainer.TopToolStripPanel.Controls.Add(this.toolStripTop);
            // 
            // dgStockBins
            // 
            this.dgStockBins.AllowUserToAddRows = false;
            this.dgStockBins.AllowUserToDeleteRows = false;
            this.dgStockBins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgStockBins.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgStockBins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgStockBins.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgStockBins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgStockBins.Location = new System.Drawing.Point(0, 0);
            this.dgStockBins.Name = "dgStockBins";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgStockBins.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgStockBins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgStockBins.Size = new System.Drawing.Size(760, 209);
            this.dgStockBins.TabIndex = 0;
            this.dgStockBins.SelectionChanged += new System.EventHandler(this.dgStockBins_SelectionChanged);
            // 
            // pDetail
            // 
            this.pDetail.Controls.Add(this.cbStockMoveType);
            this.pDetail.Controls.Add(this.label1);
            this.pDetail.Controls.Add(this.txtQty);
            this.pDetail.Controls.Add(this.cbDestinationBin);
            this.pDetail.Controls.Add(this.label10);
            this.pDetail.Controls.Add(this.label11);
            this.pDetail.Controls.Add(this.txtBinDescription);
            this.pDetail.Controls.Add(this.txtBin);
            this.pDetail.Controls.Add(this.label7);
            this.pDetail.Controls.Add(this.label9);
            this.pDetail.Controls.Add(this.label8);
            this.pDetail.Controls.Add(this.label2);
            this.pDetail.Controls.Add(this.label4);
            this.pDetail.Controls.Add(this.label6);
            this.pDetail.Controls.Add(this.txtDescription);
            this.pDetail.Controls.Add(this.txtExpiry);
            this.pDetail.Controls.Add(this.txtSKU);
            this.pDetail.Controls.Add(this.txtBarcode);
            this.pDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pDetail.Location = new System.Drawing.Point(0, 209);
            this.pDetail.Name = "pDetail";
            this.pDetail.Size = new System.Drawing.Size(760, 158);
            this.pDetail.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Description : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "SKU : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(431, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Qty : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(365, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Destination Bin : ";
            // 
            // txtDescription
            // 
            this.txtDescription.AutoSize = true;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(109, 51);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(85, 13);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Text = "txtDescription";
            // 
            // txtExpiry
            // 
            this.txtExpiry.AutoSize = true;
            this.txtExpiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpiry.Location = new System.Drawing.Point(109, 91);
            this.txtExpiry.Name = "txtExpiry";
            this.txtExpiry.Size = new System.Drawing.Size(55, 13);
            this.txtExpiry.TabIndex = 2;
            this.txtExpiry.Text = "txtExpiry";
            // 
            // txtSKU
            // 
            this.txtSKU.AutoSize = true;
            this.txtSKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSKU.Location = new System.Drawing.Point(110, 35);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(46, 13);
            this.txtSKU.TabIndex = 1;
            this.txtSKU.Text = "txtSKU";
            // 
            // txtBarcode
            // 
            this.txtBarcode.AutoSize = true;
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(109, 107);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(68, 13);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.Text = "txtBarcode";
            // 
            // toolStripTop
            // 
            this.toolStripTop.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.cbFilter,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStriptxtSearch,
            this.toolStripButtonSearch,
            this.toolStripButtonMoveStock});
            this.toolStripTop.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.Size = new System.Drawing.Size(760, 25);
            this.toolStripTop.Stretch = true;
            this.toolStripTop.TabIndex = 0;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(67, 22);
            this.toolStripLabel2.Text = "Select Filter";
            // 
            // cbFilter
            // 
            this.cbFilter.Items.AddRange(new object[] {
            "Bin",
            "Product Description",
            "SKU"});
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(74, 22);
            this.toolStripLabel1.Text = "Filter Criteria";
            // 
            // toolStriptxtSearch
            // 
            this.toolStriptxtSearch.Name = "toolStriptxtSearch";
            this.toolStriptxtSearch.Size = new System.Drawing.Size(200, 25);
            // 
            // toolStripButtonSearch
            // 
            this.toolStripButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearch.Image")));
            this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearch.Name = "toolStripButtonSearch";
            this.toolStripButtonSearch.Size = new System.Drawing.Size(50, 22);
            this.toolStripButtonSearch.Text = "Find";
            // 
            // toolStripButtonMoveStock
            // 
            this.toolStripButtonMoveStock.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMoveStock.Image")));
            this.toolStripButtonMoveStock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMoveStock.Name = "toolStripButtonMoveStock";
            this.toolStripButtonMoveStock.Size = new System.Drawing.Size(89, 22);
            this.toolStripButtonMoveStock.Text = "Move Stock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Batch Number : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Expiry Date : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Bin Description : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Bin : ";
            // 
            // txtBinDescription
            // 
            this.txtBinDescription.AutoSize = true;
            this.txtBinDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBinDescription.Location = new System.Drawing.Point(109, 19);
            this.txtBinDescription.Name = "txtBinDescription";
            this.txtBinDescription.Size = new System.Drawing.Size(103, 13);
            this.txtBinDescription.TabIndex = 25;
            this.txtBinDescription.Text = "txtBinDescription";
            // 
            // txtBin
            // 
            this.txtBin.AutoSize = true;
            this.txtBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBin.Location = new System.Drawing.Point(110, 3);
            this.txtBin.Name = "txtBin";
            this.txtBin.Size = new System.Drawing.Size(39, 13);
            this.txtBin.TabIndex = 24;
            this.txtBin.Text = "txtBin";
            // 
            // cbDestinationBin
            // 
            this.cbDestinationBin.FormattingEnabled = true;
            this.cbDestinationBin.Location = new System.Drawing.Point(476, 43);
            this.cbDestinationBin.Name = "cbDestinationBin";
            this.cbDestinationBin.Size = new System.Drawing.Size(256, 21);
            this.cbDestinationBin.TabIndex = 28;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(476, 70);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(47, 20);
            this.txtQty.TabIndex = 29;
            // 
            // cbStockMoveType
            // 
            this.cbStockMoveType.FormattingEnabled = true;
            this.cbStockMoveType.Location = new System.Drawing.Point(476, 11);
            this.cbStockMoveType.Name = "cbStockMoveType";
            this.cbStockMoveType.Size = new System.Drawing.Size(130, 21);
            this.cbStockMoveType.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Stock move type : ";
            // 
            // FrmStockMoveSKU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 392);
            this.Controls.Add(this.tsContainer);
            this.Name = "FrmStockMoveSKU";
            this.Text = "Move Stock";
            this.tsContainer.ContentPanel.ResumeLayout(false);
            this.tsContainer.TopToolStripPanel.ResumeLayout(false);
            this.tsContainer.TopToolStripPanel.PerformLayout();
            this.tsContainer.ResumeLayout(false);
            this.tsContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStockBins)).EndInit();
            this.pDetail.ResumeLayout(false);
            this.pDetail.PerformLayout();
            this.toolStripTop.ResumeLayout(false);
            this.toolStripTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tsContainer;
        private System.Windows.Forms.DataGridView dgStockBins;
        private System.Windows.Forms.Panel pDetail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtDescription;
        private System.Windows.Forms.Label txtExpiry;
        private System.Windows.Forms.Label txtSKU;
        private System.Windows.Forms.Label txtBarcode;
        private System.Windows.Forms.ToolStrip toolStripTop;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cbFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStriptxtSearch;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        private System.Windows.Forms.ToolStripButton toolStripButtonMoveStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txtBinDescription;
        private System.Windows.Forms.Label txtBin;
        private System.Windows.Forms.ComboBox cbDestinationBin;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.ComboBox cbStockMoveType;
        private System.Windows.Forms.Label label1;
    }
}