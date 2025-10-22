using BarBarevich.Classes;
using BarBarevich.Forms.View.SupplyOrder;
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
    public partial class EditSupplier : Form
    {
        private SupplierView lastForm;
        private SupplierClass supplierClass;

        public EditSupplier(SupplierView lastForm, string id, string name, string phone, string address)
        {
            InitializeComponent();
            this.lastForm = lastForm;
            supplierClass = new SupplierClass();

            textBoxID.Text = id;
            textBoxName.Text = name;
            textBoxPhone.Text = phone;
            textBoxAddress.Text = address;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            this.Close();
            lastForm.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            string name = textBoxName.Text;
            string phone = textBoxPhone.Text;
            string address = textBoxAddress.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Необходимо заполнить все поля.");
                return;
            }

            string existingSupplierId = SupplierClass.GetSupplierId(phone);

            if (existingSupplierId != "0" && existingSupplierId != id)
            {
                MessageBox.Show($"Номер телефона {phone} уже используется другим поставщиком.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (SupplierClass.EditSupplier(id, name, phone, address))
                MessageBox.Show("Информация о поставщике успешно изменена.");
            else
                MessageBox.Show("Ошибка при изменении информации о поставщике.");

            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            this.Close();
            lastForm.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(EditSupplier));
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

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHelper.RestrictToDigits(sender, e);
        }
    }
}