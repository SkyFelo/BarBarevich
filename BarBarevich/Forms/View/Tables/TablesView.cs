using BarBarevich.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarBarevich.Forms.View.Tables
{
    public partial class TablesView : Form
    {
        private MainForm lastForm;
        private TableClass tableClass;
        public TablesView(MainForm lastForm)
        {
            InitializeComponent();
            this.lastForm = lastForm;
            tableClass = new TableClass();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string id = selectedRow.Cells["id_table"].Value.ToString();
                string tableInfo = selectedRow.Cells["description"].Value.ToString();
                string peopleCount = selectedRow.Cells["seats_count"].Value.ToString();
                EditTable editTable = new EditTable(this, id, tableInfo, peopleCount);
                editTable.StartPosition = FormStartPosition.Manual;
                editTable.Location = this.Location;
                this.Hide();
                editTable.Show();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать стол для редактирования.");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            this.Close();
            lastForm.Show();
        }

        private void TablesView_Load(object sender, EventArgs e)
        {
            tableClass.FillDataGridViewTables(dataGridView1);
        }

        private void TablesView_VisibleChanged(object sender, EventArgs e)
        {
            tableClass.FillDataGridViewTables(dataGridView1);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddTable addTable = new AddTable(this);
            addTable.StartPosition = FormStartPosition.Manual;
            addTable.Location = this.Location;
            this.Hide();    
            addTable.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string id = selectedRow.Cells["id_table"].Value.ToString();

                TableClass tableClass = new TableClass();

                if (tableClass.IsClientUsed(id))
                {
                    MessageBox.Show("Невозможно удалить стол, так как он указан в бронировании.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранный стол?",
                    "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (TableClass.DeleteTable(id))
                        MessageBox.Show("Стол успешно удален.");
                    else
                        MessageBox.Show("Ошибка при удалении стола.");
                }

                tableClass.FillDataGridViewTables(dataGridView1);
            }
            else
            {
                MessageBox.Show("Необходимо выбрать стол для удаления.");
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(TablesView));
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
