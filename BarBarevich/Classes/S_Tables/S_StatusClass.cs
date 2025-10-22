using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarBarevich.Classes.S_Tables
{
    public class S_StatusClass
    {
        private DatabaseManager dbManager;
        public S_StatusClass()
        {
            dbManager = new DatabaseManager();
        }
        /// <summary>
        /// Получает все статусы выполнения из таблицы s_complete_status.
        /// </summary>
        /// <returns>Таблица со статусами, отсортированными по названию.</returns>
        public DataTable GetStatuses()
        {
            string query = "SELECT * FROM s_complete_status " +
                "ORDER BY complete_status;";
            return dbManager.GetData(query);
        }

        /// <summary>
        /// Проверяет, используется ли статус выполнения в таблицах menu_in_order или supply.
        /// </summary>
        /// <param name="categoryId">Идентификатор статуса выполнения.</param>
        /// <returns>True, если статус используется; иначе False.</returns>
        public bool IsStatusInUse(string categoryId)
        {
            string query1 = $"SELECT 1 FROM menu_in_order WHERE id_complete_status = '{categoryId}' LIMIT 1";
            DataTable result1 = dbManager.GetData(query1);

            if (result1.Rows.Count > 0)
                return true;

            string query2 = $"SELECT 1 FROM supply WHERE id_complete_status = '{categoryId}' LIMIT 1";
            DataTable result2 = dbManager.GetData(query2);

            return result2.Rows.Count > 0;
        }

        /// <summary>
        /// Удаляет статус выполнения по заданному идентификатору.
        /// </summary>
        /// <param name="categoryId">Идентификатор статуса выполнения.</param>
        /// <returns>True, если удаление выполнено успешно; иначе False.</returns>
        public bool DeleteStatus(string categoryId)
        {
            string query = $"DELETE FROM s_complete_status WHERE id_complete_status = '{categoryId}'";
            return dbManager.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Добавляет новый статус выполнения в справочную таблицу.
        /// </summary>
        /// <param name="id">Идентификатор статуса выполнения.</param>
        /// <param name="complete_status">Название статуса выполнения.</param>
        public void AddStatus(string id, string complete_status)
        {
            string query = $"INSERT INTO s_complete_status (id_complete_status, complete_status) VALUES ('{id}', '{complete_status}')";
            dbManager.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Обновляет название статуса выполнения по заданному идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор статуса выполнения.</param>
        /// <param name="complete_status">Новое название статуса выполнения.</param>
        public void EditStatus(string id, string complete_status)
        {
            string query = $"UPDATE s_complete_status SET complete_status = '{complete_status}' WHERE id_complete_status = '{id}'";
            dbManager.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Получает следующий доступный идентификатор для нового статуса выполнения.
        /// </summary>
        /// <returns>Строка с новым идентификатором (на 1 больше текущего максимального).</returns>
        public string GetStatusMaxId()
        {
            var result = dbManager.GetData("SELECT MAX(id_complete_status) AS maxId FROM s_complete_status");
            if (result.Rows.Count > 0 && result.Rows[0]["maxId"] != DBNull.Value)
            {
                int maxId = Convert.ToInt32(result.Rows[0]["maxId"]);
                return (maxId + 1).ToString();
            }
            return "1";
        }
    }
}
