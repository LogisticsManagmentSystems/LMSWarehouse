using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMSWarehouse
{
    public partial class FrmOrderEvent : Form
    {

        private int fCompanyID;
        private int Event;
        private Wrapper WS = new Wrapper();

        public FrmOrderEvent(int CompanyID)
        {
            fCompanyID = CompanyID;
            InitializeComponent();
            Event = 0;
            LoadData();
        }


        public void LoadData()
        {
            DataSet ds = WS.GetOrderEvent(fCompanyID);
            dgEvent.DataSource = ds.Tables[0];
            dgEvent.Columns["Company_ID"].Visible = false;
            dgEvent.Columns["OrderEvent_ID"].Visible = false;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text.Length > 1)
            {
                if (dateTimeEnd.Value > DateTime.Now)
                {
                    WS.SetOrderEvent(Event, fCompanyID, txtDescription.Text, dateTimeStart.Value, dateTimeEnd.Value);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("The event end date is invalid");
                }
            }
            else
            {
                MessageBox.Show("The event Description is invalid");
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgEvent_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtDescription.Text = dgEvent.CurrentRow.Cells["EventName"].Value.ToString();
                dateTimeStart.Text = dgEvent.CurrentRow.Cells["DateEventStart"].Value.ToString();
                dateTimeEnd.Text = dgEvent.CurrentRow.Cells["DateEventEnd"].Value.ToString();
                Event = int.Parse(dgEvent.CurrentRow.Cells["OrderEvent_ID"].Value.ToString());
                
            }
            catch
            {
                //No Code Object not yeat initialised
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            txtDescription.Text = "";
            dateTimeStart.Text = "";
            dateTimeEnd.Text = "";
            Event = 0;
        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
                    WS.SetOrderEvent(Event, fCompanyID, txtDescription.Text, dateTimeStart.Value, DateTime.Now.AddHours(-1));
                    LoadData();
        }
    }
}
