using BarBarevich.Classes;
using BarBarevich.Classes.S_Tables;
using BarBarevich.Forms.View.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarBarevich.Forms.S_Tables.s_writeoff_type
{
    public partial class AddWriteoffType : Form
    {
        private S_WriteoffTypeClass sWriteoffTypeClass;
        private WriteoffTypeForm lastForm;
        public AddWriteoffType(WriteoffTypeForm lastForm)
        {
            InitializeComponent();
            sWriteoffTypeClass = new S_WriteoffTypeClass();
            this.lastForm = lastForm;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            string line = textBoxInput.Text;

            if (string.IsNullOrWhiteSpace(line))
            {
                MessageBox.Show("Необходимо заполнить все поля.");
            }
            else
            {
                if (sWriteoffTypeClass.GetWriteoffTypes().AsEnumerable().Any(row => row.Field<string>("writeoff_type") == line))
                {
                    MessageBox.Show("Тип списания " + line + " уже добавлен в справочник.", 
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sWriteoffTypeClass.AddWriteoffType(id, line);
                MessageBox.Show("Тип списания успешно добавлен.");

                buttonBack.PerformClick();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            this.Close();
            lastForm.Show();
        }

        private void AddWriteoffType_Load(object sender, EventArgs e)
        {
            string id = sWriteoffTypeClass.GetWriteoffTypeMaxId();
            textBoxID.Text = id;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(AddWriteoffType));
                return true;
            }

            if (keyData == Keys.Enter)
            {
                buttonAdd.PerformClick();
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
