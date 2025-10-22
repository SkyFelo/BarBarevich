using BarBarevich.Classes;
using BarBarevich.Classes.S_Tables;
using BarBarevich.Forms.S_Tables.s_employee_role;
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

namespace BarBarevich.Forms.S_Tables.s_activity_type
{
    public partial class EventForm : Form
    {
        private S_EventsClass eventsClass;
        private MainForm lastForm;

        public EventForm(MainForm lastForm)
        {
            InitializeComponent();
            eventsClass = new S_EventsClass();
            this.lastForm = lastForm;
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = eventsClass.GetEvents();
        }

        private void EventForm_VisibleChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = eventsClass.GetEvents();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            this.Close();
            lastForm.Show();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEventForm addForm = new AddEventForm(this);
            addForm.StartPosition = FormStartPosition.Manual;
            addForm.Location = this.Location;
            this.Hide();
            addForm.Show();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                string id = row.Cells["id"].Value.ToString();
                string name = row.Cells["event_name"].Value.ToString();
                EditEventForm editForm = new EditEventForm(this, id, name);
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

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                string id = row.Cells["id"].Value.ToString();

                if (eventsClass.IsEventInUse(id))
                {
                    MessageBox.Show("Невозможно удалить мероприятие, так как оно уже используется.",
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirm = MessageBox.Show("Вы уверены, что хотите удалить мероприятие?",
                                              "Подтверждение", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    if (eventsClass.DeleteEvent(id))
                        MessageBox.Show("Мероприятие успешно удалено.");
                    else
                        MessageBox.Show("Ошибка при удалении мероприятия.");
                }

                dataGridView1.DataSource = eventsClass.GetEvents();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать мероприятие для удаления.");
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(EventForm));
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
