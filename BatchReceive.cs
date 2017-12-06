using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMSWarehouse
{
    public partial class FrmBatchReceive : Form
    {

        int ProductID;
        int QTY;
        string SKU;
        string BatchBarCode;
        int OrderDetail;
        public int QTYRec;

        private Wrapper WS = new Wrapper();

        public FrmBatchReceive(int fProductID,int fQTY, string fSKU, int fOrderDetail)
        {
            InitializeComponent();
            ProductID = fProductID;            
            BatchBarCode = "";
            QTY = fQTY;
            SKU = fSKU;
            OrderDetail = fOrderDetail;
            QTYRec = 0;
            LoadData();
        }


        public void LoadData()
        {
            DataSet dp = WS.GetProductBatches(ProductID);
            dgBatches.DataSource = dp.Tables[0];


            DataSet dt = WS.GetProductDims(ProductID);
            cbDimms.DataSource = dt.Tables[0];
            cbDimms.ValueMember = "Dimms_ID";
            cbDimms.DisplayMember = "Dimmsdescription";            

            //DataSet dt = WS.GetProductDims(ProductID);
            //cbDimms.DataSource = dt.Tables[0];
            //cbDimms.ValueMember = "Dimms_ID";
            //cbDimms.DisplayMember = "Dimmsdescription";
                        
        }




        private void tsEditOrder_Click(object sender, EventArgs e)
        {
            if (ValidateBatch())
            {
                try
                {
                    WS.SetStockOrderBatch(ProductID, SKU, Convert.ToInt32(double.Parse(txtLength.Text)),
                        Convert.ToInt32(double.Parse(txtWidth.Text)), Convert.ToInt32(double.Parse(txtHeight.Text)),
                        double.Parse(txtWeight.Text), 0.0, int.Parse(txtParts.Text), txtBarcode.Text,
                        DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd")),dtExpiry.Value,dtManufacture.Value);
                    WS.SetStockOrderBatchLink(ProductID, txtBarcode.Text, OrderDetail, int.Parse(txtQty.Text));

                    //change this later on...
                    //lblScanned.Text = (int.Parse(lblScanned.Text) + int.Parse(txtQty.Text)).ToString();
                    //QTYRec = int.Parse(lblScanned.Text);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not add batch. All data must be filled in" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Dimms and weight must be filld in.");
            }
        }

        private void tdBtnNewOrder_Click(object sender, EventArgs e)
        {
            BatchBarCode = "";
            txtHeight.Text = "0";
            txtLength.Text = "0";
            txtWidth.Text = "0";
            txtWeight.Text = "0";
            txtParts.Text = "1";
            txtBarcode.Text = DateTime.Now.ToString("yyyyMMdd"); ;
            dtExpiry.Text = "";
            dtManufacture.Text = "";
            dtExpiry.Text = "";
            EnableBatch();

        }

        private void EnableBatch()
        {
            cbDimms.Enabled = true;           
            txtHeight.Enabled = true;
            txtLength.Enabled = true;
            txtWidth.Enabled = true;
            txtWeight.Enabled = true;
            txtParts.Enabled = true;
            txtBarcode.Enabled = true;
            dtExpiry.Enabled = true;
            dtManufacture.Enabled = true;
            dtExpiry.Enabled = true;
        }

        private void DisableBatch()
        {
            cbDimms.Enabled = false;
            txtHeight.Enabled = false;
            txtLength.Enabled = false;
            txtWidth.Enabled = false;
            txtWeight.Enabled = false;
            txtParts.Enabled = false;
            txtBarcode.Enabled = false;
            dtExpiry.Enabled = false;
            dtManufacture.Enabled = false;
            dtExpiry.Enabled = false;
        }


        private bool ValidateBatch()
        {
            bool Result = false;
            try
            {
                double CheckValue = 0;

                CheckValue = double.Parse(txtHeight.Text);
                if (CheckValue > 0)
                {
                    Result = true;
                }
                else
                {
                    Result = false;
                }
                CheckValue = double.Parse(txtLength.Text);
                if ((CheckValue > 0) && (Result))
                {
                    Result = true;
                }
                else
                {
                    Result = false;
                }
                CheckValue = double.Parse(txtWidth.Text);
                if ((CheckValue > 0) && (Result))
                {
                    Result = true;
                }
                else
                {
                    Result = false;
                }
                CheckValue = double.Parse(txtWeight.Text);
                if ((CheckValue > 0) && (Result))
                {
                    Result = true;
                }
                else
                {
                    Result = false;
                }
                CheckValue = double.Parse(txtParts.Text);
                if ((CheckValue > 0) && (Result))
                {
                    Result = true;
                }
                else
                {
                    Result = false;
                }
            }
            catch
            {
                Result = false;
            }
            return Result;

        }

        private void cbDimms_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                DataSet dt = WS.GetDimDetails(int.Parse(cbDimms.SelectedValue.ToString()));
                txtHeight.Text = dt.Tables[0].Rows[0]["height"].ToString();
                txtLength.Text = dt.Tables[0].Rows[0]["length"].ToString();
                txtWidth.Text = dt.Tables[0].Rows[0]["width"].ToString();
                txtWeight.Text = dt.Tables[0].Rows[0]["weight"].ToString();

            }
            catch
            {
                MessageBox.Show("No Dimms selected");
            }



        }

        private void dgBatches_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtBarcode.Text = dgBatches.SelectedRows[0].Cells["Barcode"].Value.ToString();
                txtHeight.Text = dgBatches.SelectedRows[0].Cells["Height"].Value.ToString();
                txtLength.Text = dgBatches.SelectedRows[0].Cells["Length"].Value.ToString();
                txtWidth.Text = dgBatches.SelectedRows[0].Cells["Width"].Value.ToString(); 
                txtWeight.Text = dgBatches.SelectedRows[0].Cells["Height"].Value.ToString(); 
                txtParts.Text = "1";

                dtExpiry.Text = dgBatches.SelectedRows[0].Cells["DateExpiry"].Value.ToString(); 
                dtManufacture.Text = dgBatches.SelectedRows[0].Cells["DateManufacturer"].Value.ToString();
                DisableBatch();

            }
            catch
            {

            }
        }
    }
}
