namespace LMSWarehouse
{
    partial class FrmItemScan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItemScan));
            this.dgReceive = new System.Windows.Forms.DataGridView();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnPrintSingle = new System.Windows.Forms.ToolStripButton();
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.toolStripBottom = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.pDetail = new System.Windows.Forms.Panel();
            this.lbItem = new System.Windows.Forms.ListBox();
            this.lblScans = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtScan = new System.Windows.Forms.TextBox();
            this.lblScanned = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQtyExpected = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBin = new System.Windows.Forms.Label();
            this.txtBin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgReceive)).BeginInit();
            this.toolStripTop.SuspendLayout();
            this.toolStripBottom.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.pDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgReceive
            // 
            this.dgReceive.AllowUserToAddRows = false;
            this.dgReceive.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReceive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgReceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgReceive.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgReceive.Location = new System.Drawing.Point(0, 0);
            this.dgReceive.Name = "dgReceive";
            this.dgReceive.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReceive.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgReceive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgReceive.Size = new System.Drawing.Size(828, 202);
            this.dgReceive.TabIndex = 1;
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripButton.Text = "&Complete Order";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(69, 22);
            this.printToolStripButton.Text = "&Print All";
            // 
            // toolStripBtnPrintSingle
            // 
            this.toolStripBtnPrintSingle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnPrintSingle.Image")));
            this.toolStripBtnPrintSingle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnPrintSingle.Name = "toolStripBtnPrintSingle";
            this.toolStripBtnPrintSingle.Size = new System.Drawing.Size(118, 22);
            this.toolStripBtnPrintSingle.Text = "Print Single Lable";
            // 
            // toolStripTop
            // 
            this.toolStripTop.AutoSize = false;
            this.toolStripTop.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripButton,
            this.toolStripBtnPrintSingle,
            this.saveToolStripButton});
            this.toolStripTop.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.Size = new System.Drawing.Size(828, 25);
            this.toolStripTop.Stretch = true;
            this.toolStripTop.TabIndex = 0;
            // 
            // toolStripBottom
            // 
            this.toolStripBottom.AutoSize = false;
            this.toolStripBottom.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnSaveItem});
            this.toolStripBottom.Location = new System.Drawing.Point(0, 0);
            this.toolStripBottom.Name = "toolStripBottom";
            this.toolStripBottom.Size = new System.Drawing.Size(828, 25);
            this.toolStripBottom.Stretch = true;
            this.toolStripBottom.TabIndex = 0;
            this.toolStripBottom.Visible = false;
            // 
            // toolStripBtnSaveItem
            // 
            this.toolStripBtnSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtnSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSaveItem.Image")));
            this.toolStripBtnSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSaveItem.Name = "toolStripBtnSaveItem";
            this.toolStripBtnSaveItem.Size = new System.Drawing.Size(78, 22);
            this.toolStripBtnSaveItem.Text = "Save Item";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.toolStripBottom);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgReceive);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pDetail);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(828, 690);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(828, 715);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripTop);
            // 
            // pDetail
            // 
            this.pDetail.Controls.Add(this.lbItem);
            this.pDetail.Controls.Add(this.lblScans);
            this.pDetail.Controls.Add(this.lblStatus);
            this.pDetail.Controls.Add(this.txtScan);
            this.pDetail.Controls.Add(this.lblScanned);
            this.pDetail.Controls.Add(this.label4);
            this.pDetail.Controls.Add(this.lblQtyExpected);
            this.pDetail.Controls.Add(this.label2);
            this.pDetail.Controls.Add(this.lblBin);
            this.pDetail.Controls.Add(this.txtBin);
            this.pDetail.Controls.Add(this.label1);
            this.pDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pDetail.Location = new System.Drawing.Point(0, 202);
            this.pDetail.Name = "pDetail";
            this.pDetail.Size = new System.Drawing.Size(828, 488);
            this.pDetail.TabIndex = 0;
            this.pDetail.Paint += new System.Windows.Forms.PaintEventHandler(this.pDetail_Paint);
            // 
            // lbItem
            // 
            this.lbItem.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbItem.FormattingEnabled = true;
            this.lbItem.Location = new System.Drawing.Point(442, 0);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(199, 485);
            this.lbItem.TabIndex = 0;
            // 
            // lblScans
            // 
            this.lblScans.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblScans.FormattingEnabled = true;
            this.lblScans.Location = new System.Drawing.Point(641, 0);
            this.lblScans.Name = "lblScans";
            this.lblScans.Size = new System.Drawing.Size(187, 485);
            this.lblScans.TabIndex = 10;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(21, 368);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(79, 25);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status";
            // 
            // txtScan
            // 
            this.txtScan.Location = new System.Drawing.Point(109, 257);
            this.txtScan.Name = "txtScan";
            this.txtScan.Size = new System.Drawing.Size(194, 20);
            this.txtScan.TabIndex = 8;
            this.txtScan.TextChanged += new System.EventHandler(this.txtScan_TextChanged);
            this.txtScan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtScan_KeyUp);
            // 
            // lblScanned
            // 
            this.lblScanned.AutoSize = true;
            this.lblScanned.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanned.Location = new System.Drawing.Point(106, 177);
            this.lblScanned.Name = "lblScanned";
            this.lblScanned.Size = new System.Drawing.Size(16, 16);
            this.lblScanned.TabIndex = 7;
            this.lblScanned.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Qty Scanned";
            // 
            // lblQtyExpected
            // 
            this.lblQtyExpected.AutoSize = true;
            this.lblQtyExpected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtyExpected.Location = new System.Drawing.Point(106, 143);
            this.lblQtyExpected.Name = "lblQtyExpected";
            this.lblQtyExpected.Size = new System.Drawing.Size(16, 16);
            this.lblQtyExpected.TabIndex = 5;
            this.lblQtyExpected.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Qty Expected";
            // 
            // lblBin
            // 
            this.lblBin.AutoSize = true;
            this.lblBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBin.Location = new System.Drawing.Point(106, 66);
            this.lblBin.Name = "lblBin";
            this.lblBin.Size = new System.Drawing.Size(74, 13);
            this.lblBin.TabIndex = 3;
            this.lblBin.Text = "BinLocation";
            // 
            // txtBin
            // 
            this.txtBin.Location = new System.Drawing.Point(109, 34);
            this.txtBin.Name = "txtBin";
            this.txtBin.Size = new System.Drawing.Size(208, 20);
            this.txtBin.TabIndex = 2;
            this.txtBin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBin_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Location";
            // 
            // FrmItemScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 715);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "FrmItemScan";
            this.Text = "ItemScan";
            this.Load += new System.EventHandler(this.FrmItemScan_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmItemScan_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgReceive)).EndInit();
            this.toolStripTop.ResumeLayout(false);
            this.toolStripTop.PerformLayout();
            this.toolStripBottom.ResumeLayout(false);
            this.toolStripBottom.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.pDetail.ResumeLayout(false);
            this.pDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgReceive;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripBtnPrintSingle;
        private System.Windows.Forms.ToolStrip toolStripTop;
        private System.Windows.Forms.ToolStrip toolStripBottom;
        private System.Windows.Forms.ToolStripButton toolStripBtnSaveItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Panel pDetail;
        private System.Windows.Forms.ListBox lbItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQtyExpected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBin;
        private System.Windows.Forms.TextBox txtBin;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtScan;
        private System.Windows.Forms.Label lblScanned;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lblScans;

    }
}