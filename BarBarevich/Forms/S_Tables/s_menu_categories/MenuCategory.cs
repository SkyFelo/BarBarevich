using BarBarevich.Classes;
using BarBarevich.Classes.S_Tables;
using BarBarevich.Forms.S_Tables.s_employee_role;
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

namespace BarBarevich.Forms.S_Tables.s_menu_category
{
    public partial class MenuCategory : Form
    {
        private S_MenuCategoriesClass s_menu_category;
        private MainForm lastForm;
        public MenuCategory(MainForm lastForm)
        {
            InitializeComponent();
            this.s_menu_category = new S_MenuCategoriesClass();
            this.lastForm = lastForm;
        }

        private void MenuCategory_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = s_menu_category.GetMenuCategories();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            this.Close();
            lastForm.Show();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMenuCategory addMenuCategory = new AddMenuCategory(this);
            addMenuCategory.StartPosition = FormStartPosition.Manual;
            addMenuCategory.Location = this.Location;
            this.Hide();
            addMenuCategory.Show();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string id = selectedRow.Cells["id"].Value.ToString();
                string line = selectedRow.Cells["category_name"].Value.ToString();

                EditMenuCategory editMenuCategory
                    = new EditMenuCategory(this, id, line);
                editMenuCategory.StartPosition = FormStartPosition.Manual;
                editMenuCategory.Location = this.Location;
                this.Hide();
                editMenuCategory.ShowDialog();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать категорию для редактирования.");
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string id = selectedRow.Cells["id"].Value.ToString();

                if (s_menu_category.IsMenuCategoryInUse(id))
                {
                    MessageBox.Show("Невозможно удалить категорию, так как она уже используется.",
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show
                ("Вы уверены, что хотите удалить выбранную категорию?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool customerDeleted = s_menu_category.DeleteMenuCategory(id);

                    if (customerDeleted)
                    {
                        MessageBox.Show("Категория успешно удалена.");
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при удалении категории.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать категорию для удаления.");
            }

            dataGridView1.DataSource = s_menu_category.GetMenuCategories();
        }

        private void MenuCategory_VisibleChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = s_menu_category.GetMenuCategories();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(MenuCategory));
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
