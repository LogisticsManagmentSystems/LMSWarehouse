using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.IO;
using Microsoft.Win32;

using System.Data.Sql;
using System.Data.SqlClient;
using System.Media;

namespace LMSWarehouse
{
    public partial class frmDispatchItems : Form
    {

        private int CompanyID;
        private int WarehouseID;
        private int OrderID;
        private string OrderNum;
        private int StockOrderID;
        private Wrapper WS = new Wrapper();
        private bool Exported = false;


        SoundPlayer spDuplicate;
        SoundPlayer spAccept;
        SoundPlayer spInvalid;


        public frmDispatchItems(int fCompany, int fWarehouse, int fStockOrderID, string fReference)
        {
            CompanyID = fCompany;
            WarehouseID = fWarehouse;
            OrderID = 0;
            StockOrderID = fStockOrderID;
            OrderNum = fReference;

            InitializeComponent();
        }


        public void LoadOrder(string OrderNo)
        {
            //gbDetail.Visible = false;
            DataSet ds = WS.GetStockDetailReference(OrderNo);
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

                if (OrderID == 0)
                {
                    //Why do this? Should it not raise an exception?
                    DataSet dds = WS.SetDispOrder(OrderID, WarehouseID, 1, int.Parse(cbCustomer.SelectedValue.ToString()), OrderNum, CompanyID,
                        txtPAddressName.Text, txtPAddress1.Text, txtPAddress2.Text, txtPAddress3.Text, txtPAddress4.Text, txtPPostal.Text,
                        txtDAddressName.Text, txtDAddress1.Text, txtDAddress2.Text, txtDAddress3.Text, txtDAddress4.Text, txtDPostal.Text,
                        txtShipperRef.Text, txtCustRef.Text, txtSpecialInstruction.Text, 1, 1);
                    OrderID = int.Parse(dds.Tables[0].Rows[0]["DispOrder_ID"].ToString());
                }

                DataSet dl = WS.GetExportData(StockOrderID);
                for (int x = 0; x < dl.Tables[0].Rows.Count; x++)
                {
                    lbItems.Items.Add(dl.Tables[0].Rows[x]["ItemBarCode"].ToString());
                }

                DataSet pc = WS.GetDispParcel(OrderID);
                for (int x = 0; x < pc.Tables[0].Rows.Count; x++)
                {
                    lbScanned.Items.Add(pc.Tables[0].Rows[x]["BarCode"].ToString());
                    lbItems.Items.Remove(pc.Tables[0].Rows[x]["BarCode"].ToString());
                }

                lblQty.Text = lbItems.Items.Count.ToString();
                lblCount.Text = lbScanned.Items.Count.ToString();

                txtScan.Focus();

                //DataSet pc = WS.GetDispParcel(OrderID);
                //dgParcels.DataSource = pc.Tables[0];

            }
        }

        private void gbDetail_Enter(object sender, EventArgs e)
        {

        }

        private void btnSaveParcel_Click(object sender, EventArgs e)
        {

        }

        private void frmDispatchItems_Load(object sender, EventArgs e)
        {
            LoadOrder(OrderNum);
            try
            {
                spDuplicate = new SoundPlayer(@"C:\LMSWarehouse\_duplicate.wav");
                spAccept = new SoundPlayer(@"C:\LMSWarehouse\_Accept.wav");
                spInvalid = new SoundPlayer(@"C:\LMSWarehouse\_Unknown.wav");
            }
            catch
            {
                MessageBox.Show("Sound files are not installed properly");
            }

            DataSet dP = GetOrderLabels(OrderNum);
            if (dP.Tables[0].Rows.Count > 0)
            {
                Exported = true;
            }
        }

        private void tsBtnPrint_Click(object sender, EventArgs e)
        {
            PrintLabels(OrderNum);
        }


        private void PrintLabels(string OrderNum)
        {

            DataSet dP = GetOrderLabels(OrderNum);

            if (dP.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No data in Courier Logistics system for this order");
                return;
            }

            RegistryKey registry = Registry.LocalMachine.CreateSubKey("SOFTWARE\\logidata");
            string vLablePrn = registry.GetValue("LablePrn").ToString();
             

            for (int i = 0; i < dP.Tables[0].Rows.Count; i++)
            {



                StreamWriter SW;
                SW = File.CreateText("c:\\logidata\\temp\\PrintJob" + i.ToString() + ".dat");

                SW.WriteLine("L");
                SW.WriteLine("H30");
                SW.WriteLine("PR");
                SW.WriteLine("D11");
                SW.WriteLine("1X1100002200030P0010001008700300087029002200290");
                SW.WriteLine("191100202500030Service");
                SW.WriteLine("121200502300030" + dP.Tables[0].Rows[i]["Service"].ToString());
                SW.WriteLine("191100202500165Route");
                SW.WriteLine("121200502300165" + dP.Tables[0].Rows[i]["Route"].ToString());
                SW.WriteLine("191100202500080Reference No");
                SW.WriteLine("121200502300080" + dP.Tables[0].Rows[i]["CorderNo"].ToString());
                SW.WriteLine("121100600570340CITY");
                SW.WriteLine("121100400450322DELIVERIES");
                SW.WriteLine("121100400330325LOGISTICS");
                SW.WriteLine("111100100230318(031) 580-2800");
                SW.WriteLine("191100601900032Deliver To:");
                SW.WriteLine("191100301700035" + dP.Tables[0].Rows[i]["DName"].ToString());
                SW.WriteLine("191100201500035" + dP.Tables[0].Rows[i]["Adres1"].ToString());
                SW.WriteLine("191100201300035" + dP.Tables[0].Rows[i]["Adres2"].ToString());
                SW.WriteLine("191100301100035" + dP.Tables[0].Rows[i]["Town"].ToString());
                SW.WriteLine("191100300900035" + dP.Tables[0].Rows[i]["PCode"].ToString() + " - Ref:" + dP.Tables[0].Rows[i]["CustRef"].ToString() + "");
                SW.WriteLine("191100400700050From : " + dP.Tables[0].Rows[i]["From"].ToString());

                SW.WriteLine("191100201600300" + DateTime.Now.ToString("dd/M/yy HH:m"));
                SW.WriteLine("191100201450300Dimms: " + dP.Tables[0].Rows[i]["PH"].ToString() + "x" + dP.Tables[0].Rows[i]["PW"].ToString() + "x" + dP.Tables[0].Rows[i]["PL"].ToString());
                SW.WriteLine("191100201300300Weight: " + dP.Tables[0].Rows[i]["Weight"].ToString());
                SW.WriteLine("191100502000300" + (i + 1).ToString() + " of " + dP.Tables[0].Rows.Count.ToString());
                SW.WriteLine("1e1304000200030" + dP.Tables[0].Rows[i]["Barcode"].ToString());
                SW.WriteLine("191100200050030" + dP.Tables[0].Rows[i]["Barcode"].ToString());
                SW.WriteLine("191100100000310Printed by LogiData");
                SW.WriteLine("E");


                SW.Close();

                try
                {


                    System.Diagnostics.ProcessStartInfo sinf = new System.Diagnostics.ProcessStartInfo("cmd", @"/c copy c:\\logidata\\temp\\printjob" + i.ToString() + ".dat " + vLablePrn);
                    sinf.RedirectStandardOutput = true;
                    sinf.UseShellExecute = false;
                    sinf.CreateNoWindow = true;
                    System.Diagnostics.Process p = new System.Diagnostics.Process();
                    p.StartInfo = sinf;
                    p.Start();

                    SW.Dispose();
                    System.Threading.Thread.Sleep(1000);

                }
                catch (System.Exception)
                {
                    MessageBox.Show("Printer not available");
                }


            }
        }

        public static DataSet GetOrderLabels(string OrderNum)
        {
            //SqlConnection myconnection = new SqlConnection(constring);
            SqlConnection myconnection = new SqlConnection("Password=mosselbaai;Persist Security Info=True;Connect Timeout=2400;User ID=christocc;Initial Catalog=logidatacc;Data Source=41.185.18.34,1444;");
            SqlDataAdapter da = new SqlDataAdapter("[getParcelDedColibri]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@OrderNo ", OrderNum);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;

        }

        private void btnPost_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonExport_Click(object sender, EventArgs e)
        {
            Utils ut = new Utils();
            MessageBox.Show(ut.ExportLogidata(StockOrderID));
            Exported = true;
        }

        private void tsBtnLookup_Click(object sender, EventArgs e)
        {

        }

        private void txtScan_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (Exported)
                {
                    if (lbItems.Items.Contains(txtScan.Text))
                    {
                        DataSet ds = WS.SetDispParcel(txtScan.Text, OrderID, double.Parse(txtWeight.Text), double.Parse(txtHeight.Text),
                        double.Parse(txtWidth.Text), double.Parse(txtLength.Text));
                        gbDetail.BackColor = Color.LightGreen;
                        lblStatus.Text = "Good Scan";
                        lbScanned.Items.Add(txtScan.Text);
                        lbItems.Items.Remove(txtScan.Text);
                        txtScan.Text = "";
                        spAccept.Play();
                    }
                    else if (lbItems.Items.Contains(txtScan.Text))
                    {
                        gbDetail.BackColor = Color.LightGoldenrodYellow;
                        lblStatus.Text = "Duplicate Scan";
                        txtScan.Text = "";
                        spDuplicate.Play();
                    }
                    else
                    {
                        gbDetail.BackColor = Color.LightPink;
                        lblStatus.Text = "Not Valid for this order";
                        txtScan.Text = "";
                        spInvalid.Play();
                    }
                    lblQty.Text = lbItems.Items.Count.ToString();
                    lblCount.Text = lbScanned.Items.Count.ToString();
                }
                else
                {
                    MessageBox.Show("No data in Courier Logistics system for this order.\n Please export data to courier.");
                }
            }
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
