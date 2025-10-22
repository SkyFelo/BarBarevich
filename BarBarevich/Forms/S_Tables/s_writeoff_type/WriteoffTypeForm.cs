using BarBarevich.Classes;
using BarBarevich.Classes.S_Tables;
using BarBarevich.Forms.S_Tables.s_employee_role;
using BarBarevich.Forms.S_Tables.s_units;
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

namespace BarBarevich.Forms.S_Tables.s_writeoff_type
{
    public partial class WriteoffTypeForm : Form
    {
        private S_WriteoffTypeClass sWriteoffTypeClass;
        private MainForm lastForm;
        public WriteoffTypeForm(MainForm lastForm)
        {
            InitializeComponent();
            sWriteoffTypeClass = new S_WriteoffTypeClass();
            this.lastForm = lastForm;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddWriteoffType addWriteoffType = new AddWriteoffType(this);
            addWriteoffType.StartPosition = FormStartPosition.Manual;
            addWriteoffType.Location = this.Location;
            this.Hide();
            addWriteoffType.Show();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string id = selectedRow.Cells["id"].Value.ToString();
                string name = selectedRow.Cells["writeoff_type"].Value.ToString();

                EditWriteoffType editWriteoffType = new EditWriteoffType(this, id, name);
                editWriteoffType.StartPosition = FormStartPosition.Manual;
                editWriteoffType.Location = this.Location;
                this.Hide();
                editWriteoffType.Show();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать тип списания для редактирования.");
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string id = selectedRow.Cells["id"].Value.ToString();

                if (sWriteoffTypeClass.IsWriteoffTypeInUse(id))
                {
                    MessageBox.Show("Невозможно удалить тип списания, так как он используется.", 
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранный тип списания?", 
                    "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool success = sWriteoffTypeClass.DeleteWriteoffType(id);
                    if (success)
                    {
                        MessageBox.Show("Тип списания успешно удален.");

                        WriteoffTypeForm_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при удалении типа списания.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать тип списания для удаления.");
            }
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            this.Close();
            lastForm.Show();
        }

        private void WriteoffTypeForm_Load(object sender, EventArgs e)
        {
            DataTable lines = sWriteoffTypeClass.GetWriteoffTypes();
            dataGridView1.DataSource = lines;
        }

        private void WriteoffTypeForm_VisibleChanged(object sender, EventArgs e)
        {
            DataTable lines = sWriteoffTypeClass.GetWriteoffTypes();
            dataGridView1.DataSource = lines;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(WriteoffTypeForm));
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
