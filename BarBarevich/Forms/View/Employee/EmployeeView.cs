using BarBarevich.Classes;
using BarBarevich.Forms.View.Menu;
using BarBarevich.Forms.View.Products;
using System;
using System.Data;
using System.Windows.Forms;

namespace BarBarevich.Forms.View.Employee
{
    public partial class EmployeeView : Form
    {
        private EmployeeClass employeeClass;
        private MainForm lastForm;

        public EmployeeView(MainForm lastForm)
        {
            InitializeComponent();
            employeeClass = new EmployeeClass();
            this.lastForm = lastForm;
        }

        private void EmployeeView_Load(object sender, EventArgs e)
        {
            employeeClass.FillDataGridViewEmployees(dataGridView1);
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
            AddEmployee addEmployee = new AddEmployee(this);
            this.Hide();
            addEmployee.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string id = selectedRow.Cells["id_employee"].Value.ToString();
                string firstName = selectedRow.Cells["first_name"].Value.ToString();
                string middleName = selectedRow.Cells["middle_name"].Value.ToString();
                string lastName = selectedRow.Cells["last_name"].Value.ToString();
                string role = selectedRow.Cells["role_name"].Value.ToString();
                string phone = selectedRow.Cells["phone"].Value.ToString();
                string login = selectedRow.Cells["login"].Value.ToString();
                string password = selectedRow.Cells["password"].Value.ToString();

                EditEmployee editEmployee = new EditEmployee(this, id, firstName, middleName,
                    lastName, role, phone, login, password);
                editEmployee.StartPosition = FormStartPosition.Manual;
                editEmployee.Location = this.Location;
                this.Hide();
                editEmployee.Show();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать сотрудника для редактирования.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string id = selectedRow.Cells["id_employee"].Value.ToString();

                if (employeeClass.IsEmployeeUsed(id))
                {
                    MessageBox.Show("Невозможно удалить информацию о сотруднике, так как она уже используется.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранную информацию о сотруднике?",
                                                      "Подтверждение удаления",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (EmployeeClass.DeleteEmployee(id))
                        MessageBox.Show("Информация о сотруднике успешно удалена.");
                    else
                        MessageBox.Show("Ошибка при удалении мнформации о сотруднике.");
                }

                employeeClass.FillDataGridViewEmployees(dataGridView1);
            }
            else
            {
                MessageBox.Show("Необходимо выбрать сотрудника для удаления.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string employeeId = dataGridView1.Rows[e.RowIndex].Cells["id_employee"].Value.ToString();

                DataTable workDatetimes = employeeClass.GetWorkDatetimesForEmployee(employeeId);

                dataGridViewWorkDatetime.DataSource = workDatetimes;
            }
        }

        private void EmployeeView_VisibleChanged(object sender, EventArgs e)
        {
            employeeClass.FillDataGridViewEmployees(dataGridView1);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(EmployeeView));
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
