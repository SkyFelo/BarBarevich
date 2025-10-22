using BarBarevich.Classes;
using BarBarevich.Forms.Reservation;
using BarBarevich.Forms.View.Products;
using Microsoft.Office.Interop.Word;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarBarevich.Forms.View
{
    public partial class ReservationView : Form
    {
        private MainForm lastForm;
        public ReservationView(MainForm lastForm)
        {
            InitializeComponent();
            this.lastForm = lastForm;

            DateTime today = DateTime.Today;
            dateTimePickerStart.Value = today.AddDays(-7);
            dateTimePickerEnd.Value = today;
        }

        private void ActivityView_Load(object sender, EventArgs e)
        {
            var reservations = ReservationClass.GetReservationData();

            dataGridViewReservation.DataSource = reservations;

            foreach (DataGridViewRow row in dataGridViewReservation.Rows)
            {
                var statusValue = row.Cells["id_complete_status"].Value;

                int status = 0;

                if (statusValue != DBNull.Value && statusValue != null)
                {
                    status = Convert.ToInt32(statusValue);
                }

                if (status == 2)
                {
                    row.DefaultCellStyle.BackColor = Color.Gray;
                }
                else if (status == 1)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }

            UpdateButtonAvailability();
        }





        private void dataGridViewActivity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string id = dataGridViewReservation.Rows[e.RowIndex].Cells["id_reservation"].Value.ToString();

                System.Data.DataTable menuItems = ReservationClass.GetMenuItemsForReservationDetails(id);
                dataGridViewMenu.DataSource = menuItems;

                System.Data.DataTable tables = ReservationClass.GetTablesForReservationDetails(id);
                dataGridViewTables.DataSource = tables;

                UpdateButtonAvailability();
            }
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DateTime start = dateTimePickerStart.Value.Date;
            DateTime end = dateTimePickerEnd.Value.Date;

            if (start > end)
            {
                MessageBox.Show("Начальная дата не может быть позже конечной.", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var searchResults = ReservationClass.GetReservationsByDate(start, end);
            dataGridViewReservation.DataSource = searchResults;
        }



        private void buttonRefreshing_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            dateTimePickerStart.Value = today.AddDays(-7);
            dateTimePickerEnd.Value = today;

            ActivityView_Load(sender, e);
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            this.Close();
            lastForm.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            NewReservation newReservation = new NewReservation(this);
            newReservation.StartPosition = FormStartPosition.Manual;
            newReservation.Location = this.Location;
            this.Hide();
            newReservation.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewReservation.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewReservation.SelectedRows[0];

                string id_reservation = selectedRow.Cells["id_reservation"].Value.ToString();
                string id_client = selectedRow.Cells["id_client"].Value.ToString();
                string fullName = selectedRow.Cells["full_name"].Value.ToString();
                string phone = selectedRow.Cells["phone"].Value.ToString();
                string peopleCount = selectedRow.Cells["people_count"].Value.ToString();
                string reservationDate = selectedRow.Cells["date"].Value.ToString();
                string reservationTime = selectedRow.Cells["time"].Value.ToString();
                string deposit = selectedRow.Cells["deposit"].Value.ToString();
                string extraInfo = selectedRow.Cells["extra_info"].Value.ToString();
                string id_employee = selectedRow.Cells["id_employee"].Value.ToString();
                string employeeName = selectedRow.Cells["first_name"].Value.ToString();

                EditReservation editReservationForm = new EditReservation(this, id_reservation, id_client, fullName,
                   phone, peopleCount,  reservationDate, reservationTime, deposit, extraInfo, id_employee, employeeName);
                editReservationForm.StartPosition = FormStartPosition.Manual;
                editReservationForm.Location = this.Location;
                this.Hide();
                editReservationForm.Show();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать бронирование для редактирования.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewReservation.SelectedRows.Count > 0)
            {
                string id = dataGridViewReservation.SelectedRows[0].Cells["id_reservation"].Value.ToString();

                var confirm = MessageBox.Show("Удалить выбранное бронирование?",
                    "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    ReservationClass.ClearTablesForReservation(id);
                    MenuClass.ClearMenuItemsForReservation(Convert.ToInt32(id));
                    if (ReservationClass.DeleteReservation(id))
                        MessageBox.Show("Информация о бронировании успешно удалена.");
                    else
                        MessageBox.Show("Ошибка при удалении информации о бронировании.");

                    ActivityView_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать бронирование для удаления.");
            }
        }

        private void ReservationView_VisibleChanged(object sender, EventArgs e)
        {
            ActivityView_Load(sender, e);
        }

        private void buttonConfirmMenu_Click(object sender, EventArgs e)
        {
            if (dataGridViewReservation.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewReservation.SelectedRows[0];
                string id_reservation = selectedRow.Cells["id_reservation"].Value.ToString();

                var confirm = MessageBox.Show("Вы уверены, что хотите выполнить выдачу меню? Это действие невозможно отменить.",
                    "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    bool result = ReservationClass.ConfirmMenuIssuance(id_reservation);

                    if (result)
                    {
                        MessageBox.Show("Статус выдачи меню изменен.");
                        ActivityView_Load(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать бронирование для подтверждения выдачи меню.");
            }
        }

        private void dataGridViewReservation_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewReservation.Columns[e.ColumnIndex].Name == "id_complete_status")
            {
                int status = Convert.ToInt32(dataGridViewReservation.Rows[e.RowIndex].Cells["id_complete_status"].Value);

                if (status == 2) 
                {
                    dataGridViewReservation.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
                }
                else if (status == 1) 
                {
                    dataGridViewReservation.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else 
                {
                    dataGridViewReservation.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void UpdateButtonAvailability()
        {
            if (dataGridViewReservation.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewReservation.SelectedRows[0];

                var statusValue = selectedRow.Cells["id_complete_status"].Value;

                int status = 0; 

                if (statusValue != DBNull.Value && statusValue != null)
                {
                    status = Convert.ToInt32(statusValue);
                }

                buttonConfirmMenu.Enabled = (status == 1);

                buttonEdit.Enabled = (status != 2);
                buttonDelete.Enabled = (status != 2);
            }
            else
            {
                buttonConfirmMenu.Enabled = false;
                buttonEdit.Enabled = false;
                buttonDelete.Enabled = false;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(ReservationView));
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
