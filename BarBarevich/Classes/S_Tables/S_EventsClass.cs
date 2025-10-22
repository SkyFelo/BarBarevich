using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarBarevich.Classes.S_Tables
{
    public class S_EventsClass
    {
        private DatabaseManager dbManager;
        public S_EventsClass()
        {
            dbManager = new DatabaseManager();
        }

        /// <summary>
        /// Получает все мероприятия из таблицы s_events.
        /// </summary>
        /// <returns>Таблица с перечнем мероприятий, отсортированных по названию.</returns>
        public DataTable GetEvents()
        {
            string query = "SELECT * FROM s_events " +
                "ORDER BY event_name;";
            return dbManager.GetData(query);
        }

        /// <summary>
        /// Проверяет, используется ли мероприятие в расписании.
        /// </summary>
        /// <param name="eventId">Идентификатор мероприятия.</param>
        /// <returns>True, если мероприятие используется в таблице event_schedule; иначе False.</returns>
        public bool IsEventInUse(string eventId)
        {
            string query = $"SELECT * FROM event_schedule WHERE id_event = '{eventId}'";
            DataTable result = dbManager.GetData(query);
            return result.Rows.Count > 0;
        }

        /// <summary>
        /// Удаляет мероприятие по его идентификатору.
        /// </summary>
        /// <param name="eventId">Идентификатор мероприятия.</param>
        /// <returns>True, если удаление прошло успешно; иначе False.</returns>
        public bool DeleteEvent(string eventId)
        {
            string query = $"DELETE FROM s_events WHERE id_event = '{eventId}'";
            return dbManager.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Добавляет новое мероприятие в справочную таблицу.
        /// </summary>
        /// <param name="id">Идентификатор мероприятия.</param>
        /// <param name="event_name">Название мероприятия.</param>
        public void AddEvent(string id, string event_name)
        {
            string query = $"INSERT INTO s_events (id_event, event_name) VALUES ('{id}', '{event_name}')";
            dbManager.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Обновляет название мероприятия по заданному идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор мероприятия.</param>
        /// <param name="event_name">Новое название мероприятия.</param>
        public void EditEvent(string id, string event_name)
        {
            string query = $"UPDATE s_events SET event_name = '{event_name}' WHERE id_event = '{id}'";
            dbManager.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Получает следующий доступный идентификатор для нового мероприятия.
        /// </summary>
        /// <returns>Строка с новым идентификатором (на 1 больше текущего максимального).</returns>
        public string GetEventMaxId()
        {
            var result = dbManager.GetData("SELECT MAX(id_event) AS maxId FROM s_events");
            if (result.Rows.Count > 0 && result.Rows[0]["maxId"] != DBNull.Value)
            {
                int maxId = Convert.ToInt32(result.Rows[0]["maxId"]);
                return (maxId + 1).ToString();
            }
            return "1";
        }
    }
}
