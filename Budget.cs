using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMSWarehouse
{
    public partial class FrmBudget : Form
    {
        int CompanyID;
        private int BudgetID;
        private int RegionID;
        private Wrapper WS = new Wrapper();


        public FrmBudget(int fCompanyID)
        {
            CompanyID = fCompanyID;
            InitializeComponent();
            AddBrandFilter();            
            tcbBudgetType.SelectedIndex = 1;            
        }


        private void LoadData()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                int MyBudget = BudgetID;
                int MyRegion = RegionID;
                int MyRow = 0;
                //int MyProd = Prod.Product_ID;
                //int MyRow = 0;


                DataSet ds = WS.GetRegionBudgets(CompanyID, int.Parse(toolStripcbBrand.ComboBox.SelectedValue.ToString()),
                    int.Parse(toolStripcbCategory.ComboBox.SelectedValue.ToString()), 0, tcbBudgetType.SelectedIndex);
                dgBudget.DataSource = ds.Tables[0];

                dgBudget.Columns["Budget_ID"].Visible = false;
                dgBudget.Columns["Region_ID"].Visible = false;

                try
                {
                    for (int x = 0; x < dgBudget.Rows.Count; x++)
                    {
                        if ((MyBudget == int.Parse(dgBudget.Rows[x].Cells["Budget_ID"].Value.ToString())) &&
                            (MyRegion == int.Parse(dgBudget.Rows[x].Cells["Region_ID"].Value.ToString())))
                        {
                            MyRow = x;
                        }

                    }

                    dgBudget.CurrentCell = dgBudget.Rows[MyRow].Cells[2];
                    dgBudget.Rows[MyRow].Selected = true;
                    dgBudget_SelectionChanged(null, null);
                }
                catch
                {
                    //Reverting to last Product
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ee)
            {
                Cursor.Current = Cursors.Default;
                //MessageBox.Show("An Error Occured when loading data:" + ee.Message);
            }


        }

        private void AddBrandFilter()
        {
            DataSet ds = WS.GetBrands(CompanyID);

            DataRow dr = ds.Tables[0].NewRow();
            dr["BrandName"] = "Select All";
            dr["Brand_ID"] = 0;
            ds.Tables[0].Rows.InsertAt(dr, 0);

            toolStripcbBrand.ComboBox.DataSource = ds.Tables[0];
            toolStripcbBrand.ComboBox.ValueMember = "Brand_ID";
            toolStripcbBrand.ComboBox.DisplayMember = "BrandName";

        }

        private void AddCategoryFilter(int BrandID)
        {
            DataSet ds = WS.GetCategories(BrandID);

            DataRow dr = ds.Tables[0].NewRow();
            dr["CategoryName"] = "Select All";
            dr["Category_ID"] = 0;
            ds.Tables[0].Rows.InsertAt(dr, 0);

            toolStripcbCategory.ComboBox.DataSource = ds.Tables[0];
            toolStripcbCategory.ComboBox.ValueMember = "Category_ID";
            toolStripcbCategory.ComboBox.DisplayMember = "CategoryName";
        }

        private void toolStripcbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = WS.GetRegionBudgets(CompanyID, int.Parse(toolStripcbBrand.ComboBox.SelectedValue.ToString()), 0, 0,tcbBudgetType.SelectedIndex);
                dgBudget.DataSource = ds.Tables[0];
                AddCategoryFilter(int.Parse(toolStripcbBrand.ComboBox.SelectedValue.ToString()));
                dgBudget.Columns["Budget_ID"].Visible = false;
                dgBudget.Columns["Region_ID"].Visible = false;
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                Cursor.Current = Cursors.Default;
                //No Code: Object not yeat initialised
            }
        }

        private void toolStripcbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch
            {
            }
        }

        private void dgBudget_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtBudget.Text = dgBudget.CurrentRow.Cells["BudgetName"].Value.ToString();
                txtRegion.Text = dgBudget.CurrentRow.Cells["RegionName"].Value.ToString();
                txtValue.Text = dgBudget.CurrentRow.Cells["BudgetValue"].Value.ToString();
                txtRemaining.Text = dgBudget.CurrentRow.Cells["Remaining"].Value.ToString();
                txtBudgetAdjust.Text = dgBudget.CurrentRow.Cells["Remaining"].Value.ToString();

                BudgetID = int.Parse(dgBudget.CurrentRow.Cells["Budget_ID"].Value.ToString());
                RegionID = int.Parse(dgBudget.CurrentRow.Cells["Region_ID"].Value.ToString());
        
            }
            catch
            {
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (txtBudget.Text.Length > 2)
            {
                WS.UpdateBudget(BudgetID, RegionID, double.Parse(txtBudgetAdjust.Text));
                LoadData();
            }
            else
            {
                MessageBox.Show("Budget not valid");
            }

        }

        


    }
}
