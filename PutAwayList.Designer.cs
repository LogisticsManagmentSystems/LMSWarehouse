namespace LMSWarehouse
{
    partial class FrmPutAwayList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPutAwayList));
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.pTop = new System.Windows.Forms.Panel();
            this.pDetail = new System.Windows.Forms.Panel();
            this.dgPutList = new System.Windows.Forms.DataGridView();
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPutAway = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.pTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPutList)).BeginInit();
            this.toolStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.pDetail);
            this.toolStripContainer.ContentPanel.Controls.Add(this.pTop);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(724, 521);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(724, 546);
            this.toolStripContainer.TabIndex = 0;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStripTop);
            // 
            // pTop
            // 
            this.pTop.Controls.Add(this.dgPutList);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(724, 521);
            this.pTop.TabIndex = 0;
            // 
            // pDetail
            // 
            this.pDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pDetail.Location = new System.Drawing.Point(0, 421);
            this.pDetail.Name = "pDetail";
            this.pDetail.Size = new System.Drawing.Size(724, 100);
            this.pDetail.TabIndex = 1;
            // 
            // dgPutList
            // 
            this.dgPutList.AllowUserToAddRows = false;
            this.dgPutList.AllowUserToDeleteRows = false;
            this.dgPutList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPutList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPutList.Location = new System.Drawing.Point(0, 0);
            this.dgPutList.Name = "dgPutList";
            this.dgPutList.ReadOnly = true;
            this.dgPutList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPutList.Size = new System.Drawing.Size(724, 521);
            this.dgPutList.TabIndex = 0;
            this.dgPutList.SelectionChanged += new System.EventHandler(this.dgPutList_SelectionChanged);
            // 
            // toolStripTop
            // 
            this.toolStripTop.AutoSize = false;
            this.toolStripTop.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPutAway});
            this.toolStripTop.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.Size = new System.Drawing.Size(724, 25);
            this.toolStripTop.Stretch = true;
            this.toolStripTop.TabIndex = 0;
            // 
            // toolStripButtonPutAway
            // 
            this.toolStripButtonPutAway.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPutAway.Image")));
            this.toolStripButtonPutAway.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPutAway.Name = "toolStripButtonPutAway";
            this.toolStripButtonPutAway.Size = new System.Drawing.Size(77, 22);
            this.toolStripButtonPutAway.Text = "Put Away";
            this.toolStripButtonPutAway.Click += new System.EventHandler(this.toolStripButtonPutAway_Click);
            // 
            // FrmPutAwayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 546);
            this.Controls.Add(this.toolStripContainer);
            this.Name = "FrmPutAwayList";
            this.Text = "PutAwayList";
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.pTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPutList)).EndInit();
            this.toolStripTop.ResumeLayout(false);
            this.toolStripTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.Panel pDetail;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.DataGridView dgPutList;
        private System.Windows.Forms.ToolStrip toolStripTop;
        private System.Windows.Forms.ToolStripButton toolStripButtonPutAway;
    }
}