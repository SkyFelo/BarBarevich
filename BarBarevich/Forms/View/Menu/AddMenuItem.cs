using BarBarevich.Classes;
using BarBarevich.Forms.View.Products;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BarBarevich.Forms.View.Menu
{
    public partial class AddMenuItem : Form
    {
        private MenuView lastForm;
        private MenuClass menuClass;
        private ProductClass productClass;
        private List<(int id_product, string product_name, double quantity)> recipe;

        public AddMenuItem(MenuView lastForm)
        {
            InitializeComponent();
            this.lastForm = lastForm;
            menuClass = new MenuClass();
            productClass = new ProductClass();
            recipe = new List<(int, string, double)>();
        }

        private void AddMenuItem_Load(object sender, EventArgs e)
        {
            textBoxID.Text = menuClass.GetNextItemId();

            comboBoxCategory.Items.Clear();
            comboBoxCategory.Items.AddRange(menuClass.GetAllCategories().ToArray());

            if (comboBoxCategory.Items.Count > 0)
                comboBoxCategory.SelectedIndex = 0;

            comboBoxProduct.Items.Clear();
            foreach (var row in productClass.GetAllProductsSorted().Rows.Cast<DataRow>())
            {
                string unit = row["unit"].ToString();
                string name = row["product_name"].ToString();
                int id = Convert.ToInt32(row["id_product"]);
                comboBoxProduct.Items.Add(new ComboBoxItem($"{name} ({unit})", id));
            }

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.HeaderText = "Удалить";
            deleteButton.Text = "➖";
            deleteButton.UseColumnTextForButtonValue = true;
            dataGridViewRecipe.Columns.Add(deleteButton);
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
            string category = comboBoxCategory.Text;
            string id_category = menuClass.GetCategoryId(category);

            string priceText = textBoxPrice.Text.Replace(',', '.');
            string gramsText = textBoxGrams.Text.Replace(',', '.');
            string caloriesText = textBoxCalories.Text.Replace(',', '.');

            if (string.IsNullOrWhiteSpace(name) ||
               string.IsNullOrWhiteSpace(priceText) ||
               string.IsNullOrWhiteSpace(gramsText) ||
               string.IsNullOrWhiteSpace(caloriesText))
            {
                MessageBox.Show("Необходимо заполнить все поля.");
                return;
            }

            if (!decimal.TryParse(priceText, System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out decimal price) ||
                !decimal.TryParse(gramsText, System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out decimal grams) ||
                !decimal.TryParse(caloriesText, System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out decimal calories) ||
                price <= 0 || grams <= 0 || calories <= 0)
            {
                MessageBox.Show("Необходимо ввести корректные числовые значения для цены, грамм и калорий.");
                return;
            }

            if (menuClass.IsMenuItemExists(name, id))
            {
                MessageBox.Show($"Пункт меню {name} уже существует.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!menuClass.AddMenuItem(id, name, id_category,
    price.ToString(System.Globalization.CultureInfo.InvariantCulture),
    grams.ToString(System.Globalization.CultureInfo.InvariantCulture),
    calories.ToString(System.Globalization.CultureInfo.InvariantCulture)))
            {
                MessageBox.Show("Ошибка при добавлении информации о пункте меню.");
                return;
            }

            foreach (var entry in recipe)
                productClass.AddProductToRecipe(entry.id_product, int.Parse(id), entry.quantity);

            MessageBox.Show("Информация о пункте меню успешно добавлена.");
            buttonBack.PerformClick();
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHelper.RestrictToNonDigits(sender, e);
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            string quantityInput = textBoxProductQuantity.Text.Replace(',', '.');

            if (comboBoxProduct.SelectedItem is ComboBoxItem selected &&
                double.TryParse(quantityInput, System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out double quantity) &&
                quantity > 0)
            {
                if (recipe.Any(x => x.id_product == selected.Value))
                {
                    MessageBox.Show("Продукт уже добавлен в рецептуру.");
                    return;
                }

                recipe.Add((selected.Value, selected.Text, quantity));
                dataGridViewRecipe.Rows.Add(selected.Text, quantity.ToString("0.##",
                    System.Globalization.CultureInfo.InvariantCulture));

                if (double.TryParse(textBoxGrams.Text.Replace(',', '.'),
                    System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture,
                    out double currentGrams))
                {
                    double newGrams = currentGrams + quantity;
                    textBoxGrams.Text = newGrams.ToString("0.##",
                        System.Globalization.CultureInfo.InvariantCulture);
                }
                else
                {
                    textBoxGrams.Text = quantity.ToString("0.##",
                        System.Globalization.CultureInfo.InvariantCulture);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать продукт и Необходимо ввести корректное количество.");
            }
        }


        private void dataGridViewRecipe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                if (double.TryParse(
                    dataGridViewRecipe.Rows[e.RowIndex].Cells[1].Value?.ToString().Replace(',', '.'),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out double quantityToRemove))
                {
                    if (double.TryParse(
                        textBoxGrams.Text.Replace(',', '.'),
                        System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture,
                        out double currentGrams))
                    {
                        double newGrams = currentGrams - quantityToRemove;
                        textBoxGrams.Text = (newGrams > 0 ? newGrams : 0).ToString("0.##", 
                            System.Globalization.CultureInfo.InvariantCulture);
                    }
                }

                recipe.RemoveAt(e.RowIndex);
                dataGridViewRecipe.Rows.RemoveAt(e.RowIndex);
            }
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public ComboBoxItem(string text, int value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(AddMenuItem));
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
    }
}
