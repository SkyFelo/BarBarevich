using BarBarevich.Classes;
using BarBarevich.Forms.View.Products;
using System;
using System.Data;
using System.Windows.Forms;

namespace BarBarevich.Forms.S_Tables.s_employee_role
{
    public partial class EmployeeRoleForm : Form
    {
        private S_EmployeeRolesClass sEmployeeRolesClass;
        private MainForm lastForm;

        public EmployeeRoleForm(MainForm lastForm)
        {
            InitializeComponent();
            sEmployeeRolesClass = new S_EmployeeRolesClass();
            this.lastForm = lastForm;
        }

        private void EmployeeRoleForm_Load(object sender, EventArgs e)
        {
            DataTable roles = sEmployeeRolesClass.GetEmployeeRoles();
            dataGridView1.DataSource = roles;
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            this.Close();
            lastForm.Show();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployeeRole addEmployeeRole = new AddEmployeeRole(this);
            addEmployeeRole.StartPosition = FormStartPosition.Manual;
            addEmployeeRole.Location = this.Location;
            this.Hide();
            addEmployeeRole.Show();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string id = selectedRow.Cells["id"].Value.ToString();
                string name = selectedRow.Cells["role"].Value.ToString();

                EditEmployeeRole editEmployeeRole = new EditEmployeeRole(this, id, name);
                editEmployeeRole.StartPosition = FormStartPosition.Manual;
                editEmployeeRole.Location = this.Location;
                this.Hide();
                editEmployeeRole.ShowDialog();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать должность для редактирования.");
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string id = selectedRow.Cells["id"].Value.ToString();

                if (sEmployeeRolesClass.IsRoleInUse(id))
                {
                    MessageBox.Show("Невозможно удалить должность, так как она используется.", 
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранную должность?", 
                    "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool success = sEmployeeRolesClass.DeleteEmployeeRole(id);
                    if (success)
                    {
                        MessageBox.Show("Должность успешно удалена.");

                        EmployeeRoleForm_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при удалении должности.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать должность для удаления.");
            }
        }

        private void EmployeeRoleForm_VisibleChanged(object sender, EventArgs e)
        {
            EmployeeRoleForm_Load(sender, e);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(EmployeeRoleForm));
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
