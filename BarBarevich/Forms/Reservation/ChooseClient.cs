using BarBarevich.Classes;
using BarBarevich.Forms.ActivityReservation;
using BarBarevich.Forms.View;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarBarevich.Forms
{
    public partial class ChooseClient : Form
    {
        private ClientClass clientClass;
        private Form lastForm;
        public ChooseClient(Form lastForm)
        {
            InitializeComponent();
            clientClass = new ClientClass();
            this.lastForm = lastForm;
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string id = selectedRow.Cells["id"].Value.ToString();
                string full_name = selectedRow.Cells["full_name"].Value.ToString();
                string phone = selectedRow.Cells["phone"].Value.ToString();

                if (lastForm is IClientSelectable clientSelectable)
                {
                    clientSelectable.SetSelectedClient(id, full_name, phone);
                }

                buttonBack.PerformClick();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать клиента.");
            }
        }
        public interface IClientSelectable
        {
            void SetSelectedClient(string id, string fullName, string phone);
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            this.Close();
            lastForm.Show();
        }

        private void ChooseClient_Load(object sender, EventArgs e)
        {
            clientClass.FillDataGridViewClients(dataGridView1);
        }

        private void comboBoxChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxChoice.SelectedIndex == 0)
            {
                textBoxSearch.Enabled = true;
                labelSearch.Text = "Необходимо ввести имя";
            }
            else
            {
                textBoxSearch.Enabled = true;
                labelSearch.Text = "Необходимо ввести номер телефона";
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxChoice.SelectedIndex == -1)
            {
                MessageBox.Show("Необходимо выбрать фильтр для отбора.");
                return;
            }
            if (comboBoxChoice.SelectedIndex == 0)
            {
                string input = textBoxSearch.Text;

                clientClass.FillDataGridViewClientsFullName(input, dataGridView1);
            }
            else
            {
                string input = textBoxSearch.Text;

                clientClass.FillDataGridViewClientsPhone(input, dataGridView1);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            comboBoxChoice.SelectedIndex = -1;
            textBoxSearch.Enabled = false;
            textBoxSearch.Text = "";
            clientClass.FillDataGridViewClients(dataGridView1);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(ChooseClient));
                return true;
            }

            if (keyData == Keys.Enter)
            {
                buttonChoose.PerformClick();
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
