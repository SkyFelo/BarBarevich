using BarBarevich.Classes;
using BarBarevich.Forms.ActivityReservation;
using BarBarevich.Forms.View.Products;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
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
    public partial class ChooseTable : Form
    {
        private DatabaseManager dbManager;
        private NewReservation lastForm;
        private string id_reservation;
        private DateTime selectedDate;

        private List<int> selectedTables = new List<int>();

        public ChooseTable(NewReservation lastForm, DateTime selectedDate, string id_reservation)
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            this.lastForm = lastForm;
            this.selectedDate = selectedDate;
            this.id_reservation = id_reservation;
            this.Text = $"Выбор стола на {selectedDate:yyyy-MM-dd}";
        }

        private void ChooseTable_Load(object sender, EventArgs e)
        {
            var occupiedTables = dbManager.GetOccupiedTables(selectedDate);
            UpdateTableButtons(occupiedTables);
        }

        private void UpdateTableButtons(List<int> occupiedTables)
        {
            foreach (Control control in Controls)
            {
                if (control is Guna2Button button && button.Name.StartsWith("table") 
                    && button.Name.EndsWith("Button"))
                {
                    if (int.TryParse(button.Name.Substring(5, button.Name.Length - 11), 
                        out int tableNumber))
                    {
                        if (occupiedTables.Contains(tableNumber))
                        {
                            button.FillColor = Color.FromArgb(40, 40, 40);
                            button.Enabled = false;
                        }
                        else
                        {
                            button.FillColor = Color.FromArgb(204, 255, 158);
                            button.Click -= TableButton_Click;
                            button.Click += TableButton_Click;
                            button.Tag = tableNumber;
                        }
                    }
                }
            }
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;

            if (btn.Tag == null)
            {
                return; 
            }

            int tableNumber = (int)btn.Tag;

            if (selectedTables.Contains(tableNumber))
            {
                selectedTables.Remove(tableNumber);
                btn.FillColor = Color.FromArgb(204, 255, 158);
                btn.HoverState.FillColor = btn.FillColor;
            }
            else
            {
                selectedTables.Add(tableNumber);
                btn.FillColor = Color.Yellow;
                btn.HoverState.FillColor = btn.FillColor;
            }
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (ReservationClass.HasTablesForReservation(id_reservation))
            {
                if (!ReservationClass.DeleteTablesFromReservation(id_reservation))
                {
                    MessageBox.Show("Ошибка отмены выбора столов.");
                    return;
                }
            }

            ReservationClass.DeleteReservation(id_reservation);
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            this.Close();
            lastForm.Show();           
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            if (selectedTables.Count == 0)
            {
                MessageBox.Show("Необходимо выбрать минимум один стол.");
                return;
            }

            foreach (int tableId in selectedTables)
            {
                ReservationClass.AddTablesToReservation(id_reservation, tableId);
            }

            DialogResult result = MessageBox.Show
                ("Столы успешно добавлены. Добавить меню в бронирование?",
                "Добавить мероприятие",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ChooseMenuList activityMenuList = new ChooseMenuList(this, lastForm, id_reservation);
                activityMenuList.StartPosition = FormStartPosition.Manual;
                activityMenuList.Location = this.Location;
                this.Hide();
                activityMenuList.Show();
            }
            else
            {
                this.Close();
                lastForm.Show();
            }

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(ChooseTable));
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
