namespace LMSWarehouse
{
    partial class FrmBinLibrary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBinLibrary));
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.pGrid = new System.Windows.Forms.Panel();
            this.dgBins = new System.Windows.Forms.DataGridView();
            this.pDetail = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDecription = new System.Windows.Forms.TextBox();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.cmbColumn = new System.Windows.Forms.ComboBox();
            this.cmbRow = new System.Windows.Forms.ComboBox();
            this.cmbWarehouse = new System.Windows.Forms.ComboBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripPrintAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.pGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBins)).BeginInit();
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
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(647, 345);
            this.toolStripContainer.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(647, 370);
            this.toolStripContainer.TabIndex = 0;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
            // 
            // pGrid
            // 
            this.pGrid.Controls.Add(this.dgBins);
            this.pGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGrid.Location = new System.Drawing.Point(0, 0);
            this.pGrid.Name = "pGrid";
            this.pGrid.Size = new System.Drawing.Size(647, 192);
            this.pGrid.TabIndex = 15;
            // 
            // dgBins
            // 
            this.dgBins.AllowUserToAddRows = false;
            this.dgBins.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            this.dgBins.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgBins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBins.Location = new System.Drawing.Point(0, 0);
            this.dgBins.Name = "dgBins";
            this.dgBins.ReadOnly = true;
            this.dgBins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBins.Size = new System.Drawing.Size(647, 192);
            this.dgBins.TabIndex = 1;
            this.dgBins.SelectionChanged += new System.EventHandler(this.dgBins_SelectionChanged);
            // 
            // pDetail
            // 
            this.pDetail.Controls.Add(this.label6);
            this.pDetail.Controls.Add(this.label5);
            this.pDetail.Controls.Add(this.label4);
            this.pDetail.Controls.Add(this.label3);
            this.pDetail.Controls.Add(this.label2);
            this.pDetail.Controls.Add(this.label1);
            this.pDetail.Controls.Add(this.txtDecription);
            this.pDetail.Controls.Add(this.cmbLocation);
            this.pDetail.Controls.Add(this.cmbLevel);
            this.pDetail.Controls.Add(this.cmbColumn);
            this.pDetail.Controls.Add(this.cmbRow);
            this.pDetail.Controls.Add(this.cmbWarehouse);
            this.pDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pDetail.Location = new System.Drawing.Point(0, 192);
            this.pDetail.Name = "pDetail";
            this.pDetail.Size = new System.Drawing.Size(647, 153);
            this.pDetail.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Column";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Row";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Warehouse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Description";
            // 
            // txtDecription
            // 
            this.txtDecription.Location = new System.Drawing.Point(122, 29);
            this.txtDecription.Name = "txtDecription";
            this.txtDecription.Size = new System.Drawing.Size(161, 20);
            this.txtDecription.TabIndex = 19;
            // 
            // cmbLocation
            // 
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(122, 86);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(161, 21);
            this.cmbLocation.TabIndex = 18;
            this.cmbLocation.Leave += new System.EventHandler(this.cmbLocation_Leave);
            this.cmbLocation.Enter += new System.EventHandler(this.cmbLocation_Enter);
            // 
            // cmbLevel
            // 
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Location = new System.Drawing.Point(402, 83);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(172, 21);
            this.cmbLevel.TabIndex = 17;
            this.cmbLevel.Leave += new System.EventHandler(this.cmbLevel_Leave);
            this.cmbLevel.Enter += new System.EventHandler(this.cmbLevel_Enter);
            // 
            // cmbColumn
            // 
            this.cmbColumn.FormattingEnabled = true;
            this.cmbColumn.Location = new System.Drawing.Point(402, 55);
            this.cmbColumn.Name = "cmbColumn";
            this.cmbColumn.Size = new System.Drawing.Size(172, 21);
            this.cmbColumn.TabIndex = 16;
            this.cmbColumn.Leave += new System.EventHandler(this.cmbColumn_Leave);
            this.cmbColumn.Enter += new System.EventHandler(this.cmbColumn_Enter);
            // 
            // cmbRow
            // 
            this.cmbRow.FormattingEnabled = true;
            this.cmbRow.Location = new System.Drawing.Point(402, 29);
            this.cmbRow.Name = "cmbRow";
            this.cmbRow.Size = new System.Drawing.Size(172, 21);
            this.cmbRow.TabIndex = 15;
            this.cmbRow.Leave += new System.EventHandler(this.cmbRow_Leave);
            this.cmbRow.Enter += new System.EventHandler(this.cmbRow_Enter);
            // 
            // cmbWarehouse
            // 
            this.cmbWarehouse.FormattingEnabled = true;
            this.cmbWarehouse.Location = new System.Drawing.Point(122, 59);
            this.cmbWarehouse.Name = "cmbWarehouse";
            this.cmbWarehouse.Size = new System.Drawing.Size(161, 21);
            this.cmbWarehouse.TabIndex = 14;
            this.cmbWarehouse.Leave += new System.EventHandler(this.cmbWarehouse_Leave);
            this.cmbWarehouse.Enter += new System.EventHandler(this.cmbWarehouse_Enter);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripPrintAll});
            this.toolStrip.Location = new System.Drawing.Point(3, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(266, 25);
            this.toolStrip.TabIndex = 0;
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.AccessibleName = "";
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
            // toolStripPrintAll
            // 
            this.toolStripPrintAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPrintAll.Image")));
            this.toolStripPrintAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPrintAll.Name = "toolStripPrintAll";
            this.toolStripPrintAll.Size = new System.Drawing.Size(69, 22);
            this.toolStripPrintAll.Text = "Print All";
            this.toolStripPrintAll.Click += new System.EventHandler(this.toolStripPrintAll_Click);
            // 
            // FrmBinLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 370);
            this.Controls.Add(this.toolStripContainer);
            this.Name = "FrmBinLibrary";
            this.Text = "BinLibrary";
            this.Load += new System.EventHandler(this.FrmBinLibrary_Load);
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.pGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBins)).EndInit();
            this.pDetail.ResumeLayout(false);
            this.pDetail.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.Panel pDetail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDecription;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.ComboBox cmbColumn;
        private System.Windows.Forms.ComboBox cmbRow;
        private System.Windows.Forms.ComboBox cmbWarehouse;
        private System.Windows.Forms.Panel pGrid;
        private System.Windows.Forms.DataGridView dgBins;
        private System.Windows.Forms.ToolStripButton toolStripPrintAll;

    }
}