using BarBarevich.Classes;
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

namespace BarBarevich.Forms.View.SupplyOrder
{
    public partial class SupplyOrderView : Form
    {
        private SupplyOrderClass supplyOrderClass;
        private MainForm lastForm;

        public SupplyOrderView(MainForm mainForm)
        {
            InitializeComponent();
            supplyOrderClass = new SupplyOrderClass();
            this.lastForm = mainForm;

            DateTime today = DateTime.Today;
            dateTimePickerStart.Value = today.AddDays(-7);
            dateTimePickerEnd.Value = today;
        }

        private void SupplyOrderView_Load(object sender, EventArgs e)
        {
            supplyOrderClass.FillDataGridViewOrders(dataGridView1);
            HighlightConfirmedSupplies();
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
            AddSupplyOrder addOrder = new AddSupplyOrder(this);
            addOrder.StartPosition = FormStartPosition.Manual;
            addOrder.Location = this.Location;
            this.Hide();
            addOrder.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string orderId = row.Cells["id_purchase_order"].Value.ToString();

                if (supplyOrderClass.IsSupplyConfirmed(orderId))
                {
                    MessageBox.Show("Поставка уже подтверждена. Невозможно изменить заказ.");
                    return;
                }

                string supplier = row.Cells["supplier_name"].Value.ToString();
                string orderDate = row.Cells["purchase_date"].Value.ToString();

                EditSupplyOrder editOrder = new EditSupplyOrder(this, orderId, supplier, orderDate);
                editOrder.StartPosition = FormStartPosition.Manual;
                editOrder.Location = this.Location;
                this.Hide();
                editOrder.Show();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать поставку для редактирования.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Необходимо выбрать заказ для удаления.");
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string orderId = row.Cells["id_purchase_order"].Value.ToString();

            if (supplyOrderClass.IsSupplyConfirmed(orderId))
            {
                MessageBox.Show("Поставка уже подтверждена. Невозможно удалить заказ.");
                return;
            }

            DialogResult result = MessageBox.Show("Удалить информацию о этом заказе?", 
                "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (supplyOrderClass.DeleteOrderWithDetails(orderId))
                {
                    MessageBox.Show("Информация о заказе успешно удалена.");
                    supplyOrderClass.FillDataGridViewOrders(dataGridView1);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string orderId = selectedRow.Cells["id_purchase_order"].Value.ToString();
                LoadOrderProducts(orderId); 
            }
        }

        private void LoadOrderProducts(string orderId)
        {
            var products = supplyOrderClass.GetOrderProducts(orderId);
            if (products == null) return;

            dataGridView2.Rows.Clear();
            foreach (DataRow row in products.Rows)
            {
                int rowIndex = dataGridView2.Rows.Add();
                dataGridView2.Rows[rowIndex].Cells["Product"].Value = row["product_name"];
                dataGridView2.Rows[rowIndex].Cells["Unit"].Value = row["unit"];
                dataGridView2.Rows[rowIndex].Cells["Quantity"].Value = row["quantity"];
            }
        }


        private void SupplyOrderView_VisibleChanged(object sender, EventArgs e)
        {
            supplyOrderClass.FillDataGridViewOrders(dataGridView1);
            HighlightConfirmedSupplies();
        }

        private void buttonConfirmSupply_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string orderId = row.Cells["id_purchase_order"].Value.ToString();

                if (supplyOrderClass.IsSupplyConfirmed(orderId))
                {
                    MessageBox.Show("Поставка для этого заказа уже подтверждена.");
                    return;
                }

                DialogResult result = MessageBox.Show("Вы хотите подтвердить поставку? Это действие нельзя отменить.",
                                                       "Подтверждение поставки",
                                                       MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    ProcessSupply(orderId);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать заказ для подтверждения поставки.");
            }
        }

        private void HighlightConfirmedSupplies()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["id_complete_status"].Value != null &&
                    Convert.ToInt32(row.Cells["id_complete_status"].Value) == 2)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }


        private async void ProcessSupply(string orderId)
        {
            bool result = supplyOrderClass.ConfirmSupply(orderId, (productName, quantity) =>
            {
                using (var form = new ProductOrder(productName, quantity))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                        return (form.Price, form.Quantity);
                }
                return null;
            });

            if (result)
            {
                MessageBox.Show("Поставка подтверждена.");

                supplyOrderClass.FillDataGridViewOrders(dataGridView1);

                HighlightConfirmedSupplies();
            }
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(SupplyOrderView));
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DateTime start = dateTimePickerStart.Value.Date;
            DateTime end = dateTimePickerEnd.Value.Date;

            if (start > end)
            {
                MessageBox.Show("Начальная дата не может быть позже конечной.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            supplyOrderClass.FillDataGridViewByDate(start, end, dataGridView1);
        }

        private void buttonRefreshing_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            dateTimePickerStart.Value = today.AddDays(-7);
            dateTimePickerEnd.Value = today;

            SupplyOrderView_Load(sender, e);
        }
    }
}