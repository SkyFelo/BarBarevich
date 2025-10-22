using BarBarevich.Classes;
using BarBarevich.Forms.View.Supplier;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BarBarevich.Forms.View.Products
{
    public partial class WriteOffView : Form
    {
        private ProductClass productClass;
        private ProductView productView;
        public WriteOffView(ProductView productView)
        {
            InitializeComponent();
            productClass = new ProductClass();
            this.productView = productView;
        }

        private void WriteOffView_Load(object sender, EventArgs e)
        {
            var writeOffTypes = productClass.GetWriteOffTypes();
            comboBoxWriteOffType.DataSource = writeOffTypes;
            comboBoxWriteOffType.DisplayMember = "Type";
            comboBoxWriteOffType.ValueMember = "Id";

            LoadWriteOffData();
        }

        private void LoadWriteOffData(string writeOffTypeId = null)
        {
            DataTable dataTable;

            if (writeOffTypeId == null)
            {
                dataTable = productClass.GetWrittenOffProducts();
            }
            else
            {
                dataTable = productClass.GetWrittenOffProducts(writeOffTypeId);
            }

            dataGridViewWriteOffProducts.DataSource = dataTable;
        }

        private void comboBoxWriteOffType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string writeOffTypeId = comboBoxWriteOffType.SelectedValue.ToString();
            LoadWriteOffData(writeOffTypeId);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadWriteOffData();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            productView.StartPosition = FormStartPosition.Manual;
            productView.Location = this.Location;
            this.Close();
            productView.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(WriteOffView));
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
                productView.StartPosition = FormStartPosition.Manual;
                productView.Location = this.Location;
                productView.Show();
            }
        }
    }
}
