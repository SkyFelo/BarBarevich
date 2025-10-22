using BarBarevich.Classes;
using BarBarevich.Forms.View.Products;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BarBarevich.Forms.View.Employee
{
    public partial class AddEmployee : Form
    {
        private EmployeeClass employeeClass;
        private EmployeeView lastForm;

        public AddEmployee(EmployeeView lastForm)
        {
            InitializeComponent();
            this.lastForm = lastForm;
            employeeClass = new EmployeeClass();

            timePickerStart.Format = DateTimePickerFormat.Time;
            timePickerStart.ShowUpDown = true;
            timePickerStart.Value = DateTime.Today.AddHours(17);

            timePickerEnd.Format = DateTimePickerFormat.Time;
            timePickerEnd.ShowUpDown = true;
            timePickerEnd.Value = DateTime.Today.AddHours(23);

            datePickerShiftDate.Value = DateTime.Today;
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            dataGridViewShifts.Columns.Clear();
            dataGridViewShifts.Columns.Add("date", "Дата");
            dataGridViewShifts.Columns.Add("start", "Начало смены");
            dataGridViewShifts.Columns.Add("end", "Конец смены");

            if (!dataGridViewShifts.Columns.Contains("delete"))
            {
                DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                btnCol.HeaderText = "Удалить";
                btnCol.Name = "delete";
                btnCol.Text = "✖";
                btnCol.UseColumnTextForButtonValue = true;
                dataGridViewShifts.Columns.Add(btnCol);
            }

            dataGridViewShifts.CellClick += dataGridViewShifts_CellClick;


            textBoxID.Text = EmployeeClass.GetEmployeetMaxId();

            DataTable rolesTable = employeeClass.GetAllRoles();

            comboBoxRole.DataSource = rolesTable;
            comboBoxRole.DisplayMember = "role_name";
            comboBoxRole.ValueMember = "id_role";

            if (comboBoxRole.Items.Count > 0)
                comboBoxRole.SelectedIndex = 0;
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            string firstName = textBoxFirstName.Text;
            string middleName = textBoxMiddleName.Text;
            string lastName = textBoxLastName.Text;
            string roleName = comboBoxRole.Text;
            string id_role = EmployeeClass.GetRoleId(roleName);
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
                MessageBox.Show(
                    "Необходимо заполнить все поля.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (employeeClass.IsLoginUsed(login))
            {
                MessageBox.Show(
                    $"Логин '{login}' используется другим пользователем.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = employeeClass.AddEmployee(
                id, firstName, middleName, lastName, id_role, phone, login, password);

            foreach (DataGridViewRow row in dataGridViewShifts.Rows)
            {
                if (row.IsNewRow) continue;

                string shiftDate = row.Cells["date"].Value.ToString();
                string shiftStart = row.Cells["start"].Value.ToString();
                string shiftEnd = row.Cells["end"].Value.ToString();

                employeeClass.AddShift(
                    id,
                    DateTime.Parse(shiftDate),
                    TimeSpan.Parse(shiftStart),
                    TimeSpan.Parse(shiftEnd)
                );
            }

            if (success)
            {
                MessageBox.Show("Информация о сотруднике успешно добавлена.");
                buttonBack.PerformClick();
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении информации о сотруднике.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            this.Close();
            lastForm.Show();
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
            TimeSpan start = timePickerStart.Value.TimeOfDay;
            TimeSpan end = timePickerEnd.Value.TimeOfDay;

            foreach (DataGridViewRow row in dataGridViewShifts.Rows)
            {
                if (row.IsNewRow) continue;

                if (DateTime.TryParse(row.Cells["date"].Value.ToString(), out DateTime existingDate))
                {
                    if (existingDate.Date == date)
                    {
                        MessageBox.Show("Смена на эту дату уже добавлена.");
                        return;
                    }
                }
            }

            if (date < DateTime.Today)
            {
                MessageBox.Show("Дата смены не может быть в прошлом.");
                return;
            }

            if (start == end)
            {
                MessageBox.Show("Время начала и окончания смены не может совпадать.");
                return;
            }

            dataGridViewShifts.Rows.Add(
                date.ToShortDateString(),
                start.ToString(@"hh\:mm"),
                end.ToString(@"hh\:mm")
            );
        }

        private void dataGridViewShifts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dataGridViewShifts.Columns[e.ColumnIndex].Name == "delete")
            {
                DataGridViewRow row = dataGridViewShifts.Rows[e.RowIndex];

                if (row.IsNewRow || row.Cells["date"].Value == null ||
                    string.IsNullOrWhiteSpace(row.Cells["date"].Value.ToString()))
                {
                    return;
                }

                dataGridViewShifts.Rows.RemoveAt(e.RowIndex);               
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(AddEmployee));
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
