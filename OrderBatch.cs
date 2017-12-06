using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMSWarehouse
{
    public partial class OrderBatch : Form
    {


        int ProductID;
        int QTY;
        string SKU;
        string BatchBarCode;
        int OrderDetail;
        public int QTYRec;
        
        private Wrapper WS = new Wrapper(); 

        public OrderBatch(int fProductID,int fQTY, string fSKU, int fOrderDetail)
        {
            ProductID = fProductID;
            InitializeComponent();
            BatchBarCode = "";
            QTY = fQTY;
            SKU = fSKU;
            OrderDetail = fOrderDetail;
            QTYRec = 0;
        }

        private void LoadBatches()
        {
            DataSet ds = WS.GetStockOrderBatch(ProductID, BatchBarCode);
            for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
            {
                lbBatches.Items.Add(ds.Tables[0].Rows[x]["BarCode"].ToString());
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                BatchBarCode = ds.Tables[0].Rows[0]["BarCode"].ToString();
                txtHeight.Text = ds.Tables[0].Rows[0]["Height"].ToString();
                txtLength.Text = ds.Tables[0].Rows[0]["Length"].ToString();
                txtWidth.Text = ds.Tables[0].Rows[0]["Width"].ToString();
                txtWeight.Text = ds.Tables[0].Rows[0]["Weight"].ToString();
                txtParts.Text = ds.Tables[0].Rows[0]["NumberOfParts"].ToString();
                txtBarcode.Text = BatchBarCode;
            }
            else
            {
                BatchBarCode = "";
                txtHeight.Text = "0";
                txtLength.Text = "0";
                txtWidth.Text = "0";
                txtWeight.Text = "0";
                txtParts.Text = "1";
                txtBarcode.Text = SKU;  
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
            txtBarcode.Text = SKU;            
        }

        private void tsEditOrder_Click(object sender, EventArgs e)
        {
            if (ValidateBatch())
            {
                try
                {
                    //WS.SetStockOrderBatch(ProductID, SKU, Convert.ToInt32(double.Parse(txtLength.Text)),
                    //    Convert.ToInt32(double.Parse(txtWidth.Text)), Convert.ToInt32(double.Parse(txtHeight.Text)),
                    //    double.Parse(txtWeight.Text), 0.0, int.Parse(txtParts.Text), txtBarcode.Text,
                    //    DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd")));
                    WS.SetStockOrderBatchLink(ProductID, txtBarcode.Text, OrderDetail, int.Parse(txtQty.Text));

                    //change this later on...
                    lblScanned.Text = (int.Parse(lblScanned.Text) + int.Parse(txtQty.Text)).ToString();
                    QTYRec = int.Parse(lblScanned.Text);
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

        private void OrderBatch_Load(object sender, EventArgs e)
        {
            //Change this to be optional
            txtQty.Text = QTY.ToString();
            lblQty.Text = QTY.ToString();
            lblScanned.Text = "0";
            LoadBatches();

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
                if ((CheckValue > 0)&&(Result))
                {
                    Result = true;
                }
                else
                {
                    Result = false;
                }
                CheckValue = double.Parse(txtWidth.Text);
                if ((CheckValue > 0)&&(Result))
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
                if ((CheckValue > 0)&&(Result))
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




    }
}
