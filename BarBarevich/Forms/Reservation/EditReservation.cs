using BarBarevich.Classes;
using BarBarevich.Forms.View;
using BarBarevich.Forms.View.Products;
using BarBarevich.Forms.View.Tables;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Windows.Forms;
using static BarBarevich.Forms.ChooseClient;

namespace BarBarevich.Forms.Reservation
{
    public partial class EditReservation : Form, IClientSelectable
    {
        private ReservationView lastForm;
        private string id_reservation;
        private string id_employee;
        private string reservationDate;
        private ReservationClass reservationClass;

        public EditReservation(ReservationView lastForm, string id_reservation, string id_client,
            string fullName, string phone, string peopleCount,
            string reservationDate, string reservationTime, string deposit,
            string extraInfo, string id_employee, string employeeName)
        {
            InitializeComponent();
            this.lastForm = lastForm;
            this.id_reservation = id_reservation;
            this.id_employee = id_employee;
            this.reservationDate = reservationDate;

            reservationClass = new ReservationClass(); 

            SetSelectedClient(id_client, fullName, phone);

            textBoxGuestCount.Text = peopleCount;
            datePicker.Value = DateTime.Parse(reservationDate);
            timePicker.Value = DateTime.Parse(reservationTime);
            textBoxDeposit.Text = deposit;
            comboBoxEmployee.SelectedIndex = -1;

            if (!string.IsNullOrEmpty(id_employee) || !string.IsNullOrEmpty(extraInfo))
            {
                checkBoxExtra.Checked = true;
                textBoxExtra.Text = extraInfo;
                comboBoxEmployee.SelectedValue = Convert.ToInt32(id_employee);
            }
        }

        public void SetSelectedClient(string id_client, string fullName, string phone)
        {
            textBoxName.Text = fullName;
            textBoxPhone.Text = phone;
        }

        private void EditReservation_Load(object sender, EventArgs e)
        {
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "HH:mm";
            timePicker.ShowUpDown = true;

            try
            {
                var employees = EmployeeClass.GetFormattedEmployees();
                comboBoxEmployee.DisplayMember = "FullName";
                comboBoxEmployee.ValueMember = "Id";
                comboBoxEmployee.DataSource = employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка отображения сотрудников");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string phone = textBoxPhone.Text;
            string date = datePicker.Value.ToString("yyyy-MM-dd");
            string time = timePicker.Value.ToString("HH:mm");
            string guests = textBoxGuestCount.Text;
            string actual_guests_count = textBoxActualGuestCount.Text;
            string deposit = textBoxDeposit.Text;
            string id_client = ClientClass.GetClientId(phone);

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(guests) || string.IsNullOrWhiteSpace(deposit))
            {
                MessageBox.Show("Необходимо заполнить все данные бронирования.");
                return;
            }

            int guestsCount;
            int depositAmount;
            if (!int.TryParse(guests, out guestsCount) || guestsCount <= 0)
            {
                MessageBox.Show("Неверное количество гостей.");
                return;
            }

            bool clientExists = ReservationClass.CheckIfClientExistsByPhone(phone);

            if (!clientExists)
            {
                string id = ClientClass.GetClientMaxId();
                ClientClass.AddClient(id, name, phone);
            }

            if (string.IsNullOrWhiteSpace(actual_guests_count))
            {
                actual_guests_count = guests;
            }

            if (checkBoxExtra.Checked)
            {
                string id_employee = comboBoxEmployee.SelectedValue.ToString();
                string extra_info = textBoxExtra.Text;

                reservationClass.EditReservationExtra(id_reservation, id_client, guests,
                   actual_guests_count, date, time, deposit, id_employee, extra_info);
            }
            else 
            {
                reservationClass.EditReservationExtra(id_reservation, id_client, guests,
                    actual_guests_count, date, time, deposit, null, null);
            }
            MessageBox.Show("Информация о бронировании успешно обновлена.");
            buttonBack.PerformClick();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            this.Close();
            lastForm.Show();
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

        private void buttonEditTables_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = datePicker.Value.Date;
            EditTables editTables = new EditTables(this, id_reservation, selectedDate);
            editTables.StartPosition = FormStartPosition.Manual;
            editTables.Location = this.Location;
            this.Hide();
            editTables.Show();
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            if(datePicker.Value == DateTime.Parse(reservationDate))
            {

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show
                ("При смене даты необходимо будет выбрать столы заново. Продолжить?",
                                                 "Изменение даты",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    buttonSave.Enabled = false;
                    ReservationClass.ClearTablesForReservation(id_reservation);
                }
                else
                {
                    datePicker.Value = DateTime.Parse(reservationDate);
                }
            }           
        }
        public void EnableSaveButton()
        {
            buttonSave.Enabled = true;
        }

        private void buttonChooseClient_Click(object sender, EventArgs e)
        {
            ChooseClient chooseClient = new ChooseClient(this);
            chooseClient.StartPosition = FormStartPosition.Manual;
            chooseClient.Location = this.Location;
            this.Hide();
            chooseClient.Show();
        }

        private void buttonEditMenu_Click(object sender, EventArgs e)
        {
            EditMenuList editMenuList = new EditMenuList(this, id_reservation);
            editMenuList.StartPosition = FormStartPosition.Manual;
            editMenuList.Location = this.Location;
            this.Hide();
            editMenuList.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(EditReservation));
                return true;
            }

            if (keyData == Keys.Enter)
            {
                buttonSave.PerformClick();
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
