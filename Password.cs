using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMSWarehouse
{
    public partial class FrmPassword : Form
    {
        public int UserID;
        public int WarehouseID;
        public int CompanyID;
        public string WarehouseName;
        private Wrapper WS = new Wrapper();

        public FrmPassword(int fCompanyID,int fUserID,int fWarehouseID)
        {
            InitializeComponent();
            UserID = fUserID;
            WarehouseID = fWarehouseID;
            CompanyID = fCompanyID;
            WarehouseName = "";
            LoadData();
        }


        private void LoadData()
        {
            if (UserID > 0)
            {
                DataSet ds = WS.GetUserWarehouse(UserID);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    cbWarehouse.DataSource = ds.Tables[0];
                    cbWarehouse.ValueMember = "Warehouse_ID";
                    cbWarehouse.DisplayMember = "WarehouseName";
                    lblWarehouse.Visible = true;
                    cbWarehouse.Visible = true;
                    lblPassword.Visible = false;
                    lblUser.Visible = false;
                    txtPassword.Visible = false;
                    txtUserName.Visible = false;
                    cbWarehouse.SelectedValue = WarehouseID;
                }
            }

        }


        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (cbWarehouse.Visible)
            {
                cbWarehouse_DropDownClosed(sender, e);
                Close();
            }
            else
            {
                ValidatePassword();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                ValidatePassword();
            }
        }

        private void ValidatePassword()
        {
            lblWarehouse.Visible = false;
            cbWarehouse.Visible = false;

            DataSet ds = WS.ValidateUser(txtUserName.Text, txtPassword.Text);

            if (ds.Tables[0].Rows.Count > 1)
            {
                UserID = int.Parse(ds.Tables[0].Rows[0]["UserID"].ToString());

                WarehouseName = ds.Tables[0].Rows[0]["WarehouseName"].ToString();

                cbWarehouse.DataSource = ds.Tables[0];
                cbWarehouse.ValueMember = "Warehouse_ID";
                cbWarehouse.DisplayMember = "WarehouseName";

                lblWarehouse.Visible = true;
                cbWarehouse.Visible = true;
                WarehouseID = int.Parse(cbWarehouse.SelectedValue.ToString());

                DataSet cp = WS.GetWarehouseDetail(WarehouseID);
                CompanyID = int.Parse(cp.Tables[0].Rows[0]["Company_ID"].ToString());

                
            }
            else if (ds.Tables[0].Rows.Count == 1)
            {
                UserID = int.Parse(ds.Tables[0].Rows[0]["UserID"].ToString());
                WarehouseID = int.Parse(ds.Tables[0].Rows[0]["Warehouse_ID"].ToString());

                DataSet cp = WS.GetWarehouseDetail(WarehouseID);
                CompanyID = int.Parse(cp.Tables[0].Rows[0]["Company_ID"].ToString());

//                CompanyID = int.Parse(ds.Tables[0].Rows[0]["Company_ID"].ToString());

                WarehouseName = ds.Tables[0].Rows[0]["WarehouseName"].ToString();

                Close();
            }
            else
            {
                MessageBox.Show("The username or password was incorrect.");
            }

        }

        private void cbWarehouse_DropDownClosed(object sender, EventArgs e)
        {
            WarehouseID = int.Parse(cbWarehouse.SelectedValue.ToString());
            WarehouseName = cbWarehouse.Text;
            DataSet cp = WS.GetWarehouseDetail(WarehouseID);
            CompanyID = int.Parse(cp.Tables[0].Rows[0]["Company_ID"].ToString());

        }


    }
}
