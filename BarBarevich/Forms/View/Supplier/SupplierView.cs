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

namespace BarBarevich.Forms.View.Supplier
{
    public partial class SupplierView : Form
    {
        private SupplierClass supplierClass;
        private MainForm lastForm;
        public SupplierView(MainForm mainForm)
        {
            InitializeComponent();
            supplierClass = new SupplierClass();
            this.lastForm = mainForm;
        }

        private void SuppliersView_Load(object sender, EventArgs e)
        {
            supplierClass.FillDataGridViewSuppliers(dataGridView1);
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
            AddSupplier addSupplier = new AddSupplier(this);
            addSupplier.StartPosition = FormStartPosition.Manual;
            addSupplier.Location = this.Location;
            this.Hide();
            addSupplier.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string id = selectedRow.Cells["id_supplier"].Value.ToString();
                string name = selectedRow.Cells["supplier_name"].Value.ToString();
                string phone = selectedRow.Cells["phone"].Value.ToString();
                string address = selectedRow.Cells["address"].Value.ToString();

                EditSupplier editSupplier = new EditSupplier(this, id, name, phone, address);
                editSupplier.StartPosition = FormStartPosition.Manual;
                editSupplier.Location = this.Location;
                this.Hide();
                editSupplier.Show();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать поставщика для редактирования.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string id = selectedRow.Cells["id_supplier"].Value.ToString();

                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту информацию о поставщике?", 
                    "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (SupplierClass.DeleteSupplier(id))
                        MessageBox.Show("Информация о поставщике успешно удалена.");
                    else
                        MessageBox.Show("Ошибка при удалении информации о поставщике.");
                }

                supplierClass.FillDataGridViewSuppliers(dataGridView1);
            }
            else
            {
                MessageBox.Show("Необходимо выбрать запись для удаления.");
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(SupplierView));
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