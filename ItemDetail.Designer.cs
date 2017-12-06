namespace LMSWarehouse
{
    partial class FrmItemDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItemDetail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStriptxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.tsContainer = new System.Windows.Forms.ToolStripContainer();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.pDetail = new System.Windows.Forms.Panel();
            this.dgItemTrack = new System.Windows.Forms.DataGridView();
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.cbFilter = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtBarcode = new System.Windows.Forms.Label();
            this.txtSKU = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPONumber = new System.Windows.Forms.Label();
            this.txtPODate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSODate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSONumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddressName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.Label();
            this.txtAddress3 = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.Label();
            this.txtAddress4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tsContainer.ContentPanel.SuspendLayout();
            this.tsContainer.TopToolStripPanel.SuspendLayout();
            this.tsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.pDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemTrack)).BeginInit();
            this.toolStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStriptxtSearch
            // 
            this.toolStriptxtSearch.Name = "toolStriptxtSearch";
            this.toolStriptxtSearch.Size = new System.Drawing.Size(200, 25);
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
            // tsContainer
            // 
            // 
            // tsContainer.ContentPanel
            // 
            this.tsContainer.ContentPanel.Controls.Add(this.dgItems);
            this.tsContainer.ContentPanel.Controls.Add(this.pDetail);
            this.tsContainer.ContentPanel.Controls.Add(this.dgItemTrack);
            this.tsContainer.ContentPanel.Size = new System.Drawing.Size(809, 591);
            this.tsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsContainer.Location = new System.Drawing.Point(0, 0);
            this.tsContainer.Name = "tsContainer";
            this.tsContainer.Size = new System.Drawing.Size(809, 616);
            this.tsContainer.TabIndex = 1;
            this.tsContainer.Text = "toolStripContainer1";
            // 
            // tsContainer.TopToolStripPanel
            // 
            this.tsContainer.TopToolStripPanel.Controls.Add(this.toolStripTop);
            // 
            // dgItems
            // 
            this.dgItems.AllowUserToAddRows = false;
            this.dgItems.AllowUserToDeleteRows = false;
            this.dgItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgItems.Location = new System.Drawing.Point(0, 0);
            this.dgItems.Name = "dgItems";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItems.Size = new System.Drawing.Size(809, 269);
            this.dgItems.TabIndex = 0;
            this.dgItems.SelectionChanged += new System.EventHandler(this.dgItems_SelectionChanged);
            // 
            // pDetail
            // 
            this.pDetail.Controls.Add(this.txtWeight);
            this.pDetail.Controls.Add(this.label8);
            this.pDetail.Controls.Add(this.txtqty);
            this.pDetail.Controls.Add(this.label2);
            this.pDetail.Controls.Add(this.txtPostalCode);
            this.pDetail.Controls.Add(this.txtAddress4);
            this.pDetail.Controls.Add(this.txtAddress3);
            this.pDetail.Controls.Add(this.txtAddress2);
            this.pDetail.Controls.Add(this.txtAddress1);
            this.pDetail.Controls.Add(this.txtAddressName);
            this.pDetail.Controls.Add(this.label5);
            this.pDetail.Controls.Add(this.txtSODate);
            this.pDetail.Controls.Add(this.label4);
            this.pDetail.Controls.Add(this.txtSONumber);
            this.pDetail.Controls.Add(this.label6);
            this.pDetail.Controls.Add(this.txtPODate);
            this.pDetail.Controls.Add(this.label3);
            this.pDetail.Controls.Add(this.txtPONumber);
            this.pDetail.Controls.Add(this.label1);
            this.pDetail.Controls.Add(this.txtDescription);
            this.pDetail.Controls.Add(this.txtStatus);
            this.pDetail.Controls.Add(this.txtSKU);
            this.pDetail.Controls.Add(this.txtBarcode);
            this.pDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pDetail.Location = new System.Drawing.Point(0, 269);
            this.pDetail.Name = "pDetail";
            this.pDetail.Size = new System.Drawing.Size(809, 158);
            this.pDetail.TabIndex = 1;
            // 
            // dgItemTrack
            // 
            this.dgItemTrack.AllowUserToAddRows = false;
            this.dgItemTrack.AllowUserToDeleteRows = false;
            this.dgItemTrack.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItemTrack.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgItemTrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgItemTrack.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgItemTrack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgItemTrack.Location = new System.Drawing.Point(0, 427);
            this.dgItemTrack.Name = "dgItemTrack";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItemTrack.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgItemTrack.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItemTrack.Size = new System.Drawing.Size(809, 164);
            this.dgItemTrack.TabIndex = 2;
            // 
            // toolStripTop
            // 
            this.toolStripTop.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.cbFilter,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStriptxtSearch,
            this.toolStripButtonSearch});
            this.toolStripTop.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.Size = new System.Drawing.Size(809, 25);
            this.toolStripTop.Stretch = true;
            this.toolStripTop.TabIndex = 0;
            // 
            // cbFilter
            // 
            this.cbFilter.Items.AddRange(new object[] {
            "Item",
            "Bin",
            "Order"});
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(74, 22);
            this.toolStripLabel1.Text = "Filter Criteria";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(67, 22);
            this.toolStripLabel2.Text = "Select Filter";
            // 
            // txtBarcode
            // 
            this.txtBarcode.AutoSize = true;
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(23, 7);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(68, 13);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.Text = "txtBarcode";
            // 
            // txtSKU
            // 
            this.txtSKU.AutoSize = true;
            this.txtSKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSKU.Location = new System.Drawing.Point(23, 43);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(46, 13);
            this.txtSKU.TabIndex = 1;
            this.txtSKU.Text = "txtSKU";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(23, 24);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(57, 13);
            this.txtStatus.TabIndex = 2;
            this.txtStatus.Text = "txtStatus";
            // 
            // txtDescription
            // 
            this.txtDescription.AutoSize = true;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(23, 60);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(85, 13);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Text = "txtDescription";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PO Number : ";
            // 
            // txtPONumber
            // 
            this.txtPONumber.AutoSize = true;
            this.txtPONumber.Location = new System.Drawing.Point(268, 7);
            this.txtPONumber.Name = "txtPONumber";
            this.txtPONumber.Size = new System.Drawing.Size(70, 13);
            this.txtPONumber.TabIndex = 5;
            this.txtPONumber.Text = "txtPONumber";
            // 
            // txtPODate
            // 
            this.txtPODate.AutoSize = true;
            this.txtPODate.Location = new System.Drawing.Point(268, 25);
            this.txtPODate.Name = "txtPODate";
            this.txtPODate.Size = new System.Drawing.Size(56, 13);
            this.txtPODate.TabIndex = 7;
            this.txtPODate.Text = "txtPODate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "PO Date : ";
            // 
            // txtSODate
            // 
            this.txtSODate.AutoSize = true;
            this.txtSODate.Location = new System.Drawing.Point(490, 21);
            this.txtSODate.Name = "txtSODate";
            this.txtSODate.Size = new System.Drawing.Size(56, 13);
            this.txtSODate.TabIndex = 11;
            this.txtSODate.Text = "txtSODate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "PO Date : ";
            // 
            // txtSONumber
            // 
            this.txtSONumber.AutoSize = true;
            this.txtSONumber.Location = new System.Drawing.Point(490, 3);
            this.txtSONumber.Name = "txtSONumber";
            this.txtSONumber.Size = new System.Drawing.Size(70, 13);
            this.txtSONumber.TabIndex = 9;
            this.txtSONumber.Text = "txtSONumber";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "PO Number : ";
            // 
            // txtAddressName
            // 
            this.txtAddressName.AutoSize = true;
            this.txtAddressName.Location = new System.Drawing.Point(490, 39);
            this.txtAddressName.Name = "txtAddressName";
            this.txtAddressName.Size = new System.Drawing.Size(84, 13);
            this.txtAddressName.TabIndex = 13;
            this.txtAddressName.Text = "txtAddressName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Address";
            // 
            // txtAddress1
            // 
            this.txtAddress1.AutoSize = true;
            this.txtAddress1.Location = new System.Drawing.Point(490, 52);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(62, 13);
            this.txtAddress1.TabIndex = 14;
            this.txtAddress1.Text = "txtAddress1";
            // 
            // txtAddress3
            // 
            this.txtAddress3.AutoSize = true;
            this.txtAddress3.Location = new System.Drawing.Point(490, 78);
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.Size = new System.Drawing.Size(62, 13);
            this.txtAddress3.TabIndex = 16;
            this.txtAddress3.Text = "txtAddress3";
            // 
            // txtAddress2
            // 
            this.txtAddress2.AutoSize = true;
            this.txtAddress2.Location = new System.Drawing.Point(490, 65);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(62, 13);
            this.txtAddress2.TabIndex = 15;
            this.txtAddress2.Text = "txtAddress2";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.AutoSize = true;
            this.txtPostalCode.Location = new System.Drawing.Point(490, 104);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(72, 13);
            this.txtPostalCode.TabIndex = 18;
            this.txtPostalCode.Text = "txtPostalCode";
            // 
            // txtAddress4
            // 
            this.txtAddress4.AutoSize = true;
            this.txtAddress4.Location = new System.Drawing.Point(490, 91);
            this.txtAddress4.Name = "txtAddress4";
            this.txtAddress4.Size = new System.Drawing.Size(62, 13);
            this.txtAddress4.TabIndex = 17;
            this.txtAddress4.Text = "txtAddress4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Parcel Qty : ";
            // 
            // txtqty
            // 
            this.txtqty.AutoSize = true;
            this.txtqty.Location = new System.Drawing.Point(89, 77);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(32, 13);
            this.txtqty.TabIndex = 20;
            this.txtqty.Text = "txtqty";
            // 
            // txtWeight
            // 
            this.txtWeight.AutoSize = true;
            this.txtWeight.Location = new System.Drawing.Point(89, 96);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(52, 13);
            this.txtWeight.TabIndex = 22;
            this.txtWeight.Text = "txtWeight";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Weight : ";
            // 
            // FrmItemDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 616);
            this.Controls.Add(this.tsContainer);
            this.Name = "FrmItemDetail";
            this.Text = "ItemDetail";
            this.Load += new System.EventHandler(this.ItemDetail_Load);
            this.tsContainer.ContentPanel.ResumeLayout(false);
            this.tsContainer.TopToolStripPanel.ResumeLayout(false);
            this.tsContainer.TopToolStripPanel.PerformLayout();
            this.tsContainer.ResumeLayout(false);
            this.tsContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.pDetail.ResumeLayout(false);
            this.pDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemTrack)).EndInit();
            this.toolStripTop.ResumeLayout(false);
            this.toolStripTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripTextBox toolStriptxtSearch;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        private System.Windows.Forms.ToolStripContainer tsContainer;
        private System.Windows.Forms.ToolStrip toolStripTop;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.Panel pDetail;
        private System.Windows.Forms.DataGridView dgItemTrack;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cbFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label txtDescription;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.Label txtSKU;
        private System.Windows.Forms.Label txtBarcode;
        private System.Windows.Forms.Label txtPODate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtPONumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtSODate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtSONumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtAddressName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtAddress3;
        private System.Windows.Forms.Label txtAddress2;
        private System.Windows.Forms.Label txtAddress1;
        private System.Windows.Forms.Label txtPostalCode;
        private System.Windows.Forms.Label txtAddress4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtWeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtqty;
    }
}