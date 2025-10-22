using BarBarevich.Classes;
using System;
using System.Windows.Forms;

namespace BarBarevich.Forms.View.Tables
{
    public partial class AddTable : Form
    {
        private TablesView lastForm;
        private TableClass tableClass;

        public AddTable(TablesView lastForm)
        {
            InitializeComponent();
            this.lastForm = lastForm;
            tableClass = new TableClass();
        }

        private void AddTable_Load(object sender, EventArgs e)
        {
            string id = TableClass.GetTableMaxId();
            textBoxID.Text = id;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            lastForm.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            string description = textBoxInfo.Text;
            string peopleCount = textBoxPeopleCount.Text;

            if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Необходимо заполнить описание стола.");
                return;
            }

            if (!int.TryParse(peopleCount, out int count) || count <= 0)
            {
                MessageBox.Show("Необходимо ввести количество мест.");
                return;
            }

            if (TableClass.AddTable(id, description, peopleCount))
            {
                MessageBox.Show("Информация о столе успешно добавлена.");
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении информации о столе.");
            }

            buttonBack.PerformClick();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(AddTable));
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
