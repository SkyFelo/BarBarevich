using BarBarevich.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using BarBarevich.Forms.View.Tables;
using BarBarevich.Forms.Docs;

namespace BarBarevich.Forms.View
{
    public partial class BarHallView : Form
    {
        private DatabaseManager dbManager;
        private MainForm lastForm;

        private string id_reservation;
        public BarHallView(MainForm lastForm)
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            this.lastForm = lastForm;

            datePicker.Value = DateTime.Today;
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = datePicker.Value.Date;

            List<int> occupiedTables = dbManager.GetOccupiedTables(selectedDate);

            UpdateTableButtons(occupiedTables);
        }

        private void UpdateTableButtons(List<int> occupiedTables)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Guna2Button)
                {
                    Guna2Button tableButton = (Guna2Button)control;

                    if (tableButton.Name.StartsWith("table") && tableButton.Name.EndsWith("Button"))
                    {
                        string buttonName = tableButton.Name;
                        int tableNumber = int.Parse(buttonName.Substring(5, buttonName.Length - 11));

                        if (occupiedTables.Contains(tableNumber))
                        {
                            tableButton.FillColor = Color.FromArgb(40, 40, 40);
                            tableButton.ForeColor = Color.White;  
                            tableButton.Enabled = true;
                        }
                        else
                        {
                            tableButton.FillColor = Color.FromArgb(204, 255, 158);
                            tableButton.ForeColor = Color.Black; 
                            tableButton.Enabled = false;
                        }
                    }
                }
            }
        }


        private void TableButton_Click(object sender, EventArgs e)
        {
            Guna2Button clickedButton = (Guna2Button)sender;
            string buttonName = clickedButton.Name;
            int tableNumber = int.Parse(buttonName.Substring(5, buttonName.Length - 11));
            string selectedDate = datePicker.Value.ToString("yyyy-MM-dd");

            DataTable reservationData = dbManager.GetReservationDetails(tableNumber, selectedDate);

            if (reservationData.Rows.Count > 0)
            {
                groupBoxReservation.Visible = true;

                id_reservation = reservationData.Rows[0]["id_reservation"].ToString();
                string clientName = reservationData.Rows[0]["full_name"].ToString();
                string clientPhone = reservationData.Rows[0]["phone"].ToString();
                int guestsCount = Convert.ToInt32(reservationData.Rows[0]["people_count"]);
                TimeSpan reservationTimeSpan = (TimeSpan)reservationData.Rows[0]["time"];
                DateTime reservationTime = DateTime.Today.Add(reservationTimeSpan);
                decimal deposit = Convert.ToDecimal(reservationData.Rows[0]["deposit"]);

                textBoxClientName.Text = clientName;
                textBoxClientPhone.Text = clientPhone;
                textBoxGuestsCount.Text = guestsCount.ToString();
                textBoxReservationTime.Text = reservationTime.ToString("HH:mm");
                textBoxDeposit.Text = deposit.ToString();
            }
            else
            {

                groupBoxReservation.Visible = false;
            }
        }


        private void BarHallView_Load(object sender, EventArgs e)
        {
            DateTime selectedDate = datePicker.Value.Date;

            List<int> occupiedTables = dbManager.GetOccupiedTables(selectedDate);

            UpdateTableButtons(occupiedTables);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            lastForm.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(BarHallView));
                return true;
            }

            if (keyData == Keys.Enter)
            {
                buttonView.PerformClick();
                return true;
            }

            if (keyData == Keys.Escape)
            {
                buttonBack.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                lastForm.StartPosition = FormStartPosition.Manual;
                lastForm.Location = this.Location;
                lastForm.Show();
            }
        }
    }
}
