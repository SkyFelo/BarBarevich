using BarBarevich.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BarBarevich.Forms.View.SupplyOrder
{
    public partial class EditSupplyOrder : Form
    {
        private SupplyOrderView supplyOrderView;
        private SupplyOrderClass supplyOrderClass = new SupplyOrderClass();
        private string orderId;
        private List<int> productIds = new List<int>();
        private List<int> quantityList = new List<int>();

        public EditSupplyOrder(SupplyOrderView supplyOrderView, string orderId, string supplierName, string orderDate)
        {
            InitializeComponent();
            this.supplyOrderView = supplyOrderView;
            this.orderId = orderId;

            LoadSuppliers(supplierName);
            LoadProducts();
            LoadOrderProducts();
            dateTimePickerOrderDate.Value = Convert.ToDateTime(orderDate);
        }

        private void LoadSuppliers(string supplierName)
        {
            var suppliers = supplyOrderClass.GetSuppliers();
            comboBoxSuppliers.DisplayMember = "supplier_name";
            comboBoxSuppliers.ValueMember = "id_supplier";
            comboBoxSuppliers.DataSource = suppliers;

            foreach (DataRow row in suppliers.Rows)
            {
                if (row["supplier_name"].ToString() == supplierName)
                {
                    comboBoxSuppliers.SelectedValue = row["id_supplier"];
                    break;
                }
            }
        }
        private void LoadProducts()
        {
            var products = supplyOrderClass.GetProducts();
            listBoxProducts.DisplayMember = "product_display";
            listBoxProducts.ValueMember = "id_product";
            listBoxProducts.DataSource = products;
        }

        private void LoadOrderProducts()
        {
            var orderProducts = supplyOrderClass.GetOrderProductsWithUnit(orderId);

            foreach (DataRow row in orderProducts.Rows)
            {
                int rowIndex = dataGridViewProducts.Rows.Add();
                dataGridViewProducts.Rows[rowIndex].Cells["Product"].Value = row["product_name"];
                dataGridViewProducts.Rows[rowIndex].Cells["Quantity"].Value = row["quantity"];
                productIds.Add(Convert.ToInt32(row["id_product"]));
                quantityList.Add(Convert.ToInt32(row["quantity"]));
            }

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.HeaderText = "Удалить";
            deleteButton.Text = "➖";
            deleteButton.UseColumnTextForButtonValue = true;
            dataGridViewProducts.Columns.Add(deleteButton);

            dataGridViewProducts.CellContentClick += dataGridViewProducts_CellContentClick;
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewProducts.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                if (dataGridViewProducts.Rows[e.RowIndex].Cells["Product"].Value != null)
                {
                    productIds.RemoveAt(e.RowIndex);
                    quantityList.RemoveAt(e.RowIndex);
                    dataGridViewProducts.Rows.RemoveAt(e.RowIndex);
                }
            }
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
                        row.Cells["Quantity"].Value = Convert.ToInt32(row.Cells["Quantity"].Value) + quantity;
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

        private void buttonSaveOrder_Click(object sender, EventArgs e)
        {
            if (comboBoxSuppliers.SelectedIndex == -1 || dataGridViewProducts.Rows.Count == 0)
            {
                MessageBox.Show("Необходимо заполнить все поля.");
                return;
            }

            try
            {
                int supplierId = Convert.ToInt32(comboBoxSuppliers.SelectedValue);
                DateTime orderDate = dateTimePickerOrderDate.Value;
                string orderIdStr = orderId; 
                int orderIdInt = Convert.ToInt32(orderIdStr);

                supplyOrderClass.UpdatePurchaseOrder(orderIdStr, supplierId, orderDate);

                supplyOrderClass.DeleteOrderProducts(orderIdStr);

                foreach (DataGridViewRow row in dataGridViewProducts.Rows)
                {
                    if (row.Cells["Product"].Value != null)
                    {
                        string productName = row.Cells["Product"].Value.ToString();
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);

                        int productId = supplyOrderClass.GetProductIdByName(productName);
                        if (productId != -1)
                        {
                            supplyOrderClass.AddProductToOrder(orderIdInt, productId, quantity);
                        }
                        else
                        {
                            MessageBox.Show($"Продукт {productName} не найден в базе данных.");
                        }
                    }
                }

                MessageBox.Show("Заказ успешно обновлен.");
                supplyOrderView.StartPosition = FormStartPosition.Manual;
                supplyOrderView.Location = this.Location;
                this.Close();
                supplyOrderView.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении заказа.");
            }
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            supplyOrderView.StartPosition = FormStartPosition.Manual;
            supplyOrderView.Location = this.Location;
            supplyOrderView.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(EditSupplyOrder));
                return true;
            }

            if (keyData == Keys.Enter)
            {
                buttonEditOrder.PerformClick();
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
                supplyOrderView.StartPosition = FormStartPosition.Manual;
                supplyOrderView.Location = this.Location;
                supplyOrderView.Show();
            }
        }
    }
}
