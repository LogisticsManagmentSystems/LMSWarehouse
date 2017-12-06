namespace LMSWarehouse
{
    partial class FrmStockPutaway
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockPutaway));
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.lbStock = new System.Windows.Forms.ListBox();
            this.pScan = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtScan = new System.Windows.Forms.TextBox();
            this.PStock = new System.Windows.Forms.Panel();
            this.txtPacksize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStockItem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.PBin = new System.Windows.Forms.Panel();
            this.lblBinLocation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBin = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsButtonClose = new System.Windows.Forms.ToolStripButton();
            this.tsBtnAddStock = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.pScan.SuspendLayout();
            this.PStock.SuspendLayout();
            this.PBin.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.lbStock);
            this.toolStripContainer.ContentPanel.Controls.Add(this.pScan);
            this.toolStripContainer.ContentPanel.Controls.Add(this.PStock);
            this.toolStripContainer.ContentPanel.Controls.Add(this.PBin);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(414, 305);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(414, 330);
            this.toolStripContainer.TabIndex = 8;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip2);
            // 
            // lbStock
            // 
            this.lbStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStock.FormattingEnabled = true;
            this.lbStock.Location = new System.Drawing.Point(0, 189);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(414, 108);
            this.lbStock.TabIndex = 10;
            // 
            // pScan
            // 
            this.pScan.Controls.Add(this.label2);
            this.pScan.Controls.Add(this.txtQty);
            this.pScan.Controls.Add(this.txtScan);
            this.pScan.Dock = System.Windows.Forms.DockStyle.Top;
            this.pScan.Location = new System.Drawing.Point(0, 133);
            this.pScan.Name = "pScan";
            this.pScan.Size = new System.Drawing.Size(414, 56);
            this.pScan.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Qty";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(328, 17);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(43, 20);
            this.txtQty.TabIndex = 1;
            // 
            // txtScan
            // 
            this.txtScan.Location = new System.Drawing.Point(104, 17);
            this.txtScan.Name = "txtScan";
            this.txtScan.Size = new System.Drawing.Size(174, 20);
            this.txtScan.TabIndex = 0;
            this.txtScan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtScan_KeyUp);
            // 
            // PStock
            // 
            this.PStock.Controls.Add(this.txtPacksize);
            this.PStock.Controls.Add(this.label3);
            this.PStock.Controls.Add(this.lblStockItem);
            this.PStock.Controls.Add(this.label1);
            this.PStock.Controls.Add(this.txtLabel);
            this.PStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.PStock.Location = new System.Drawing.Point(0, 58);
            this.PStock.Name = "PStock";
            this.PStock.Size = new System.Drawing.Size(414, 75);
            this.PStock.TabIndex = 8;
            // 
            // txtPacksize
            // 
            this.txtPacksize.Location = new System.Drawing.Point(104, 48);
            this.txtPacksize.Name = "txtPacksize";
            this.txtPacksize.Size = new System.Drawing.Size(174, 20);
            this.txtPacksize.TabIndex = 14;
            this.txtPacksize.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Pack Size";
            // 
            // lblStockItem
            // 
            this.lblStockItem.AutoSize = true;
            this.lblStockItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockItem.Location = new System.Drawing.Point(101, 29);
            this.lblStockItem.Name = "lblStockItem";
            this.lblStockItem.Size = new System.Drawing.Size(119, 16);
            this.lblStockItem.TabIndex = 12;
            this.lblStockItem.Text = "Scan Stock Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Product Label";
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(104, 6);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(162, 20);
            this.txtLabel.TabIndex = 10;
            this.txtLabel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLabel_KeyUp);
            // 
            // PBin
            // 
            this.PBin.Controls.Add(this.lblBinLocation);
            this.PBin.Controls.Add(this.label4);
            this.PBin.Controls.Add(this.txtBin);
            this.PBin.Dock = System.Windows.Forms.DockStyle.Top;
            this.PBin.Location = new System.Drawing.Point(0, 0);
            this.PBin.Name = "PBin";
            this.PBin.Size = new System.Drawing.Size(414, 58);
            this.PBin.TabIndex = 7;
            // 
            // lblBinLocation
            // 
            this.lblBinLocation.AutoSize = true;
            this.lblBinLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinLocation.Location = new System.Drawing.Point(101, 36);
            this.lblBinLocation.Name = "lblBinLocation";
            this.lblBinLocation.Size = new System.Drawing.Size(132, 16);
            this.lblBinLocation.TabIndex = 15;
            this.lblBinLocation.Text = "Scan Bin Barcode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Bin Barcode";
            // 
            // txtBin
            // 
            this.txtBin.Location = new System.Drawing.Point(104, 13);
            this.txtBin.Name = "txtBin";
            this.txtBin.Size = new System.Drawing.Size(162, 20);
            this.txtBin.TabIndex = 13;
            this.txtBin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBin_KeyUp);
            this.txtBin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBin_KeyPress);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsButtonClose,
            this.tsBtnAddStock});
            this.toolStrip2.Location = new System.Drawing.Point(3, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(149, 25);
            this.toolStrip2.TabIndex = 0;
            // 
            // tsButtonClose
            // 
            this.tsButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("tsButtonClose.Image")));
            this.tsButtonClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonClose.Name = "tsButtonClose";
            this.tsButtonClose.Size = new System.Drawing.Size(56, 22);
            this.tsButtonClose.Text = "Close";
            this.tsButtonClose.Click += new System.EventHandler(this.tsButtonClose_Click);
            // 
            // tsBtnAddStock
            // 
            this.tsBtnAddStock.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnAddStock.Image")));
            this.tsBtnAddStock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAddStock.Name = "tsBtnAddStock";
            this.tsBtnAddStock.Size = new System.Drawing.Size(81, 22);
            this.tsBtnAddStock.Text = "Add Stock";
            // 
            // FrmStockPutaway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 330);
            this.Controls.Add(this.toolStripContainer);
            this.Name = "FrmStockPutaway";
            this.Text = "Stock Putaway";
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.pScan.ResumeLayout(false);
            this.pScan.PerformLayout();
            this.PStock.ResumeLayout(false);
            this.PStock.PerformLayout();
            this.PBin.ResumeLayout(false);
            this.PBin.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.ListBox lbStock;
        private System.Windows.Forms.Panel pScan;
        private System.Windows.Forms.Panel PStock;
        private System.Windows.Forms.TextBox txtPacksize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStockItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.Panel PBin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBin;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsButtonClose;
        private System.Windows.Forms.ToolStripButton tsBtnAddStock;
        private System.Windows.Forms.TextBox txtScan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblBinLocation;


    }
}