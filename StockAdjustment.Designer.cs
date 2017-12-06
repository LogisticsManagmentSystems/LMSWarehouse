namespace LMSWarehouse
{
    partial class FrmStockAdjustment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockAdjustment));
            this.dgStock = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdjust = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.pGrid = new System.Windows.Forms.Panel();
            this.pDetail = new System.Windows.Forms.Panel();
            this.txtBin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewStock = new System.Windows.Forms.TextBox();
            this.txtOldStock = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgStock)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.pGrid.SuspendLayout();
            this.pDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgStock
            // 
            this.dgStock.AllowUserToAddRows = false;
            this.dgStock.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            this.dgStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgStock.Location = new System.Drawing.Point(0, 0);
            this.dgStock.Name = "dgStock";
            this.dgStock.ReadOnly = true;
            this.dgStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgStock.Size = new System.Drawing.Size(665, 287);
            this.dgStock.TabIndex = 1;
            this.dgStock.SelectionChanged += new System.EventHandler(this.dgStock_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Bin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(76, 22);
            this.saveToolStripButton.Text = "&Save Line";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.toolStripButtonAdjust});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(665, 25);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 0;
            // 
            // toolStripButtonAdjust
            // 
            this.toolStripButtonAdjust.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdjust.Image")));
            this.toolStripButtonAdjust.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdjust.Name = "toolStripButtonAdjust";
            this.toolStripButtonAdjust.Size = new System.Drawing.Size(93, 22);
            this.toolStripButtonAdjust.Text = "Adjust Stock";
            this.toolStripButtonAdjust.Click += new System.EventHandler(this.toolStripButtonAdjust_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Original Stock Level";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.pGrid);
            this.toolStripContainer.ContentPanel.Controls.Add(this.pDetail);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(665, 440);
            this.toolStripContainer.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(665, 465);
            this.toolStripContainer.TabIndex = 1;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
            // 
            // pGrid
            // 
            this.pGrid.Controls.Add(this.dgStock);
            this.pGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGrid.Location = new System.Drawing.Point(0, 0);
            this.pGrid.Name = "pGrid";
            this.pGrid.Size = new System.Drawing.Size(665, 287);
            this.pGrid.TabIndex = 15;
            // 
            // pDetail
            // 
            this.pDetail.Controls.Add(this.txtBin);
            this.pDetail.Controls.Add(this.label3);
            this.pDetail.Controls.Add(this.txtNewStock);
            this.pDetail.Controls.Add(this.label2);
            this.pDetail.Controls.Add(this.label1);
            this.pDetail.Controls.Add(this.txtOldStock);
            this.pDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pDetail.Location = new System.Drawing.Point(0, 287);
            this.pDetail.Name = "pDetail";
            this.pDetail.Size = new System.Drawing.Size(665, 153);
            this.pDetail.TabIndex = 14;
            // 
            // txtBin
            // 
            this.txtBin.Enabled = false;
            this.txtBin.Location = new System.Drawing.Point(164, 24);
            this.txtBin.Name = "txtBin";
            this.txtBin.Size = new System.Drawing.Size(161, 20);
            this.txtBin.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "New Stock Level";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNewStock
            // 
            this.txtNewStock.Location = new System.Drawing.Point(164, 80);
            this.txtNewStock.Name = "txtNewStock";
            this.txtNewStock.Size = new System.Drawing.Size(161, 20);
            this.txtNewStock.TabIndex = 22;
            this.txtNewStock.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtOldStock
            // 
            this.txtOldStock.Enabled = false;
            this.txtOldStock.Location = new System.Drawing.Point(164, 54);
            this.txtOldStock.Name = "txtOldStock";
            this.txtOldStock.Size = new System.Drawing.Size(161, 20);
            this.txtOldStock.TabIndex = 19;
            // 
            // FrmStockAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 465);
            this.Controls.Add(this.toolStripContainer);
            this.Name = "FrmStockAdjustment";
            this.Text = "StockAdjustment";
            ((System.ComponentModel.ISupportInitialize)(this.dgStock)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.pGrid.ResumeLayout(false);
            this.pDetail.ResumeLayout(false);
            this.pDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdjust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.Panel pGrid;
        private System.Windows.Forms.Panel pDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewStock;
        private System.Windows.Forms.TextBox txtOldStock;
        private System.Windows.Forms.TextBox txtBin;
    }
}