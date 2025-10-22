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
    public partial class AddEvent : Form
    {
        private EventView lastForm;
        private EventClass eventClass;
        public AddEvent(EventView lastForm)
        {
            InitializeComponent();
            this.lastForm = lastForm;
            eventClass = new EventClass();
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {
            string id = EventClass.GetMaxEventScheduleId();
            textBoxID.Text = id;
            eventClass.LoadEventComboBox(comboBoxEvent);

            datePickerEventDate.Value = DateTime.Today;

            timePickerStart.Format = DateTimePickerFormat.Time;
            timePickerStart.ShowUpDown = true;
            timePickerStart.Value = DateTime.Today.AddHours(18);

            timePickerEnd.Format = DateTimePickerFormat.Time;
            timePickerEnd.ShowUpDown = true;
            timePickerEnd.Value = DateTime.Today.AddHours(20);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            string eventId = comboBoxEvent.SelectedValue?.ToString();
            DateTime eventDate = datePickerEventDate.Value.Date;
            TimeSpan startTime = timePickerStart.Value.TimeOfDay;
            TimeSpan endTime = timePickerEnd.Value.TimeOfDay;

            if (eventId == null)
            {
                MessageBox.Show("Необходимо выбрать мероприятие.");
                return;
            }

            if (startTime == endTime)
            {
                MessageBox.Show("Время начала и конца даты мероприятия не должны совпадать.");
                return;
            }

            DateTime startDateTime = eventDate.Add(startTime);

            if (startDateTime < DateTime.Now)
            {
                MessageBox.Show("Время начала мероприятия не может быть в прошлом.");
                return;
            }

            string date = eventDate.ToString("yyyy-MM-dd");
            string start = timePickerStart.Value.ToString("HH:mm:ss");
            string end = timePickerEnd.Value.ToString("HH:mm:ss");

            if (EventClass.AddEventSchedule(id, eventId, date, start, end))
                MessageBox.Show("Информация о мероприятии добавлена.");
            else
                MessageBox.Show("Ошибка при добавлении информации о мероприятии.");

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
                HelpManager.ShowHelp(nameof(AddEvent));
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