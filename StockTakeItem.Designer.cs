namespace LMSWarehouse
{
    partial class FrmStockTakeItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockTakeItem));
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.pOrder = new System.Windows.Forms.Panel();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblBin = new System.Windows.Forms.Label();
            this.txtBin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripBottom = new System.Windows.Forms.ToolStrip();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.POrderDetail = new System.Windows.Forms.Panel();
            this.lbScanned = new System.Windows.Forms.ListBox();
            this.toolStripTop.SuspendLayout();
            this.pOrder.SuspendLayout();
            this.toolStripBottom.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.POrderDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(71, 22);
            this.newToolStripButton.Text = "&New Bin";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // toolStripTop
            // 
            this.toolStripTop.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.toolStripButtonClose});
            this.toolStripTop.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.Size = new System.Drawing.Size(792, 25);
            this.toolStripTop.Stretch = true;
            this.toolStripTop.TabIndex = 0;
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
            // pOrder
            // 
            this.pOrder.Controls.Add(this.txtItem);
            this.pOrder.Controls.Add(this.label3);
            this.pOrder.Controls.Add(this.label2);
            this.pOrder.Controls.Add(this.lblQty);
            this.pOrder.Controls.Add(this.lblBin);
            this.pOrder.Controls.Add(this.txtBin);
            this.pOrder.Controls.Add(this.label1);
            this.pOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pOrder.Location = new System.Drawing.Point(0, 0);
            this.pOrder.Name = "pOrder";
            this.pOrder.Size = new System.Drawing.Size(792, 216);
            this.pOrder.TabIndex = 0;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(136, 90);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(231, 20);
            this.txtItem.TabIndex = 19;
            this.txtItem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtItem_KeyUp);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(35, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Scan Item :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(59, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Items in Bin:";
            // 
            // lblQty
            // 
            this.lblQty.Font = new System.Drawing.Font("Tahoma", 28F);
            this.lblQty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQty.Location = new System.Drawing.Point(136, 129);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(90, 43);
            this.lblQty.TabIndex = 22;
            this.lblQty.Text = "0";
            // 
            // lblBin
            // 
            this.lblBin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblBin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBin.Location = new System.Drawing.Point(133, 56);
            this.lblBin.Name = "lblBin";
            this.lblBin.Size = new System.Drawing.Size(174, 20);
            this.lblBin.TabIndex = 23;
            this.lblBin.Text = "Bin Description";
            // 
            // txtBin
            // 
            this.txtBin.Location = new System.Drawing.Point(136, 18);
            this.txtBin.Name = "txtBin";
            this.txtBin.Size = new System.Drawing.Size(231, 20);
            this.txtBin.TabIndex = 18;
            this.txtBin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBin_KeyUp);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(57, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Scan Bin :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.toolStripContainer1.ContentPanel.Controls.Add(this.POrderDetail);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pOrder);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(792, 651);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(792, 676);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripTop);
            // 
            // POrderDetail
            // 
            this.POrderDetail.Controls.Add(this.lbScanned);
            this.POrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.POrderDetail.Location = new System.Drawing.Point(0, 216);
            this.POrderDetail.Name = "POrderDetail";
            this.POrderDetail.Size = new System.Drawing.Size(792, 435);
            this.POrderDetail.TabIndex = 1;
            // 
            // lbScanned
            // 
            this.lbScanned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbScanned.FormattingEnabled = true;
            this.lbScanned.Location = new System.Drawing.Point(0, 0);
            this.lbScanned.Name = "lbScanned";
            this.lbScanned.Size = new System.Drawing.Size(792, 433);
            this.lbScanned.TabIndex = 0;
            // 
            // FrmStockTakeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 676);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "FrmStockTakeItem";
            this.Text = "Stock Take Bin Scan";
            this.toolStripTop.ResumeLayout(false);
            this.toolStripTop.PerformLayout();
            this.pOrder.ResumeLayout(false);
            this.pOrder.PerformLayout();
            this.toolStripBottom.ResumeLayout(false);
            this.toolStripBottom.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.POrderDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStrip toolStripTop;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.Panel pOrder;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblBin;
        private System.Windows.Forms.TextBox txtBin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStripBottom;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Panel POrderDetail;
        private System.Windows.Forms.ListBox lbScanned;
    }
}