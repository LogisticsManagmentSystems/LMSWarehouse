using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LMSWarehouse
{
    public partial class FrmItemDetail : Form
    {
        int WarehouseID;
        int CompanyID;
        int Bin_ID;
        int Product_ID;
        string ORderReference;
        string BarCode;
        private Wrapper WS = new Wrapper();

        public FrmItemDetail(int fCompanyID, int fWarehouseID,int fBin_ID, int fProduct_ID,string fOrderReference)
        {
            BarCode = "";
            ORderReference = fOrderReference;
            CompanyID = fCompanyID;
            WarehouseID = fWarehouseID;
            Bin_ID = fBin_ID;
            Product_ID = fProduct_ID;
            InitializeComponent();
        }

        private void ItemDetail_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void LoadData()
        {
            DataSet ds = WS.GetBinItems(Bin_ID, Product_ID, BarCode, ORderReference);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dgItems.DataSource = ds.Tables[0];
            }
        }




        private void dgItems_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = WS.GetItemDetail(int.Parse(dgItems.CurrentRow.Cells["Item_ID"].Value.ToString()));
                txtBarcode.Text = ds.Tables[0].Rows[0]["ItemBarCode"].ToString();
                txtSKU.Text = ds.Tables[0].Rows[0]["SKU"].ToString();
                txtDescription.Text = ds.Tables[0].Rows[0]["ProductDescription"].ToString();
                txtqty.Text = ds.Tables[0].Rows[0]["ItemQty"].ToString();
                txtStatus.Text = ds.Tables[0].Rows[0]["BinDescription"].ToString();
                txtWeight.Text = ds.Tables[0].Rows[0]["Weight"].ToString();
                txtPODate.Text = ds.Tables[0].Rows[0]["DatePO"].ToString();
                txtPONumber.Text = ds.Tables[0].Rows[0]["POrderReference"].ToString();
                txtSODate.Text = ds.Tables[0].Rows[0]["DateSO"].ToString();
                txtSONumber.Text = ds.Tables[0].Rows[0]["SOrderReference"].ToString();
                txtAddressName.Text = ds.Tables[0].Rows[0]["AddressName"].ToString();
                txtAddress1.Text = ds.Tables[0].Rows[0]["Address1"].ToString();
                txtAddress2.Text = ds.Tables[0].Rows[0]["Address2"].ToString();
                txtAddress3.Text = ds.Tables[0].Rows[0]["Address3"].ToString();
                txtAddress4.Text = ds.Tables[0].Rows[0]["Address4"].ToString();
                txtPostalCode.Text = ds.Tables[0].Rows[0]["PostalCode"].ToString();
//                txtSKU.Text = ds.Tables[0].Rows[0]["Batch"].ToString();
//                txtSKU.Text = ds.Tables[0].Rows[0]["DateBatch"].ToString();
                DataSet dt = WS.GetItemTrack(int.Parse(dgItems.CurrentRow.Cells["Item_ID"].Value.ToString()));
                if (dt.Tables[0].Rows.Count > 0)
                {
                    dgItemTrack.DataSource = dt.Tables[0];
                }
            }
            catch
            {
                //Do nothing
            }

        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            if (cbFilter.Text == "Bin")
            {
                Bin_ID = 0;
                ORderReference = "";
                BarCode = "";
                int.TryParse(toolStriptxtSearch.Text, out Bin_ID);                
            }
            if (cbFilter.Text == "Item")
            {
                Bin_ID = 0;
                ORderReference = "";
                BarCode = toolStriptxtSearch.Text;
            }
            if (cbFilter.Text == "Order")
            {
                Bin_ID = 0;
                ORderReference = toolStriptxtSearch.Text;
                BarCode = "";
            }
            LoadData();

        }
    }
}
