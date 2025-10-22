using BarBarevich.Classes;
using BarBarevich.Forms.View.Products;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BarBarevich.Forms.ChooseClient;

namespace BarBarevich.Forms.Reservation
{
    public partial class EditTables : Form
    {
        private DatabaseManager dbManager;
        private EditReservation lastForm;
        private string id_reservation;
        private DateTime selectedDate;

        private List<int> selectedTables = new List<int>();

        public EditTables(EditReservation lastForm, string id_reservation, DateTime selectedDate)
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            this.lastForm = lastForm;
            this.id_reservation = id_reservation;
            this.selectedDate = selectedDate;
            this.Text = $"Редактирование столов на {selectedDate:yyyy-MM-dd}";
        }

        private void EditTables_Load(object sender, EventArgs e)
        {
            var occupiedTables = dbManager.GetOccupiedTables(selectedDate);
            var selectedTablesForReservation = dbManager.GetSelectedTablesForReservation(id_reservation);

            selectedTables.AddRange(selectedTablesForReservation);

            UpdateTableButtons(occupiedTables, selectedTablesForReservation);
        }

        private void UpdateTableButtons(List<int> occupiedTables, List<int> selectedTablesForReservation)
        {
            foreach (Control control in Controls)
            {
                if (control is Guna2Button button && button.Name.StartsWith("table") && button.Name.EndsWith("Button"))
                {
                    if (int.TryParse(button.Name.Substring(5, button.Name.Length - 11), out int tableNumber))
                    {
                        if (selectedTablesForReservation.Contains(tableNumber))
                        {
                            button.FillColor = Color.Yellow;
                            button.Enabled = true;
                        }
                        else
                        {
                            if (occupiedTables.Contains(tableNumber))
                            {
                                button.FillColor = Color.FromArgb(40, 40, 40); 
                                button.Enabled = false;
                            }
                            else
                            {
                                button.FillColor = Color.FromArgb(204, 255, 158); 
                                button.Enabled = true;
                            }
                        }

                        button.Click -= TableButton_Click;
                        button.Click += TableButton_Click;

                        button.Tag = tableNumber;
                    }
                }
            }
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;

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

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            if (selectedTables.Count == 0)
            {
                MessageBox.Show("Необходимо выбрать минимум один стол.");
                return;
            }

            ReservationClass.ClearTablesForReservation(id_reservation);
            foreach (int tableId in selectedTables)
            {
                ReservationClass.AddTablesToReservation(id_reservation, tableId);
            }

            MessageBox.Show("Столы в бронировании успешно обновлены.");
            buttonBack.PerformClick();

            (lastForm as EditReservation)?.EnableSaveButton();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            this.Close();
            lastForm.Show();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(EditTables));
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
