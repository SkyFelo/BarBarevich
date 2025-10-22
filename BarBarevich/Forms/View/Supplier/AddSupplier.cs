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
    public partial class AddSupplier : Form
    {
        private SupplierView lastForm;
        private SupplierClass supplierClass;

        public AddSupplier(SupplierView lastForm)
        {
            InitializeComponent();
            this.lastForm = lastForm;
            supplierClass = new SupplierClass();
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
            string name = textBoxName.Text;
            string phone = textBoxPhone.Text;
            string address = textBoxAddress.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Необходимо заполнить все поля.");
            }
            else
            {
                string existingId = SupplierClass.GetSupplierId(phone);

                if (existingId != "0")
                {
                    MessageBox.Show($"Поставщик с номером телефона {phone} уже добавлен в таблицу.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (SupplierClass.AddSupplier(id, name, phone, address))
                    MessageBox.Show("Информация о поставщике успешно добавлена.");
                else
                    MessageBox.Show("Ошибка при добавлении иноформации о поставщике.");

                buttonBack.PerformClick();
            }
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {
            string id = SupplierClass.GetSupplierMaxId();
            textBoxID.Text = id;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(AddSupplier));
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

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHelper.RestrictToDigits(sender, e);
        }
    }
}