using BarBarevich.Classes;
using BarBarevich.Forms.View.Products;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BarBarevich.Forms.S_Tables.s_employee_role
{
    public partial class EditEmployeeRole : Form
    {
        private EmployeeRoleForm lastForm;
        private S_EmployeeRolesClass sEmployeeRolesClass;

        public EditEmployeeRole(EmployeeRoleForm lastForm, string id, string input)
        {
            InitializeComponent();
            this.lastForm = lastForm;
            sEmployeeRolesClass = new S_EmployeeRolesClass();

            textBoxID.Text = id;
            textBoxInput.Text = input;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Должность " + line + " уже добавлена в справочник.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    sEmployeeRolesClass.EditEmployeeRole(id, line);
                    MessageBox.Show("Должность успешно изменена.");

                    buttonBack.PerformClick();
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            this.Close();
            lastForm.Show();
        }

        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHelper.RestrictToNonDigits(sender, e);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(EditEmployeeRole));
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
