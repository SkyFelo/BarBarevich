using BarBarevich.Classes;
using BarBarevich.Classes.S_Tables;
using BarBarevich.Forms.View.Products;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BarBarevich.Forms.S_Tables.s_activity_type
{
    public partial class EditEventForm : Form
    {
        private EventForm lastForm;
        private S_EventsClass eventsClass;

        public EditEventForm(EventForm lastForm, string id, string name)
        {
            InitializeComponent();
            this.lastForm = lastForm;
            eventsClass = new S_EventsClass();

            textBoxID.Text = id;
            textBoxInput.Text = name;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            string name = textBoxInput.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Необходимо заполнить поле.");
                return;
            }

            if (eventsClass.GetEvents().AsEnumerable().Any(row => row.Field<string>("event_name") == name))
            {
                MessageBox.Show("Мероприятие " + name + " уже добавлено в справочник.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                eventsClass.EditEvent(id, name);
                MessageBox.Show("Мероприятие обновлено.");
            }

            buttonBack.PerformClick();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            this.Close();
            lastForm.Show();
        }

        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHelper.RestrictToNonDigits(sender, e);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(EditEventForm));
                return true;
            }

            if (keyData == Keys.Enter)
            {
                buttonEdit.PerformClick();
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
