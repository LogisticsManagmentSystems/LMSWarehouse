namespace LMSWarehouse
{
    partial class fReportDeliveryNote
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Report = new LMSWarehouse.Report();
            this.sp_stock_GetStockOrderFullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_stock_GetStockOrderFullTableAdapter = new LMSWarehouse.ReportTableAdapters.sp_stock_GetStockOrderFullTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_stock_GetStockOrderFullBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Report_sp_stock_GetStockOrderFull";
            reportDataSource1.Value = this.sp_stock_GetStockOrderFullBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LMSWarehouse.RepDeliveryNote.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(770, 363);
            this.reportViewer1.TabIndex = 0;
            // 
            // Report
            // 
            this.Report.DataSetName = "Report";
            this.Report.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_stock_GetStockOrderFullBindingSource
            // 
            this.sp_stock_GetStockOrderFullBindingSource.DataMember = "sp_stock_GetStockOrderFull";
            this.sp_stock_GetStockOrderFullBindingSource.DataSource = this.Report;
            // 
            // sp_stock_GetStockOrderFullTableAdapter
            // 
            this.sp_stock_GetStockOrderFullTableAdapter.ClearBeforeFill = true;
            // 
            // fReportDeliveryNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 363);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fReportDeliveryNote";
            this.Text = "fReportDeliveryNote";
            this.Load += new System.EventHandler(this.fReportDeliveryNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_stock_GetStockOrderFullBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_stock_GetStockOrderFullBindingSource;
        private Report Report;
        private LMSWarehouse.ReportTableAdapters.sp_stock_GetStockOrderFullTableAdapter sp_stock_GetStockOrderFullTableAdapter;
    }
}