namespace LMSWarehouse
{
    partial class FrmBatchReceive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBatchReceive));
            this.tsContainer = new System.Windows.Forms.ToolStripContainer();
            this.splConTainer = new System.Windows.Forms.SplitContainer();
            this.dgBatches = new System.Windows.Forms.DataGridView();
            this.pDetail = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dtExpiry = new System.Windows.Forms.DateTimePicker();
            this.dtManufacture = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.cbDimms = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblScanned = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtParts = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.tdBtnNewOrder = new System.Windows.Forms.ToolStripButton();
            this.tsEditOrder = new System.Windows.Forms.ToolStripButton();
            this.tsContainer.ContentPanel.SuspendLayout();
            this.tsContainer.TopToolStripPanel.SuspendLayout();
            this.tsContainer.SuspendLayout();
            this.splConTainer.Panel1.SuspendLayout();
            this.splConTainer.Panel2.SuspendLayout();
            this.splConTainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBatches)).BeginInit();
            this.pDetail.SuspendLayout();
            this.toolStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsContainer
            // 
            // 
            // tsContainer.ContentPanel
            // 
            this.tsContainer.ContentPanel.Controls.Add(this.splConTainer);
            this.tsContainer.ContentPanel.Size = new System.Drawing.Size(888, 435);
            this.tsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsContainer.Location = new System.Drawing.Point(0, 0);
            this.tsContainer.Name = "tsContainer";
            this.tsContainer.Size = new System.Drawing.Size(888, 460);
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
            this.splConTainer.Panel1.Controls.Add(this.dgBatches);
            // 
            // splConTainer.Panel2
            // 
            this.splConTainer.Panel2.Controls.Add(this.pDetail);
            this.splConTainer.Size = new System.Drawing.Size(888, 435);
            this.splConTainer.SplitterDistance = 213;
            this.splConTainer.TabIndex = 0;
            // 
            // dgBatches
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBatches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgBatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgBatches.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgBatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBatches.Location = new System.Drawing.Point(0, 0);
            this.dgBatches.Name = "dgBatches";
            this.dgBatches.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBatches.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgBatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBatches.Size = new System.Drawing.Size(888, 213);
            this.dgBatches.TabIndex = 0;
            this.dgBatches.SelectionChanged += new System.EventHandler(this.dgBatches_SelectionChanged);
            // 
            // pDetail
            // 
            this.pDetail.Controls.Add(this.label15);
            this.pDetail.Controls.Add(this.label16);
            this.pDetail.Controls.Add(this.dtExpiry);
            this.pDetail.Controls.Add(this.dtManufacture);
            this.pDetail.Controls.Add(this.label14);
            this.pDetail.Controls.Add(this.cbDimms);
            this.pDetail.Controls.Add(this.label10);
            this.pDetail.Controls.Add(this.label11);
            this.pDetail.Controls.Add(this.label12);
            this.pDetail.Controls.Add(this.label13);
            this.pDetail.Controls.Add(this.label9);
            this.pDetail.Controls.Add(this.label8);
            this.pDetail.Controls.Add(this.lblScanned);
            this.pDetail.Controls.Add(this.lblQty);
            this.pDetail.Controls.Add(this.txtBarcode);
            this.pDetail.Controls.Add(this.label7);
            this.pDetail.Controls.Add(this.txtQty);
            this.pDetail.Controls.Add(this.label6);
            this.pDetail.Controls.Add(this.txtParts);
            this.pDetail.Controls.Add(this.label5);
            this.pDetail.Controls.Add(this.txtWeight);
            this.pDetail.Controls.Add(this.label3);
            this.pDetail.Controls.Add(this.txtLength);
            this.pDetail.Controls.Add(this.label4);
            this.pDetail.Controls.Add(this.txtWidth);
            this.pDetail.Controls.Add(this.label2);
            this.pDetail.Controls.Add(this.txtHeight);
            this.pDetail.Controls.Add(this.label1);
            this.pDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDetail.Location = new System.Drawing.Point(0, 0);
            this.pDetail.Name = "pDetail";
            this.pDetail.Size = new System.Drawing.Size(888, 218);
            this.pDetail.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(436, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Manufacturing Date : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(482, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "ExpiryDate : ";
            // 
            // dtExpiry
            // 
            this.dtExpiry.Location = new System.Drawing.Point(552, 45);
            this.dtExpiry.Name = "dtExpiry";
            this.dtExpiry.Size = new System.Drawing.Size(137, 20);
            this.dtExpiry.TabIndex = 25;
            // 
            // dtManufacture
            // 
            this.dtManufacture.Location = new System.Drawing.Point(552, 24);
            this.dtManufacture.Name = "dtManufacture";
            this.dtManufacture.Size = new System.Drawing.Size(137, 20);
            this.dtManufacture.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Dimms : ";
            // 
            // cbDimms
            // 
            this.cbDimms.FormattingEnabled = true;
            this.cbDimms.Location = new System.Drawing.Point(67, 26);
            this.cbDimms.Name = "cbDimms";
            this.cbDimms.Size = new System.Drawing.Size(121, 21);
            this.cbDimms.TabIndex = 22;
            this.cbDimms.DropDownClosed += new System.EventHandler(this.cbDimms_DropDownClosed);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(432, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "kg";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(173, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "cm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(173, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "cm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(173, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "cm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Scanned QTY : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Order QTY :";
            // 
            // lblScanned
            // 
            this.lblScanned.AutoSize = true;
            this.lblScanned.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanned.Location = new System.Drawing.Point(85, 308);
            this.lblScanned.Name = "lblScanned";
            this.lblScanned.Size = new System.Drawing.Size(100, 25);
            this.lblScanned.TabIndex = 15;
            this.lblScanned.Text = "LBLQTY";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(85, 270);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(100, 25);
            this.lblQty.TabIndex = 14;
            this.lblQty.Text = "LBLQTY";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(326, 23);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(100, 20);
            this.txtBarcode.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Barcode :";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(326, 47);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 11;
            this.txtQty.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "QTY :";
            // 
            // txtParts
            // 
            this.txtParts.Location = new System.Drawing.Point(326, 94);
            this.txtParts.Name = "txtParts";
            this.txtParts.Size = new System.Drawing.Size(100, 20);
            this.txtParts.TabIndex = 9;
            this.txtParts.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Parts :";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(326, 70);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Weigth :";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(67, 98);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Length :";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(67, 74);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width :";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(67, 50);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height :";
            // 
            // toolStripTop
            // 
            this.toolStripTop.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tdBtnNewOrder,
            this.tsEditOrder});
            this.toolStripTop.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.Size = new System.Drawing.Size(888, 25);
            this.toolStripTop.Stretch = true;
            this.toolStripTop.TabIndex = 0;
            // 
            // tdBtnNewOrder
            // 
            this.tdBtnNewOrder.Image = ((System.Drawing.Image)(resources.GetObject("tdBtnNewOrder.Image")));
            this.tdBtnNewOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tdBtnNewOrder.Name = "tdBtnNewOrder";
            this.tdBtnNewOrder.Size = new System.Drawing.Size(84, 22);
            this.tdBtnNewOrder.Text = "New Batch";
            this.tdBtnNewOrder.Click += new System.EventHandler(this.tdBtnNewOrder_Click);
            // 
            // tsEditOrder
            // 
            this.tsEditOrder.Image = ((System.Drawing.Image)(resources.GetObject("tsEditOrder.Image")));
            this.tsEditOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEditOrder.Name = "tsEditOrder";
            this.tsEditOrder.Size = new System.Drawing.Size(132, 22);
            this.tsEditOrder.Text = "Save and Link Batch";
            this.tsEditOrder.Click += new System.EventHandler(this.tsEditOrder_Click);
            // 
            // FrmBatchReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 460);
            this.Controls.Add(this.tsContainer);
            this.Name = "FrmBatchReceive";
            this.Text = "BatchReceive";
            this.tsContainer.ContentPanel.ResumeLayout(false);
            this.tsContainer.TopToolStripPanel.ResumeLayout(false);
            this.tsContainer.TopToolStripPanel.PerformLayout();
            this.tsContainer.ResumeLayout(false);
            this.tsContainer.PerformLayout();
            this.splConTainer.Panel1.ResumeLayout(false);
            this.splConTainer.Panel2.ResumeLayout(false);
            this.splConTainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBatches)).EndInit();
            this.pDetail.ResumeLayout(false);
            this.pDetail.PerformLayout();
            this.toolStripTop.ResumeLayout(false);
            this.toolStripTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tsContainer;
        private System.Windows.Forms.SplitContainer splConTainer;
        private System.Windows.Forms.Panel pDetail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblScanned;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtParts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStripTop;
        private System.Windows.Forms.ToolStripButton tdBtnNewOrder;
        private System.Windows.Forms.ToolStripButton tsEditOrder;
        private System.Windows.Forms.DataGridView dgBatches;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbDimms;
        private System.Windows.Forms.DateTimePicker dtManufacture;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtExpiry;
    }
}