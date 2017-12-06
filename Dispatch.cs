using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LMSWarehouse
{
    public partial class Dispatch : Form
    {

        private int CompanyID;
        private int WarehouseID;
        private int OrderID;
        //private string OrderType;
        private Wrapper WS = new Wrapper();

        public Dispatch(int fCompany, int fWarehouse)
        {
            CompanyID = fCompany;
            WarehouseID = fWarehouse;
            OrderID = 0;
            
            //OrderType = fOrderType;
            InitializeComponent();
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {

        }

        private void btnPost_Click(object sender, EventArgs e)
        {
             Fedex.SupaTask FD = new Fedex.SupaTask();
             DataSet dp = WS.GetDispParcel(OrderID);
             DataSet ds = WS.GetStockDetailReference(txtLookup.Text);
             string result = "";
             for (int x = 0; x < dp.Tables[0].Rows.Count; x++)

             {//Fix up Value and Phone
                 
                 result = FD.CaptureParcel(dp.Tables[0].Rows[x]["BarCode"].ToString(), txtLookup.Text,
                     "6012649", txtCustRef.Text, "S1", ds.Tables[0].Rows[0]["DAddressName"].ToString(),
                     ds.Tables[0].Rows[0]["DAddress1"].ToString(), ds.Tables[0].Rows[0]["DAddress2"].ToString(),
                     ds.Tables[0].Rows[0]["DAddress3"].ToString(), ds.Tables[0].Rows[0]["DAddress4"].ToString(),
                     ds.Tables[0].Rows[0]["DPostalCode"].ToString(), "ZA",
                     ds.Tables[0].Rows[0]["CelNr"].ToString(), 
                     "07",
                     double.Parse(dp.Tables[0].Rows[0]["Weight"].ToString()),double.Parse(dp.Tables[0].Rows[0]["Length"].ToString()),
                     double.Parse(dp.Tables[0].Rows[0]["Width"].ToString()), double.Parse(dp.Tables[0].Rows[0]["Height"].ToString()),
                     500, DateTime.Now, false, 1, 1, "NA",
                     ds.Tables[0].Rows[0]["PAddressName"].ToString(), ds.Tables[0].Rows[0]["PAddress1"].ToString(), 
                     ds.Tables[0].Rows[0]["PAddress2"].ToString(), ds.Tables[0].Rows[0]["PAddress3"].ToString(),
                     ds.Tables[0].Rows[0]["PAddress4"].ToString(), ds.Tables[0].Rows[0]["PPostalCode"].ToString(), "ZA",
                     ds.Tables[0].Rows[0]["CelNr"].ToString(), false, false);

             }

             MessageBox.Show(result);

        }

        private void tsBtnLookup_Click(object sender, EventArgs e)
        {
            gbAddDetail.Visible = false;
            DataSet ds = WS.GetStockDetailReference(txtLookup.Text);
            if (ds.Tables[0].Rows.Count > 0)
            {
                string Ctype = "";
                //OrderType = "Sale";
                if (ds.Tables[0].Rows[0]["OrderType"].ToString().ToUpper() == "PURCHASE")
                {
                    Ctype = "Sup";
                    //OrderType = "Purchase";
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
                OrderID = int.Parse(ds.Tables[0].Rows[0]["DispOrder_ID"].ToString());
                DataSet pc = WS.GetDispParcel(OrderID);
                dgParcels.DataSource = pc.Tables[0];

            }
        }


        private void tsBtnAddParcel_Click(object sender, EventArgs e)
        {
            DataSet ds = WS.SetDispOrder(OrderID, WarehouseID, 1, int.Parse(cbCustomer.SelectedValue.ToString()), txtLookup.Text, CompanyID,
                txtPAddressName.Text, txtPAddress1.Text, txtPAddress2.Text, txtPAddress3.Text, txtPAddress4.Text, txtPPostal.Text,
                txtDAddressName.Text, txtDAddress1.Text, txtDAddress2.Text, txtDAddress3.Text, txtDAddress4.Text, txtDPostal.Text,
                txtShipperRef.Text, txtCustRef.Text, txtSpecialInstruction.Text, 1, 1);
            OrderID = int.Parse(ds.Tables[0].Rows[0]["DispOrder_ID"].ToString());

            DataSet pc = WS.GetDispParcel(OrderID);
            dgParcels.DataSource = pc.Tables[0];
            gbAddDetail.Visible = true;
        }


        private void btnSaveParcel_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < int.Parse(txtNumOfPcls.Text);x++)
            {
                DataSet ds = WS.SetDispParcel(OrderID, double.Parse(txtWeight.Text), double.Parse(txtHeight.Text),
                    double.Parse(txtWidth.Text), double.Parse(txtLength.Text));
            }

            DataSet pc = WS.GetDispParcel(OrderID);
            dgParcels.DataSource = pc.Tables[0];
        }

        private void tsBtnPrint_Click(object sender, EventArgs e)
        {
            DataSet pc = WS.GetDispParcel(OrderID);
            for (int x = 0; x < pc.Tables[0].Rows.Count; x++)
            {

                //qty = qty.PadLeft(4,'0');
                StreamWriter sw = new StreamWriter(@"c:\temp\label.txt", false);
                //StreamWriter sw = new StreamWriter(@"c:\label.txt", false);
                sw.WriteLine("@0");
                sw.WriteLine("ZS");
                sw.WriteLine("N");
                sw.WriteLine("q2483");
                sw.WriteLine("Q3507,36");
                sw.WriteLine("JB");
                sw.WriteLine("D10");
                sw.WriteLine("S2");
                sw.WriteLine("O");
                sw.WriteLine("B520,220,2,1,3,4,150,N,\"" + pc.Tables[0].Rows[x]["BarCode"].ToString() + "\"");
                sw.WriteLine("A725,30,2,1,1,1,N,\"Distributed by Sauce-ing (PTY) LTD - Printed by LMS\"");
                sw.WriteLine("X750,10,3,200,35");
                sw.WriteLine("A520,60,2,3,1,1,N,\"" + pc.Tables[0].Rows[x]["BarCode"].ToString() + "\"");
                sw.WriteLine("A750,550,2,3,1,2,N,\"TO:\"");
                sw.WriteLine("A750,515,2,2,1,2,N,\"" + txtDAddressName.Text + "\"");
                sw.WriteLine("A750,470,2,2,1,2,N,\"" + txtDAddress1.Text + "\"");
                sw.WriteLine("A750,435,2,2,1,2,N,\"" + txtDAddress2.Text + "\"");
                sw.WriteLine("A750,400,2,2,1,2,N,\"" + txtDAddress3.Text + "\"");
                sw.WriteLine("A750,365,2,2,1,2,N,\"" + txtDAddress4.Text + "\"");
                sw.WriteLine("A750,330,2,2,1,2,N,\"" + txtDPostal.Text + "\"");
                sw.WriteLine("A725,270,2,3,2,3,N,\"FED\"");
                sw.WriteLine("A725,180,2,3,2,4,N,\"FDX3\"");
                sw.WriteLine("X750,80,3,550,200");
                sw.WriteLine("A450,550,2,3,1,3,N,\"" + txtLookup.Text + "\"");
                sw.WriteLine("A450,470,2,3,1,2,N,\"Order Number:\"");
                sw.WriteLine("A450,435,2,2,1,2,N,\"" + txtLookup.Text + "\"");
                sw.WriteLine("A450,390,2,3,1,2,N,\"SENDER:\"");
                sw.WriteLine("A450,355,2,2,1,1,N,\"" + txtPAddressName.Text + "\"");
                sw.WriteLine("A450,335,2,2,1,1,N,\"" + txtPAddress1.Text + "\"");
                sw.WriteLine("A450,315,2,2,1,1,N,\"" + txtPAddress2.Text + "\"");
                sw.WriteLine("A450,295,2,2,1,1,N,\"" + txtPAddress3.Text + "\"");
                sw.WriteLine("A450,275,2,2,1,1,N,\"" + txtPAddress4.Text + "\"");
                sw.WriteLine("A450,255,2,2,1,1,N,\"" + txtPPostal.Text + "\"");
                sw.WriteLine("A700,75,2,3,2,2,N,\"" + pc.Tables[0].Rows[x]["RouteCode"].ToString() + "\"");
                //sw.WriteLine("A450,550,2,3,1,3,N,\"" + txtLookup.Text + "\"");
                //                sw.WriteLine("A750,150,2,4,1,2,N,\"PackSize : " + Item.packsize.ToString() + "\"");
                //sw.WriteLine("A750,100,2,1,1,1,N,\"" + Item.ProductExtraDescription + "\"");
                sw.WriteLine("P1," + 1 + "");
                sw.WriteLine("ZN");
                sw.Close();

                //Missing Tel, Route,Number of Parcels


                FileInfo f = new FileInfo(@"c:\temp\label.txt");
                //MessageBox.Show("\\\\warehouse\\labelprint");
                f.CopyTo("\\\\SI-JDHS1\\labelprint");
                //f.CopyTo("\\\\Si-Thami\\labelprint");
                //f.CopyTo("\\\\Si-Mike\\labelprint");
            }
        }
    }
}
