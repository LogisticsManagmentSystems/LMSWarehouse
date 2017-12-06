using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace LMSWarehouse
{
    public partial class FrmStockLabelPrint : Form
    {
        int ProductID;
        private struct StockLabel
        {
            public int packsize, Product_ID;
            public string BarCode, SKU, BatchNo, ProductDescription,ProductExtraDescription;
            public DateTime DateLabel, DateExpiry;
        }
        private StockLabel Item;
        public int QtyPrint;
        private Wrapper WS = new Wrapper();

        public FrmStockLabelPrint(int fProduct)
        {
            ProductID = fProduct;
            QtyPrint = 1;
            InitializeComponent();
        }

        private void FStockLabelPrint_Load(object sender, EventArgs e)
        {
            DataSet ds = WS.GetStockLabelSKU(ProductID);
            dgStockLabel.DataSource = ds.Tables[0];
        }

        private void dgStockLabel_SelectionChanged(object sender, EventArgs e)
        {
            Item.packsize = int.Parse(dgStockLabel.CurrentRow.Cells["PackSize"].Value.ToString());
            Item.BarCode = dgStockLabel.CurrentRow.Cells["BarCode"].Value.ToString();
            Item.BatchNo = dgStockLabel.CurrentRow.Cells["BatchNum"].Value.ToString();
            //Item.DateExpiry = DateTime.Parse(dgStockLabel.CurrentRow.Cells["DateExpiry"].Value.ToString());
            //Item.DateLabel = DateTime.Parse(dgStockLabel.CurrentRow.Cells["DateReceive"].Value.ToString());
            Item.Product_ID = int.Parse(dgStockLabel.CurrentRow.Cells["Product_ID"].Value.ToString());
            Item.ProductDescription = dgStockLabel.CurrentRow.Cells["ProductDescription"].Value.ToString();
            Item.ProductExtraDescription = dgStockLabel.CurrentRow.Cells["ExtraDescription"].Value.ToString();
            Item.SKU = dgStockLabel.CurrentRow.Cells["SKU"].Value.ToString();

            txtCopies.Text = QtyPrint.ToString();
            txtBarCode.Text = Item.BarCode;
            txtDescription.Text = Item.ProductDescription;
            txtExDescription.Text = Item.ProductExtraDescription;
            txtPackSize.Text = Item.packsize.ToString();
            txtSKU.Text = Item.SKU;
            //LoadDetail();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripBtnPrint_Click(object sender, EventArgs e)
        {
            int Validate = 0;
            if (int.TryParse(txtCopies.Text, out Validate))
            {
                for (int x = 0; x < int.Parse(txtCopies.Text); x++)
                {
                    PrintStocklabel();
                }
            }
            else
            {
                MessageBox.Show("Number of copies is not valid");
            }

		
	
        }


        private void PrintStocklabel()
        {
            //PrintStocklabelArgox();
            //PrintStocklabelZPL();
            PrintStocklabelDataMax();
        }

        private void PrintStocklabelArgox()
        {
            //qty = qty.PadLeft(4,'0');
            StreamWriter sw = new StreamWriter(@"c:\LMSWarehouse\label.txt", false);
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
            //sw.WriteLine("B750,500,2,1,5,6,200,N,\"" + Item.BarCode + "\"");
            sw.WriteLine("B750,500,2,1,4,5,200,N,\"" + Item.BarCode + "\"");
            sw.WriteLine("A725,45,2,1,1,1,N,\"Distributed by Sauce-ing (PTY) LTD - Printed by LMS\"");
            sw.WriteLine("X750,25,3,200,75");
            sw.WriteLine("A750,300,2,3,1,1,N,\"" + Item.BarCode + "\"");
            sw.WriteLine("A750,250,2,4,1,2,N,\"" + Item.SKU + "\"");
            sw.WriteLine("A750,200,2,4,1,2,N,\"" + Item.ProductDescription + "\"");
            sw.WriteLine("A750,150,2,4,1,2,N,\"PackSize : " + Item.packsize.ToString() + "\"");
            sw.WriteLine("A750,100,2,1,1,1,N,\"" + Item.ProductExtraDescription + "\"");
            sw.WriteLine("P1," + 1 + "");
            sw.WriteLine("ZN");
            sw.Close();

            FileInfo f = new FileInfo(@"c:\LMSWarehouse\label.txt");


            string path = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\LMSWarehouse", "Label", "No Printer").ToString();


            //MessageBox.Show(path);
            f.CopyTo(path);
            //MessageBox.Show(path);
            //f.CopyTo("\\\\SI-JDHS1\\labelprint");
            //f.CopyTo("\\\\Si-Thami\\labelprint");
            //f.CopyTo("\\\\Si-Mike\\labelprint");

        }

        private void PrintStocklabelZPL()
        {
            //qty = qty.PadLeft(4,'0');
            StreamWriter sw = new StreamWriter(@"c:\LMSWarehouse\label.txt", false);
            //StreamWriter sw = new StreamWriter(@"c:\label.txt", false);
            sw.WriteLine("^XA");


            sw.WriteLine("^FO450,320^ADN,18,10^FDPrinted by LMS^FS");
            sw.WriteLine("^FO50,10^BCN,100,Y,N,N^FD" + Item.BarCode + "^FS");
            sw.WriteLine("^FO40,130^GB600,180,2^FS");
            
            sw.WriteLine("^FO50,140^ADN,36 20^FDSKU: " + Item.BarCode + "^FS");
            sw.WriteLine("^FO50,180^ADN,36 20^FD" + Item.ProductDescription + "^FS");
            sw.WriteLine("^FO50,220^ADN,36 20^FDPacksise: " + Item.packsize.ToString() + "^FS");
            sw.WriteLine("^FO50,260^ADN,18 10^FD" + Item.ProductExtraDescription + "^FS");

            sw.WriteLine("^XZ");
            sw.Close();


            FileInfo f = new FileInfo(@"c:\LMSWarehouse\label.txt");


            string path = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\LMSWarehouse", "Label", "No Printer").ToString();


            //MessageBox.Show(path);
            f.CopyTo(path);
            
            //MessageBox.Show("\\\\warehouse\\labelprint");
            //f.CopyTo("\\\\SI-JDHS1\\labelprint");
            
            //f.CopyTo("\\\\Si-Thami\\labelprint");
            //f.CopyTo("\\\\Si-Mike\\labelprint");

        }


        private void PrintStocklabelDataMax()
        {

            //qty = qty.PadLeft(4,'0');
            StreamWriter sw = new StreamWriter(@"c:\LMSWarehouse\label.txt", false);
            //StreamWriter sw = new StreamWriter(@"c:\label.txt", false);

            sw.WriteLine("L");
            sw.WriteLine("H30");
            sw.WriteLine("PR");
            sw.WriteLine("D11");
            sw.WriteLine("1e1308000900060" + Item.BarCode.ToString().Trim());
            sw.WriteLine("191100302000060" + Item.ProductDescription.ToString());
            sw.WriteLine("191100201700060" + Item.BarCode.ToString().Trim());

            //sw.WriteLine("1e1508000900060" + Item.BarCode.ToString().Trim());
            //sw.WriteLine("191100502000060" + Item.ProductDescription.ToString());
            //sw.WriteLine("191100301700060" + Item.BarCode.ToString().Trim());

            sw.WriteLine("E");
            sw.Close();


            FileInfo f = new FileInfo(@"c:\LMSWarehouse\label.txt");


            string path = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\LMSWarehouse", "Label", "No Printer").ToString();


            //MessageBox.Show(path);
            f.CopyTo(path);

        }

    }
}
