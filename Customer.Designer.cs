﻿namespace LMSWarehouse
{
    partial class FrmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomer));
            this.lblName = new System.Windows.Forms.Label();
            this.dgCustomer = new System.Windows.Forms.DataGridView();
            this.tsBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelB = new System.Windows.Forms.ToolStripLabel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.toolStripcbFilter = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.nameTxt = new System.Windows.Forms.ToolStripTextBox();
            this.searchBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.pGrid = new System.Windows.Forms.Panel();
            this.pDetail = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPPostal = new System.Windows.Forms.TextBox();
            this.txtPAddress4 = new System.Windows.Forms.TextBox();
            this.txtPAddress3 = new System.Windows.Forms.TextBox();
            this.txtPAddress2 = new System.Windows.Forms.TextBox();
            this.txtPAddress1 = new System.Windows.Forms.TextBox();
            this.txtPAddressName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPrimaryCustomer = new System.Windows.Forms.ComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.pGrid.SuspendLayout();
            this.pDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(65, 82);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Name";
            // 
            // dgCustomer
            // 
            this.dgCustomer.AllowUserToAddRows = false;
            this.dgCustomer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            this.dgCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCustomer.Location = new System.Drawing.Point(0, 0);
            this.dgCustomer.Name = "dgCustomer";
            this.dgCustomer.ReadOnly = true;
            this.dgCustomer.RowTemplate.Height = 24;
            this.dgCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCustomer.Size = new System.Drawing.Size(676, 337);
            this.dgCustomer.TabIndex = 1;
            this.dgCustomer.SelectionChanged += new System.EventHandler(this.dgCustomer_SelectionChanged);
            this.dgCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomer_CellContentClick);
            // 
            // tsBtnDelete
            // 
            this.tsBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnDelete.Image")));
            this.tsBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDelete.Name = "tsBtnDelete";
            this.tsBtnDelete.Size = new System.Drawing.Size(60, 22);
            this.tsBtnDelete.Text = "Delete";
            this.tsBtnDelete.Click += new System.EventHandler(this.tsBtnDelete_Click);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelB
            // 
            this.toolStripLabelB.Name = "toolStripLabelB";
            this.toolStripLabelB.Size = new System.Drawing.Size(103, 22);
            this.toolStripLabelB.Text = "Primary Customer";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 20);
            this.txtName.TabIndex = 12;
            // 
            // toolStripcbFilter
            // 
            this.toolStripcbFilter.Name = "toolStripcbFilter";
            this.toolStripcbFilter.Size = new System.Drawing.Size(121, 25);
            this.toolStripcbFilter.DropDownClosed += new System.EventHandler(this.toolStripcbFilter_DropDownClosed);
            this.toolStripcbFilter.TextChanged += new System.EventHandler(this.toolStripcbFilter_TextChanged);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.saveToolStripButton,
            this.tsBtnDelete,
            this.toolStripSeparator1,
            this.toolStripLabelB,
            this.toolStripcbFilter,
            this.toolStripSeparator2,
            this.nameTxt,
            this.searchBtn});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(676, 25);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 0;
            // 
            // nameTxt
            // 
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(100, 25);
            // 
            // searchBtn
            // 
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(62, 22);
            this.searchBtn.Text = "Search";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.pGrid);
            this.toolStripContainer.ContentPanel.Controls.Add(this.pDetail);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(676, 560);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(676, 585);
            this.toolStripContainer.TabIndex = 1;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
            // 
            // pGrid
            // 
            this.pGrid.Controls.Add(this.dgCustomer);
            this.pGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGrid.Location = new System.Drawing.Point(0, 0);
            this.pGrid.Name = "pGrid";
            this.pGrid.Size = new System.Drawing.Size(676, 337);
            this.pGrid.TabIndex = 2;
            // 
            // pDetail
            // 
            this.pDetail.Controls.Add(this.label4);
            this.pDetail.Controls.Add(this.txtPPostal);
            this.pDetail.Controls.Add(this.txtPAddress4);
            this.pDetail.Controls.Add(this.txtPAddress3);
            this.pDetail.Controls.Add(this.txtPAddress2);
            this.pDetail.Controls.Add(this.txtPAddress1);
            this.pDetail.Controls.Add(this.txtPAddressName);
            this.pDetail.Controls.Add(this.lblName);
            this.pDetail.Controls.Add(this.txtName);
            this.pDetail.Controls.Add(this.label2);
            this.pDetail.Controls.Add(this.cbUsers);
            this.pDetail.Controls.Add(this.label1);
            this.pDetail.Controls.Add(this.cbPrimaryCustomer);
            this.pDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pDetail.Location = new System.Drawing.Point(0, 337);
            this.pDetail.Name = "pDetail";
            this.pDetail.Size = new System.Drawing.Size(676, 223);
            this.pDetail.TabIndex = 1;
            this.pDetail.Paint += new System.Windows.Forms.PaintEventHandler(this.pDetail_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Address";
            // 
            // txtPPostal
            // 
            this.txtPPostal.Location = new System.Drawing.Point(410, 160);
            this.txtPPostal.Name = "txtPPostal";
            this.txtPPostal.Size = new System.Drawing.Size(100, 20);
            this.txtPPostal.TabIndex = 24;
            // 
            // txtPAddress4
            // 
            this.txtPAddress4.Location = new System.Drawing.Point(410, 133);
            this.txtPAddress4.Name = "txtPAddress4";
            this.txtPAddress4.Size = new System.Drawing.Size(152, 20);
            this.txtPAddress4.TabIndex = 23;
            // 
            // txtPAddress3
            // 
            this.txtPAddress3.Location = new System.Drawing.Point(410, 106);
            this.txtPAddress3.Name = "txtPAddress3";
            this.txtPAddress3.Size = new System.Drawing.Size(152, 20);
            this.txtPAddress3.TabIndex = 22;
            // 
            // txtPAddress2
            // 
            this.txtPAddress2.Location = new System.Drawing.Point(410, 79);
            this.txtPAddress2.Name = "txtPAddress2";
            this.txtPAddress2.Size = new System.Drawing.Size(152, 20);
            this.txtPAddress2.TabIndex = 21;
            // 
            // txtPAddress1
            // 
            this.txtPAddress1.Location = new System.Drawing.Point(410, 53);
            this.txtPAddress1.Name = "txtPAddress1";
            this.txtPAddress1.Size = new System.Drawing.Size(152, 20);
            this.txtPAddress1.TabIndex = 20;
            // 
            // txtPAddressName
            // 
            this.txtPAddressName.Location = new System.Drawing.Point(410, 26);
            this.txtPAddressName.Name = "txtPAddressName";
            this.txtPAddressName.Size = new System.Drawing.Size(152, 20);
            this.txtPAddressName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Linked User";
            // 
            // cbUsers
            // 
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Location = new System.Drawing.Point(106, 52);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(182, 21);
            this.cbUsers.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Primary Customer";
            // 
            // cbPrimaryCustomer
            // 
            this.cbPrimaryCustomer.Enabled = false;
            this.cbPrimaryCustomer.FormattingEnabled = true;
            this.cbPrimaryCustomer.Location = new System.Drawing.Point(106, 26);
            this.cbPrimaryCustomer.Name = "cbPrimaryCustomer";
            this.cbPrimaryCustomer.Size = new System.Drawing.Size(182, 21);
            this.cbPrimaryCustomer.TabIndex = 0;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 585);
            this.Controls.Add(this.toolStripContainer);
            this.Name = "FrmCustomer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.pGrid.ResumeLayout(false);
            this.pDetail.ResumeLayout(false);
            this.pDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgCustomer;
        private System.Windows.Forms.ToolStripButton tsBtnDelete;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelB;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ToolStripComboBox toolStripcbFilter;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.Panel pGrid;
        private System.Windows.Forms.Panel pDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPrimaryCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPPostal;
        private System.Windows.Forms.TextBox txtPAddress4;
        private System.Windows.Forms.TextBox txtPAddress3;
        private System.Windows.Forms.TextBox txtPAddress2;
        private System.Windows.Forms.TextBox txtPAddress1;
        private System.Windows.Forms.TextBox txtPAddressName;
        private System.Windows.Forms.ToolStripTextBox nameTxt;
        private System.Windows.Forms.ToolStripButton searchBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}