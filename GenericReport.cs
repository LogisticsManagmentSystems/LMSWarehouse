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
    public partial class FrmGenericReport : Form
    {

        private int CompanyID;
        private int WarehouseID;
        private string OrderType;
        private string ReportName;

        private Wrapper WS = new Wrapper();

        public FrmGenericReport(string fReportName, int fCompany, int fWarehouse)
        {
            CompanyID = fCompany;
            WarehouseID = fWarehouse;
            ReportName = fReportName;
            InitializeComponent();
            OrderType = "Sale";
            LoadReport();
        }

        private void LoadReport()
        {
            AddEmptyCombo(cbPrimaryCustomer);
            AddEmptyCombo(cbCustomer);
            AddEmptyCombo(cbBrand);
            AddEmptyCombo(cbCategory);
            AddEmptyCombo(cbProduct);
            PresetReport();

        }


        private void PresetReport()
        {
            OrderType = "Sale";
        }



        private void AddEmptyCombo(ComboBox Combo)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add("NewTable");
            ds.Tables[0].Columns.Add("ID");
            ds.Tables[0].Columns.Add("Description");

            DataRow dr = ds.Tables[0].NewRow();
            dr["ID"] = 0;
            dr["Description"] = "Select All";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            Combo.DataSource = ds.Tables[0];
            Combo.ValueMember = "ID";
            Combo.DisplayMember = "Description";

        }

        private void AddDataCombo(DataSet Data,ComboBox Combo, string ID, string Description )
        {
            DataRow dr = Data.Tables[0].NewRow();
            dr[ID] = 0;
            dr[Description] = "Select All";

            Data.Tables[0].Rows.InsertAt(dr, 0);
            Combo.DataSource = Data.Tables[0];
            Combo.ValueMember = ID;
            Combo.DisplayMember = Description;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            dgResult.Visible = false;
            DataSet ds = WS.GenericReport(ReportName, CompanyID, dtStart.Value, dtEnd.Value,
                int.Parse(cbPrimaryCustomer.SelectedValue.ToString()), int.Parse(cbCustomer.SelectedValue.ToString()),
                int.Parse(cbBrand.SelectedValue.ToString()), int.Parse(cbCategory.SelectedValue.ToString()),
                int.Parse(cbProduct.SelectedValue.ToString()), WarehouseID);
                //int.Parse(cbWarehouse.SelectedValue.ToString()));
            dgResult.DataSource = ds.Tables[0];

            if (rdWindows.Checked)
            {
                dgResult.Visible = true;
            }
            else if (rdExcel.Checked)
            {
                ExportDatagridviewToExcel(dgResult, "c:\\temp\\" + ReportName + ".xls");
                System.Diagnostics.Process.Start("c:\\temp\\" + ReportName + ".xls");
            }
            else
            {
                ExportDatagridviewToHtml(dgResult, "c:\\temp\\" + ReportName + ".html");
                System.Diagnostics.Process.Start("c:\\temp\\" + ReportName + ".html");

            }

        }

        public void ExportDatagridviewToExcel(DataGridView dgv, string excelfile)
        {
            int cols;
            //open file
            StreamWriter wr = new StreamWriter(excelfile);

            //Writing Header Information
            wr.Write("Report : " + ReportName + "\t");
            wr.WriteLine();
            wr.WriteLine();
            wr.Write("From Date : " + dtStart.Text + "\t");
            wr.WriteLine();
            wr.Write("To Date : " + dtEnd.Text + "\t");
            wr.WriteLine();
            wr.Write("Primary Customer : " + cbPrimaryCustomer.Text + "\t");
            wr.WriteLine();
            wr.Write("Customer : " + cbCustomer.Text + "\t");
            wr.WriteLine();
            wr.Write("Brand : " + cbBrand.Text + "\t");
            wr.WriteLine();
            wr.Write("Category : " + cbCategory.Text + "\t");
            wr.WriteLine();
            wr.Write("Product : " + cbProduct.Text + "\t");
            wr.WriteLine();
            wr.WriteLine();
            wr.WriteLine();
            //determine the number of columns and write columns to file
            cols = dgv.Columns.Count;
            for (int i = 0; i < cols; i++)
            {
                wr.Write(dgv.Columns[i].Name.ToString().ToUpper() + "\t");
            }

            wr.WriteLine();

            //write rows to excel file
            for (int i = 0; i < (dgv.Rows.Count - 1); i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (dgv.Rows[i].Cells[j].Value != null)
                        wr.Write(dgv.Rows[i].Cells[j].Value + "\t");
                    else
                    {
                        wr.Write("\t");
                    }
                }

                wr.WriteLine();
            }

            //close file
            wr.Close();
        }

        public void ExportDatagridviewToHtml(DataGridView dgv, string htmlfile)
        {
            int cols;
            //open file
            StreamWriter wr = new StreamWriter(htmlfile);

            //Writing Header Information
            wr.Write("<table>");
            wr.Write("<tr><td width=\"200px\"> Report : " + ReportName + "</td></tr>");
            wr.Write("</table>");
            wr.Write("<br>");
            wr.Write("<br>");
            wr.WriteLine();
            wr.Write("<table>");

            //determine the number of columns and write columns to file
            wr.Write("<tr>");
            cols = dgv.Columns.Count;
            for (int i = 0; i < cols; i++)
            {
                wr.Write("<td width=\"" + dgv.Columns[i].Width.ToString() + "px\">" + dgv.Columns[i].Name.ToString().ToUpper() + "</td>");
            }

            wr.Write("</tr>");
            wr.WriteLine();
            //wr.Write("<table>");

            //write rows to excel file
            for (int i = 0; i < (dgv.Rows.Count - 1); i++)
            {

            wr.Write("<tr>");
                for (int j = 0; j < cols; j++)
                {
                    if (dgv.Rows[i].Cells[j].Value != null)
                        wr.Write("<td width=\"" + dgv.Rows[i].Cells[j].Size.Width.ToString() + "px\">" + dgv.Rows[i].Cells[j].Value + "</td>");
                    else
                    {
                        wr.Write("\t");
                    }
                }

            wr.Write("</tr>");
                wr.WriteLine();
            }
            wr.Write("</table>");
            wr.WriteLine();

            //close file
            wr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgResult.Visible = false;
            DataSet ds = WS.GetJHBStock();
            //int.Parse(cbWarehouse.SelectedValue.ToString()));
            dgResult.DataSource = ds.Tables[0];

            string tmpName = ReportName;
            ReportName = "JHB Stock Report";

            if (rdWindows.Checked)
            {
                dgResult.Visible = true;
            }
            else if (rdExcel.Checked)
            {
                ExportDatagridviewToExcel(dgResult, "c:\\temp\\" + ReportName + ".xls");
                System.Diagnostics.Process.Start("c:\\temp\\" + ReportName + ".xls");
            }
            else
            {
                ExportDatagridviewToHtml(dgResult, "c:\\temp\\" + ReportName + ".html");
                System.Diagnostics.Process.Start("c:\\temp\\" + ReportName + ".html");

            }
            ReportName = tmpName; 
        }

        private void cbPrimaryCustomer_Enter(object sender, EventArgs e)
        {
            DataSet dpc = WS.GetPrimaryCustomer(CompanyID, OrderType);
            AddDataCombo(dpc, cbPrimaryCustomer, "PrimaryCustomer_ID", "PrimaryCustomerName");
        }

        private void cbCustomer_Enter(object sender, EventArgs e)
        {
            if (int.Parse(cbPrimaryCustomer.SelectedValue.ToString()) > 0)
            {
                DataSet dc = WS.GetCustomer(int.Parse(cbPrimaryCustomer.SelectedValue.ToString()));
                AddDataCombo(dc, cbCustomer, "Customer_ID", "CustomerName");
            }
        }

        private void cbBrand_Enter(object sender, EventArgs e)
        {
            DataSet ds = WS.GetBrands(CompanyID);
            AddDataCombo(ds, cbBrand, "Brand_ID", "BrandName");
        }

        private void cbCategory_Enter(object sender, EventArgs e)
        {
            if (int.Parse(cbBrand.SelectedValue.ToString()) > 0)
            {
                DataSet dc = WS.GetCategories(int.Parse(cbBrand.SelectedValue.ToString()));
                AddDataCombo(dc, cbCategory, "Category_ID", "CategoryName");
            }

        }

        private void cbProduct_Enter(object sender, EventArgs e)
        {
            if (int.Parse(cbBrand.SelectedValue.ToString()) > 0)
            {
                DataSet dc = WS.GetProducts(CompanyID, int.Parse(cbBrand.SelectedValue.ToString()), 0, 0, 1, 0, WarehouseID);
                AddDataCombo(dc, cbProduct, "Product_ID", "ProductDescription");
            }
        }




    }
}



