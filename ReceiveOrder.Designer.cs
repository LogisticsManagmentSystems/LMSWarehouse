namespace LMSWarehouse
{
    partial class FrmReceiveOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReceiveOrder));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripBottom = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dgReceive = new System.Windows.Forms.DataGridView();
            this.pDetail = new System.Windows.Forms.Panel();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblRe = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblOr = new System.Windows.Forms.Label();
            this.lblIT = new System.Windows.Forms.Label();
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnReceiveAll = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnRecItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnPrintSingle = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBatch = new System.Windows.Forms.ToolStripButton();
            this.toolStripScanItems = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStripBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReceive)).BeginInit();
            this.pDetail.SuspendLayout();
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
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgReceive);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pDetail);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(836, 486);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(836, 511);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripTop);
            // 
            // toolStripBottom
            // 
            this.toolStripBottom.AutoSize = false;
            this.toolStripBottom.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnSaveItem});
            this.toolStripBottom.Location = new System.Drawing.Point(0, 0);
            this.toolStripBottom.Name = "toolStripBottom";
            this.toolStripBottom.Size = new System.Drawing.Size(836, 25);
            this.toolStripBottom.Stretch = true;
            this.toolStripBottom.TabIndex = 0;
            this.toolStripBottom.Visible = false;
            // 
            // toolStripBtnSaveItem
            // 
            this.toolStripBtnSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtnSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSaveItem.Image")));
            this.toolStripBtnSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSaveItem.Name = "toolStripBtnSaveItem";
            this.toolStripBtnSaveItem.Size = new System.Drawing.Size(78, 22);
            this.toolStripBtnSaveItem.Text = "Save Item";
            this.toolStripBtnSaveItem.Click += new System.EventHandler(this.toolStripBtnSaveItem_Click);
            // 
            // dgReceive
            // 
            this.dgReceive.AllowUserToAddRows = false;
            this.dgReceive.AllowUserToDeleteRows = false;
            this.dgReceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgReceive.Location = new System.Drawing.Point(0, 0);
            this.dgReceive.Name = "dgReceive";
            this.dgReceive.ReadOnly = true;
            this.dgReceive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgReceive.Size = new System.Drawing.Size(836, 386);
            this.dgReceive.TabIndex = 1;
            this.dgReceive.SelectionChanged += new System.EventHandler(this.dgReceive_SelectionChanged);
            // 
            // pDetail
            // 
            this.pDetail.Controls.Add(this.txtQty);
            this.pDetail.Controls.Add(this.lblRe);
            this.pDetail.Controls.Add(this.lblQty);
            this.pDetail.Controls.Add(this.lblItem);
            this.pDetail.Controls.Add(this.lblOr);
            this.pDetail.Controls.Add(this.lblIT);
            this.pDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pDetail.Location = new System.Drawing.Point(0, 386);
            this.pDetail.Name = "pDetail";
            this.pDetail.Size = new System.Drawing.Size(836, 100);
            this.pDetail.TabIndex = 0;
            this.pDetail.Visible = false;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(356, 47);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(72, 20);
            this.txtQty.TabIndex = 5;
            // 
            // lblRe
            // 
            this.lblRe.AutoSize = true;
            this.lblRe.Location = new System.Drawing.Point(259, 49);
            this.lblRe.Name = "lblRe";
            this.lblRe.Size = new System.Drawing.Size(78, 13);
            this.lblRe.TabIndex = 4;
            this.lblRe.Text = "Qty Received :";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(112, 49);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(14, 13);
            this.lblQty.TabIndex = 3;
            this.lblQty.Text = "0";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(112, 23);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(31, 13);
            this.lblItem.TabIndex = 2;
            this.lblItem.Text = "Item";
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Location = new System.Drawing.Point(36, 50);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(70, 13);
            this.lblOr.TabIndex = 1;
            this.lblOr.Text = "Qty Ordered :";
            // 
            // lblIT
            // 
            this.lblIT.AutoSize = true;
            this.lblIT.Location = new System.Drawing.Point(73, 23);
            this.lblIT.Name = "lblIT";
            this.lblIT.Size = new System.Drawing.Size(33, 13);
            this.lblIT.TabIndex = 0;
            this.lblIT.Text = "Item :";
            // 
            // toolStripTop
            // 
            this.toolStripTop.AutoSize = false;
            this.toolStripTop.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnReceiveAll,
            this.printToolStripButton,
            this.toolStripBtnRecItem,
            this.toolStripBtnPrintSingle,
            this.saveToolStripButton,
            this.toolStripButtonBatch,
            this.toolStripScanItems});
            this.toolStripTop.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.Size = new System.Drawing.Size(836, 25);
            this.toolStripTop.Stretch = true;
            this.toolStripTop.TabIndex = 0;
            // 
            // toolStripBtnReceiveAll
            // 
            this.toolStripBtnReceiveAll.Enabled = false;
            this.toolStripBtnReceiveAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnReceiveAll.Image")));
            this.toolStripBtnReceiveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnReceiveAll.Name = "toolStripBtnReceiveAll";
            this.toolStripBtnReceiveAll.Size = new System.Drawing.Size(84, 22);
            this.toolStripBtnReceiveAll.Text = "Recieve All";
            this.toolStripBtnReceiveAll.Click += new System.EventHandler(this.toolStripBtnReceiveAll_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(69, 22);
            this.printToolStripButton.Text = "&Print All";
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
            // 
            // toolStripBtnRecItem
            // 
            this.toolStripBtnRecItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnRecItem.Image")));
            this.toolStripBtnRecItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnRecItem.Name = "toolStripBtnRecItem";
            this.toolStripBtnRecItem.Size = new System.Drawing.Size(94, 22);
            this.toolStripBtnRecItem.Text = "Receive Item";
            this.toolStripBtnRecItem.Click += new System.EventHandler(this.toolStripBtnRecItem_Click);
            // 
            // toolStripBtnPrintSingle
            // 
            this.toolStripBtnPrintSingle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnPrintSingle.Image")));
            this.toolStripBtnPrintSingle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnPrintSingle.Name = "toolStripBtnPrintSingle";
            this.toolStripBtnPrintSingle.Size = new System.Drawing.Size(118, 22);
            this.toolStripBtnPrintSingle.Text = "Print Single Lable";
            this.toolStripBtnPrintSingle.Click += new System.EventHandler(this.toolStripBtnPrintSingle_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripButton.Text = "&Complete Order";
            this.saveToolStripButton.Visible = false;
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripButtonBatch
            // 
            this.toolStripButtonBatch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBatch.Image")));
            this.toolStripButtonBatch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBatch.Name = "toolStripButtonBatch";
            this.toolStripButtonBatch.Size = new System.Drawing.Size(100, 22);
            this.toolStripButtonBatch.Text = "Receive Batch";
            this.toolStripButtonBatch.Visible = false;
            this.toolStripButtonBatch.Click += new System.EventHandler(this.toolStripButtonBatch_Click);
            // 
            // toolStripScanItems
            // 
            this.toolStripScanItems.Image = ((System.Drawing.Image)(resources.GetObject("toolStripScanItems.Image")));
            this.toolStripScanItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripScanItems.Name = "toolStripScanItems";
            this.toolStripScanItems.Size = new System.Drawing.Size(84, 22);
            this.toolStripScanItems.Text = "Scan Items";
            // 
            // FrmReceiveOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 511);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "FrmReceiveOrder";
            this.Text = "ReceiveOrder";
            this.Load += new System.EventHandler(this.FrmReceiveOrder_Load);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStripBottom.ResumeLayout(false);
            this.toolStripBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReceive)).EndInit();
            this.pDetail.ResumeLayout(false);
            this.pDetail.PerformLayout();
            this.toolStripTop.ResumeLayout(false);
            this.toolStripTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridView dgReceive;
        private System.Windows.Forms.Panel pDetail;
        private System.Windows.Forms.ToolStrip toolStripTop;
        private System.Windows.Forms.ToolStripButton toolStripBtnReceiveAll;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripBtnRecItem;
        private System.Windows.Forms.ToolStripButton toolStripBtnPrintSingle;
        private System.Windows.Forms.ToolStrip toolStripBottom;
        private System.Windows.Forms.ToolStripButton toolStripBtnSaveItem;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblRe;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Label lblIT;
        private System.Windows.Forms.ToolStripButton toolStripButtonBatch;
        private System.Windows.Forms.ToolStripButton toolStripScanItems;
    }
}