namespace LMSWarehouse
{
    partial class FrmDispatchLabels
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
            this.btnPrintLabels = new System.Windows.Forms.Button();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrintLabels
            // 
            this.btnPrintLabels.Location = new System.Drawing.Point(53, 117);
            this.btnPrintLabels.Name = "btnPrintLabels";
            this.btnPrintLabels.Size = new System.Drawing.Size(75, 23);
            this.btnPrintLabels.TabIndex = 3;
            this.btnPrintLabels.Text = "Print";
            this.btnPrintLabels.UseVisualStyleBackColor = true;
            this.btnPrintLabels.Click += new System.EventHandler(this.btnPrintLabels_Click);
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(53, 68);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(100, 20);
            this.txtOrder.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Reference Number";
            // 
            // FrmDispatchLabels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrintLabels);
            this.Controls.Add(this.txtOrder);
            this.Name = "FrmDispatchLabels";
            this.Text = "DispatchLabels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrintLabels;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Label label1;
    }
}