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
    public partial class EditMenuCategory : Form
    {
        private S_MenuCategoriesClass s_menu_category;
        private MenuCategory lastForm;
        public EditMenuCategory(MenuCategory lastForm, string id, string input)
        {
            InitializeComponent();
            this.s_menu_category = new S_MenuCategoriesClass();
            this.lastForm = lastForm;

            textBoxID.Text = id;
            textBoxInput.Text = input;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            string line = textBoxInput.Text;

            if (string.IsNullOrWhiteSpace(line))
            {
                MessageBox.Show("Необходимо заполнить все поля.");
            }
            else
            {
                if (s_menu_category.GetMenuCategories().AsEnumerable().Any(row => 
                row.Field<string>("category_name") == line))
                {
                    MessageBox.Show("Категория меню " + line + " уже добавлена в справочник.", 
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    s_menu_category.EditMenuCategory(id, line);

                    MessageBox.Show("Категория меню  успешно изменена.");

                    buttonBack.PerformClick();
                }
            }              
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            this.Close();
            lastForm.Show();
        }

        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHelper.RestrictToNonDigits(sender, e);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(EditMenuCategory));
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
