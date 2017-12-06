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
    public partial class FrmBinLibrary : Form
    {
        private struct BinLoc
        {
            public int BinID, Location, Row, Column, Level;
        }


        private BinLoc Bin;
        private int CompanyID;
        private int WarehouseID;
        private Wrapper WS = new Wrapper();



        public FrmBinLibrary(int fCompany,int fWarehouse)
        {
            WS = new Wrapper();
            Bin = new BinLoc();
            Bin.BinID = 0;
            Bin.Location = 0;
            Bin.Row = 0;
            Bin.Column = 0;
            Bin.Level = 0;
            InitializeComponent();
            CompanyID = fCompany;
            WarehouseID = fWarehouse;
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }



        private void cmbWarehouse_Enter(object sender, EventArgs e)
        {
            DataSet ds = WS.GetWarehouse(CompanyID);
            cmbWarehouse.DataSource = ds.Tables[0];
            cmbWarehouse.ValueMember = "Warehouse_ID";
            cmbWarehouse.DisplayMember = "WarehouseName";
            try
            {
                cmbWarehouse.SelectedValue = WarehouseID;
            }
            catch
            {
                //No Code Object not yeat initialised
            }
        }

        private void cmbLocation_Enter(object sender, EventArgs e)
        {
            DataSet ds = WS.GetBinLocation(WarehouseID);
            cmbLocation.DataSource = ds.Tables[0];
            cmbLocation.ValueMember = "BinLocation_ID";
            cmbLocation.DisplayMember = "LocationDescription";
            try
            {
                cmbLocation.SelectedValue = Bin.Location;
            }
            catch
            {
                //No Code Object not yeat initialised
            }
        }

        private void cmbLevel_Enter(object sender, EventArgs e)
        {
            DataSet ds = WS.GetBinLevels(WarehouseID);
            cmbLevel.DataSource = ds.Tables[0];
            cmbLevel.ValueMember = "BinLevel_ID";
            cmbLevel.DisplayMember = "LevelDescription";
            try
            {
                cmbLevel.SelectedValue = Bin.Level;
            }
            catch
            {
                //No Code Object not yeat initialised
            }
        }

        private void cmbRow_Enter(object sender, EventArgs e)
        {
            DataSet ds = WS.GetBinRow(Bin.Location);
            cmbRow.DataSource = ds.Tables[0];
            cmbRow.ValueMember = "BinRow_ID";
            cmbRow.DisplayMember = "RowDescription";

            try
            {
                cmbRow.SelectedValue = Bin.Row;
            }
            catch
            {
                //No Code Object not yeat initialised
            }
        }

        private void cmbColumn_Enter(object sender, EventArgs e)
        {
            DataSet ds = WS.GetBinColumn(Bin.Location);
            cmbColumn.DataSource = ds.Tables[0];
            cmbColumn.ValueMember = "BinColumn_ID";
            cmbColumn.DisplayMember = "ColumnDescription";
            try
            {

                cmbColumn.SelectedValue = Bin.Column;
            }
            catch
            {
                //No Code Object not yeat initialised
            }
        }

        private void cmbWarehouse_Leave(object sender, EventArgs e)
        {
            try
            {
                WarehouseID = int.Parse(cmbWarehouse.SelectedValue.ToString());
            }
            catch
            {
                //No Code Object not yeat initialised
            }
        }

        private void cmbLocation_Leave(object sender, EventArgs e)
        {
            try
            {
                Bin.Location = int.Parse(cmbLocation.SelectedValue.ToString());
            }
            catch
            {
                //No Code Object not yeat initialised
            }
        }

        private void cmbRow_Leave(object sender, EventArgs e)
        {
            try
            {
                Bin.Row = int.Parse(cmbRow.SelectedValue.ToString());
            }
            catch
            {
                //No Code Object not yeat initialised
            }
        }

        private void cmbColumn_Leave(object sender, EventArgs e)
        {
            try
            {
                Bin.Column = int.Parse(cmbColumn.SelectedValue.ToString());
            }
            catch
            {
                //No Code Object not yeat initialised
            }
        }

        private void cmbLevel_Leave(object sender, EventArgs e)
        {
            try
            {
                Bin.Level = int.Parse(cmbLevel.SelectedValue.ToString());
            }
            catch
            {
                //No Code Object not yeat initialised
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if ((cmbRow.Text == "") || (cmbWarehouse.Text == "") || (cmbColumn.Text == "") 
                || (cmbLevel.Text == "") || (cmbLocation.Text == "") || (txtDecription.Text ==""))
            {
                MessageBox.Show("All fields must be filled before Bin can be saved.");
            }
            else
            {
                txtDecription.Focus();
                WS.SetBin(Bin.BinID, txtDecription.Text, Bin.Location, Bin.Row, Bin.Column, Bin.Level, WarehouseID);
                DataSet ds = WS.GetBins(WarehouseID);
                dgBins.DataSource = ds.Tables[0];
            }
        }

        private void FrmBinLibrary_Load(object sender, EventArgs e)
        {
            DataSet ds = WS.GetBins(WarehouseID);
            dgBins.DataSource = ds.Tables[0];
        }



        private void LoadDetail()
        {
            cmbRow.DataSource = null;
            cmbWarehouse.DataSource = null;
            cmbColumn.DataSource = null;
            cmbLevel.DataSource = null;
            cmbLocation.DataSource = null; 

            cmbRow.Items.Clear();
            cmbRow.Items.Add(dgBins.CurrentRow.Cells["Row"].Value.ToString());
            cmbRow.SelectedIndex = 0;

            cmbWarehouse.Items.Clear();
            cmbWarehouse.Items.Add(dgBins.CurrentRow.Cells["Warehouse"].Value.ToString());
            cmbWarehouse.SelectedIndex = 0;

            cmbColumn.Items.Clear();
            cmbColumn.Items.Add(dgBins.CurrentRow.Cells["Column"].Value.ToString());
            cmbColumn.SelectedIndex = 0;

            cmbLevel.Items.Clear();
            cmbLevel.Items.Add(dgBins.CurrentRow.Cells["Level"].Value.ToString());
            cmbLevel.SelectedIndex = 0;

            cmbLocation.Items.Clear();
            cmbLocation.Items.Add(dgBins.CurrentRow.Cells["Location"].Value.ToString());
            cmbLocation.SelectedIndex = 0;

            txtDecription.Text = dgBins.CurrentRow.Cells["Description"].Value.ToString();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            txtDecription.Focus();
            txtDecription.Text = "";
            Bin.BinID = 0;
            Bin.Location = 0;
            Bin.Row = 0;
            Bin.Column = 0;
            Bin.Level = 0;
            cmbRow.DataSource = null;
            cmbWarehouse.DataSource = null;
            cmbColumn.DataSource = null;
            cmbLevel.DataSource = null;
            cmbLocation.DataSource = null; 
            
            cmbRow.Items.Clear();
            cmbWarehouse.Items.Clear();
            cmbColumn.Items.Clear();
            cmbLevel.Items.Clear();
            cmbLocation.Items.Clear();

            cmbRow.Text = "";
            cmbWarehouse.Text = "";
            cmbColumn.Text = "";
            cmbLevel.Text = "";
            cmbLocation.Text = "";
            
        }

        private void dgBins_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Bin.BinID = int.Parse(dgBins.CurrentRow.Cells["BarCode"].Value.ToString());
                Bin.Level = int.Parse(dgBins.CurrentRow.Cells["BinLevel_ID"].Value.ToString());
                Bin.Column = int.Parse(dgBins.CurrentRow.Cells["BinColumn_ID"].Value.ToString());
                Bin.Location = int.Parse(dgBins.CurrentRow.Cells["BinLocation_ID"].Value.ToString());
                Bin.Row = int.Parse(dgBins.CurrentRow.Cells["BinRow_ID"].Value.ToString());
                LoadDetail();
            }
            catch
            {
                //No Code Object not yeat initialised
            }

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            //PrintBinZPL();
            //PrintBinArgox();
            PrintBinDataMax();
            //PrintBinArgoxSmall();


        }


        private void PrintBinArgoxSmall()
        {
            //qty = qty.PadLeft(4,'0');
            StreamWriter sw = new StreamWriter(@"c:\LMSWarehouse\label.txt", false);
            //StreamWriter sw = new StreamWriter(@"c:\label.txt", false);
            sw.WriteLine("N");
            sw.WriteLine("B482,204,2,1,5,10,133,N,\"" + dgBins.CurrentRow.Cells["BarCode"].Value.ToString() + "\"");
            sw.WriteLine("A348,65,2,4,1,1,N,\"" + dgBins.CurrentRow.Cells["BarCode"].Value.ToString() + "\"");
            sw.WriteLine("A492,278,2,1,2,2,N,\"Bin:-" + dgBins.CurrentRow.Cells["Description"].Value.ToString() + "\"");
            sw.WriteLine("P1");

            sw.Close();

            FileInfo f = new FileInfo(@"c:\LMSWarehouse\label.txt");

            string path = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\LMSWarehouse", "Label", "No Printer").ToString();

            f.CopyTo(path);

        }

        private void PrintBinArgox()
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
            sw.WriteLine("B750,500,2,1,5,6,200,N,\"" + dgBins.CurrentRow.Cells["BarCode"].Value.ToString() + "\"");
            sw.WriteLine("A725,45,2,1,1,1,N,\"Distributed by Sauce-ing (PTY) LTD - Printed by LMS\"");
            sw.WriteLine("X750,25,3,200,75");
            sw.WriteLine("A750,300,2,3,1,1,N,\"Bin: - " + dgBins.CurrentRow.Cells["BarCode"].Value.ToString() + "\"");
            sw.WriteLine("A750,250,2,4,1,2,N,\"" + dgBins.CurrentRow.Cells["Description"].Value.ToString() + "\"");
            sw.WriteLine("A750,200,2,4,1,2,N,\"Row: " + dgBins.CurrentRow.Cells["Row"].Value.ToString() +
                " - Column: " + dgBins.CurrentRow.Cells["Column"].Value.ToString() +
                " - Level: " + dgBins.CurrentRow.Cells["Level"].Value.ToString() + "\"");
            sw.WriteLine("A750,150,2,4,1,2,N,\"" + dgBins.CurrentRow.Cells["Location"].Value.ToString() + "\"");
            sw.WriteLine("P1," + 1 + "");
            sw.WriteLine("ZN");
            sw.Close();

            FileInfo f = new FileInfo(@"c:\LMSWarehouse\label.txt");

            string path = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\LMSWarehouse", "Label", "No Printer").ToString();

            f.CopyTo(path);

            //MessageBox.Show("\\\\warehouse\\labelprint");
            //f.CopyTo("\\\\SI-JDHS1\\labelprint");
            //f.CopyTo("\\\\Si-Thami\\labelprint");
            //f.CopyTo("\\\\Si-Mike\\labelprint");
        }

        private void PrintBinZPL()
        {
            //qty = qty.PadLeft(4,'0');
            StreamWriter sw = new StreamWriter(@"c:\LMSWarehouse\label.txt", false);
            //StreamWriter sw = new StreamWriter(@"c:\label.txt", false);


            sw.WriteLine("^XA");

            sw.WriteLine("^FO450,320^ADN,18,10^FDPrinted by LMS^FS");

            sw.WriteLine("^FO50,10^BCN,100,Y,N,N^FD" + dgBins.CurrentRow.Cells["BarCode"].Value.ToString() + "^FS");
            sw.WriteLine("^FO40,130^GB600,180,2^FS");

            sw.WriteLine("^FO50,140^ADN,36,20^FDBin: - " + dgBins.CurrentRow.Cells["BarCode"].Value.ToString()  +"^FS");
            sw.WriteLine("^FO50,180^ADN,36,20^FD" + dgBins.CurrentRow.Cells["Description"].Value.ToString() + "^FS");
            sw.WriteLine("^FO50,220^ADN,36,10^FDRow: " + dgBins.CurrentRow.Cells["Row"].Value.ToString() +
                " - Column: " + dgBins.CurrentRow.Cells["Column"].Value.ToString() +
                " - Level: " + dgBins.CurrentRow.Cells["Level"].Value.ToString() +  "^FS");
            sw.WriteLine("^FO50,260^ADN,18,10^FD" + dgBins.CurrentRow.Cells["Location"].Value.ToString() + "^FS");

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



        private void PrintBinDataMax()
        {
            //qty = qty.PadLeft(4,'0');
            StreamWriter sw = new StreamWriter(@"c:\LMSWarehouse\label.txt", false);
            //StreamWriter sw = new StreamWriter(@"c:\label.txt", false);

            sw.WriteLine("L");
            sw.WriteLine("H30");
            sw.WriteLine("PR");
            sw.WriteLine("D11");
            sw.WriteLine("1e1508000900060" + dgBins.CurrentRow.Cells["BarCode"].Value.ToString().Trim());
            sw.WriteLine("191100602000060" + dgBins.CurrentRow.Cells["Description"].Value.ToString());
            sw.WriteLine("191100301700060Row: " + dgBins.CurrentRow.Cells["Row"].Value.ToString() +
                " - Column: " + dgBins.CurrentRow.Cells["Column"].Value.ToString() +
                " - Level: " + dgBins.CurrentRow.Cells["Level"].Value.ToString());

            sw.WriteLine("E");
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

        private void toolStripPrintAll_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < dgBins.RowCount; x++)
            {
                StreamWriter sw = new StreamWriter(@"c:\LMSWarehouse\label.txt", false);
                //StreamWriter sw = new StreamWriter(@"c:\label.txt", false);
                sw.WriteLine("L");
                sw.WriteLine("H30");
                sw.WriteLine("PR");
                sw.WriteLine("D11");
                sw.WriteLine("1e1508000900060" + dgBins.Rows[x].Cells["BarCode"].Value.ToString().Trim());
                sw.WriteLine("191100602000060" + dgBins.Rows[x].Cells["Description"].Value.ToString());
                sw.WriteLine("191100301700060Row: " + dgBins.Rows[x].Cells["Row"].Value.ToString() +
                    " - Column: " + dgBins.Rows[x].Cells["Column"].Value.ToString() +
                    " - Level: " + dgBins.Rows[x].Cells["Level"].Value.ToString());
                sw.WriteLine("E");
                sw.Close();                
                FileInfo f = new FileInfo(@"c:\LMSWarehouse\label.txt");                
                string path = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\LMSWarehouse", "Label", "No Printer").ToString();                
                //MessageBox.Show(path);
                f.CopyTo(path);
            }

        }

    }
}
