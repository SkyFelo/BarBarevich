using BarBarevich.Classes;
using BarBarevich.Forms.View.Products;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BarBarevich.Forms.S_Tables.s_employee_role
{
    public partial class AddEmployeeRole : Form
    {
        private EmployeeRoleForm lastForm;
        private S_EmployeeRolesClass sEmployeeRolesClass;

        public AddEmployeeRole(EmployeeRoleForm lastForm)
        {
            InitializeComponent();
            this.lastForm = lastForm;
            sEmployeeRolesClass = new S_EmployeeRolesClass();
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
            string id = textBoxID.Text;
            string line = textBoxInput.Text;

            if (string.IsNullOrWhiteSpace(line))
            {
                MessageBox.Show("Необходимо заполнить все поля.");
            }
            else
            {
                if (sEmployeeRolesClass.GetEmployeeRoles().AsEnumerable().Any(row => row.Field<string>("role_name") == line))
                {
                    MessageBox.Show("Дожность " + line + " уже добавлена в справочник.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sEmployeeRolesClass.AddEmployeeRole(id, line);
                MessageBox.Show("Должность успешно добавлена.");

                buttonBack.PerformClick();
            }
        }

        private void AddActivityType_Load(object sender, EventArgs e)
        {
            string id = sEmployeeRolesClass.GetEmployeeMaxId();
            textBoxID.Text = id;
        }

        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHelper.RestrictToNonDigits(sender, e);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(AddEmployeeRole));
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
