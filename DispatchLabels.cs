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


namespace LMSWarehouse
{
    public partial class FrmDispatchLabels : Form
    {
        public static string constring = "Password=mosselbaai;Persist Security Info=True;Connect Timeout=2400;User ID=christocc;Initial Catalog=logidatacc;Data Source=41.185.18.34,1444;";
        
        public FrmDispatchLabels(int fCompanyID, int fWarehouseID)
        {
            InitializeComponent();
        }

        private void btnPrintLabels_Click(object sender, EventArgs e)
        {
            PrintLabels(txtOrder.Text);
        }


        public static DataSet GetOrderLabels(string OrderNum)
        {
            SqlConnection myconnection = new SqlConnection(constring);
            SqlDataAdapter da = new SqlDataAdapter("[getParcelDedColibri]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@OrderNo ", OrderNum);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;

        }

        private void PrintLabels(string OrderNum)
        {

            DataSet dP = GetOrderLabels(OrderNum);

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


    }
}
