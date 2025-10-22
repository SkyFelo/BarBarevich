using BarBarevich.Classes;
using BarBarevich.Forms;
using BarBarevich.Forms.ActivityReservation;
using BarBarevich.Forms.S_Tables.s_activity_type;
using BarBarevich.Forms.View.Tables;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarBarevich
{
    public partial class Authorization : Form
    {
        private DatabaseManager dbManager;
        private int ID_employee;
        public Authorization()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string username = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            (int userType, int employeeId) = dbManager.CheckCredentials(username, password);
            ID_employee = employeeId;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Необходимо ввести логин",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Необходимо ввести пароль",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (employeeId == 0)
            {
                MessageBox.Show("Неверный логин или пароль",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (userType)
            {
                case 1:
                    MainForm mainForm1 = new MainForm(this, ID_employee, 1);
                    mainForm1.StartPosition = FormStartPosition.Manual;
                    mainForm1.Location = this.Location;
                    this.Hide();
                    mainForm1.Show();
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                    break;

                case 2:
                    MainForm mainForm2 = new MainForm(this, ID_employee, 2);
                    mainForm2.StartPosition = FormStartPosition.Manual;
                    mainForm2.Location = this.Location;
                    this.Hide();
                    mainForm2.Show();
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                    break;

                default:
                    MessageBox.Show("Неверный логин или пароль");
                    break;
            }
        }

        private void showPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar
                = !textBoxPassword.UseSystemPasswordChar;

            showPassword.Text
                = textBoxPassword.UseSystemPasswordChar ? "Показать пароль" : "Скрыть пароль";
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(Authorization));
                return true;
            }

            if (keyData == Keys.Enter)
            {
                buttonEnter.PerformClick();
                return true;
            }

            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm2 = new MainForm(this, ID_employee, 2);
            mainForm2.StartPosition = FormStartPosition.Manual;
            mainForm2.Location = this.Location;
            this.Hide();
            mainForm2.Show();
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
        }
    }
}