namespace LMSWarehouse
{
    partial class FrmStockTake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockTake));
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.pList = new System.Windows.Forms.Panel();
            this.dgStockTake = new System.Windows.Forms.DataGridView();
            this.pDetail = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnStockTake = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonScan = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.pList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStockTake)).BeginInit();
            this.pDetail.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.pList);
            this.toolStripContainer.ContentPanel.Controls.Add(this.pDetail);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(795, 612);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(795, 637);
            this.toolStripContainer.TabIndex = 0;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // pList
            // 
            this.pList.Controls.Add(this.dgStockTake);
            this.pList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pList.Location = new System.Drawing.Point(0, 0);
            this.pList.Name = "pList";
            this.pList.Size = new System.Drawing.Size(795, 531);
            this.pList.TabIndex = 1;
            // 
            // dgStockTake
            // 
            this.dgStockTake.AllowUserToAddRows = false;
            this.dgStockTake.AllowUserToDeleteRows = false;
            this.dgStockTake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStockTake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgStockTake.Location = new System.Drawing.Point(0, 0);
            this.dgStockTake.Name = "dgStockTake";
            this.dgStockTake.ReadOnly = true;
            this.dgStockTake.Size = new System.Drawing.Size(795, 531);
            this.dgStockTake.TabIndex = 0;
            // 
            // pDetail
            // 
            this.pDetail.Controls.Add(this.label1);
            this.pDetail.Controls.Add(this.txtDescription);
            this.pDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pDetail.Location = new System.Drawing.Point(0, 531);
            this.pDetail.Name = "pDetail";
            this.pDetail.Size = new System.Drawing.Size(795, 81);
            this.pDetail.TabIndex = 0;
            this.pDetail.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stock Take Description : ";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(161, 31);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(258, 20);
            this.txtDescription.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnNew,
            this.toolStripBtnSave,
            this.toolStripBtnStockTake,
            this.toolStripButtonScan});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(795, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripBtnNew
            // 
            this.toolStripBtnNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnNew.Image")));
            this.toolStripBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnNew.Name = "toolStripBtnNew";
            this.toolStripBtnNew.Size = new System.Drawing.Size(51, 22);
            this.toolStripBtnNew.Text = "New";
            this.toolStripBtnNew.Click += new System.EventHandler(this.toolStripBtnNew_Click);
            // 
            // toolStripBtnSave
            // 
            this.toolStripBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSave.Image")));
            this.toolStripBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSave.Name = "toolStripBtnSave";
            this.toolStripBtnSave.Size = new System.Drawing.Size(51, 22);
            this.toolStripBtnSave.Text = "Save";
            this.toolStripBtnSave.Click += new System.EventHandler(this.toolStripBtnSave_Click);
            // 
            // toolStripBtnStockTake
            // 
            this.toolStripBtnStockTake.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnStockTake.Image")));
            this.toolStripBtnStockTake.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnStockTake.Name = "toolStripBtnStockTake";
            this.toolStripBtnStockTake.Size = new System.Drawing.Size(84, 22);
            this.toolStripBtnStockTake.Text = "Stock Take";
            this.toolStripBtnStockTake.Click += new System.EventHandler(this.toolStripBtnStockTake_Click);
            // 
            // toolStripButtonScan
            // 
            this.toolStripButtonScan.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonScan.Image")));
            this.toolStripButtonScan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonScan.Name = "toolStripButtonScan";
            this.toolStripButtonScan.Size = new System.Drawing.Size(77, 22);
            this.toolStripButtonScan.Text = "Scan Bins";
            this.toolStripButtonScan.Click += new System.EventHandler(this.toolStripButtonScan_Click);
            // 
            // FrmStockTake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 637);
            this.Controls.Add(this.toolStripContainer);
            this.Name = "FrmStockTake";
            this.Text = "StockTake";
            this.Load += new System.EventHandler(this.FrmStockTake_Load);
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.pList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgStockTake)).EndInit();
            this.pDetail.ResumeLayout(false);
            this.pDetail.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.Panel pList;
        private System.Windows.Forms.DataGridView dgStockTake;
        private System.Windows.Forms.Panel pDetail;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnNew;
        private System.Windows.Forms.ToolStripButton toolStripBtnSave;
        private System.Windows.Forms.ToolStripButton toolStripBtnStockTake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ToolStripButton toolStripButtonScan;

    }
}