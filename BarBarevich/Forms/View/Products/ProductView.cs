using BarBarevich.Classes;
using BarBarevich.Forms.View.Supplier;
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

namespace BarBarevich.Forms.View.Products
{
    public partial class ProductView : Form
    {
        private ProductClass productClass;
        private MainForm lastForm;

        public ProductView(MainForm form)
        {
            InitializeComponent();
            lastForm = form;
            productClass = new ProductClass();
        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            productClass.FillDataGridViewProducts(dataGridView1);

            if (!dataGridView1.Columns.Contains("WriteOffButton"))
            {
                DataGridViewButtonColumn writeOffButton = new DataGridViewButtonColumn
                {
                    HeaderText = "Списать",
                    Text = "Списать",
                    UseColumnTextForButtonValue = true,
                    Name = "WriteOffButton"
                };
                dataGridView1.Columns.Add(writeOffButton);
            }
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            lastForm.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddProduct addForm = new AddProduct(this);
            addForm.StartPosition = FormStartPosition.Manual;
            addForm.Location = this.Location;
            this.Hide();
            addForm.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                EditProduct edit = new EditProduct(this,
                    row.Cells["id_product"].Value.ToString(),
                    row.Cells["product_name"].Value.ToString(),
                    row.Cells["unit"].Value.ToString(),
                    row.Cells["stock_quantity"].Value.ToString());

                edit.StartPosition = FormStartPosition.Manual;
                edit.Location = this.Location;
                this.Hide();
                edit.Show();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать продукт для редактирования.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells["id_product"].Value.ToString();

                if (productClass.IsProductUsed(id))
                {
                    MessageBox.Show("Невозможно удалить, продукт используется в меню.", 
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirm = MessageBox.Show("Удалить информацию о выбранном продукте?", 
                    "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    if (ProductClass.DeleteProduct(id))
                        MessageBox.Show("Информация о продукте успешно удалена.");
                    else
                        MessageBox.Show("Ошибка при удалении информации о продукте.");

                    productClass.FillDataGridViewProducts(dataGridView1);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать продукт для удаления.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "WriteOffButton")
            {
                var row = dataGridView1.Rows[e.RowIndex];
                string productId = row.Cells["id_product"].Value.ToString();
                string productName = row.Cells["product_name"].Value.ToString();
                int stockQuantity = Convert.ToInt32(row.Cells["stock_quantity"].Value);

                WriteOffForm writeOffForm = new WriteOffForm(productId, productName, stockQuantity, this);
                writeOffForm.StartPosition = FormStartPosition.Manual;
                writeOffForm.Location = this.Location;
                writeOffForm.ShowDialog();
            }
        }
        public void LoadData()
        {
            productClass.FillDataGridViewProducts(dataGridView1);
        }

        private void buttonWriteOffView_Click(object sender, EventArgs e)
        {
            WriteOffView writeOffView = new WriteOffView(this);
            writeOffView.StartPosition = FormStartPosition.Manual;
            writeOffView.Location = this.Location;
            this.Hide();
            writeOffView.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(ProductView));
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
            string name = textBoxSearch.Text;
            productClass.FillDataGridViewProductsByName(dataGridView1, name);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            productClass.FillDataGridViewProducts(dataGridView1);
        }
    }
}
