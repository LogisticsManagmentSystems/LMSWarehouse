using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LMSWarehouse
{
    public partial class FrmStockEventReturn : Form
    {

        private Wrapper WS = new Wrapper();
        private int CompanyID;
        private int WarehouseID;
        

        public FrmStockEventReturn(int fCompany, int fWarehouse,bool AllowSave)
        {
            InitializeComponent();
            if (AllowSave)
            {
                saveToolStripButton.Enabled = true;
            }
            else
            {
                saveToolStripButton.Enabled = false;
            }
        }

        private void btnGetEvent_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButtonOnline_Click(object sender, EventArgs e)
        {
            DataSet ds = WS.GetOrderEventReturn(txtEventRef.Text);
            dgStockEvent.DataSource = ds.Tables[0];
            dgStockEvent.Columns["BrandName"].Visible = false;
            dgStockEvent.Columns["EventName"].Visible = false;
            dgStockEvent.Columns["StockOrder_ID"].Visible = false;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            txtEventRef.Focus();
            int StockID = int.Parse(dgStockEvent.Rows[0].Cells["StockOrder_Id"].Value.ToString());
            DataSet ds = WS.SetStockOrderReturn(StockID, CompanyID, txtDamage.Text);
            if (int.Parse(ds.Tables[0].Rows[0]["StockOrder_ID"].ToString()) != StockID)
            {
                for (int x = 0; x < dgStockEvent.RowCount; x++)
                {
                    WS.SetStockDetail(int.Parse(ds.Tables[0].Rows[0]["StockOrder_ID"].ToString()), 
                        int.Parse(dgStockEvent.Rows[x].Cells["Product_ID"].Value.ToString()),
                        int.Parse(dgStockEvent.Rows[x].Cells["Received"].Value.ToString()), 0.00);
                }
                Close();
            }

            else
            {
                MessageBox.Show("Order already returned");
            }
            
        }

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            ExportDatagridviewToExcel(dgStockEvent, "c:\\temp\\" + "Delivery Report" + ".xls");
            System.Diagnostics.Process.Start("c:\\temp\\" + "Delivery Report" + ".xls");
        }

        public void ExportDatagridviewToExcel(DataGridView dgv, string excelfile)
        {
            int cols;
            //open file
            StreamWriter wr = new StreamWriter(excelfile);

            //Writing Header Information
            wr.Write("Report : " + "Sauce-ing Event Collection/Delivery Report" + "\t");
            wr.WriteLine();
            wr.WriteLine();
            wr.Write("Event : " + dgStockEvent.Rows[0].Cells["EventName"].Value.ToString() + "\t");
            wr.WriteLine();
            wr.WriteLine();
            wr.Write("Date : " + DateTime.Now.ToShortDateString() + "\t");
            wr.WriteLine();
            wr.WriteLine();
            wr.Write("Damage : " + txtDamage.Text + "\t");

            wr.WriteLine();
            wr.WriteLine();
            wr.WriteLine();
            //determine the number of columns and write columns to file
            cols = dgv.Columns.Count;
            for (int i = 0; i < cols; i++)
            {
                if (dgv.Columns[i].Visible)
                {
                    wr.Write(dgv.Columns[i].Name.ToString().ToUpper() + "\t");
                }
            }

            wr.WriteLine();

            //write rows to excel file
            for (int i = 0; i < (dgv.Rows.Count); i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (dgv.Columns[j].Visible)
                    {
                        if (dgv.Rows[i].Cells[j].Value != null)
                            wr.Write(dgv.Rows[i].Cells[j].Value + "\t");
                        else
                        {
                            wr.Write("\t");
                        }
                    }                    
                }
                wr.WriteLine();
            }

            wr.WriteLine();
            wr.WriteLine();
            wr.Write("Signature Client : " + "\t");
            wr.WriteLine();
            wr.Write("Signature Sauce-ing : " + "\t");

            //close file
            wr.Close();
        }
    }
}
