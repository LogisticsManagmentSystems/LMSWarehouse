using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMSWarehouse
{
    public partial class FrmOnlineOutlet : Form
    {

        private int fCompanyID;
        private int Outlet;
        private Wrapper WS = new Wrapper();

        public FrmOnlineOutlet(int CompanyID)
        {
            fCompanyID = CompanyID;
            InitializeComponent();
            Outlet = 0;
            LoadData();
        }

        public void LoadData()
        {
            DataSet ds = WS.GetOutlets(fCompanyID);
            dgOutlet.DataSource = ds.Tables[0];
            //dgOutlet.Columns["Company_ID"].Visible = false;
            dgOutlet.Columns["OutLet_ID"].Visible = false;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text.Length > 1)
            {
                WS.AddOutlet(Outlet, fCompanyID, txtDescription.Text);
                LoadData();
            }
            else
            {
                MessageBox.Show("The Name is not valid");
            }
        }

        private void dgOutlet_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtDescription.Text = dgOutlet.CurrentRow.Cells["OutletDescription"].Value.ToString();
                Outlet = int.Parse(dgOutlet.CurrentRow.Cells["OutLet_ID"].Value.ToString());
            }
            catch
            {
                //No Code Object not yeat initialised
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                txtDescription.Text = "";
                Outlet = 0;
            }
            catch
            {
                //No Code Object not yeat initialised
            }
        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            WS.DeleteOutlet(Outlet);
            LoadData();

        }
    }
}
