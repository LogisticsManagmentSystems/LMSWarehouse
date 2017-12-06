namespace LMSWarehouse
{
    partial class FrmStockMoveOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockMoveOrder));
            this.tsContainer = new System.Windows.Forms.ToolStripContainer();
            this.splConTainer = new System.Windows.Forms.SplitContainer();
            this.dgStockMove = new System.Windows.Forms.DataGridView();
            this.dgStockMoveDetail = new System.Windows.Forms.DataGridView();
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDispatch = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTrack = new System.Windows.Forms.ToolStripButton();
            this.tsContainer.ContentPanel.SuspendLayout();
            this.tsContainer.TopToolStripPanel.SuspendLayout();
            this.tsContainer.SuspendLayout();
            this.splConTainer.Panel1.SuspendLayout();
            this.splConTainer.Panel2.SuspendLayout();
            this.splConTainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStockMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStockMoveDetail)).BeginInit();
            this.toolStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsContainer
            // 
            // 
            // tsContainer.ContentPanel
            // 
            this.tsContainer.ContentPanel.Controls.Add(this.splConTainer);
            this.tsContainer.ContentPanel.Size = new System.Drawing.Size(904, 582);
            this.tsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsContainer.Location = new System.Drawing.Point(0, 0);
            this.tsContainer.Name = "tsContainer";
            this.tsContainer.Size = new System.Drawing.Size(904, 607);
            this.tsContainer.TabIndex = 2;
            this.tsContainer.Text = "toolStripContainer1";
            // 
            // tsContainer.TopToolStripPanel
            // 
            this.tsContainer.TopToolStripPanel.Controls.Add(this.toolStripTop);
            // 
            // splConTainer
            // 
            this.splConTainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splConTainer.Location = new System.Drawing.Point(0, 0);
            this.splConTainer.Name = "splConTainer";
            this.splConTainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splConTainer.Panel1
            // 
            this.splConTainer.Panel1.Controls.Add(this.dgStockMove);
            // 
            // splConTainer.Panel2
            // 
            this.splConTainer.Panel2.Controls.Add(this.dgStockMoveDetail);
            this.splConTainer.Size = new System.Drawing.Size(904, 582);
            this.splConTainer.SplitterDistance = 310;
            this.splConTainer.TabIndex = 0;
            // 
            // dgStockMove
            // 
            this.dgStockMove.AllowUserToAddRows = false;
            this.dgStockMove.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgStockMove.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgStockMove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgStockMove.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgStockMove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgStockMove.Location = new System.Drawing.Point(0, 0);
            this.dgStockMove.MultiSelect = false;
            this.dgStockMove.Name = "dgStockMove";
            this.dgStockMove.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgStockMove.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgStockMove.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgStockMove.Size = new System.Drawing.Size(904, 310);
            this.dgStockMove.TabIndex = 0;
            this.dgStockMove.SelectionChanged += new System.EventHandler(this.dgStockMove_SelectionChanged);
            // 
            // dgStockMoveDetail
            // 
            this.dgStockMoveDetail.AllowUserToAddRows = false;
            this.dgStockMoveDetail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgStockMoveDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgStockMoveDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgStockMoveDetail.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgStockMoveDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgStockMoveDetail.Location = new System.Drawing.Point(0, 0);
            this.dgStockMoveDetail.MultiSelect = false;
            this.dgStockMoveDetail.Name = "dgStockMoveDetail";
            this.dgStockMoveDetail.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgStockMoveDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgStockMoveDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgStockMoveDetail.Size = new System.Drawing.Size(904, 268);
            this.dgStockMoveDetail.TabIndex = 0;
            // 
            // toolStripTop
            // 
            this.toolStripTop.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonExport,
            this.toolStripButtonDispatch,
            this.toolStripButtonTrack});
            this.toolStripTop.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.Size = new System.Drawing.Size(904, 25);
            this.toolStripTop.Stretch = true;
            this.toolStripTop.TabIndex = 0;
            // 
            // toolStripButtonExport
            // 
            this.toolStripButtonExport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExport.Image")));
            this.toolStripButtonExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExport.Name = "toolStripButtonExport";
            this.toolStripButtonExport.Size = new System.Drawing.Size(87, 22);
            this.toolStripButtonExport.Text = "Export Data";
            this.toolStripButtonExport.Click += new System.EventHandler(this.toolStripButtonExport_Click);
            // 
            // toolStripButtonDispatch
            // 
            this.toolStripButtonDispatch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDispatch.Image")));
            this.toolStripButtonDispatch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDispatch.Name = "toolStripButtonDispatch";
            this.toolStripButtonDispatch.Size = new System.Drawing.Size(73, 22);
            this.toolStripButtonDispatch.Text = "Dispatch";
            this.toolStripButtonDispatch.Click += new System.EventHandler(this.toolStripButtonDispatch_Click);
            // 
            // toolStripButtonTrack
            // 
            this.toolStripButtonTrack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTrack.Image")));
            this.toolStripButtonTrack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTrack.Name = "toolStripButtonTrack";
            this.toolStripButtonTrack.Size = new System.Drawing.Size(56, 22);
            this.toolStripButtonTrack.Text = "Track";
            // 
            // FrmStockMoveOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 607);
            this.Controls.Add(this.tsContainer);
            this.Name = "FrmStockMoveOrder";
            this.Text = "Return Stock";
            this.Load += new System.EventHandler(this.StockMoveOrder_Load);
            this.tsContainer.ContentPanel.ResumeLayout(false);
            this.tsContainer.TopToolStripPanel.ResumeLayout(false);
            this.tsContainer.TopToolStripPanel.PerformLayout();
            this.tsContainer.ResumeLayout(false);
            this.tsContainer.PerformLayout();
            this.splConTainer.Panel1.ResumeLayout(false);
            this.splConTainer.Panel2.ResumeLayout(false);
            this.splConTainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgStockMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStockMoveDetail)).EndInit();
            this.toolStripTop.ResumeLayout(false);
            this.toolStripTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tsContainer;
        private System.Windows.Forms.SplitContainer splConTainer;
        private System.Windows.Forms.DataGridView dgStockMove;
        private System.Windows.Forms.DataGridView dgStockMoveDetail;
        private System.Windows.Forms.ToolStrip toolStripTop;
        private System.Windows.Forms.ToolStripButton toolStripButtonExport;
        private System.Windows.Forms.ToolStripButton toolStripButtonDispatch;
        private System.Windows.Forms.ToolStripButton toolStripButtonTrack;
    }
}