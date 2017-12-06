using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMSWarehouse
{
    public partial class FrmReceiveOrder : Form
    {

        private int OrderID;
        private int ProductID;
        private int ReceiveID;

        private Wrapper WS = new Wrapper();

        public FrmReceiveOrder(int fOrderID)
        {
            ProductID = 0;
            OrderID = fOrderID;
            InitializeComponent();
        }

        private void LoadGridData()
        {

            DataSet ds = WS.GetStockDetail(OrderID);
            dgReceive.DataSource = ds.Tables[0];

        }

        private void FrmReceiveOrder_Load(object sender, EventArgs e)
        {
            LoadGridData();

        }

        private void toolStripBtnSaveItem_Click(object sender, EventArgs e)
        {
            int Rec = 0;
            if (int.TryParse(txtQty.Text, out Rec))
            {
                if (Rec > 0)
                {
                    WS.SetStockReceive(ReceiveID, Rec);
                    pDetail.Visible = false;
                    toolStripBottom.Visible = false;
                    LoadGridData();
                }
                else
                {
                    MessageBox.Show("Qty Received must be bigger then 0");
                }
            }
            else
            {
                MessageBox.Show("Qty Received is not valid");
            }
        }

        private void toolStripBtnRecItem_Click(object sender, EventArgs e)
        {
            if (ReceiveID > 0)
            {
                FrmBatchReceive FB = new FrmBatchReceive(ProductID, 
                    int.Parse(dgReceive.CurrentRow.Cells["QTY"].Value.ToString()),
                    dgReceive.CurrentRow.Cells["SKU"].Value.ToString(), ReceiveID);
                FB.ShowDialog();

                MessageBox.Show("Done");

                pDetail.Visible = true;
                toolStripBottom.Visible = true;
                lblItem.Text = dgReceive.CurrentRow.Cells["SKU"].Value.ToString() + ": " + 
                    dgReceive.CurrentRow.Cells["ProductDescription"].Value.ToString();
                lblQty.Text = dgReceive.CurrentRow.Cells["QTY"].Value.ToString();
                txtQty.Text = lblQty.Text;
                txtQty.Focus();

            }
            else
            {
                MessageBox.Show("No line was selected.");
            }
        }

        private void dgReceive_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                pDetail.Visible = false;
                toolStripBottom.Visible = false;
                ReceiveID = int.Parse(dgReceive.CurrentRow.Cells["StockOrderDetail_ID"].Value.ToString());
                ProductID = int.Parse(dgReceive.CurrentRow.Cells["Product_ID"].Value.ToString());
            }
            catch (Exception ex)
            {
                ProductID = 0;
                ReceiveID = 0;

            }
        }

        private void toolStripBtnReceiveAll_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < dgReceive.RowCount; x++)
            {
                int RecID = 0;
                int RecQty = 0;
                if ((int.TryParse(dgReceive.Rows[x].Cells["StockOrderDetail_ID"].Value.ToString(), out RecID))
                    &&(int.TryParse(dgReceive.Rows[x].Cells["QTY"].Value.ToString(), out RecQty)))
                {
                    int InitQty = 0;
                    int.TryParse(dgReceive.Rows[x].Cells["QTY Processed"].Value.ToString(), out InitQty);

                    if (InitQty == 0)
                    {
                        WS.SetStockReceive(RecID, RecQty);
                    }
                }
                
            }
            LoadGridData();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Not all Items have been fully received. Ar you sure you want to complete this order?",
                "Complete Stock",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

            }

        }

        private void toolStripBtnPrintSingle_Click(object sender, EventArgs e)
        {
            int InitQty = 0;
            int.TryParse(dgReceive.CurrentRow.Cells["QTY Processed"].Value.ToString(), out InitQty);

            if ((ProductID != 0) && (InitQty > 0))
            {
                int PackSize = 1;
                int.TryParse(dgReceive.CurrentRow.Cells["PackSize"].Value.ToString(), out PackSize);

                double qtyPrint = 1;
                qtyPrint = Math.Ceiling((double)(InitQty / PackSize));
                
                FrmStockLabelPrint FStockaLabelPrint = new FrmStockLabelPrint(ProductID);
                FStockaLabelPrint.QtyPrint = (int)qtyPrint;
                FStockaLabelPrint.ShowDialog();
            }
            else
            {
                MessageBox.Show("No line was selected and qty received.");
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonBatch_Click(object sender, EventArgs e)
        {
            if (ReceiveID > 0)
            {
                OrderBatch ob = new OrderBatch(ProductID, int.Parse(dgReceive.CurrentRow.Cells["QTY"].Value.ToString()),
                    dgReceive.CurrentRow.Cells["SKU"].Value.ToString(), ReceiveID);
                ob.ShowDialog();


                int Rec = ob.QTYRec;

                if (Rec > 0)
                {
                    WS.SetStockReceive(ReceiveID, Rec);
                    pDetail.Visible = false;
                    toolStripBottom.Visible = false;
                    LoadGridData();
                }
                else
                {
                    MessageBox.Show("Qty Received must be bigger then 0");
                }



            }
            else
            {
                MessageBox.Show("No line was selected.");
            }
        }



    }
}
