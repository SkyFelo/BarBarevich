using BarBarevich.Classes;
using BarBarevich.Forms.View.Products;
using System;
using System.Windows.Forms;

namespace BarBarevich.Forms.View
{
    public partial class AddClient : Form
    {
        private ClientsView lastForm;
        private ClientClass clientClass;

        public AddClient(ClientsView lastForm)
        {
            InitializeComponent();
            this.lastForm = lastForm;
            clientClass = new ClientClass();
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
            string fio = textBoxFio.Text;
            string phone = textBoxPhone.Text;

            if (string.IsNullOrWhiteSpace(fio) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Необходимо заполнить все поля.");
            }
            else
            {
                string existingId = ClientClass.GetClientId(phone);

                if (existingId != "0")
                {
                    MessageBox.Show(
                        $"Клиент с номером телефона {phone} уже добавлен в таблицу.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ClientClass.AddClient(id, fio, phone))
                    MessageBox.Show("Информация о клиенте успешно добавлена.");
                else
                    MessageBox.Show("Ошибка при добавлении информации о клиенте.");

                buttonBack.PerformClick();
            }
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            string id = ClientClass.GetClientMaxId();
            textBoxID.Text = id;
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHelper.RestrictToDigits(sender, e);
        }

        private void textBoxFio_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHelper.RestrictToNonDigits(sender, e);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(AddClient));
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
