using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;

namespace LMSWarehouse
{
    public partial class FrmItemScan : Form
    {
        public int FromBinID = 0;
        public int QtyMax = 0;

        private string StockMoveType;
        private int CompanyID;
        private int WarehouseID;
        private int UserID;
        private int StockMoveOriginID;
        private string MoveName;
        private int StockMove = 0;

        SoundPlayer spDuplicate;
        SoundPlayer spAccept;
        SoundPlayer spInvalid;


        private Wrapper WS = new Wrapper();

        public FrmItemScan(string fStockMoveType, int fCompanyID, int fWarehouseID, int fUserID, int fStockMoveOriginID, string fMoveName)
        {
            StockMoveType = fStockMoveType;
            CompanyID = fCompanyID;
            WarehouseID = fWarehouseID;
            UserID = fUserID;
            StockMoveOriginID = fStockMoveOriginID;
            MoveName = fMoveName;

            InitializeComponent();
        }

        private void pDetail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

            DataSet dt = WS.GetStockMoveType(StockMoveType, CompanyID,WarehouseID);
            if (dt.Tables[0].Rows.Count > 0)
            {
                DataSet dg = null;

                if ((StockMoveOriginID != 0) && (FromBinID == 0))
                {
                    dg = WS.GetStockMoveItems(0, StockMoveOriginID);
                }
                else if (dt.Tables[0].Rows[0]["FromBin_ID"].ToString() != "0")
                {
                    dg = WS.GetStockMoveItems(int.Parse(dt.Tables[0].Rows[0]["FromBin_ID"].ToString()), 0);
                }
                else if (FromBinID != 0)
                {
                    dg = WS.GetStockMoveItems(FromBinID, 0);
                    lblQtyExpected.Text = QtyMax.ToString();
                }
                else
                {
                    dg = WS.GetStockMoveItems(0, 0);
                }
                dgReceive.DataSource = dg.Tables[0];

                for (int x = 0; x < dg.Tables[0].Rows.Count; x++)
                {
                    if (dg.Tables[0].Rows[x]["Bin_ID"].ToString() == dt.Tables[0].Rows[0]["Bin_ID"].ToString())
                    {
                        lblScans.Items.Add(dg.Tables[0].Rows[x]["ItemBarCode"].ToString());
                    }
                    else
                    {
                        lbItem.Items.Add(dg.Tables[0].Rows[x]["ItemBarCode"].ToString());
                    }
                }

                DataSet sm = WS.GetStockMoveFromOrder(StockMoveOriginID);
                if (sm.Tables[0].Rows.Count > 0)
                {
                    StockMove = int.Parse(sm.Tables[0].Rows[0]["StockMove_ID"].ToString());
                    if (sm.Tables[0].Rows[0]["StockMove_ID"].ToString() == "0")
                    {
                        StockMove = WS.SetStockMove(WarehouseID, UserID, DateTime.Now, MoveName, StockMoveType);
                        WS.SetStockMoveDetailPOSO(StockMove, StockMoveOriginID);
                    }
                }
                else
                {
                    StockMove = WS.SetStockMove(WarehouseID, UserID, DateTime.Now, MoveName, StockMoveType);
                }

                if (dt.Tables[0].Rows[0]["Bin_ID"].ToString() == "0")
                {
                    lblStatus.Text = "Please Scan Bin...";
                    txtBin.Select();
                }
                else if (QtyMax > 0)
                {
                    lblScanned.Text = "0";
                    lblQtyExpected.Text = QtyMax.ToString();
                    lblStatus.Text = "Please Scan Items...";
                    txtBin.Text = dt.Tables[0].Rows[0]["Bin_ID"].ToString();
                    txtBin.Enabled = false;
                    lblBin.Text = dt.Tables[0].Rows[0]["BinDescription"].ToString();
                    txtScan.Select();  
                }
                else
                {
                    lblScanned.Text = lblScans.Items.Count.ToString();
                    lblQtyExpected.Text = (lblScans.Items.Count + lbItem.Items.Count).ToString();
                    lblStatus.Text = "Please Scan Items...";
                    txtBin.Text = dt.Tables[0].Rows[0]["Bin_ID"].ToString();
                    txtBin.Enabled = false;
                    lblBin.Text = dt.Tables[0].Rows[0]["BinDescription"].ToString();
                    txtScan.Select();                   

                }



            }
            else
            {
                MessageBox.Show("Stock Movement Type not setup Correctly");
                Close();
            }



        }

        private void txtScan_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (lbItem.Items.Contains(txtScan.Text))
                {
                    if (QtyMax != 0)
                    {
                        String searchValue = txtScan.Text;
                        foreach (DataGridViewRow row in dgReceive.Rows)
                        {
                            if (row.Cells["ItemBarCode"].Value.ToString().Equals(searchValue))
                            {
                                lblScanned.Text = (int.Parse(lblScanned.Text) + int.Parse(row.Cells["ItemQty"].Value.ToString())).ToString();

                            }
                        }

                    }
                    else
                    {
                        lblScanned.Text = (int.Parse(lblScanned.Text) + 1).ToString();
                    }

                    

                    WS.SetItemTrack(StockMove, txtScan.Text, int.Parse(txtBin.Text));
                    pDetail.BackColor = Color.LightGreen;
                    lblStatus.Text = "Good Scan";                    
                    lblScans.Items.Add(txtScan.Text);
                    lbItem.Items.Remove(txtScan.Text);
                    spAccept.Play();
                    
                    txtScan.Text = "";

                    if ((int.Parse(lblScanned.Text) >= QtyMax) && (QtyMax != 0))
                    {
                        MessageBox.Show("This Order Item is now FullFilled");
                        AsdjustStock();
                        Close();
                    }


                }
                else if (lblScans.Items.Contains(txtScan.Text))
                {
                    pDetail.BackColor = Color.LightGoldenrodYellow;
                    lblStatus.Text = "Duplicate Scan";
                    txtScan.Text = "";
                    spDuplicate.Play();
                }
                else
                {
                    pDetail.BackColor = Color.LightPink;
                    lblStatus.Text = "No Data Received";
                    txtScan.Text = "";
                    spInvalid.Play();
                }
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            AsdjustStock();
            Close();

        }


        private void AsdjustStock()
        {
            WS.SetStockMoveDetail(StockMove);
            DataSet DL = WS.GetStockMovementPrev(StockMove);
            for (int x = 0; x < DL.Tables[0].Rows.Count; x++)
            {
                WS.SetStockDelFromStockMove(WarehouseID, int.Parse(DL.Tables[0].Rows[x]["Bin_ID"].ToString()), int.Parse(DL.Tables[0].Rows[x]["Qty"].ToString()), int.Parse(DL.Tables[0].Rows[x]["StockMoveDetail_ID"].ToString()));
            }
            DataSet SA = WS.GetStockMovement(StockMove);
            for (int x = 0; x < SA.Tables[0].Rows.Count; x++)
            {
                WS.SetStockAddFromStockMove(WarehouseID, int.Parse(SA.Tables[0].Rows[x]["Bin_ID"].ToString()), int.Parse(SA.Tables[0].Rows[x]["Qty"].ToString()), int.Parse(SA.Tables[0].Rows[x]["StockMoveDetail_ID"].ToString()));
            }


        }

        private void txtBin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                try
                {
                DataSet ds = WS.GetBinBarCode(int.Parse(txtBin.Text));
                if (ds.Tables[0].Rows.Count > 0)
                {
                    lblBin.Text = ds.Tables[0].Rows[0]["BinDescription"].ToString();
                    lblStatus.Text = "Please Scan Items...";                    
                    txtBin.Enabled = false;                    
                    txtScan.Select(); 
                }
                else
                {
                    lblBin.Text = "Bin not found";
                    txtBin.Text = "";
                    txtBin.Select();
                }
                }
                catch
                {
                    MessageBox.Show("Invalid barcode was scanned for Bin");
                    txtBin.Text = "";
                    txtBin.Select();
                }

            }

        }

        private void FrmItemScan_FormClosing(object sender, FormClosingEventArgs e)
        {
            AsdjustStock();
        }

        private void FrmItemScan_Load(object sender, EventArgs e)
        {
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
        }

        private void txtScan_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
