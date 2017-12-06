using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMSWarehouse
{
    public partial class fReportDeliveryNote : Form
    {
        int OrderID;
        public fReportDeliveryNote(int fOrderID)
        {
            InitializeComponent();
            OrderID = fOrderID;
        }

        private void fReportDeliveryNote_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Report.sp_stock_GetStockOrderFull' table. You can move, or remove it, as needed.
            this.sp_stock_GetStockOrderFullTableAdapter.Fill(this.Report.sp_stock_GetStockOrderFull,OrderID);
            this.reportViewer1.RefreshReport();
           // this.reportViewer1.refr
        }
    }
}
