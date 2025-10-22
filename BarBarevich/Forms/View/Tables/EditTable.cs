using BarBarevich.Classes;
using BarBarevich.Forms.View.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarBarevich.Forms.View.Tables
{
    public partial class EditTable : Form
    {    
        private TablesView lastForm;
        public EditTable(TablesView lastForm, string id_table, string tableInfo, string peopleCount)
        {
            InitializeComponent();
            this.lastForm = lastForm;

            textBoxID.Text = id_table;
            textBoxInfo.Text = tableInfo;
            textBoxPeopleCount.Text = peopleCount;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string id_table = textBoxID.Text;
            string tableInfo = textBoxInfo.Text;
            string peopleCount = textBoxPeopleCount.Text;

            if (string.IsNullOrWhiteSpace(tableInfo))
            {
                MessageBox.Show("Необходимо заполнить описание стола.");
            }
            else if (int.Parse(peopleCount) <= 0)
            {
                MessageBox.Show("Необходимо ввести количество мест.");
            }
            else
            {
                TableClass.EditTable(id_table, tableInfo, peopleCount);

                MessageBox.Show("Информация о столе изменена.");

                buttonBack.PerformClick();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            lastForm.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(EditTable));
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
