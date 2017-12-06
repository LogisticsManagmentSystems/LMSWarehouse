using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMSWarehouse
{
    public partial class FrmPutAwayList : Form
    {

        private Wrapper WS = new Wrapper();

        private int WarehouseID;
        private int SetProductID;
        private int SetQty;

        public FrmPutAwayList(int fWarehouseID)
        {
            WarehouseID = fWarehouseID;
            SetQty = 0;
            SetProductID = 0;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DataSet ds = WS.GetPutawayDetail(WarehouseID, 0);
                dgPutList.DataSource = ds.Tables[0];
            }
            catch
            {
                SetProductID = 0;
                SetQty = 0;
            }
        }

        private void dgPutList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                SetProductID = int.Parse(dgPutList.CurrentRow.Cells[3].Value.ToString());
                SetQty = int.Parse(dgPutList.CurrentRow.Cells[2].Value.ToString());
            }
            catch
            {
                SetProductID = 0;
                SetQty = 0;

            }
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButtonPutAway_Click(object sender, EventArgs e)
        {
            if ((WarehouseID > 0) && (SetProductID > 0) && (SetQty > 0))
            {
                FrmPutAway FPutAway = new FrmPutAway(WarehouseID, SetProductID, SetQty);
                FPutAway.ShowDialog();
                LoadData();
            }
            else
            {
                MessageBox.Show("No Item was selected to be put away'");
            }
        }
    }
}
