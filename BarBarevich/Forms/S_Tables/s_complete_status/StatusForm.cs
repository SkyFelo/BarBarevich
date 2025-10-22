using BarBarevich.Classes;
using BarBarevich.Classes.S_Tables;
using BarBarevich.Forms.S_Tables.s_employee_role;
using BarBarevich.Forms.S_Tables.s_menu_category;
using BarBarevich.Forms.View.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarBarevich.Forms.S_Tables.s_menu_complete_status
{
    public partial class StatusForm : Form
    {
        private S_StatusClass sMenuStatusClass;
        private MainForm lastForm;
        public StatusForm(MainForm lastForm)
        {
            InitializeComponent();
            sMenuStatusClass = new S_StatusClass();
            this.lastForm = lastForm;
        }

        private void MenuStatusForm_Load(object sender, EventArgs e)
        {
            DataTable lines = sMenuStatusClass.GetStatuses();
            dataGridView1.DataSource = lines;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStatus addMenuStatus = new AddStatus(this);
            addMenuStatus.StartPosition = FormStartPosition.Manual;
            addMenuStatus.Location = this.Location;
            this.Hide();
            addMenuStatus.Show();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string id = selectedRow.Cells["id"].Value.ToString();
                string name = selectedRow.Cells["complete_status"].Value.ToString();

                s_complete_status.EditStatusForm editMenuStatus = new s_complete_status.EditStatusForm(this, id, name);
                editMenuStatus.StartPosition = FormStartPosition.Manual;
                editMenuStatus.Location = this.Location;
                this.Hide();
                editMenuStatus.Show();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать статус для редактирования.");
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string id = selectedRow.Cells["id"].Value.ToString();

                if (sMenuStatusClass.IsStatusInUse(id))
                {
                    MessageBox.Show("Невозможно удалить должность, так как она используется.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранный статус?", 
                    "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool success = sMenuStatusClass.DeleteStatus(id);
                    if (success)
                    {
                        MessageBox.Show("Статус успешно удален.");

                        MenuStatusForm_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при удалении статуса.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать статус для удаления.");
            }
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            this.Close();
            lastForm.Show();
        }

        private void MenuStatusForm_VisibleChanged(object sender, EventArgs e)
        {
            MenuStatusForm_Load(sender, e);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(StatusForm));
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
