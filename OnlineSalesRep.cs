using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMSWarehouse
{
    public partial class FrmOnlineSalesRep : Form
    {
        private int fCompanyID;
        private int SalesRep;
        private Wrapper WS = new Wrapper();

        public FrmOnlineSalesRep(int CompanyID)
        {
            fCompanyID = CompanyID;
            InitializeComponent();
            SalesRep = 0;
            LoadData();
        }

        public void LoadData()
        {
            DataSet ds = WS.GetOrderRep(fCompanyID);
            dgSalesRep.DataSource = ds.Tables[0];
            dgSalesRep.Columns["OrderRep_ID"].Visible = false;
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgSalesRep_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtDescription.Text = dgSalesRep.CurrentRow.Cells["RepName"].Value.ToString();
                SalesRep = int.Parse(dgSalesRep.CurrentRow.Cells["OrderRep_ID"].Value.ToString());
            }
            catch
            {
                //No Code Object not yeat initialised
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text.Length > 1)
            {
                WS.SetOrderRep(SalesRep, fCompanyID, txtDescription.Text);
                LoadData();
            }
            else
            {
                MessageBox.Show("The Name is not valid");
            }

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            SalesRep = 0;
            txtDescription.Text = "";
        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            WS.DeleteOrderRep(SalesRep);
            LoadData();
        }
    }
}
