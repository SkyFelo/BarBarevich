using Guna.UI2.WinForms.Suite;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarBarevich.Classes
{
    public class TableClass
    {
        private DatabaseManager dbManager;

        public TableClass()
        {
            dbManager = new DatabaseManager();
        }

        /// <summary>
        /// Получает максимальный идентификатор столика из таблицы "tables".
        /// </summary>
        /// <returns>Следующее значение идентификатора как строка.</returns>
        public static string GetTableMaxId()
        {
            string maxId = "0";

            try
            {
                using (MySqlCommand command = new MySqlCommand
                    ("SELECT MAX(id_table) AS maxId FROM tables", DatabaseManager.connection))
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
                MessageBox.Show("Ошибка при получении максимального идентификатора стола.");
            }

            return maxId;
        }

        /// <summary>
        /// Добавляет новую запись о столике в базу данных.
        /// </summary>
        /// <param name="id">Идентификатор столика.</param>
        /// <param name="description">Описание столика.</param>
        /// <param name="seats_count">Количество мест за столиком.</param>
        /// <returns>True, если добавление прошло успешно; иначе — false.</returns>
        public static bool AddTable(string id, string description, string seats_count)
        {
            try
            {
                DatabaseManager.myCommand.CommandText
                    = $"INSERT INTO tables (id_table, description, seats_count) " +
                    $"VALUES ('{id}', '{description}', '{seats_count}')";

                return DatabaseManager.myCommand.ExecuteNonQuery() > 0;
            }
            catch 
            {
                MessageBox.Show("Ошибка при добавлении информации о столе.");
                return false;
            }
        }

        /// <summary>
        /// Обновляет данные существующего столика в базе данных.
        /// </summary>
        /// <param name="id">Идентификатор столика.</param>
        /// <param name="description">Новое описание столика.</param>
        /// <param name="seats_count">Новое количество мест за столиком.</param>
        /// <returns>True, если обновление прошло успешно; иначе — false.</returns>
        public static bool EditTable(string id, string description, string seats_count)
        {
            try
            {
                DatabaseManager.myCommand.CommandText
                    = $"UPDATE tables SET description = '{description}', seats_count = '{seats_count}' " +
                    $"WHERE id_table = '{id}'";

                return DatabaseManager.myCommand.ExecuteNonQuery() > 0;
            }
            catch 
            {
                MessageBox.Show("Ошибка при редактировании информации о столе.");
                return false;
            }
        }

        /// <summary>
        /// Удаляет запись о столике из базы данных.
        /// </summary>
        /// <param name="id">Идентификатор удаляемого столика.</param>
        /// <returns>True, если удаление прошло успешно; иначе — false.</returns>
        public static bool DeleteTable(string id)
        {
            try
            {
                DatabaseManager.myCommand.CommandText
                    = $"DELETE FROM tables WHERE id_table = '{id}'";

                return DatabaseManager.myCommand.ExecuteNonQuery() > 0;
            }
            catch 
            {
                MessageBox.Show("Ошибка при удалении информации о столе");
                return false;
            }
        }

        /// <summary>
        /// Получает идентификатор столика по его описанию.
        /// </summary>
        /// <param name="description">Описание столика.</param>
        /// <returns>Идентификатор столика как строка.</returns>
        public static string GetTableId(string description)
        {
            string id = "0";

            try
            {
                using (MySqlCommand command = new MySqlCommand
                    ($"SELECT id_table FROM tables WHERE description = '{description}'", DatabaseManager.connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        id = result.ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при получении идентификатора стола.");
            }

            return id;
        }

        /// <summary>
        /// Проверяет, используется ли указанный столик в таблице бронирований.
        /// </summary>
        /// <param name="id">Идентификатор столика.</param>
        /// <returns>True, если столик используется; иначе — false.</returns>
        public bool IsClientUsed(string id)
        {
            string query = $"SELECT * FROM tables_in_reservation WHERE id_table = '{id}'";
            return dbManager.GetData(query).Rows.Count > 0;
        }

        /// <summary>
        /// Заполняет элемент DataGridView данными из таблицы "tables".
        /// </summary>
        /// <param name="dataGridView">Элемент DataGridView для отображения данных.</param>
        public void FillDataGridViewTables(DataGridView dataGridView)
        {
            System.Data.DataTable dataTable = dbManager.GetData("SELECT * FROM tables");
            dataGridView.DataSource = dataTable;
        }
    }
}
