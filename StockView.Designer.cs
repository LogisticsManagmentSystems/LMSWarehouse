namespace LMSWarehouse
{
    partial class FrmStockView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockView));
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.pList = new System.Windows.Forms.Panel();
            this.dgStockView = new System.Windows.Forms.DataGridView();
            this.pDetail = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnAllocate = new System.Windows.Forms.ToolStripButton();
            this.toolStripDetail = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.pList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStockView)).BeginInit();
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
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(818, 414);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(818, 439);
            this.toolStripContainer.TabIndex = 1;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // pList
            // 
            this.pList.Controls.Add(this.dgStockView);
            this.pList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pList.Location = new System.Drawing.Point(0, 0);
            this.pList.Name = "pList";
            this.pList.Size = new System.Drawing.Size(818, 333);
            this.pList.TabIndex = 1;
            // 
            // dgStockView
            // 
            this.dgStockView.AllowUserToAddRows = false;
            this.dgStockView.AllowUserToDeleteRows = false;
            this.dgStockView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgStockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStockView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgStockView.Location = new System.Drawing.Point(0, 0);
            this.dgStockView.Name = "dgStockView";
            this.dgStockView.ReadOnly = true;
            this.dgStockView.Size = new System.Drawing.Size(818, 333);
            this.dgStockView.TabIndex = 0;
            this.dgStockView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStockView_CellContentClick);
            // 
            // pDetail
            // 
            this.pDetail.Controls.Add(this.label1);
            this.pDetail.Controls.Add(this.txtDescription);
            this.pDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pDetail.Location = new System.Drawing.Point(0, 333);
            this.pDetail.Name = "pDetail";
            this.pDetail.Size = new System.Drawing.Size(818, 81);
            this.pDetail.TabIndex = 0;
            this.pDetail.Visible = false;
            this.pDetail.Paint += new System.Windows.Forms.PaintEventHandler(this.pDetail_Paint);
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
            this.toolStripBtnAllocate,
            this.toolStripDetail,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(818, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripBtnAllocate
            // 
            this.toolStripBtnAllocate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnAllocate.Image")));
            this.toolStripBtnAllocate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAllocate.Name = "toolStripBtnAllocate";
            this.toolStripBtnAllocate.Size = new System.Drawing.Size(121, 22);
            this.toolStripBtnAllocate.Text = "Allocate and Print";
            this.toolStripBtnAllocate.Click += new System.EventHandler(this.toolStripBtnAllocate_Click);
            // 
            // toolStripDetail
            // 
            this.toolStripDetail.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDetail.Image")));
            this.toolStripDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDetail.Name = "toolStripDetail";
            this.toolStripDetail.Size = new System.Drawing.Size(89, 22);
            this.toolStripDetail.Text = "Stock Detail";
            this.toolStripDetail.Click += new System.EventHandler(this.toolStripDetail_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel1.Text = "Search:";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Find";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FrmStockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 439);
            this.Controls.Add(this.toolStripContainer);
            this.Name = "FrmStockView";
            this.Text = "View Stock";
            this.Load += new System.EventHandler(this.FrmStockView_Load);
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.pList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgStockView)).EndInit();
            this.pDetail.ResumeLayout(false);
            this.pDetail.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.Panel pList;
        private System.Windows.Forms.DataGridView dgStockView;
        private System.Windows.Forms.Panel pDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnAllocate;
        private System.Windows.Forms.ToolStripButton toolStripDetail;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}