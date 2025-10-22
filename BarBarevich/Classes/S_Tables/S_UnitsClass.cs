using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace BarBarevich.Classes.S_Tables
{
    public class S_UnitsClass
    {
        private DatabaseManager dbManager;
        public S_UnitsClass()
        {
            dbManager = new DatabaseManager();
        }

        /// <summary>
        /// Получает все единицы измерения из справочной таблицы s_units.
        /// </summary>
        /// <returns>Таблица с единицами измерения, отсортированными по названию.</returns>
        public DataTable GetUnits()
        {
            string query = "SELECT * FROM s_units " +
                "ORDER BY unit;";
            return dbManager.GetData(query);
        }

        /// <summary>
        /// Проверяет, используется ли указанная единица измерения в таблице product.
        /// </summary>
        /// <param name="unitId">Идентификатор единицы измерения.</param>
        /// <returns>True, если используется; иначе False.</returns>
        public bool IsUnitInUse(string unitId)
        {
            string query = $"SELECT * FROM product WHERE id_unit = '{unitId}'";
            DataTable result = dbManager.GetData(query);
            return result.Rows.Count > 0;
        }

        /// <summary>
        /// Удаляет единицу измерения по заданному идентификатору.
        /// </summary>
        /// <param name="unitId">Идентификатор единицы измерения.</param>
        /// <returns>True, если удаление прошло успешно; иначе False.</returns>
        public bool DeleteUnit(string unitId)
        {
            string query = $"DELETE FROM s_units WHERE id_unit = '{unitId}'";
            return dbManager.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Добавляет новую единицу измерения в справочную таблицу.
        /// </summary>
        /// <param name="id">Идентификатор единицы измерения.</param>
        /// <param name="unit">Название единицы измерения.</param>
        public void AddUnit(string id, string unit)
        {
            string query = $"INSERT INTO s_units (id_unit, unit) VALUES ('{id}', '{unit}')";
            dbManager.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Обновляет название единицы измерения по заданному идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор единицы измерения.</param>
        /// <param name="unit">Новое название единицы измерения.</param>
        public void EditUnit(string id, string unit)
        {
            string query = $"UPDATE s_units SET unit = '{unit}' WHERE id_unit = '{id}'";
            dbManager.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Получает следующий доступный идентификатор для новой единицы измерения.
        /// </summary>
        /// <returns>Строка с идентификатором, на единицу больше текущего максимального.</returns>
        public string GetUnitMaxId()
        {
            var result = dbManager.GetData("SELECT MAX(id_unit) AS maxId FROM s_units");
            if (result.Rows.Count > 0 && result.Rows[0]["maxId"] != DBNull.Value)
            {
                int maxId = Convert.ToInt32(result.Rows[0]["maxId"]);
                return (maxId + 1).ToString();
            }
            return "1";
        }
    }
}
