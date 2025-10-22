using BarBarevich.Classes;
using BarBarevich.Forms.View.Products;
using System;
using System.Data;
using System.Net.Sockets;
using System.Windows.Forms;

namespace BarBarevich.Forms.View
{
    public partial class ClientsView : Form
    {
        private ClientClass clientClass;
        private MainForm lastForm;
        private object сlientClass;

        public ClientsView(MainForm mainForm)
        {
            InitializeComponent();
            clientClass = new ClientClass();
            this.lastForm = mainForm;
        }

        private void ClientsView_Load(object sender, EventArgs e)
        {
            clientClass.FillDataGridViewClients(dataGridView1);
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
            AddClient addClient = new AddClient(this);
            addClient.StartPosition = FormStartPosition.Manual;
            addClient.Location = this.Location;
            this.Hide();
            addClient.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string id = selectedRow.Cells["id_client"].Value.ToString();
                string fio = selectedRow.Cells["full_name"].Value.ToString();
                string phone = selectedRow.Cells["phone"].Value.ToString();

                EditClient editClient = new EditClient(this, id, fio, phone);
                editClient.StartPosition = FormStartPosition.Manual;
                editClient.Location = this.Location;
                this.Hide();
                editClient.Show();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать клиента для редактирования.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string id = selectedRow.Cells["id_client"].Value.ToString();

                if (clientClass.IsClientUsed(id))
                {
                    MessageBox.Show("Невозможно удалить информацию о клиенте, так как она указана в бронировании.", 
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить информацию о клиенте?", 
                    "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (ClientClass.DeleteClient(id))
                        MessageBox.Show("Информация о клиенте успешно удалена.");
                    else
                        MessageBox.Show("Ошибка при удалении информации о клиенте.");
                }

                clientClass.FillDataGridViewClients(dataGridView1);
            }
            else
            {
                MessageBox.Show("Необходимо выбрать клиента для удаления.");
            }
        }

        private void comboBoxChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSearch.Enabled = true;
            labelSearch.Text = comboBoxChoice.SelectedIndex == 0 ? "Необходимо ввести имя" : "Необходимо ввести номер телефона";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxChoice.SelectedIndex == -1)
            {
                MessageBox.Show("Необходимо выбрать фильтр для отбора.");
                return;
            }

            string input = textBoxSearch.Text;

            if (comboBoxChoice.SelectedIndex == 0)
                clientClass.FillDataGridViewClientsFullName(input, dataGridView1);
            else
                clientClass.FillDataGridViewClientsPhone(input, dataGridView1);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            comboBoxChoice.SelectedIndex = -1;
            textBoxSearch.Enabled = false;
            labelSearch.Text = "*Необходимо выбрать фильтр для отбора";
            textBoxSearch.Text = "";

            clientClass.FillDataGridViewClients(dataGridView1);
        }

        private void ClientsView_VisibleChanged(object sender, EventArgs e)
        {
            clientClass.FillDataGridViewClients(dataGridView1);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(ClientsView));
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

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}