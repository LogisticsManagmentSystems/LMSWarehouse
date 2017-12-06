namespace LMSWarehouse
{
    partial class FrmPickList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPickList));
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dgOrder = new System.Windows.Forms.DataGridView();
            this.dgDetail = new System.Windows.Forms.DataGridView();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPick = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnGenPickList = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnFreePick = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.splitContainer);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(635, 512);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(635, 537);
            this.toolStripContainer.TabIndex = 0;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.dgOrder);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dgDetail);
            this.splitContainer.Size = new System.Drawing.Size(635, 512);
            this.splitContainer.SplitterDistance = 229;
            this.splitContainer.TabIndex = 0;
            // 
            // dgOrder
            // 
            this.dgOrder.AllowUserToAddRows = false;
            this.dgOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOrder.Location = new System.Drawing.Point(0, 0);
            this.dgOrder.Name = "dgOrder";
            this.dgOrder.ReadOnly = true;
            this.dgOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrder.Size = new System.Drawing.Size(635, 229);
            this.dgOrder.TabIndex = 0;
            this.dgOrder.SelectionChanged += new System.EventHandler(this.dgOrder_SelectionChanged);
            // 
            // dgDetail
            // 
            this.dgDetail.AllowUserToAddRows = false;
            this.dgDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDetail.Location = new System.Drawing.Point(0, 0);
            this.dgDetail.Name = "dgDetail";
            this.dgDetail.ReadOnly = true;
            this.dgDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDetail.Size = new System.Drawing.Size(635, 279);
            this.dgDetail.TabIndex = 0;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPick,
            this.toolStripButtonPrint,
            this.toolStripBtnGenPickList,
            this.toolStripBtnFreePick});
            this.toolStrip.Location = new System.Drawing.Point(3, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(399, 25);
            this.toolStrip.TabIndex = 0;
            // 
            // toolStripButtonPick
            // 
            this.toolStripButtonPick.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPick.Image")));
            this.toolStripButtonPick.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPick.Name = "toolStripButtonPick";
            this.toolStripButtonPick.Size = new System.Drawing.Size(76, 22);
            this.toolStripButtonPick.Text = "Pick Item";
            this.toolStripButtonPick.Click += new System.EventHandler(this.toolStripButtonPick_Click);
            // 
            // toolStripButtonPrint
            // 
            this.toolStripButtonPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrint.Image")));
            this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new System.Drawing.Size(92, 22);
            this.toolStripButtonPrint.Text = "Print Picklist";
            this.toolStripButtonPrint.Click += new System.EventHandler(this.toolStripButtonPrint_Click);
            // 
            // toolStripBtnGenPickList
            // 
            this.toolStripBtnGenPickList.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnGenPickList.Image")));
            this.toolStripBtnGenPickList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnGenPickList.Name = "toolStripBtnGenPickList";
            this.toolStripBtnGenPickList.Size = new System.Drawing.Size(114, 22);
            this.toolStripBtnGenPickList.Text = "Generate Picklist";
            this.toolStripBtnGenPickList.Click += new System.EventHandler(this.toolStripBtnGenPickList_Click);
            // 
            // toolStripBtnFreePick
            // 
            this.toolStripBtnFreePick.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnFreePick.Image")));
            this.toolStripBtnFreePick.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnFreePick.Name = "toolStripBtnFreePick";
            this.toolStripBtnFreePick.Size = new System.Drawing.Size(74, 22);
            this.toolStripBtnFreePick.Text = "Free Pick";
            this.toolStripBtnFreePick.Click += new System.EventHandler(this.toolStripBtnFreePick_Click);
            // 
            // FrmPickList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 537);
            this.Controls.Add(this.toolStripContainer);
            this.Name = "FrmPickList";
            this.Text = "PickList";
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView dgOrder;
        private System.Windows.Forms.DataGridView dgDetail;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonPick;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.ToolStripButton toolStripBtnGenPickList;
        private System.Windows.Forms.ToolStripButton toolStripBtnFreePick;
    }
}