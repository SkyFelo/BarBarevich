using BarBarevich.Classes;
using Guna.UI2.WinForms.Suite;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BarBarevich.Forms.View.SupplyOrder
{
    public partial class AddSupplyOrder : Form
    {
        private SupplyOrderView supplyOrderView;
        private SupplyOrderClass supplyOrderClass = new SupplyOrderClass();
        private List<int> productIds = new List<int>();
        private List<int> quantityList = new List<int>();

        public AddSupplyOrder(SupplyOrderView supplyOrderView)
        {
            InitializeComponent();
            this.supplyOrderView = supplyOrderView;

            LoadSuppliers();
            LoadProducts();

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "Delete";
            btnColumn.HeaderText = "Удалить";
            btnColumn.Text = "➖";
            btnColumn.UseColumnTextForButtonValue = true;
            dataGridViewProducts.Columns.Add(btnColumn);

            dataGridViewProducts.CellContentClick += dataGridViewProducts_CellContentClick;

            DateTime today = DateTime.Today;
            dateTimePickerOrderDate.Value = today.AddDays(+7);
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewProducts.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                if (dataGridViewProducts.Rows[e.RowIndex].Cells["Product"].Value != null)
                {
                    dataGridViewProducts.Rows.RemoveAt(e.RowIndex);

                    productIds.RemoveAt(e.RowIndex);
                    quantityList.RemoveAt(e.RowIndex);
                }
            }
        }

        private void LoadSuppliers()
        {
            comboBoxSuppliers.DataSource = supplyOrderClass.GetSuppliers();

            comboBoxSuppliers.DisplayMember = "supplier_name";
            comboBoxSuppliers.ValueMember = "id_supplier";
        }

        private void LoadProducts()
        {
            listBoxProducts.DataSource = supplyOrderClass.GetProducts();

            listBoxProducts.DisplayMember = "product_display";
            listBoxProducts.ValueMember = "id_product";
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem != null && numericUpDownQuantity.Value > 0)
            {
                int productId = Convert.ToInt32(listBoxProducts.SelectedValue);
                int quantity = (int)numericUpDownQuantity.Value;

                bool productExists = false;
                foreach (DataGridViewRow row in dataGridViewProducts.Rows)
                {
                    if (row.Cells["Product"].Value != null && row.Cells["Product"].Value.ToString() == listBoxProducts.Text)
                    {
                        int currentQty = Convert.ToInt32(row.Cells["Quantity"].Value);
                        int newQty = currentQty + quantity;
                        row.Cells["Quantity"].Value = newQty;

                        int index = row.Index;
                        if (index >= 0 && index < quantityList.Count)
                        {
                            quantityList[index] = newQty;  
                        }

                        productExists = true;
                        break;
                    }

                }

                if (!productExists)
                {
                    productIds.Add(productId);
                    quantityList.Add(quantity);

                    int rowIndex = dataGridViewProducts.Rows.Add();
                    dataGridViewProducts.Rows[rowIndex].Cells["Product"].Value = listBoxProducts.Text;
                    dataGridViewProducts.Rows[rowIndex].Cells["Quantity"].Value = quantity;
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать продукт и указать количество.");
            }
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                if (dataGridViewProducts.SelectedRows[0].Cells["Product"].Value != null)
                {
                    dataGridViewProducts.Rows.RemoveAt(dataGridViewProducts.SelectedRows[0].Index);
                }
                else
                {
                    MessageBox.Show("Необходимо выбрать продукт для удаления.");
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать продукт для удаления.");
            }
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxSuppliers.SelectedIndex == -1 || productIds.Count == 0)
                {
                    MessageBox.Show("Необходимо заполнить все поля.");
                    return;
                }

                DateTime supplyDate = dateTimePickerOrderDate.Value.Date;
                if (supplyDate < DateTime.Today)
                {
                    MessageBox.Show("Дата доставки не может быть в прошлом.");
                    return;
                }

                int supplierId = Convert.ToInt32(comboBoxSuppliers.SelectedValue);
                DateTime orderDate = DateTime.Now;

                int orderId = supplyOrderClass.AddPurchaseOrder(supplierId, orderDate);
                supplyOrderClass.AddSupply(orderId, supplyDate);

                for (int i = 0; i < productIds.Count; i++)
                {
                    supplyOrderClass.AddProductToOrder(orderId, productIds[i], quantityList[i]);
                }

                MessageBox.Show("Заказ успешно добавлен.");

                supplyOrderView.StartPosition = FormStartPosition.Manual;
                supplyOrderView.Location = this.Location;
                this.Close();
                supplyOrderView.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении заказа.");
            }
        }




        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(AddSupplyOrder));
                return true;
            }

            if (keyData == Keys.Enter)
            {
                buttonAddOrder.PerformClick();
                return true;
            }

            if (keyData == Keys.Escape)
            {
                buttonBack.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            supplyOrderView.StartPosition = FormStartPosition.Manual;
            supplyOrderView.Location = this.Location;
            supplyOrderView.Show();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                supplyOrderView.StartPosition = FormStartPosition.Manual;
                supplyOrderView.Location = this.Location;
                supplyOrderView.Show();
            }
        }
    }
}
