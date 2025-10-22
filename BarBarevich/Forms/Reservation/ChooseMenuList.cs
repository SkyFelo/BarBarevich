using BarBarevich.Classes;
using BarBarevich.Forms.View.Products;
using Guna.UI2.WinForms.Suite;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarBarevich.Forms.ActivityReservation
{
    public partial class ChooseMenuList : Form
    {
        private Form lastForm;
        private NewReservation lastLastForm;

        private string id_reservation;
        public ChooseMenuList(Form lastForm, NewReservation lastLastForm, string id_reservation)
        {
            InitializeComponent();
            this.lastForm = lastForm;
            this.lastLastForm = lastLastForm;
            this.id_reservation = id_reservation;
        }

        private void ActivityMenuList_Load(object sender, EventArgs e)
        {
            MenuClass menu = new MenuClass();
            dataGridViewMenuList.DataSource = menu.GetMenuItemsWithPrices();

            if (!dataGridViewMenuList.Columns.Contains("AddColumn"))
            {
                DataGridViewButtonColumn addButton = new DataGridViewButtonColumn
                {
                    HeaderText = "Добавить",
                    Text = "➕",
                    UseColumnTextForButtonValue = true,
                    Name = "AddColumn"
                };
                dataGridViewMenuList.Columns.Add(addButton);
            }

            if (!dataGridViewMenuInOrder.Columns.Contains("colDelete"))
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
                {
                    HeaderText = "Удалить",
                    Text = "➖",
                    UseColumnTextForButtonValue = true,
                    Name = "colDelete"
                };
                dataGridViewMenuInOrder.Columns.Add(deleteButton);
            }

        }
        private void dataGridViewMenuList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&
               !dataGridViewMenuList.Rows[e.RowIndex].IsNewRow &&
                dataGridViewMenuList.Columns[e.ColumnIndex].Name == "AddColumn")
            {
                var row = dataGridViewMenuList.Rows[e.RowIndex];

                string name = row.Cells["name"].Value.ToString();
                decimal price = Convert.ToDecimal(row.Cells["price"].Value);

                bool itemExists = false;
                foreach (DataGridViewRow orderRow in dataGridViewMenuInOrder.Rows)
                {
                    if (orderRow.Cells["colName"].Value != null &&
                        orderRow.Cells["colName"].Value.ToString() == name)
                    {
                        int currentQuantity = Convert.ToInt32(orderRow.Cells["colQuantity"].Value);
                        orderRow.Cells["colQuantity"].Value = currentQuantity + 1;
                        itemExists = true;
                        break;
                    }
                }

                if (!itemExists)
                {
                    int newRowIndex = dataGridViewMenuInOrder.Rows.Add();
                    var newRow = dataGridViewMenuInOrder.Rows[newRowIndex];

                    newRow.Cells["colName"].Value = name;
                    newRow.Cells["colPrice"].Value = price;
                    newRow.Cells["colQuantity"].Value = 1;
                }

                UpdateTotalPrice();
            }
        }

        private void dataGridViewMenuInOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                !dataGridViewMenuInOrder.Rows[e.RowIndex].IsNewRow &&
                dataGridViewMenuInOrder.Columns[e.ColumnIndex].Name == "colDelete")
            {
                dataGridViewMenuInOrder.Rows.RemoveAt(e.RowIndex);
                UpdateTotalPrice();
            }
        }

        private void UpdateTotalPrice()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridViewMenuInOrder.Rows)
            {
                if (row.Cells["colPrice"].Value != null && row.Cells["colQuantity"].Value != null)
                {
                    decimal price = Convert.ToDecimal(row.Cells["colPrice"].Value);
                    int quantity = Convert.ToInt32(row.Cells["colQuantity"].Value);
                    total += price * quantity;
                }
            }

            textBoxTotalPrice.Text = total.ToString("0.00") + " ₽";
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

            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            this.Close();
            lastForm.Show();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenuInOrder.Rows.Count == 0)
            {
                MessageBox.Show("Необходимо добавить позиции в заказ.");
                return;
            }

            foreach (DataGridViewRow row in dataGridViewMenuInOrder.Rows)
            {
                if (row.IsNewRow) continue;

                string name = row.Cells["colName"].Value?.ToString();
                int quantity = Convert.ToInt32(row.Cells["colQuantity"].Value);

                int? id_price = MenuClass.GetLatestPriceIdByItemName(name);

                if (id_price == null)
                {
                    MessageBox.Show($"Не найдена цена для блюда: {name}");
                    continue;
                }

                bool success = MenuClass.AddMenuItemToOrder(Convert.ToInt32(id_reservation), id_price.Value, quantity);

                if (!success)
                {
                    MessageBox.Show($"Ошибка при добавлении блюда: {name}");
                }
            }


            MessageBox.Show("Информация о позициях меню в заказе успешно добавлена.");
            this.Close();
            lastLastForm.StartPosition = FormStartPosition.Manual;
            lastLastForm.Location = this.Location;
            lastForm.Close();
            lastLastForm.Show();
        }


        private void buttonClean_Click(object sender, EventArgs e)
        {
            dataGridViewMenuInOrder.Rows.Clear();
            UpdateTotalPrice();
        }

        private void dataGridViewMenuInOrder_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridViewMenuInOrder.CurrentCell.ColumnIndex == dataGridViewMenuInOrder.Columns["colQuantity"].Index)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress -= QuantityColumn_KeyPress;
                    tb.KeyPress += QuantityColumn_KeyPress;
                }
            }
        }

        private void QuantityColumn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridViewMenuInOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewMenuInOrder.Columns[e.ColumnIndex].Name == "colQuantity")
            {
                var cell = dataGridViewMenuInOrder.Rows[e.RowIndex].Cells["colQuantity"];
                if (cell.Value == null || !int.TryParse(cell.Value.ToString(), out int value) || value <= 0)
                {
                    cell.Value = 1; 
                }

                UpdateTotalPrice();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(ChooseMenuList));
                return true;
            }

            if (keyData == Keys.Enter)
            {
                buttonSave.PerformClick();
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
