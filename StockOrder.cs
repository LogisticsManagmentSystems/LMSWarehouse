using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMSWarehouse
{
    public partial class FrmStockOrder : Form
    {

        private int CompanyID;
        private int WarehouseID;
        private int OrderID;
        private string OrderType;
        private int ProductID;
        private Wrapper WS = new Wrapper();

        public FrmStockOrder(int fCompany, int fWarehouse, int fOrderID, string fOrderType)
        {

            InitializeComponent();
            CompanyID = fCompany;
            WarehouseID = fWarehouse;
            OrderID = fOrderID;
            OrderType = fOrderType;
            ProductID = 0;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            bool AddOrder = true;
            DataSet Dcount = WS.CheckStockOrderReference(WarehouseID, txtReference.Text.Trim(), OrderType);
            if ((Dcount.Tables[0].Rows.Count > 0)&& (dgStockItems.RowCount == 0))
            {
                //if (MessageBox.Show("This order number have already being used. Are you sure you want to continue?",
                //    "Duplicate order number", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                //{
                //    AddOrder = false;
                //}
                MessageBox.Show("This order number have already being used.", "Duplicate order number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AddOrder = false;
            }

            if (AddOrder)
            {
                DataSet ds = WS.SetStockOrder(OrderID, WarehouseID, 1, int.Parse(cbCustomer.SelectedValue.ToString()),
                    txtReference.Text.Trim(), CompanyID, OrderType, txtPAddressName.Text, txtPAddress1.Text,
                    txtPAddress2.Text, txtPAddress3.Text, txtPAddress4.Text, txtPPostal.Text, txtDAddressName.Text, txtDAddress1.Text,
                    txtDAddress2.Text, txtDAddress3.Text, txtDAddress4.Text, txtDPostal.Text, txtShipperRef.Text, txtCustRef.Text, txtSpecialInstruction.Text);
                OrderID = int.Parse(ds.Tables[0].Rows[0]["StockOrder_ID"].ToString());
            }
            
            //MessageBox.Show(ds.Tables[0].Rows[0]["StockOrder_ID"].ToString());
        }

        private void toolStripBtnNewLine_Click(object sender, EventArgs e)
        {
            if (OrderID > 0)
            {
                PAddDetail.Visible = true;
                toolStripBottom.Visible = true;
            }
            else
            {
                MessageBox.Show("Order is not saved yet");
            }
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            LMSWarehouse.FrmProductLibrary FProduct = new FrmProductLibrary(CompanyID, WarehouseID);
            FProduct.ShowDialog();
            txtSKU.Text = FProduct.Prod.SKU;
            txtDescription.Text = FProduct.Prod.ProductDescription;
            ProductID = FProduct.Prod.Product_ID;
            txtQty.Focus();
        }

        private void txtSKU_Leave(object sender, EventArgs e)
        {
            if (txtSKU.Text.Length > 3)
            {
                txtSKU.Text = txtSKU.Text.ToUpper();
                DataSet ds = WS.GetProductDetail(0, txtSKU.Text, 0);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtDescription.Text = ds.Tables[0].Rows[0]["ProductDescription"].ToString();
                    ProductID = int.Parse(ds.Tables[0].Rows[0]["Product_ID"].ToString());
                }
                else
                {
                    txtDescription.Text = "";
                    txtSKU.Text = "";
                    ProductID = 0;
                }

            }
            else
            {
                ProductID = 0;
                txtDescription.Text = "";
            }
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            if (ProductID != 0)
            {
                if (txtAmount.Text.Trim() == "")
                {
                    txtAmount.Text = "0";
                }
                int qty = 0;
                double amount = 0;
                int.TryParse(txtQty.Text, out qty);
                if ((qty > 0) && (double.TryParse(txtAmount.Text, out amount)))
                {
                    txtAmount.Text = "";
                    txtSKU.Text = "";
                    txtQty.Text = "";
                    txtDescription.Text = "";
                    WS.SetStockDetail(OrderID, ProductID, qty, amount);
                    LoadGridData();                    
                }
                else
                {
                    MessageBox.Show("Qty or Amount is not valid.");
                }

            }
            else
            {
                MessageBox.Show("No valid product selectd.");
            }

        }

        private void FrmStockOrder_Load(object sender, EventArgs e)
        {
            if (OrderID == 0)
            {
                string Ctype = "";
                DataSet ds = WS.GetWarehouseDetail(WarehouseID);
                if (OrderType.ToUpper().Trim() == "PURCHASE")
                {
                    Ctype = "Sup";
                    toolStripButtonOnline.Visible = false;
                    lblPrimaryCustomer.Text = "Primary Supplier";
                    lblCustomer.Text = "Supplier";
                    txtDAddressName.Text = ds.Tables[0].Rows[0]["AddressName"].ToString();
                    txtDAddress1.Text = ds.Tables[0].Rows[0]["Address1"].ToString();
                    txtDAddress2.Text = ds.Tables[0].Rows[0]["Address2"].ToString();
                    txtDAddress3.Text = ds.Tables[0].Rows[0]["Address3"].ToString();
                    txtDAddress4.Text = ds.Tables[0].Rows[0]["Address4"].ToString();
                    txtDPostal.Text = ds.Tables[0].Rows[0]["PostalCode"].ToString();
                }                                    
                else
                {
                    Ctype = "Cust";
                    txtPAddressName.Text = ds.Tables[0].Rows[0]["AddressName"].ToString();
                    txtPAddress1.Text = ds.Tables[0].Rows[0]["Address1"].ToString();
                    txtPAddress2.Text = ds.Tables[0].Rows[0]["Address2"].ToString();
                    txtPAddress3.Text = ds.Tables[0].Rows[0]["Address3"].ToString();
                    txtPAddress4.Text = ds.Tables[0].Rows[0]["Address4"].ToString();
                    txtPPostal.Text = ds.Tables[0].Rows[0]["PostalCode"].ToString();
                }


                txtDate.Text = DateTime.Now.Date.ToString();
                DataSet dpc = WS.GetPrimaryCustomer(CompanyID, Ctype);
                cbPrimaryCustomer.DataSource = dpc.Tables[0];
                cbPrimaryCustomer.ValueMember = "PrimaryCustomer_ID";
                cbPrimaryCustomer.DisplayMember = "PrimaryCustomerName";
                try
                {
                    cbPrimaryCustomer.SelectedValue = int.Parse(dpc.Tables[0].Rows[0]["PrimaryCustomer_ID"].ToString());
                }
                catch
                {
                    MessageBox.Show("Primary customers and suppliers not set up for this company.");
                    Close();
                }
                DataSet dc = WS.GetCustomer(int.Parse(cbPrimaryCustomer.SelectedValue.ToString()));
                cbCustomer.DataSource = dc.Tables[0];
                cbCustomer.ValueMember = "Customer_ID";
                cbCustomer.DisplayMember = "CustomerName";
            }
            else
            {
                DataSet ds = WS.GetStockOrder(OrderID);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    string Ctype = "";
                    OrderType = "Sale";
                    if (ds.Tables[0].Rows[0]["OrderType"].ToString().ToUpper() == "PURCHASE")
                    {
                        Ctype = "Sup";
                        OrderType = "Purchase";
                    }
                    else
                    {
                        Ctype = "Cust";
                    }


                    DataSet dpc = WS.GetPrimaryCustomer(CompanyID, Ctype);
                    cbPrimaryCustomer.DataSource = dpc.Tables[0];
                    cbPrimaryCustomer.ValueMember = "PrimaryCustomer_ID";
                    cbPrimaryCustomer.DisplayMember = "PrimaryCustomerName";
                    try
                    {
                        cbPrimaryCustomer.SelectedValue = int.Parse(ds.Tables[0].Rows[0]["PrimaryCustomer_ID"].ToString());
                    }
                    catch
                    {
                        MessageBox.Show("Primary customers and suppliers not set up for this company.");
                        Close();
                    }
                    DataSet dc = WS.GetCustomer(int.Parse(cbPrimaryCustomer.SelectedValue.ToString()));
                    cbCustomer.DataSource = dc.Tables[0];
                    cbCustomer.ValueMember = "Customer_ID";
                    cbCustomer.DisplayMember = "CustomerName";
                    try
                    {
                        cbCustomer.SelectedValue = int.Parse(ds.Tables[0].Rows[0]["Customer_ID"].ToString());
                    }
                    catch
                    {
                        MessageBox.Show("Customers and suppliers not set up for this company.");
                        Close();
                    }

                    txtDAddressName.Text = ds.Tables[0].Rows[0]["DAddressName"].ToString();
                    txtDAddress1.Text = ds.Tables[0].Rows[0]["DAddress1"].ToString();
                    txtDAddress2.Text = ds.Tables[0].Rows[0]["DAddress2"].ToString();
                    txtDAddress3.Text = ds.Tables[0].Rows[0]["DAddress3"].ToString();
                    txtDAddress4.Text = ds.Tables[0].Rows[0]["DAddress4"].ToString();
                    txtDPostal.Text = ds.Tables[0].Rows[0]["DPostalCode"].ToString();
                    txtPAddressName.Text = ds.Tables[0].Rows[0]["PAddressName"].ToString();
                    txtPAddress1.Text = ds.Tables[0].Rows[0]["PAddress1"].ToString();
                    txtPAddress2.Text = ds.Tables[0].Rows[0]["PAddress2"].ToString();
                    txtPAddress3.Text = ds.Tables[0].Rows[0]["PAddress3"].ToString();
                    txtPAddress4.Text = ds.Tables[0].Rows[0]["PAddress4"].ToString();
                    txtPPostal.Text = ds.Tables[0].Rows[0]["PPostalCode"].ToString();
                    txtReference.Text = ds.Tables[0].Rows[0]["OrderReference"].ToString();
                    txtDate.Text = ds.Tables[0].Rows[0]["DateOrder"].ToString();
                    txtCustRef.Text = ds.Tables[0].Rows[0]["CustomerReference"].ToString();
                    txtShipperRef.Text = ds.Tables[0].Rows[0]["ShipperReference"].ToString();
                    txtSpecialInstruction.Text = ds.Tables[0].Rows[0]["SpecialInstructions"].ToString();


                    LoadGridData();
                }
            }
        }

        private void LoadGridData()
        {

            DataSet ds = WS.GetStockDetail(OrderID);
            dgStockItems.DataSource = ds.Tables[0];

        }

        private void cbPrimaryCustomer_DropDownClosed(object sender, EventArgs e)
        {
            DataSet dc = WS.GetCustomer(int.Parse(cbPrimaryCustomer.SelectedValue.ToString()));
            cbCustomer.DataSource = dc.Tables[0];
            cbCustomer.ValueMember = "Customer_ID";
            cbCustomer.DisplayMember = "CustomerName";
        }

        private void cbCustomer_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                DataSet dc = WS.GetCustomerDetail(int.Parse(cbCustomer.SelectedValue.ToString()));
                if (OrderType.ToUpper().Trim() == "PURCHASE")
                {
                    txtPAddressName.Text = dc.Tables[0].Rows[0]["AddressName"].ToString();
                    txtPAddress1.Text = dc.Tables[0].Rows[0]["Address1"].ToString();
                    txtPAddress2.Text = dc.Tables[0].Rows[0]["Address2"].ToString();
                    txtPAddress3.Text = dc.Tables[0].Rows[0]["Address3"].ToString();
                    txtPAddress4.Text = dc.Tables[0].Rows[0]["Address4"].ToString();
                    txtPPostal.Text = dc.Tables[0].Rows[0]["PostalCode"].ToString();
                }
                else
                {
                    txtDAddressName.Text = dc.Tables[0].Rows[0]["AddressName"].ToString();
                    txtDAddress1.Text = dc.Tables[0].Rows[0]["Address1"].ToString();
                    txtDAddress2.Text = dc.Tables[0].Rows[0]["Address2"].ToString();
                    txtDAddress3.Text = dc.Tables[0].Rows[0]["Address3"].ToString();
                    txtDAddress4.Text = dc.Tables[0].Rows[0]["Address4"].ToString();
                    txtDPostal.Text = dc.Tables[0].Rows[0]["PostalCode"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Customers and suppliers not set up for this company.");
                Close();
            }            


        }

        private void txtSKU_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtDescription.Focus();
            }
        }

        private void toolStripButtonOnline_Click(object sender, EventArgs e)
        {
            if (txtReference.Text.Trim() == "")
            {
                MessageBox.Show("Online Reference can not be empty");
            }
            else
            {
                DataSet ds = WS.GetOnlineOrder(txtReference.Text);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No Online Orders found for this reference.");
                }
                else
                {
                    DataSet du = WS.GetCustomerFromUserName(ds.Tables[0].Rows[0]["Fullname"].ToString());
                    if (du.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Could not find the Customer for this order");
                    }
                    else
                    {
                        try
                        {
                            cbCustomer.SelectedValue = int.Parse(du.Tables[0].Rows[0]["Customer_ID"].ToString());
                            cbCustomer_DropDownClosed(sender, e);
                            saveToolStripButton_Click(sender, e);
                            if (OrderID == 0)
                            {
                                MessageBox.Show("There is allready an order with this reference number");
                                return;
                            }
                            else
                            {
                                for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
                                {
                                    DataSet dr = WS.GetProductDetail(0, ds.Tables[0].Rows[x]["SKU"].ToString(), 0);
                                    if (dr.Tables[0].Rows.Count > 0)
                                    {
                                        ProductID = int.Parse(dr.Tables[0].Rows[0]["Product_ID"].ToString());
                                        int qty = 0;
                                        double amount = 0;
                                        int.TryParse(ds.Tables[0].Rows[x]["Qty"].ToString(), out qty);
                                        if ((qty > 0) && (double.TryParse(ds.Tables[0].Rows[x]["Amount"].ToString(), out amount)))
                                        {
                                            WS.SetStockDetail(OrderID, ProductID, qty, amount);                                            

                                        }
                                    }
                                }
                                LoadGridData();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Customers and suppliers not correct for this Order.");
                            return;
                        }

                    }

                }
            }

        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgStockItems.RowCount > 0)
                {
                    int LineItem = int.Parse(dgStockItems.CurrentRow.Cells["StockOrderDetail_ID"].Value.ToString());
                    string LineStatus = dgStockItems.CurrentRow.Cells["OrderStatus"].Value.ToString();

                    if (LineStatus.ToUpper() == "INDUCTED")
                    {
                        WS.DeleteStockOrderDetail(LineItem);
                        LoadGridData();
                    }
                    else
                    {
                        MessageBox.Show("Processing has already begun on this line and can not be deleted");
                    }

                }
                else
                {
                    MessageBox.Show("No line to delete");
                }
            }
            catch
            {
                MessageBox.Show("Error deleting order detail.");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            string Ctype = "";
            if (OrderType.ToUpper().Trim() == "PURCHASE")
            {
                Ctype = "Sup";
            }
            else
            {
                Ctype = "Cust";
            }

            LMSWarehouse.FrmCustomer FCust = new FrmCustomer(CompanyID, Ctype, int.Parse(cbPrimaryCustomer.SelectedValue.ToString()));
            FCust.ShowDialog();

            DataSet dc = WS.GetCustomer(int.Parse(cbPrimaryCustomer.SelectedValue.ToString()));
            cbCustomer.DataSource = dc.Tables[0];
            cbCustomer.ValueMember = "Customer_ID";
            cbCustomer.DisplayMember = "CustomerName";

            cbCustomer.SelectedValue = FCust.CustomerID;
            cbCustomer_DropDownClosed(sender, e);
            txtReference.Focus();
            //txtSKU.Text = FProduct.Prod.SKU;
            //txtDescription.Text = FProduct.Prod.ProductDescription;
            //ProductID = FProduct.Prod.Product_ID;
            //txtQty.Focus();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {

        }



    }
}
