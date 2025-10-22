using BarBarevich.Classes;
using BarBarevich.Forms.View.Menu;
using BarBarevich.Forms.View.Products;
using System;
using System.Windows.Forms;

namespace BarBarevich.Forms.View
{
    public partial class MenuView : Form
    {
        private MenuClass menuClass;
        private MainForm lastForm;

        public MenuView(MainForm mainForm)
        {
            InitializeComponent();
            menuClass = new MenuClass();
            lastForm = mainForm;
        }

        private void MenuView_Load(object sender, EventArgs e)
        {
            dataGridViewMenu.DataSource = menuClass.GetMenuItems();

            comboBoxCategory.Items.Clear();
            comboBoxCategory.Items.AddRange(menuClass.GetMenuCategories().ToArray());

            if (comboBoxCategory.Items.Count > 0)
                comboBoxCategory.SelectedIndex = -1;

            comboBoxChoice.SelectedIndex = -1;
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
            AddMenuItem addMenuItem = new AddMenuItem(this);
            addMenuItem.StartPosition = FormStartPosition.Manual;
            addMenuItem.Location = this.Location;
            this.Hide();
            addMenuItem.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenu.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewMenu.SelectedRows[0];

                string id = selectedRow.Cells["id_item"].Value.ToString();
                string name = selectedRow.Cells["name"].Value.ToString();
                string category = selectedRow.Cells["category_name"].Value.ToString();
                string price = selectedRow.Cells["price"].Value.ToString();
                string grams = selectedRow.Cells["grams_ml"].Value.ToString();
                string calories = selectedRow.Cells["calories"].Value.ToString();

                EditMenuItem editMenuItem = new EditMenuItem(this, id, name, category, price, grams, calories);
                editMenuItem.StartPosition = FormStartPosition.Manual;
                editMenuItem.Location = this.Location;
                this.Hide();
                editMenuItem.Show();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать пункт меню для редактирования.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenu.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewMenu.SelectedRows[0];
                string id = selectedRow.Cells["id_item"].Value.ToString();

                if (menuClass.IsMenuItemUsed(id))
                {
                    MessageBox.Show("Невозможно удалить позицию, так как она используется в заказе.",
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранный пункт меню?",
                                                      "Подтверждение удаления",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (menuClass.DeleteMenuItem(id))
                        MessageBox.Show("Информация о пункте меню успешно удалена.");
                    else
                        MessageBox.Show("Ошибка при удалении информации о пункте меню.");
                }

                dataGridViewMenu.DataSource = menuClass.GetMenuItems();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать пункт меню для удаления.");
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            comboBoxChoice.SelectedIndex = -1;

            textBoxSearch.Text = "";
            textBoxSearch.Enabled = false;

            comboBoxCategory.SelectedIndex = -1;
            comboBoxCategory.Enabled = false;

            labelSearch.Text = "*Необходимо выбрать фильтр для отбора";

            dataGridViewMenu.DataSource = menuClass.GetMenuItems();
        }

        private void dataGridViewMenu_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewMenu.SelectedRows.Count > 0)
            {
                string itemId = dataGridViewMenu.SelectedRows[0].Cells["id_item"].Value.ToString();
                dataGridViewRecipe.DataSource = menuClass.GetRecipeForMenuItem(itemId);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(MenuView));
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

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = comboBoxCategory.Text;
            dataGridViewMenu.DataSource = menuClass.GetMenuItemsByCategory(category);
        }

        private void comboBoxChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxChoice.SelectedIndex == 0) 
            {
                labelSearch.Text = "Необходимо выбрать категорию";
                comboBoxCategory.Visible = true;
                comboBoxCategory.Enabled = true;
                textBoxSearch.Visible = false;
                textBoxSearch.Enabled = false;
            }
            else if (comboBoxChoice.SelectedIndex == 1) 
            {
                labelSearch.Text = "Необходимо ввести наименование пункта";
                comboBoxCategory.Visible = false;
                comboBoxCategory.Enabled = false;
                textBoxSearch.Visible = true;
                textBoxSearch.Enabled = true;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
           string name = textBoxSearch.Text;
           dataGridViewMenu.DataSource = menuClass.GetMenuItemsByName(name);
        }
    }
}
