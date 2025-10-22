using BarBarevich.Classes;
using BarBarevich.Forms.View.Products;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static BarBarevich.Forms.ChooseClient;

namespace BarBarevich.Forms
{
    public partial class NewReservation : Form, IClientSelectable
    {
        private DatabaseManager dbManager;
        private Form lastForm;

        public NewReservation(Form lastForm)
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            this.lastForm = lastForm;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string phone = textBoxPhone.Text;
            string date = datePicker.Value.ToString("yyyy-MM-dd");
            string time = timePicker.Value.ToString("HH:mm");
            string guests = textBoxGuestCount.Text;
            string deposit = textBoxDeposit.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone) || 
                string.IsNullOrWhiteSpace(guests) || string.IsNullOrWhiteSpace(deposit) ||
                Convert.ToInt32(guests) <= 0 || Convert.ToInt32(deposit) <= 0)
            {
                MessageBox.Show("Необходимо заполнить данные бронирования.");
            }
            else if (datePicker.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Дата бронирования не может быть в прошлом.");
            }
            else
            {
                bool clientExists = ReservationClass.CheckIfClientExistsByPhone(phone);

                if (!clientExists)
                {
                    string id = ClientClass.GetClientMaxId();
                    ClientClass.AddClient(id, name, phone);
                }

                string id_reservation = ReservationClass.GetMaxReservationId();
                string id_client = ClientClass.GetClientId(phone);

                if (checkBoxExtra.Checked)
                {
                    string id_employee = comboBoxEmployee.SelectedValue.ToString();
                    string extra_info = textBoxExtra.Text;

                    ReservationClass.AddReservationExtra(id_reservation, id_client, guests, 
                        date, time, deposit, id_employee, extra_info);
                }
                else
                {
                    ReservationClass.AddReservation(id_reservation, id_client, guests, 
                        date, time, deposit);
                }

              
                DateTime selectedDate = datePicker.Value.Date;
                ChooseTable chooseTable = new ChooseTable(this, selectedDate, id_reservation);
                chooseTable.StartPosition = FormStartPosition.Manual;
                chooseTable.Location = this.Location;
                this.Hide();
                chooseTable.Show();         
            }
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            this.Close();
            lastForm.Show();
        }

        public void SetSelectedClient(string id, string fullName, string phone)
        {
            textBoxName.Text = fullName;
            textBoxPhone.Text = phone;
        }

        private void buttonChooseClient_Click(object sender, EventArgs e)
        {
            ChooseClient chooseClient = new ChooseClient(this);
            chooseClient.StartPosition = FormStartPosition.Manual;
            chooseClient.Location = this.Location;
            this.Hide();
            chooseClient.Show();
        }

        private void NewReservation_Load(object sender, EventArgs e)
        {
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "HH:mm";
            timePicker.ShowUpDown = true;
            timePicker.Value = DateTime.Today.AddHours(20);
            datePicker.Value = DateTime.Today;

            try
            {
                var employees = EmployeeClass.GetFormattedEmployees();

                comboBoxEmployee.DisplayMember = "FullName";
                comboBoxEmployee.ValueMember = "Id";
                comboBoxEmployee.DataSource = employees;

                if (comboBoxEmployee.Items.Count > 0)
                    comboBoxEmployee.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка отображения сотрудников.");
            }
        }


        private void datePicker_ValueChanged(object sender, EventArgs e)
        {       
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHelper.RestrictToNonDigits(sender, e);
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHelper.RestrictToDigits(sender, e);
        }

        private void checkBoxExtra_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxExtra.Checked)
            {
                textBoxExtra.Enabled = true;
                comboBoxEmployee.Enabled = true;
            }
            else
            {
                textBoxExtra.Enabled = false;
                comboBoxEmployee.Enabled = false;
                textBoxExtra.Text = "";
                comboBoxEmployee.SelectedIndex = -1;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(NewReservation));
                return true;
            }

            if (keyData == Keys.Enter)
            {
                buttonAdd.PerformClick();
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
