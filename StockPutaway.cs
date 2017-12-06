using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMSWarehouse
{
    public partial class FrmStockPutaway : Form
    {
        int WarehouseID;
        private struct StockItem
        {
            public int packsize, Product_ID, Bin_ID, Qty;
            public string BarCode, SKU, ProductDescription, BinDescription;
        }
        private StockItem Item;
        private Wrapper WS = new Wrapper();

        public FrmStockPutaway(int fWarehouseID)
        {
            WarehouseID = fWarehouseID;
            InitializeComponent();
            ResetItem();
        }

        private void ResetItem()
        {
            Item.Bin_ID = 0;
            Item.packsize = 0;
            Item.Product_ID = 0;
            Item.ProductDescription = "";
            Item.Qty = 0;
            Item.SKU = "";
            Item.BinDescription = "";
            Item.BarCode = "";

            txtBin.Text = Item.Bin_ID.ToString();
            txtLabel.Text = Item.SKU;
            txtPacksize.Text = Item.packsize.ToString();
            txtScan.Text = "";
            lblBinLocation.Text = "Scan Bin BarCode";
            lblStockItem.Text = "Scan Bin Stock Label";


            txtBin.Focus();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBin_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtBin_KeyUp(object sender, KeyEventArgs e)
        {            
            if (e.KeyValue == 13)
                if (int.TryParse(txtBin.Text, out Item.Bin_ID))
                {
                    DataSet ds = WS.GetBinBarCode(int.Parse(txtBin.Text));
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        Item.BinDescription = ds.Tables[0].Rows[0]["Description"].ToString();
                        lblBinLocation.Text = Item.BinDescription;
                        txtLabel.Focus();
                    }
                    else
                    {
                        MessageBox.Show("This Bin location was not found");
                    }

                }
                else
                {
                    MessageBox.Show("The Barcode is invalid for a Bin location");
                }


            //MessageBox.Show(e.KeyValue.ToString());            
            //MessageBox.Show(e.KeyCode.ToString());
            //MessageBox.Show(e.KeyData.ToString());
        }

        private void txtLabel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                DataSet ds = WS.GetStockLabel(txtLabel.Text);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Item.packsize = int.Parse(ds.Tables[0].Rows[0]["PackSize"].ToString());
                    Item.Product_ID = int.Parse(ds.Tables[0].Rows[0]["Product_ID"].ToString());
                    Item.ProductDescription = ds.Tables[0].Rows[0]["ProductDescription"].ToString();
                    Item.SKU = ds.Tables[0].Rows[0]["SKU"].ToString();
                    Item.BarCode = ds.Tables[0].Rows[0]["BarCode"].ToString(); ;
                    Item.Qty = 0;

                    lblStockItem.Text = Item.SKU + " - " + Item.ProductDescription;
                    txtPacksize.Text = Item.packsize.ToString();
                    txtQty.Text = "";
                    
                    txtScan.Focus();
                }
                else
                {
                    txtScan.Clear();
                    MessageBox.Show("This StockItem was not found");
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtScan_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {                
                if (txtScan.Text.Trim() == Item.BarCode.Trim())
                {
                    lbStock.Items.Add(lblStockItem.Text + " - " + txtPacksize.Text + " Items allocated");
                    Item.Qty = Item.Qty + Item.packsize;
                    txtQty.Text = Item.Qty.ToString();

                    txtScan.Clear();
                    txtScan.Focus();
                }
                else
                {
                    MessageBox.Show("This StockItem was not found");
                }

            }

        }
    }
}
