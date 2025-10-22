using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BarBarevich.Classes
{
    public class EventClass
    {
        private DatabaseManager dbManager;

        public EventClass()
        {
            dbManager = new DatabaseManager();
        }

        /// <summary>
        /// Возвращает следующий доступный ID для таблицы расписания мероприятий.
        /// </summary>
        /// <returns>Строка с новым ID мероприятия (на 1 больше максимального).</returns>
        public static string GetMaxEventScheduleId()
        {
            string maxId = "0";
            try
            {
                using (MySqlCommand command = new MySqlCommand("SELECT MAX(id_event_schedule) AS maxId FROM event_schedule", DatabaseManager.connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        maxId = (Convert.ToInt32(result) + 1).ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при получении максимального идентификатора мероприятия.");
            }

            return maxId;
        }

        /// <summary>
        /// Добавляет новое мероприятие в расписание.
        /// </summary>
        /// <param name="id">ID записи расписания мероприятия.</param>
        /// <param name="idEvent">ID события из справочника событий.</param>
        /// <param name="date">Дата проведения мероприятия.</param>
        /// <param name="startTime">Время начала мероприятия.</param>
        /// <param name="endTime">Время окончания мероприятия.</param>
        /// <returns>True, если операция выполнена успешно.</returns>
        public static bool AddEventSchedule(string id, string idEvent, string date, string startTime, string endTime)
        {
            try
            {
                DatabaseManager.myCommand.CommandText = $@"
                    INSERT INTO event_schedule (id_event_schedule, id_event, date, start_time, end_time) 
                    VALUES ('{id}', '{idEvent}', '{date}', '{startTime}', '{endTime}')";

                return DatabaseManager.myCommand.ExecuteNonQuery() > 0;
            }
            catch 
            {
                MessageBox.Show("Ошибка при добавлении информации о мероприятии.");
                return false;
            }
        }

        /// <summary>
        /// Обновляет запись расписания мероприятия.
        /// </summary>
        /// <param name="id">ID записи расписания мероприятия.</param>
        /// <param name="idEvent">Обновлённый ID события.</param>
        /// <param name="date">Обновлённая дата мероприятия.</param>
        /// <param name="startTime">Обновлённое время начала.</param>
        /// <param name="endTime">Обновлённое время окончания.</param>
        /// <returns>True, если операция выполнена успешно.</returns>
        public static bool EditEventSchedule(string id, string idEvent, string date, string startTime, string endTime)
        {
            try
            {
                DatabaseManager.myCommand.CommandText = $@"
                    UPDATE event_schedule 
                    SET id_event = '{idEvent}', date = '{date}', start_time = '{startTime}', end_time = '{endTime}'
                    WHERE id_event_schedule = '{id}'";

                return DatabaseManager.myCommand.ExecuteNonQuery() > 0;
            }
            catch 
            {
                MessageBox.Show("Ошибка при редактировании информации о мероприятии.");
                return false;
            }
        }

        /// <summary>
        /// Удаляет запись мероприятия из расписания.
        /// </summary>
        /// <param name="id">ID записи расписания мероприятия.</param>
        /// <returns>True, если удаление прошло успешно.</returns>
        public static bool DeleteEventSchedule(string id)
        {
            try
            {
                DatabaseManager.myCommand.CommandText = $@"
                    DELETE FROM event_schedule 
                    WHERE id_event_schedule = '{id}'";

                return DatabaseManager.myCommand.ExecuteNonQuery() > 0;
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении информации о мероприятии.");
                return false;
            }
        }

        /// <summary>
        /// Заполняет DataGridView данными о расписании мероприятий.
        /// </summary>
        /// <param name="dgv">Компонент DataGridView, в который загружаются данные.</param>
        public void FillDataGridViewEventSchedule(DataGridView dgv)
        {
            string query = @"
                SELECT es.id_event_schedule, s.id_event, s.event_name, es.date, es.start_time, es.end_time
                FROM event_schedule es
                JOIN s_events s ON es.id_event = s.id_event 
                ORDER BY event_name";

            DataTable dataTable = dbManager.GetData(query);
            dgv.DataSource = dataTable;
        }

        /// <summary>
        /// Загружает список мероприятий в ComboBox.
        /// </summary>
        /// <param name="comboBox">ComboBox, в который загружаются данные.</param>
        public void LoadEventComboBox(ComboBox comboBox)
        {
            try
            {
                string query = "SELECT id_event, event_name FROM s_events";
                DataTable dt = dbManager.GetData(query);

                comboBox.DataSource = dt;
                comboBox.DisplayMember = "event_name";
                comboBox.ValueMember = "id_event";
            }
            catch 
            {
                MessageBox.Show("Ошибка при загрузке мероприятий в выпадающий список.");
            }
        }
    }
}
