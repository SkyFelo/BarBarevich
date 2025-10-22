using BarBarevich.Classes;
using BarBarevich.Classes.S_Tables;
using BarBarevich.Forms.S_Tables.s_employee_role;
using BarBarevich.Forms.S_Tables.s_menu_complete_status;
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

namespace BarBarevich.Forms.S_Tables.s_units
{
    public partial class UnitForm : Form
    {
        private S_UnitsClass sUnitsClass;
        private MainForm lastForm;
        public UnitForm(MainForm lastForm)
        {
            InitializeComponent();
            sUnitsClass = new S_UnitsClass();
            this.lastForm = lastForm;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUnit addUnit = new AddUnit(this);
            addUnit.StartPosition = FormStartPosition.Manual;
            addUnit.Location = this.Location;
            this.Hide();
            addUnit.Show();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string id = selectedRow.Cells["id"].Value.ToString();
                string name = selectedRow.Cells["unit"].Value.ToString();

                EditUnit editUnit = new EditUnit(this, id, name);
                editUnit.StartPosition = FormStartPosition.Manual;
                editUnit.Location = this.Location;
                this.Hide();
                editUnit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать единицу измерения для редактирования.");
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string id = selectedRow.Cells["id"].Value.ToString();

                if (sUnitsClass.IsUnitInUse(id))
                {
                    MessageBox.Show("Невозможно удалить должность, так как она используется.", 
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранную единицу измерения?", 
                    "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool success = sUnitsClass.DeleteUnit(id);
                    if (success)
                    {
                        MessageBox.Show("Единица измерения успешно удалена.");

                        UnitForm_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при удалении единицы измерения.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать единицу измерения для удаления.");
            }
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            this.Close();
            lastForm.Show();
        }

        private void UnitForm_Load(object sender, EventArgs e)
        {
            DataTable lines = sUnitsClass.GetUnits();
            dataGridView1.DataSource = lines;
        }

        private void UnitForm_VisibleChanged(object sender, EventArgs e)
        {
            DataTable lines = sUnitsClass.GetUnits();
            dataGridView1.DataSource = lines;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(UnitForm));
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
