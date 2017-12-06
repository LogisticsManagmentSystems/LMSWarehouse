namespace LMSWarehouse
{
    partial class FrmBackOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackOrder));
            this.tsContainer = new System.Windows.Forms.ToolStripContainer();
            this.splConTainer = new System.Windows.Forms.SplitContainer();
            this.dgOrder = new System.Windows.Forms.DataGridView();
            this.dgOrderDetail = new System.Windows.Forms.DataGridView();
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.tdBtnNewOrder = new System.Windows.Forms.ToolStripButton();
            this.tsEditOrder = new System.Windows.Forms.ToolStripButton();
            this.tsBtnReceiveOrder = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRecFloor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripAllocate = new System.Windows.Forms.ToolStripButton();
            this.toolStriptxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.btnImportOrder = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCloseOrder = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDetail = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonInterface = new System.Windows.Forms.ToolStripButton();
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
            this.tsContainer.ContentPanel.Size = new System.Drawing.Size(1161, 567);
            this.tsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsContainer.Location = new System.Drawing.Point(0, 0);
            this.tsContainer.Name = "tsContainer";
            this.tsContainer.Size = new System.Drawing.Size(1161, 592);
            this.tsContainer.TabIndex = 0;
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
            this.splConTainer.Size = new System.Drawing.Size(1161, 567);
            this.splConTainer.SplitterDistance = 303;
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
            this.dgOrder.Size = new System.Drawing.Size(1161, 303);
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
            this.dgOrderDetail.Size = new System.Drawing.Size(1161, 260);
            this.dgOrderDetail.TabIndex = 0;
            this.dgOrderDetail.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgOrderDetail_RowPrePaint);
            this.dgOrderDetail.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgOrderDetail_CellFormatting);
            // 
            // toolStripTop
            // 
            this.toolStripTop.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tdBtnNewOrder,
            this.tsEditOrder,
            this.tsBtnReceiveOrder,
            this.toolStripButtonRecFloor,
            this.toolStripButtonDelete,
            this.toolStripAllocate,
            this.toolStriptxtSearch,
            this.toolStripButtonSearch,
            this.btnImportOrder,
            this.toolStripButtonCloseOrder,
            this.toolStripButtonDetail,
            this.toolStripButtonInterface});
            this.toolStripTop.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.Size = new System.Drawing.Size(1161, 25);
            this.toolStripTop.Stretch = true;
            this.toolStripTop.TabIndex = 0;
            // 
            // tdBtnNewOrder
            // 
            this.tdBtnNewOrder.Image = ((System.Drawing.Image)(resources.GetObject("tdBtnNewOrder.Image")));
            this.tdBtnNewOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tdBtnNewOrder.Name = "tdBtnNewOrder";
            this.tdBtnNewOrder.Size = new System.Drawing.Size(84, 22);
            this.tdBtnNewOrder.Text = "New Order";
            this.tdBtnNewOrder.Click += new System.EventHandler(this.tdBtnNewOrder_Click);
            // 
            // tsEditOrder
            // 
            this.tsEditOrder.Image = ((System.Drawing.Image)(resources.GetObject("tsEditOrder.Image")));
            this.tsEditOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEditOrder.Name = "tsEditOrder";
            this.tsEditOrder.Size = new System.Drawing.Size(80, 22);
            this.tsEditOrder.Text = "Edit Order";
            this.tsEditOrder.Click += new System.EventHandler(this.tsEditOrder_Click);
            // 
            // tsBtnReceiveOrder
            // 
            this.tsBtnReceiveOrder.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnReceiveOrder.Image")));
            this.tsBtnReceiveOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnReceiveOrder.Name = "tsBtnReceiveOrder";
            this.tsBtnReceiveOrder.Size = new System.Drawing.Size(100, 22);
            this.tsBtnReceiveOrder.Text = "Receive Order";
            this.tsBtnReceiveOrder.Click += new System.EventHandler(this.tsBtnReceiveOrder_Click);
            // 
            // toolStripButtonRecFloor
            // 
            this.toolStripButtonRecFloor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRecFloor.Image")));
            this.toolStripButtonRecFloor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRecFloor.Name = "toolStripButtonRecFloor";
            this.toolStripButtonRecFloor.Size = new System.Drawing.Size(111, 22);
            this.toolStripButtonRecFloor.Text = "Recieve to Floor";
            this.toolStripButtonRecFloor.Click += new System.EventHandler(this.toolStripButtonRecFloor_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.Enabled = false;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(93, 22);
            this.toolStripButtonDelete.Text = "Delete Order";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripAllocate
            // 
            this.toolStripAllocate.Enabled = false;
            this.toolStripAllocate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAllocate.Image")));
            this.toolStripAllocate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAllocate.Name = "toolStripAllocate";
            this.toolStripAllocate.Size = new System.Drawing.Size(121, 22);
            this.toolStripAllocate.Text = "Allocate and Print";
            this.toolStripAllocate.Click += new System.EventHandler(this.toolStripAllocate_Click);
            // 
            // toolStriptxtSearch
            // 
            this.toolStriptxtSearch.Name = "toolStriptxtSearch";
            this.toolStriptxtSearch.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButtonSearch
            // 
            this.toolStripButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearch.Image")));
            this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearch.Name = "toolStripButtonSearch";
            this.toolStripButtonSearch.Size = new System.Drawing.Size(50, 22);
            this.toolStripButtonSearch.Text = "Find";
            this.toolStripButtonSearch.Click += new System.EventHandler(this.toolStripButtonSearch_Click);
            // 
            // btnImportOrder
            // 
            this.btnImportOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnImportOrder.Image")));
            this.btnImportOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportOrder.Name = "btnImportOrder";
            this.btnImportOrder.Size = new System.Drawing.Size(96, 22);
            this.btnImportOrder.Text = "Import Order";
            this.btnImportOrder.Click += new System.EventHandler(this.btnImportOrder_Click);
            // 
            // toolStripButtonCloseOrder
            // 
            this.toolStripButtonCloseOrder.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCloseOrder.Image")));
            this.toolStripButtonCloseOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCloseOrder.Name = "toolStripButtonCloseOrder";
            this.toolStripButtonCloseOrder.Size = new System.Drawing.Size(89, 22);
            this.toolStripButtonCloseOrder.Text = "Close Order";
            this.toolStripButtonCloseOrder.Click += new System.EventHandler(this.toolStripButtonCloseOrder_Click);
            // 
            // toolStripButtonDetail
            // 
            this.toolStripButtonDetail.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDetail.Image")));
            this.toolStripButtonDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDetail.Name = "toolStripButtonDetail";
            this.toolStripButtonDetail.Size = new System.Drawing.Size(56, 22);
            this.toolStripButtonDetail.Text = "Track";
            this.toolStripButtonDetail.Click += new System.EventHandler(this.toolStripButtonDetail_Click);
            // 
            // toolStripButtonInterface
            // 
            this.toolStripButtonInterface.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInterface.Image")));
            this.toolStripButtonInterface.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInterface.Name = "toolStripButtonInterface";
            this.toolStripButtonInterface.Size = new System.Drawing.Size(118, 22);
            this.toolStripButtonInterface.Text = "Interfaced Orders";
            this.toolStripButtonInterface.Click += new System.EventHandler(this.toolStripButtonInterface_Click);
            // 
            // FrmBackOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 592);
            this.Controls.Add(this.tsContainer);
            this.Name = "FrmBackOrder";
            this.Text = "BackOrder";
            this.Load += new System.EventHandler(this.FBackOrder_Load);
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
        private System.Windows.Forms.ToolStripButton tdBtnNewOrder;
        private System.Windows.Forms.ToolStripButton tsEditOrder;
        private System.Windows.Forms.ToolStripButton tsBtnReceiveOrder;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripAllocate;
        private System.Windows.Forms.ToolStripTextBox toolStriptxtSearch;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        private System.Windows.Forms.ToolStripButton btnImportOrder;
        private System.Windows.Forms.ToolStripButton toolStripButtonRecFloor;
        private System.Windows.Forms.ToolStripButton toolStripButtonCloseOrder;
        private System.Windows.Forms.ToolStripButton toolStripButtonDetail;
        private System.Windows.Forms.ToolStripButton toolStripButtonInterface;

    }
}