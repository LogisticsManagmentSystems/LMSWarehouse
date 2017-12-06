namespace LMSWarehouse
{
    partial class FrmAdminStockMove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminStockMove));
            this.pDetail = new System.Windows.Forms.Panel();
            this.toolStripMoveStock = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStockMove = new System.Windows.Forms.TextBox();
            this.pDetail.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pDetail
            // 
            this.pDetail.Controls.Add(this.txtStockMove);
            this.pDetail.Controls.Add(this.label1);
            this.pDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDetail.Location = new System.Drawing.Point(0, 0);
            this.pDetail.Name = "pDetail";
            this.pDetail.Size = new System.Drawing.Size(743, 587);
            this.pDetail.TabIndex = 0;
            // 
            // toolStripMoveStock
            // 
            this.toolStripMoveStock.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMoveStock.Image")));
            this.toolStripMoveStock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMoveStock.Name = "toolStripMoveStock";
            this.toolStripMoveStock.Size = new System.Drawing.Size(89, 22);
            this.toolStripMoveStock.Text = "Move Stock";
            this.toolStripMoveStock.Click += new System.EventHandler(this.toolStripMoveStock_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMoveStock});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(101, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.pDetail);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(743, 587);
            this.toolStripContainer.ContentPanel.Load += new System.EventHandler(this.toolStripContainer_ContentPanel_Load);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(743, 612);
            this.toolStripContainer.TabIndex = 2;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "StockMoveID";
            // 
            // txtStockMove
            // 
            this.txtStockMove.Location = new System.Drawing.Point(129, 41);
            this.txtStockMove.Name = "txtStockMove";
            this.txtStockMove.Size = new System.Drawing.Size(100, 20);
            this.txtStockMove.TabIndex = 1;
            // 
            // FrmAdminStockMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 612);
            this.Controls.Add(this.toolStripContainer);
            this.Name = "FrmAdminStockMove";
            this.Text = "AdminStockMove";
            this.pDetail.ResumeLayout(false);
            this.pDetail.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pDetail;
        private System.Windows.Forms.ToolStripButton toolStripMoveStock;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.TextBox txtStockMove;
        private System.Windows.Forms.Label label1;
    }
}