using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMSWarehouse
{
    public partial class FrmStockTake : Form
    {


        int WarehouseID;
        int UserID;
        int StockTakeType;
        private Wrapper WS = new Wrapper();


        public FrmStockTake(int fWarehouseID,int fUserID, int fStockTakeType)
        {
            WarehouseID = fWarehouseID;
            UserID = fUserID;
            StockTakeType = fStockTakeType;
            InitializeComponent();
        }

        private void FrmStockTake_Load(object sender, EventArgs e)
        {
            LoadStockTakes();
        }


        private void LoadStockTakes()
        {
            DataSet ds = WS.GetStockTake(WarehouseID, StockTakeType);
            dgStockTake.DataSource = ds.Tables[0];
        }
        

        private void toolStripBtnSave_Click(object sender, EventArgs e)
        {
            if ((pDetail.Visible == false)|| (txtDescription.Text == ""))
            {
                MessageBox.Show("No data to save.");
            }
            else
            {
                int RetVal = 0;
                RetVal = WS.SetStockTake(0, WarehouseID, UserID, txtDescription.Text,StockTakeType);
                if (RetVal == 1)
                {
                    pDetail.Visible = false;
                    LoadStockTakes();
                }
                else
                {
                    pDetail.Visible = false;
                    MessageBox.Show("Only one Active Stocktake can exist per warehouse.");
                }
            }

        }

        private void toolStripBtnNew_Click(object sender, EventArgs e)
        {
            if (StockTakeType == 3)
            {
                txtDescription.Text = "Cycle count : " + DateTime.Now.ToString("yyyyMMddhhmmss");
                txtDescription.Enabled = false;
                pDetail.Visible = true;
            }
            else
            {
                txtDescription.Text = "";
                pDetail.Visible = true;
            }
        }

        private void toolStripBtnStockTake_Click(object sender, EventArgs e)
        {
            //try
            //{
                int STakeID = int.Parse(dgStockTake.CurrentRow.Cells["StockTake_ID"].Value.ToString());
                int StatusID = int.Parse(dgStockTake.CurrentRow.Cells["OrderStatus_ID"].Value.ToString());
                //LMSWarehouse.FrmStockTakeDetail FStockTakeDetail = new FrmStockTakeDetail(WarehouseID,STakeID, StatusID);  
                FrmStockTakeItemDetail FStockTakeDetail = new FrmStockTakeItemDetail(WarehouseID, STakeID, StatusID);
                FStockTakeDetail.ShowDialog();
            //}
            //catch
            //{
            //    MessageBox.Show("No Stocktake was selected");
            //}
            
        }

        private void toolStripButtonScan_Click(object sender, EventArgs e)
        {
            try
            {
                int STakeID = int.Parse(dgStockTake.CurrentRow.Cells["StockTake_ID"].Value.ToString());
                int StatusID = int.Parse(dgStockTake.CurrentRow.Cells["OrderStatus_ID"].Value.ToString());
                //LMSWarehouse.FrmStockTakeDetail FStockTakeDetail = new FrmStockTakeDetail(WarehouseID,STakeID, StatusID);                
                LMSWarehouse.FrmStockTakeItem FStockTakeDetail = new FrmStockTakeItem(STakeID);
                FStockTakeDetail.ShowDialog();
            }
            catch
            {
                MessageBox.Show("No Stocktake was selected");
            }
        }
    }
}
