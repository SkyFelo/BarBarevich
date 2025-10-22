using BarBarevich.Classes;
using BarBarevich.Forms.View.Supplier;
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
    public partial class EventView : Form
    {
        private EventClass eventClass;
        private MainForm lastForm;
        public EventView(MainForm mainForm)
        {
            InitializeComponent();
            eventClass = new EventClass();
            this.lastForm = mainForm;
        }

        private void EventView_Load(object sender, EventArgs e)
        {
            eventClass.FillDataGridViewEventSchedule(dataGridView1);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddEvent addEvent = new AddEvent(this);
            addEvent.StartPosition = FormStartPosition.Manual;
            addEvent.Location = this.Location;
            this.Hide();
            addEvent.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                EditEvent editForm = new EditEvent(this,
                    row.Cells["id_event_schedule"].Value.ToString(),
                    row.Cells["id_event"].Value.ToString(),
                    row.Cells["date"].Value.ToString(),
                    row.Cells["start_time"].Value.ToString(),
                    row.Cells["end_time"].Value.ToString());

                editForm.StartPosition = FormStartPosition.Manual;
                editForm.Location = this.Location;
                this.Hide();
                editForm.Show();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать мероприятие для редактирования.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells["id_event_schedule"].Value.ToString();
                DialogResult result = MessageBox.Show("Удалить информацию о мероприятии?", 
                    "Подтверждение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (EventClass.DeleteEventSchedule(id))
                        MessageBox.Show("Информация о мероприятии удалена успешно.");
                    else
                        MessageBox.Show("Ошибка при удалении информации о мероприятии.");

                    eventClass.FillDataGridViewEventSchedule(dataGridView1);
                }
            }
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
                HelpManager.ShowHelp(nameof(EventView));
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