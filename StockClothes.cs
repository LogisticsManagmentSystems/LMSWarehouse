using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMSWarehouse
{
    public partial class FrmStockClothes : Form
    {
        private int CompanyID;
        private Wrapper WS = new Wrapper();

        public FrmStockClothes(int fCompanyID)
        {
            CompanyID = fCompanyID;
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSKU.Text.Length > 3)
            {
                try
                {

                    WS.SetClothing(CompanyID, txtSKU.Text);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not create clothing group. " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("SKU Not Valid.");
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtSKU.Text.Length > 3)
            {
                try
                {
                    WS.DeleteClothing(CompanyID, txtSKU.Text);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not delete clothing groups. " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("SKU Not Valid.");
            }
        }
    }
}
