using BarBarevich.Classes;
using BarBarevich.Forms.View.Products;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BarBarevich.Forms.View.Employee
{
    public partial class EditEmployee : Form
    {
        private EmployeeClass employeeClass;
        private EmployeeView lastForm;
        private string currentLogin;
        private string selectedRole;

        public EditEmployee(EmployeeView lastForm, string id, string firstName, 
            string middleName, string lastName, string role,
            string phone, string login, string password)
        {
            InitializeComponent();
            this.lastForm = lastForm;
            employeeClass = new EmployeeClass();

            textBoxID.Text = id;
            textBoxFirstName.Text = firstName;
            textBoxMiddleName.Text = middleName;
            textBoxLastName.Text = lastName;
            textBoxPhone.Text = phone;
            textBoxLogin.Text = login;
            textBoxPassword.Text = password;

            currentLogin = login;
            selectedRole = role;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            string firstName = textBoxFirstName.Text;
            string middleName = textBoxMiddleName.Text;
            string lastName = textBoxLastName.Text;
            string role = comboBoxRole.Text;
            string id_role = comboBoxRole.SelectedValue?.ToString();
            string phone = textBoxPhone.Text;
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(middleName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(login) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Необходимо заполнить все поля.", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (login != currentLogin && employeeClass.IsLoginUsed(login))
            {
                MessageBox.Show($"Логин '{login}' используется другим пользователем.",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = employeeClass.EditEmployee(id, firstName, middleName, 
                lastName, id_role, phone, login, password);

            employeeClass.DeleteFutureShifts(id);

            foreach (DataGridViewRow row in dataGridViewShifts.Rows)
            {
                if (row.IsNewRow) continue;

                string shiftDate = row.Cells["date"].Value?.ToString();
                string shiftStart = row.Cells["start"].Value?.ToString();
                string shiftEnd = row.Cells["end"].Value?.ToString();

                if (string.IsNullOrEmpty(shiftDate) || string.IsNullOrEmpty(shiftStart) || string.IsNullOrEmpty(shiftEnd))
                    continue;

                employeeClass.AddShift(
                    id,
                    DateTime.Parse(shiftDate),
                    TimeSpan.Parse(shiftStart),
                    TimeSpan.Parse(shiftEnd)
                );
            }


            if (success)
                MessageBox.Show("Информация о сотруднике успешно изменена.");
            else
                MessageBox.Show("Ошибка при редактировании информации о сотруднике.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

            buttonBack.PerformClick();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            this.Close();
            lastForm.Show();
        }

        private void EditEmployee_Load(object sender, EventArgs e)
        {
            DataTable rolesTable = employeeClass.GetAllRoles();

            comboBoxRole.DataSource = rolesTable;
            comboBoxRole.DisplayMember = "role_name";
            comboBoxRole.ValueMember = "id_role";

            if (rolesTable.Select($"role_name = '{selectedRole}'").FirstOrDefault() is DataRow selectedRow)
            {
                comboBoxRole.SelectedValue = selectedRow["id_role"];
            }
            else if (rolesTable.Rows.Count > 0)
            {
                comboBoxRole.SelectedIndex = 0;
            }


            dataGridViewShifts.Columns.Clear();
            dataGridViewShifts.Columns.Add("date", "Дата");
            dataGridViewShifts.Columns.Add("start", "Начало смены");
            dataGridViewShifts.Columns.Add("end", "Конец смены");

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "delete";
            deleteButton.HeaderText = "Удалить";
            deleteButton.Text = "✖";
            deleteButton.UseColumnTextForButtonValue = true;
            dataGridViewShifts.Columns.Add(deleteButton);

            timePickerStart.Format = DateTimePickerFormat.Time;
            timePickerStart.ShowUpDown = true;
            timePickerStart.Value = DateTime.Today.AddHours(17);

            timePickerEnd.Format = DateTimePickerFormat.Time;
            timePickerEnd.ShowUpDown = true;
            timePickerEnd.Value = DateTime.Today.AddHours(23);

            datePickerShiftDate.Value = DateTime.Today;

            LoadShifts(textBoxID.Text);
        }

        private void LoadShifts(string employeeId)
        {
            DataTable shifts = employeeClass.GetShifts(employeeId);
            DateTime today = DateTime.Today;

            foreach (DataRow row in shifts.Rows)
            {
                DateTime shiftDate = Convert.ToDateTime(row["date"]);
                if (shiftDate >= today)
                {
                    TimeSpan start = TimeSpan.Parse(row["start_time"].ToString());
                    TimeSpan end = TimeSpan.Parse(row["end_time"].ToString());

                    dataGridViewShifts.Rows.Add(
                        shiftDate.ToShortDateString(),
                        start.ToString(@"hh\:mm"),
                        end.ToString(@"hh\:mm")
                    );
                }
            }
        }

        private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHelper.RestrictToNonDigits(sender, e);
        }

        private void textBoxMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHelper.RestrictToNonDigits(sender, e);
        }

        private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHelper.RestrictToNonDigits(sender, e);
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHelper.RestrictToDigits(sender, e);
        }

        private void buttonAddShift_Click(object sender, EventArgs e)
        {
            DateTime date = datePickerShiftDate.Value.Date;
            DateTime start = timePickerStart.Value;
            DateTime end = timePickerEnd.Value;

            if (date < DateTime.Today)
            {
                MessageBox.Show("Дата смены не может быть в прошлом.");
                return;
            }

            foreach (DataGridViewRow row in dataGridViewShifts.Rows)
            {
                if (!row.IsNewRow && row.Cells["date"].Value != null &&
                    row.Cells["date"].Value.ToString() == date.ToShortDateString())
                {
                    MessageBox.Show("Смена на эту дату уже добавлена.");
                    return;
                }
            }

            if (start.TimeOfDay == end.TimeOfDay)
            {
                MessageBox.Show("Время начала и окончания смены не может совпадать.");
                return;
            }

            dataGridViewShifts.Rows.Add(
                date.ToShortDateString(),
                start.ToShortTimeString(),
                end.ToShortTimeString()
            );
        }

        private void dataGridViewShifts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 &&
                dataGridViewShifts.Columns[e.ColumnIndex].Name == "delete")
            {
                var cell = dataGridViewShifts.Rows[e.RowIndex].Cells["date"];
                if (cell.Value == null) return;

                dataGridViewShifts.Rows.RemoveAt(e.RowIndex);
                
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(EditEmployee));
                return true;
            }

            if (keyData == Keys.Enter)
            {
                buttonEdit.PerformClick();
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
