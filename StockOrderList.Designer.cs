namespace LMSWarehouse
{
    partial class FrmStockOrderList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockOrderList));
            this.tsContainer = new System.Windows.Forms.ToolStripContainer();
            this.splConTainer = new System.Windows.Forms.SplitContainer();
            this.dgOrder = new System.Windows.Forms.DataGridView();
            this.dgOrderDetail = new System.Windows.Forms.DataGridView();
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.toolStripPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDispatch = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpenOrder = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTrack = new System.Windows.Forms.ToolStripButton();
            this.btnPRintItems = new System.Windows.Forms.ToolStripButton();
            this.tsContainer.ContentPanel.SuspendLayout();
            this.tsContainer.TopToolStripPanel.SuspendLayout();
            this.tsContainer.SuspendLayout();
            this.splConTainer.Panel1.SuspendLayout();
            this.splConTainer.Panel2.SuspendLayout();
            this.splConTainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderDetail)).BeginInit();
            this.toolStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsContainer
            // 
            // 
            // tsContainer.ContentPanel
            // 
            this.tsContainer.ContentPanel.Controls.Add(this.splConTainer);
            this.tsContainer.ContentPanel.Size = new System.Drawing.Size(710, 335);
            this.tsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsContainer.Location = new System.Drawing.Point(0, 0);
            this.tsContainer.Name = "tsContainer";
            this.tsContainer.Size = new System.Drawing.Size(710, 360);
            this.tsContainer.TabIndex = 1;
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
            this.splConTainer.Panel1.Controls.Add(this.dgOrder);
            // 
            // splConTainer.Panel2
            // 
            this.splConTainer.Panel2.Controls.Add(this.dgOrderDetail);
            this.splConTainer.Size = new System.Drawing.Size(710, 335);
            this.splConTainer.SplitterDistance = 179;
            this.splConTainer.TabIndex = 0;
            // 
            // dgOrder
            // 
            this.dgOrder.AllowUserToAddRows = false;
            this.dgOrder.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOrder.Location = new System.Drawing.Point(0, 0);
            this.dgOrder.MultiSelect = false;
            this.dgOrder.Name = "dgOrder";
            this.dgOrder.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrder.Size = new System.Drawing.Size(710, 179);
            this.dgOrder.TabIndex = 0;
            this.dgOrder.SelectionChanged += new System.EventHandler(this.dgOrder_SelectionChanged);
            // 
            // dgOrderDetail
            // 
            this.dgOrderDetail.AllowUserToAddRows = false;
            this.dgOrderDetail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgOrderDetail.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOrderDetail.Location = new System.Drawing.Point(0, 0);
            this.dgOrderDetail.MultiSelect = false;
            this.dgOrderDetail.Name = "dgOrderDetail";
            this.dgOrderDetail.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrderDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgOrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrderDetail.Size = new System.Drawing.Size(710, 152);
            this.dgOrderDetail.TabIndex = 0;
            // 
            // toolStripTop
            // 
            this.toolStripTop.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPrint,
            this.toolStripButtonExport,
            this.toolStripButtonDispatch,
            this.toolStripButtonOpenOrder,
            this.toolStripButtonTrack,
            this.btnPRintItems});
            this.toolStripTop.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.Size = new System.Drawing.Size(710, 25);
            this.toolStripTop.Stretch = true;
            this.toolStripTop.TabIndex = 0;
            // 
            // toolStripPrint
            // 
            this.toolStripPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPrint.Image")));
            this.toolStripPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPrint.Name = "toolStripPrint";
            this.toolStripPrint.Size = new System.Drawing.Size(52, 22);
            this.toolStripPrint.Text = "Print";
            this.toolStripPrint.Click += new System.EventHandler(this.toolStripPrint_Click);
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
            // toolStripButtonOpenOrder
            // 
            this.toolStripButtonOpenOrder.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpenOrder.Image")));
            this.toolStripButtonOpenOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenOrder.Name = "toolStripButtonOpenOrder";
            this.toolStripButtonOpenOrder.Size = new System.Drawing.Size(105, 22);
            this.toolStripButtonOpenOrder.Text = "Re-open Order";
            this.toolStripButtonOpenOrder.Click += new System.EventHandler(this.toolStripButtonOpenOrder_Click);
            // 
            // toolStripButtonTrack
            // 
            this.toolStripButtonTrack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTrack.Image")));
            this.toolStripButtonTrack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTrack.Name = "toolStripButtonTrack";
            this.toolStripButtonTrack.Size = new System.Drawing.Size(56, 22);
            this.toolStripButtonTrack.Text = "Track";
            this.toolStripButtonTrack.Click += new System.EventHandler(this.toolStripButtonTrack_Click);
            // 
            // btnPRintItems
            // 
            this.btnPRintItems.Image = ((System.Drawing.Image)(resources.GetObject("btnPRintItems.Image")));
            this.btnPRintItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPRintItems.Name = "btnPRintItems";
            this.btnPRintItems.Size = new System.Drawing.Size(117, 22);
            this.btnPRintItems.Text = "Print Order Items";
            this.btnPRintItems.Click += new System.EventHandler(this.btnPRintItems_Click);
            // 
            // FrmStockOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 360);
            this.Controls.Add(this.tsContainer);
            this.Name = "FrmStockOrderList";
            this.Text = "StockOrderList";
            this.Load += new System.EventHandler(this.FrmStockOrderList_Load);
            this.tsContainer.ContentPanel.ResumeLayout(false);
            this.tsContainer.TopToolStripPanel.ResumeLayout(false);
            this.tsContainer.TopToolStripPanel.PerformLayout();
            this.tsContainer.ResumeLayout(false);
            this.tsContainer.PerformLayout();
            this.splConTainer.Panel1.ResumeLayout(false);
            this.splConTainer.Panel2.ResumeLayout(false);
            this.splConTainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderDetail)).EndInit();
            this.toolStripTop.ResumeLayout(false);
            this.toolStripTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tsContainer;
        private System.Windows.Forms.SplitContainer splConTainer;
        private System.Windows.Forms.DataGridView dgOrder;
        private System.Windows.Forms.DataGridView dgOrderDetail;
        private System.Windows.Forms.ToolStrip toolStripTop;
        private System.Windows.Forms.ToolStripButton toolStripPrint;
        private System.Windows.Forms.ToolStripButton toolStripButtonExport;
        private System.Windows.Forms.ToolStripButton toolStripButtonDispatch;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenOrder;
        private System.Windows.Forms.ToolStripButton toolStripButtonTrack;
        private System.Windows.Forms.ToolStripButton btnPRintItems;
    }
}