using BarBarevich.Classes;
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
    public partial class ProductOrder : Form
    {
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        private string productName;
        public ProductOrder(string productName, int quantity)
        {
            InitializeComponent();
            labelProductName.Text = "Подтверждение поставки: " + productName;
            numericUpDownQuantity.Maximum = quantity;

            this.productName = productName;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Price = numericUpDownPrice.Value;
            Quantity = (int)numericUpDownQuantity.Value;

            if (Quantity <= 0)
            {
                MessageBox.Show("Количество продукта должно быть больше 0. " +
                    "Для отмены поставки необходимо нажать кнопку *Отменить поставку*");
                return;
            }

            if (Price <= 0)
            {
                MessageBox.Show("Цена должна быть больше 0.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(ProductOrder));
                return true;
            }

            if (keyData == Keys.Enter)
            {
                buttonAdd.PerformClick();
                return true;
            }

            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show(
                    $"Отмена приведет к тому, что поставка {productName} не будет добавлена на склад." +
                    $"\n\nВы уверены, что хотите отменить?",
                    "Подтверждение отмены",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}

