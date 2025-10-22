using BarBarevich.Classes;
using BarBarevich.Forms.View.Products;
using System;
using System.Windows.Forms;

namespace BarBarevich.Forms.View
{
    public partial class EditClient : Form
    {
        private ClientsView lastForm;
        private ClientClass clientClass;

        public EditClient(ClientsView lastForm, string id, string fio, string phone)
        {
            InitializeComponent();
            this.lastForm = lastForm;
            clientClass = new ClientClass();

            textBoxID.Text = id;
            textBoxFio.Text = fio;
            textBoxPhone.Text = phone;
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
            string fio = textBoxFio.Text;
            string phone = textBoxPhone.Text;

            if (string.IsNullOrWhiteSpace(fio) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Необходимо заполнить все поля.");
                return;
            }

            string existingClientId = ClientClass.GetClientId(phone);

            if (existingClientId != "0" && existingClientId != id)
            {
                MessageBox.Show($"Номер телефона {phone} уже используется другим клиентом.", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ClientClass.EditClient(id, fio, phone))
                MessageBox.Show("Информация о клиенте успешно изменена.");
            else
                MessageBox.Show("Ошибка при редактировании информации о клиенте.");

            buttonBack.PerformClick();
        }

        private void textBoxFio_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHelper.RestrictToNonDigits(sender, e);
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHelper.RestrictToDigits(sender, e);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(EditClient));
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
