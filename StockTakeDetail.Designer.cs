namespace LMSWarehouse
{
    partial class FrmStockTakeDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockTakeDetail));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dbStockTakeDet = new System.Windows.Forms.DataGridView();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnUpdStock = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnCorrection = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbStockTakeDet)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dbStockTakeDet);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 611);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 636);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip);
            // 
            // dbStockTakeDet
            // 
            this.dbStockTakeDet.AllowUserToAddRows = false;
            this.dbStockTakeDet.AllowUserToDeleteRows = false;
            this.dbStockTakeDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbStockTakeDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbStockTakeDet.Location = new System.Drawing.Point(0, 0);
            this.dbStockTakeDet.MultiSelect = false;
            this.dbStockTakeDet.Name = "dbStockTakeDet";
            this.dbStockTakeDet.ReadOnly = true;
            this.dbStockTakeDet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbStockTakeDet.Size = new System.Drawing.Size(800, 611);
            this.dbStockTakeDet.TabIndex = 0;
            this.dbStockTakeDet.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dbStockTakeDet_CellFormatting);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnUpdStock,
            this.toolStripBtnCorrection,
            this.toolStripButton3,
            this.toolStripClose});
            this.toolStrip.Location = new System.Drawing.Point(3, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(421, 25);
            this.toolStrip.TabIndex = 0;
            // 
            // toolStripBtnUpdStock
            // 
            this.toolStripBtnUpdStock.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnUpdStock.Image")));
            this.toolStripBtnUpdStock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnUpdStock.Name = "toolStripBtnUpdStock";
            this.toolStripBtnUpdStock.Size = new System.Drawing.Size(139, 22);
            this.toolStripBtnUpdStock.Text = "Complete Stock Take";
            this.toolStripBtnUpdStock.Click += new System.EventHandler(this.toolStripBtnUpdStock_Click);
            // 
            // toolStripBtnCorrection
            // 
            this.toolStripBtnCorrection.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCorrection.Image")));
            this.toolStripBtnCorrection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCorrection.Name = "toolStripBtnCorrection";
            this.toolStripBtnCorrection.Size = new System.Drawing.Size(83, 22);
            this.toolStripBtnCorrection.Text = "Correction";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(131, 22);
            this.toolStripButton3.Text = "Match to Stocklevel";
            // 
            // toolStripClose
            // 
            this.toolStripClose.Image = ((System.Drawing.Image)(resources.GetObject("toolStripClose.Image")));
            this.toolStripClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripClose.Name = "toolStripClose";
            this.toolStripClose.Size = new System.Drawing.Size(56, 22);
            this.toolStripClose.Text = "Close";
            this.toolStripClose.Click += new System.EventHandler(this.toolStripClose_Click);
            // 
            // FrmStockTakeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 636);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "FrmStockTakeDetail";
            this.Text = "StockTakeDetail";
            this.Load += new System.EventHandler(this.FrmStockTakeDetail_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbStockTakeDet)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.DataGridView dbStockTakeDet;
        private System.Windows.Forms.ToolStripButton toolStripBtnUpdStock;
        private System.Windows.Forms.ToolStripButton toolStripBtnCorrection;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripClose;

    }
}