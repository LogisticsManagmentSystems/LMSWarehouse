namespace LMSWarehouse
{
    partial class FrmBudget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBudget));
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.pGrid = new System.Windows.Forms.Panel();
            this.dgBudget = new System.Windows.Forms.DataGridView();
            this.pDetail = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBudgetAdjust = new System.Windows.Forms.TextBox();
            this.txtRemaining = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelB = new System.Windows.Forms.ToolStripLabel();
            this.toolStripcbBrand = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabelC = new System.Windows.Forms.ToolStripLabel();
            this.toolStripcbCategory = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tcbBudgetType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.pGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBudget)).BeginInit();
            this.pDetail.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.pGrid);
            this.toolStripContainer.ContentPanel.Controls.Add(this.pDetail);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(695, 376);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(695, 401);
            this.toolStripContainer.TabIndex = 1;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
            // 
            // pGrid
            // 
            this.pGrid.Controls.Add(this.dgBudget);
            this.pGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGrid.Location = new System.Drawing.Point(0, 0);
            this.pGrid.Name = "pGrid";
            this.pGrid.Size = new System.Drawing.Size(695, 153);
            this.pGrid.TabIndex = 2;
            // 
            // dgBudget
            // 
            this.dgBudget.AllowUserToAddRows = false;
            this.dgBudget.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            this.dgBudget.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgBudget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBudget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBudget.Location = new System.Drawing.Point(0, 0);
            this.dgBudget.Name = "dgBudget";
            this.dgBudget.ReadOnly = true;
            this.dgBudget.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBudget.Size = new System.Drawing.Size(695, 153);
            this.dgBudget.TabIndex = 1;
            this.dgBudget.SelectionChanged += new System.EventHandler(this.dgBudget_SelectionChanged);
            // 
            // pDetail
            // 
            this.pDetail.Controls.Add(this.label3);
            this.pDetail.Controls.Add(this.label6);
            this.pDetail.Controls.Add(this.txtBudgetAdjust);
            this.pDetail.Controls.Add(this.txtRemaining);
            this.pDetail.Controls.Add(this.label1);
            this.pDetail.Controls.Add(this.txtValue);
            this.pDetail.Controls.Add(this.label5);
            this.pDetail.Controls.Add(this.label4);
            this.pDetail.Controls.Add(this.txtRegion);
            this.pDetail.Controls.Add(this.txtBudget);
            this.pDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pDetail.Location = new System.Drawing.Point(0, 153);
            this.pDetail.Name = "pDetail";
            this.pDetail.Size = new System.Drawing.Size(695, 223);
            this.pDetail.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Budget Adjustment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Remaining ";
            // 
            // txtBudgetAdjust
            // 
            this.txtBudgetAdjust.Location = new System.Drawing.Point(455, 62);
            this.txtBudgetAdjust.Name = "txtBudgetAdjust";
            this.txtBudgetAdjust.Size = new System.Drawing.Size(113, 20);
            this.txtBudgetAdjust.TabIndex = 23;
            // 
            // txtRemaining
            // 
            this.txtRemaining.Enabled = false;
            this.txtRemaining.Location = new System.Drawing.Point(455, 18);
            this.txtRemaining.Name = "txtRemaining";
            this.txtRemaining.Size = new System.Drawing.Size(113, 20);
            this.txtRemaining.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Value";
            // 
            // txtValue
            // 
            this.txtValue.Enabled = false;
            this.txtValue.Location = new System.Drawing.Point(138, 102);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(182, 20);
            this.txtValue.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Region";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Budget";
            // 
            // txtRegion
            // 
            this.txtRegion.Enabled = false;
            this.txtRegion.Location = new System.Drawing.Point(138, 62);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(182, 20);
            this.txtRegion.TabIndex = 9;
            // 
            // txtBudget
            // 
            this.txtBudget.Enabled = false;
            this.txtBudget.Location = new System.Drawing.Point(138, 22);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(182, 20);
            this.txtBudget.TabIndex = 7;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.toolStripLabelB,
            this.toolStripcbBrand,
            this.toolStripLabelC,
            this.toolStripcbCategory,
            this.toolStripLabel1,
            this.tcbBudgetType});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(695, 25);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 0;
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
            this.toolStripLabelB.Size = new System.Drawing.Size(38, 22);
            this.toolStripLabelB.Text = "Brand";
            // 
            // toolStripcbBrand
            // 
            this.toolStripcbBrand.Name = "toolStripcbBrand";
            this.toolStripcbBrand.Size = new System.Drawing.Size(121, 25);
            this.toolStripcbBrand.SelectedIndexChanged += new System.EventHandler(this.toolStripcbBrand_SelectedIndexChanged);
            // 
            // toolStripLabelC
            // 
            this.toolStripLabelC.Name = "toolStripLabelC";
            this.toolStripLabelC.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabelC.Text = "Category";
            // 
            // toolStripcbCategory
            // 
            this.toolStripcbCategory.Name = "toolStripcbCategory";
            this.toolStripcbCategory.Size = new System.Drawing.Size(121, 25);
            this.toolStripcbCategory.SelectedIndexChanged += new System.EventHandler(this.toolStripcbCategory_SelectedIndexChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(74, 22);
            this.toolStripLabel1.Text = "Budget Type";
            // 
            // tcbBudgetType
            // 
            this.tcbBudgetType.Items.AddRange(new object[] {
            "Monatary Budgets",
            "Unit Budgets"});
            this.tcbBudgetType.Name = "tcbBudgetType";
            this.tcbBudgetType.Size = new System.Drawing.Size(121, 25);
            // 
            // FrmBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 401);
            this.Controls.Add(this.toolStripContainer);
            this.Name = "FrmBudget";
            this.Text = "Budget";
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.pGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBudget)).EndInit();
            this.pDetail.ResumeLayout(false);
            this.pDetail.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.Panel pGrid;
        private System.Windows.Forms.DataGridView dgBudget;
        private System.Windows.Forms.Panel pDetail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelB;
        private System.Windows.Forms.ToolStripComboBox toolStripcbBrand;
        private System.Windows.Forms.ToolStripLabel toolStripLabelC;
        private System.Windows.Forms.ToolStripComboBox toolStripcbCategory;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tcbBudgetType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBudgetAdjust;
        private System.Windows.Forms.TextBox txtRemaining;
    }
}