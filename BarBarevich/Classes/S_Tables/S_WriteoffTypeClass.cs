using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarBarevich.Classes.S_Tables
{
    public class S_WriteoffTypeClass
    {
        private DatabaseManager dbManager;
        public S_WriteoffTypeClass()
        {
            dbManager = new DatabaseManager();
        }

        /// <summary>
        /// Получает все типы списания из справочной таблицы s_writeoff_type.
        /// </summary>
        /// <returns>Таблица с типами списания, отсортированными по названию.</returns>
        public DataTable GetWriteoffTypes()
        {
            string query = "SELECT * FROM s_writeoff_type " +
                "ORDER BY writeoff_type;";
            return dbManager.GetData(query);
        }

        /// <summary>
        /// Проверяет, используется ли указанный тип списания в таблице product.
        /// </summary>
        /// <param name="writeoff_typeId">Идентификатор типа списания.</param>
        /// <returns>True, если используется; иначе False.</returns>
        public bool IsWriteoffTypeInUse(string writeoff_typeId)
        {
            string query = $"SELECT * FROM written_off_products WHERE id_writeoff_type = '{writeoff_typeId}'";
            DataTable result = dbManager.GetData(query);
            return result.Rows.Count > 0;
        }

        /// <summary>
        /// Удаляет тип списания по заданному идентификатору.
        /// </summary>
        /// <param name="writeoff_typeId">Идентификатор типа списания.</param>
        /// <returns>True, если удаление прошло успешно; иначе False.</returns>
        public bool DeleteWriteoffType(string writeoff_typeId)
        {
            string query = $"DELETE FROM s_writeoff_type WHERE id_writeoff_type = '{writeoff_typeId}'";
            return dbManager.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Добавляет новый тип списания в справочную таблицу.
        /// </summary>
        /// <param name="id">Идентификатор типа списания.</param>
        /// <param name="writeoff_type">Название типа списания.</param>
        public void AddWriteoffType(string id, string writeoff_type)
        {
            string query = $"INSERT INTO s_writeoff_type (id_writeoff_type, writeoff_type) VALUES ('{id}', '{writeoff_type}')";
            dbManager.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Обновляет название типа списания по заданному идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор типа списания.</param>
        /// <param name="writeoff_type">Новое название типа списания.</param>
        public void EditWriteoffType(string id, string writeoff_type)
        {
            string query = $"UPDATE s_writeoff_type SET writeoff_type = '{writeoff_type}' WHERE id_writeoff_type = '{id}'";
            dbManager.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Получает следующий доступный идентификатор для нового типа списания.
        /// </summary>
        /// <returns>Строка с идентификатором, на единицу больше текущего максимального.</returns>
        public string GetWriteoffTypeMaxId()
        {
            var result = dbManager.GetData("SELECT MAX(id_writeoff_type) AS maxId FROM s_writeoff_type");
            if (result.Rows.Count > 0 && result.Rows[0]["maxId"] != DBNull.Value)
            {
                int maxId = Convert.ToInt32(result.Rows[0]["maxId"]);
                return (maxId + 1).ToString();
            }
            return "1";
        }
    }
}
