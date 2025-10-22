using BarBarevich.Classes;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarBarevich.Forms.View.Products
{
    public partial class WriteOffForm : Form
    {
        private string productId;
        private string productName;
        private decimal stockQuantity;
        private ProductView productView;

        public WriteOffForm(string productId, string productName, decimal stockQuantity, ProductView productView)
        {
            InitializeComponent();
            this.productId = productId;
            this.productName = productName;
            this.stockQuantity = stockQuantity;
            this.productView = productView;
        }

        private void WriteOffForm_Load(object sender, EventArgs e)
        {
            labelProductName.Text = productName;
            textBoxQuantity.Text = "10,00";

            var writeOffTypes = new ProductClass().GetWriteOffTypes();

            comboBoxWriteOffType.DataSource = writeOffTypes;
            comboBoxWriteOffType.DisplayMember = "Type";
            comboBoxWriteOffType.ValueMember = "Id";
        }

        private void buttonConfirmWriteOff_Click(object sender, EventArgs e)
        {
            string quantityToWriteOffText = textBoxQuantity.Text.Replace(',', '.');

            if (string.IsNullOrWhiteSpace(quantityToWriteOffText))
            {
                MessageBox.Show("Необходимо заполнить количество для списания.");
                return;
            }

            if (!decimal.TryParse(quantityToWriteOffText, System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out decimal quantityToWriteOff))
            {
                MessageBox.Show("Необходимо ввести корректное количество для списания.");
                return;
            }

            if (quantityToWriteOff > stockQuantity)
            {
                MessageBox.Show("На складе недостаточно продукта.");
                return;
            }

            string writeOffTypeId = comboBoxWriteOffType.SelectedValue.ToString();

            bool success = ProductClass.WriteOffProduct(productId, quantityToWriteOff, writeOffTypeId);

            if (success)
            {
                MessageBox.Show("Продукт успешно списан.");

                productView.LoadData();

                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка при списании продукта.");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxProductQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != '\b' && ch != '.' && ch != ',')
            {
                e.Handled = true;
                return;
            }

            if (sender is System.Windows.Forms.TextBox textBox)
            {
                if ((ch == '.' || ch == ',') && (textBox.Text.Contains('.') || textBox.Text.Contains(',')))
                {
                    e.Handled = true;
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(WriteOffForm));
                return true;
            }

            if (keyData == Keys.Enter)
            {
                buttonConfirmWriteOff.PerformClick();
                return true;
            }

            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
