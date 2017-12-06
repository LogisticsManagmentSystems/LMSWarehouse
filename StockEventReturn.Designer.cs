namespace LMSWarehouse
{
    partial class FrmStockEventReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockEventReturn));
            this.txtEventRef = new System.Windows.Forms.TextBox();
            this.dgStockEvent = new System.Windows.Forms.DataGridView();
            this.txtDamage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pTop = new System.Windows.Forms.Panel();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.PFill = new System.Windows.Forms.Panel();
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOnline = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgStockEvent)).BeginInit();
            this.pTop.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.PFill.SuspendLayout();
            this.toolStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEventRef
            // 
            this.txtEventRef.Location = new System.Drawing.Point(113, 27);
            this.txtEventRef.Name = "txtEventRef";
            this.txtEventRef.Size = new System.Drawing.Size(158, 20);
            this.txtEventRef.TabIndex = 0;
            // 
            // dgStockEvent
            // 
            this.dgStockEvent.AllowUserToAddRows = false;
            this.dgStockEvent.AllowUserToDeleteRows = false;
            this.dgStockEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStockEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgStockEvent.Location = new System.Drawing.Point(0, 0);
            this.dgStockEvent.Name = "dgStockEvent";
            this.dgStockEvent.Size = new System.Drawing.Size(726, 351);
            this.dgStockEvent.TabIndex = 1;
            // 
            // txtDamage
            // 
            this.txtDamage.Location = new System.Drawing.Point(113, 67);
            this.txtDamage.Name = "txtDamage";
            this.txtDamage.Size = new System.Drawing.Size(496, 20);
            this.txtDamage.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Order Reference";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Damage Report";
            // 
            // pTop
            // 
            this.pTop.Controls.Add(this.label1);
            this.pTop.Controls.Add(this.label2);
            this.pTop.Controls.Add(this.txtEventRef);
            this.pTop.Controls.Add(this.txtDamage);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(726, 157);
            this.pTop.TabIndex = 8;
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.PFill);
            this.toolStripContainer.ContentPanel.Controls.Add(this.pTop);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(726, 508);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(726, 533);
            this.toolStripContainer.TabIndex = 10;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStripTop);
            // 
            // PFill
            // 
            this.PFill.Controls.Add(this.dgStockEvent);
            this.PFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PFill.Location = new System.Drawing.Point(0, 157);
            this.PFill.Name = "PFill";
            this.PFill.Size = new System.Drawing.Size(726, 351);
            this.PFill.TabIndex = 10;
            // 
            // toolStripTop
            // 
            this.toolStripTop.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOnline,
            this.saveToolStripButton,
            this.toolStripButtonPrint,
            this.toolStripButtonClose});
            this.toolStripTop.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.Size = new System.Drawing.Size(726, 25);
            this.toolStripTop.Stretch = true;
            this.toolStripTop.TabIndex = 1;
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(84, 22);
            this.saveToolStripButton.Text = "&Save Order";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripButtonOnline
            // 
            this.toolStripButtonOnline.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOnline.Image")));
            this.toolStripButtonOnline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOnline.Name = "toolStripButtonOnline";
            this.toolStripButtonOnline.Size = new System.Drawing.Size(95, 22);
            this.toolStripButtonOnline.Text = "Import Event";
            this.toolStripButtonOnline.Click += new System.EventHandler(this.toolStripButtonOnline_Click);
            // 
            // toolStripButtonClose
            // 
            this.toolStripButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClose.Image")));
            this.toolStripButtonClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClose.Name = "toolStripButtonClose";
            this.toolStripButtonClose.Size = new System.Drawing.Size(56, 22);
            this.toolStripButtonClose.Text = "Close";
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // toolStripButtonPrint
            // 
            this.toolStripButtonPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrint.Image")));
            this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonPrint.Text = "Print";
            this.toolStripButtonPrint.Click += new System.EventHandler(this.toolStripButtonPrint_Click);
            // 
            // FrmStockEventReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 533);
            this.Controls.Add(this.toolStripContainer);
            this.Name = "FrmStockEventReturn";
            this.Text = "StockEventReturn";
            ((System.ComponentModel.ISupportInitialize)(this.dgStockEvent)).EndInit();
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.PFill.ResumeLayout(false);
            this.toolStripTop.ResumeLayout(false);
            this.toolStripTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEventRef;
        private System.Windows.Forms.DataGridView dgStockEvent;
        private System.Windows.Forms.TextBox txtDamage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.Panel PFill;
        private System.Windows.Forms.ToolStrip toolStripTop;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButtonOnline;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
    }
}