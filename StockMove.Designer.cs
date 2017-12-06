namespace LMSWarehouse
{
    partial class FrmStockMove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockMove));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPick = new System.Windows.Forms.ToolStripButton();
            this.pDetail = new System.Windows.Forms.Panel();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.lblLabel = new System.Windows.Forms.Label();
            this.cbStockMoveType = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.pDetail.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPick});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(132, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButtonPick
            // 
            this.toolStripButtonPick.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPick.Image")));
            this.toolStripButtonPick.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPick.Name = "toolStripButtonPick";
            this.toolStripButtonPick.Size = new System.Drawing.Size(89, 22);
            this.toolStripButtonPick.Text = "Move Stock";
            this.toolStripButtonPick.Click += new System.EventHandler(this.toolStripButtonPick_Click);
            // 
            // pDetail
            // 
            this.pDetail.Controls.Add(this.cbStockMoveType);
            this.pDetail.Controls.Add(this.lblLabel);
            this.pDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDetail.Location = new System.Drawing.Point(0, 0);
            this.pDetail.Name = "pDetail";
            this.pDetail.Size = new System.Drawing.Size(669, 511);
            this.pDetail.TabIndex = 0;
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.pDetail);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(669, 511);
            this.toolStripContainer.ContentPanel.Load += new System.EventHandler(this.toolStripContainer_ContentPanel_Load);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(669, 536);
            this.toolStripContainer.TabIndex = 1;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(45, 41);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(154, 13);
            this.lblLabel.TabIndex = 0;
            this.lblLabel.Text = "Please select Stock Movement";
            // 
            // cbStockMoveType
            // 
            this.cbStockMoveType.FormattingEnabled = true;
            this.cbStockMoveType.Location = new System.Drawing.Point(48, 73);
            this.cbStockMoveType.Name = "cbStockMoveType";
            this.cbStockMoveType.Size = new System.Drawing.Size(287, 21);
            this.cbStockMoveType.TabIndex = 1;
            // 
            // FrmStockMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 536);
            this.Controls.Add(this.toolStripContainer);
            this.Name = "FrmStockMove";
            this.Text = "StockMove";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pDetail.ResumeLayout(false);
            this.pDetail.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonPick;
        private System.Windows.Forms.Panel pDetail;
        private System.Windows.Forms.ComboBox cbStockMoveType;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
    }
}