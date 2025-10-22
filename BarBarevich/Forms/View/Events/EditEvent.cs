using BarBarevich.Classes;
using BarBarevich.Forms.View.Supplier;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarBarevich.Forms.View.Events
{
    public partial class EditEvent : Form
    {
        private EventView lastForm;
        private EventClass eventClass;
        private string selectedEventId;

        public EditEvent(EventView lastForm, string id, string eventId, string date, string start, string end)
        {
            InitializeComponent();
            this.lastForm = lastForm;
            eventClass = new EventClass();

            selectedEventId = eventId;

            textBoxID.Text = id;
            datePickerEventDate.Value = DateTime.Parse(date);
            timePickerStart.Value = DateTime.Today.Add(TimeSpan.Parse(start));
            timePickerEnd.Value = DateTime.Today.Add(TimeSpan.Parse(end));
        }

        private void EditEvent_Load(object sender, EventArgs e)
        {
            eventClass.LoadEventComboBox(comboBoxEvent);
            comboBoxEvent.SelectedValue = selectedEventId;
            timePickerStart.Format = DateTimePickerFormat.Time;
            timePickerEnd.Format = DateTimePickerFormat.Time;
            timePickerStart.ShowUpDown = true;
            timePickerEnd.ShowUpDown = true;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            string eventId = comboBoxEvent.SelectedValue?.ToString();
            string date = datePickerEventDate.Value.ToString("yyyy-MM-dd");
            string start = timePickerStart.Value.ToString("HH:mm:ss");
            string end = timePickerEnd.Value.ToString("HH:mm:ss");

            if (eventId == null)
            {
                MessageBox.Show("Необходимо выбрать мероприятие.");
                return;
            }

            if (timePickerStart.Value.TimeOfDay == timePickerEnd.Value.TimeOfDay)
            {
                MessageBox.Show("Время начала и конца даты мероприятия не должны совпадать.");
                return;
            }

            if (EventClass.EditEventSchedule(id, eventId, date, start, end))
                MessageBox.Show("Информация о мероприятии обновлена.");
            else
                MessageBox.Show("Ошибка при редактировании информации о мероприятии.");

            buttonBack.PerformClick();
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
                HelpManager.ShowHelp(nameof(EditEvent));
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