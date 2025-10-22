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

namespace BarBarevich.Forms.View.Products
{
    public partial class EditProduct : Form
    {
        private ProductView lastForm;
        private ProductClass productClass;
        private string productId;

        private string unitName; 

        public EditProduct(ProductView form, string id, string name, string unit, string quantity)
        {
            InitializeComponent();
            lastForm = form;
            productClass = new ProductClass();

            productId = id;
            textBoxID.Text = id;
            textBoxName.Text = name;
            textBoxQuantity.Text = quantity;

            unitName = unit; 
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            comboBoxUnit.DataSource = productClass.GetUnits();
            comboBoxUnit.DisplayMember = "unit";
            comboBoxUnit.ValueMember = "id_unit";

            comboBoxUnit.SelectedIndex = comboBoxUnit.FindStringExact(unitName);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string newName = textBoxName.Text.Trim();
            string unitId = comboBoxUnit.SelectedValue?.ToString();

            string quantityText = textBoxQuantity.Text.Replace(',', '.');

            if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(quantityText) 
                || string.IsNullOrWhiteSpace(unitId))
            {
                MessageBox.Show("Пожалуйста, Необходимо заполнить все поля.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!decimal.TryParse(quantityText, System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out decimal quantity) ||
                quantity <= 0)
            {
                MessageBox.Show("Необходимо ввести корректное значение количества продукта на складе.");
                return;
            }

            string currentName = productClass.GetProductNameById(productId);
            if (newName != currentName && productClass.IsProductNameExists(newName))
            {
                MessageBox.Show($"Продукт с названием \"{newName}\" уже существует.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ProductClass.EditProduct(productId, newName, unitId, 
                quantity.ToString(System.Globalization.CultureInfo.InvariantCulture)))
                MessageBox.Show("Информация о продукте успешно изменена.");
            else
                MessageBox.Show("Ошибка при изменении информации о продукте.");

            buttonBack.PerformClick();
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            this.Close();
            lastForm.Show();
        }

        private void textBoxOnlyDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHelper.RestrictToDigits(sender, e);
        }
        private void textBoxProductQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != '\b' && ch != '.' && ch != ',')
            {
                e.Handled = true;
                return;
            }

            if (sender is TextBox textBox)
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
                HelpManager.ShowHelp(nameof(EditProduct));
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