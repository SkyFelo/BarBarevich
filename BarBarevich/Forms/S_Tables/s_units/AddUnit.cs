using BarBarevich.Classes;
using BarBarevich.Classes.S_Tables;
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
    public partial class AddUnit : Form
    {
        private S_UnitsClass sUnitsClass;
        private UnitForm lastForm;
        public AddUnit(UnitForm lastForm)
        {
            InitializeComponent();
            sUnitsClass = new S_UnitsClass();
            this.lastForm = lastForm;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            string line = textBoxInput.Text;

            if (string.IsNullOrWhiteSpace(line))
            {
                MessageBox.Show("Необходимо заполнить все поля.");
            }
            else
            {
                if (sUnitsClass.GetUnits().AsEnumerable().Any(row => row.Field<string>("unit") == line))
                {
                    MessageBox.Show("Единица измерения " + line + " уже добавлена в справочник.", 
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sUnitsClass.AddUnit(id, line);
                MessageBox.Show("Единица измерения успешно добавлена.");

                buttonBack.PerformClick();
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

        }

        private void AddUnit_Load(object sender, EventArgs e)
        {
            string id = sUnitsClass.GetUnitMaxId();
            textBoxID.Text = id;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(AddUnit));
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
