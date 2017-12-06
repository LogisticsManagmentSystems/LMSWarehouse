using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMSWarehouse
{
    public partial class FrmCustomer : Form
    {

        int CompanyID;
        int PrimaryCustomerID;
        public int CustomerID;
        private string Ctype;
        private string TableType;

        private Wrapper WS = new Wrapper();

        public FrmCustomer(int fCompanyID, string fCType, int fPrimaryCustomerID)
        {
            CompanyID = fCompanyID;
            CustomerID = 0;
            PrimaryCustomerID = fPrimaryCustomerID;
            Ctype = fCType;
            if (Ctype == "Cust")
            {
                TableType = "customer";
            }
            else
            {
                TableType = "Supplier";
            }



            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DataSet dpc = WS.GetPrimaryCustomer(CompanyID, Ctype);
                cbPrimaryCustomer.DataSource = dpc.Tables[0];
                cbPrimaryCustomer.ValueMember = "PrimaryCustomer_ID";
                cbPrimaryCustomer.DisplayMember = "PrimaryCustomerName";

                toolStripcbFilter.ComboBox.DataSource = dpc.Tables[0];
                toolStripcbFilter.ComboBox.ValueMember = "PrimaryCustomer_ID";
                toolStripcbFilter.ComboBox.DisplayMember = "PrimaryCustomerName";

                if (PrimaryCustomerID > 0)
                {
                    toolStripcbFilter.ComboBox.SelectedValue = PrimaryCustomerID;
                    toolStripcbFilter.ComboBox.Enabled = false;
                }

                //DataSet dc = WS.GetCustomer(int.Parse(cbPrimaryCustomer.SelectedValue.ToString()));
                DataSet dc = WS.GetCustomer(int.Parse(toolStripcbFilter.ComboBox.SelectedValue.ToString()));
                dgCustomer.DataSource = dc.Tables[0];


                DataSet du = WS.GetUserList(CompanyID);
                DataRow dr = du.Tables[0].NewRow();
                dr["User_ID"] = 0;
                dr["UserName"] = "No User Linked";

                du.Tables[0].Rows.InsertAt(dr, 0);
                cbUsers.DataSource = du.Tables[0];
                cbUsers.ValueMember = "User_ID";
                cbUsers.DisplayMember = "UserName";



                cbPrimaryCustomer.SelectedValue = int.Parse(dpc.Tables[0].Rows[0]["PrimaryCustomer_ID"].ToString());
            }
            catch
            {
                //Data not initialised
            }

        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {

        }

        private void dgCustomer_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtName.Text = dgCustomer.CurrentRow.Cells["CustomerName"].Value.ToString();
                txtPAddressName.Text = dgCustomer.CurrentRow.Cells["AddressName"].Value.ToString();
                txtPAddress1.Text = dgCustomer.CurrentRow.Cells["Address1"].Value.ToString();
                txtPAddress2.Text = dgCustomer.CurrentRow.Cells["Address2"].Value.ToString();
                txtPAddress3.Text = dgCustomer.CurrentRow.Cells["Address3"].Value.ToString();
                txtPAddress4.Text = dgCustomer.CurrentRow.Cells["Address4"].Value.ToString();
                txtPPostal.Text = dgCustomer.CurrentRow.Cells["PostalCode"].Value.ToString();
                CustomerID = int.Parse(dgCustomer.CurrentRow.Cells["Customer_ID"].Value.ToString());

                cbPrimaryCustomer.SelectedValue = int.Parse(dgCustomer.CurrentRow.Cells["PrimaryCustomer_ID"].Value.ToString());
                cbUsers.SelectedValue = int.Parse(dgCustomer.CurrentRow.Cells["User_ID"].Value.ToString());
                

            }
            catch
            {
            }
        }

        private void pDetail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                txtName.Text = "";
                txtPAddressName.Text = "";
                txtPAddress1.Text = "";
                txtPAddress2.Text = "";
                txtPAddress3.Text = "";
                txtPAddress4.Text = "";
                txtPPostal.Text = "";
                CustomerID = 0;

                cbUsers.SelectedValue = 0;
            }
            catch
            {
            }
        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                WS.DeleteCustomer(CustomerID);
                //DataSet dc = WS.GetCustomer(int.Parse(cbPrimaryCustomer.SelectedValue.ToString()));
                DataSet dc = WS.GetCustomer(int.Parse(toolStripcbFilter.ComboBox.SelectedValue.ToString()));
                dgCustomer.DataSource = dc.Tables[0];
                CustomerID = int.Parse(dgCustomer.CurrentRow.Cells["Customer_ID"].Value.ToString());
            }
            catch
            {
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            int MyProd = CustomerID;
            int MyRow = 0;

            WS.SetCustomer(int.Parse(cbPrimaryCustomer.SelectedValue.ToString()), CustomerID, txtName.Text, TableType,
                txtPAddressName.Text,txtPAddress1.Text,txtPAddress2.Text,txtPAddress3.Text,txtPAddress4.Text,txtPPostal.Text,
                int.Parse(cbUsers.SelectedValue.ToString()));

            DataSet dc = WS.GetCustomer(int.Parse(toolStripcbFilter.ComboBox.SelectedValue.ToString()));
            dgCustomer.DataSource = dc.Tables[0];

            try
            {
                for (int x = 0; x < dgCustomer.Rows.Count; x++)
                {
                    if (MyProd == int.Parse(dgCustomer.Rows[x].Cells["Customer_ID"].Value.ToString()))
                    {
                        MyRow = x;
                    }

                }

                dgCustomer.CurrentCell = dgCustomer.Rows[MyRow].Cells[0];
                dgCustomer.Rows[MyRow].Selected = true;
                dgCustomer_SelectionChanged(sender, e);
            }
            catch
            {
                //Reverting to last Product
            }
        }

        private void toolStripcbFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripcbFilter_DropDownClosed(object sender, EventArgs e)
        {
            DataSet dc = WS.GetCustomer(int.Parse(toolStripcbFilter.ComboBox.SelectedValue.ToString()));
            dgCustomer.DataSource = dc.Tables[0];
        }

        private void dgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //GetCustomerfilter(int PrimaryCustomerID, string name)
            try
            {
                DataSet dpc = WS.GetPrimaryCustomer(CompanyID, Ctype);
                cbPrimaryCustomer.DataSource = dpc.Tables[0];
                cbPrimaryCustomer.ValueMember = "PrimaryCustomer_ID";
                cbPrimaryCustomer.DisplayMember = "PrimaryCustomerName";

                toolStripcbFilter.ComboBox.DataSource = dpc.Tables[0];
                toolStripcbFilter.ComboBox.ValueMember = "PrimaryCustomer_ID";
                toolStripcbFilter.ComboBox.DisplayMember = "PrimaryCustomerName";

                if (PrimaryCustomerID > 0)
                {
                    toolStripcbFilter.ComboBox.SelectedValue = PrimaryCustomerID;
                    toolStripcbFilter.ComboBox.Enabled = false;
                }

                //DataSet dc = WS.GetCustomer(int.Parse(cbPrimaryCustomer.SelectedValue.ToString()));
                DataSet dc = WS.GetCustomerfilter(1,nameTxt.Text);
                dgCustomer.DataSource = dc.Tables[0];


                DataSet du = WS.GetUserList(CompanyID);
                DataRow dr = du.Tables[0].NewRow();
                dr["User_ID"] = 0;
                dr["UserName"] = "No User Linked";

                du.Tables[0].Rows.InsertAt(dr, 0);
                cbUsers.DataSource = du.Tables[0];
                cbUsers.ValueMember = "User_ID";
                cbUsers.DisplayMember = "UserName";



                cbPrimaryCustomer.SelectedValue = int.Parse(dpc.Tables[0].Rows[0]["PrimaryCustomer_ID"].ToString());
            }
            catch
            {
                //Data not initialised
                //Bollox man!!!
            }

        }

    }
}
