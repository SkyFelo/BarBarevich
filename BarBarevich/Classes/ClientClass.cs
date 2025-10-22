using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace BarBarevich.Classes
{
    public class ClientClass
    {
        private DatabaseManager dbManager;

        public ClientClass()
        {
            dbManager = new DatabaseManager();
        }
        /// <summary>
        /// Получает следующий доступный ID для нового клиента.
        /// </summary>
        /// <returns>Строка с новым ID клиента (на 1 больше текущего максимального).</returns>
        public static string GetClientMaxId()
        {
            string maxId = "0";

            try
            {
                using (MySqlCommand command = new MySqlCommand
                    ("SELECT MAX(id_client) AS maxId FROM client", DatabaseManager.connection))
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
                MessageBox.Show("Ошибка при получении максимального значения идентификатора клиента.");
            }

            return maxId;
        }

        /// <summary>
        /// Добавляет нового клиента в базу данных.
        /// </summary>
        /// <param name="id">ID клиента.</param>
        /// <param name="full_name">ФИО клиента.</param>
        /// <param name="phone">Номер телефона клиента.</param>
        /// <returns>True, если добавление прошло успешно.</returns>
        public static bool AddClient(string id, string full_name, string phone)
        {
            try
            {
                DatabaseManager.myCommand.CommandText 
                    = $"INSERT INTO client (id_client, full_name, phone) " +
                    $"VALUES ('{id}', '{full_name}', '{phone}')";

                return DatabaseManager.myCommand.ExecuteNonQuery() > 0;
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении данных клиента");
                return false;
            }
        }

        /// <summary>
        /// Обновляет данные клиента в базе.
        /// </summary>
        /// <param name="id">ID клиента.</param>
        /// <param name="full_name">Новое ФИО.</param>
        /// <param name="phone">Новый номер телефона.</param>
        /// <returns>True, если обновление прошло успешно.</returns>
        public static bool EditClient(string id, string full_name, string phone)
        {
            try
            {
                DatabaseManager.myCommand.CommandText 
                    = $"UPDATE client SET full_name = '{full_name}', phone = '{phone}' " +
                    $"WHERE id_client = '{id}'";

                return DatabaseManager.myCommand.ExecuteNonQuery() > 0;
            }
            catch 
            {
                MessageBox.Show("Ошибка при добавлении данных клиента.");
                return false;
            }
        }

        /// <summary>
        /// Удаляет клиента из базы данных по ID.
        /// </summary>
        /// <param name="id">ID клиента.</param>
        /// <returns>True, если удаление прошло успешно.</returns>
        public static bool DeleteClient(string id)
        {
            try
            {
                DatabaseManager.myCommand.CommandText 
                    = $"DELETE FROM client WHERE id_client = '{id}'";

                return DatabaseManager.myCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении данных клиента.");
                return false;
            }
        }

        /// <summary>
        /// Получает ID клиента по номеру телефона.
        /// </summary>
        /// <param name="phone">Телефон клиента.</param>
        /// <returns>ID клиента в виде строки, либо "0", если не найден.</returns>
        public static string GetClientId(string phone)
        {
            string id = "0";

            try
            {
                using (MySqlCommand command = new MySqlCommand
                    ($"SELECT id_client FROM client WHERE phone = '{phone}'", DatabaseManager.connection))
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
                MessageBox.Show("Ошибка при получении значения идентификатора клиента.");
            }

            return id;
        }

        /// <summary>
        /// Проверяет, используется ли клиент в таблице reservation.
        /// </summary>
        /// <param name="id">ID клиента.</param>
        /// <returns>True, если клиент используется.</returns>
        public bool IsClientUsed(string id)
        {
            string query = $"SELECT * FROM reservation WHERE id_client = '{id}'";
            return dbManager.GetData(query).Rows.Count > 0;
        }

        /// <summary>
        /// Заполняет DataGridView всеми клиентами, отсортированными по ФИО.
        /// </summary>
        /// <param name="dataGridView">Компонент DataGridView для заполнения.</param>
        public void FillDataGridViewClients(DataGridView dataGridView)
        {
            System.Data.DataTable dataTable = dbManager.GetData("SELECT * FROM client ORDER BY full_name");
            dataGridView.DataSource = dataTable;
        }

        /// <summary>
        /// Заполняет DataGridView клиентами, чье ФИО начинается с заданной строки.
        /// </summary>
        /// <param name="input">Начало ФИО для фильтрации.</param>
        /// <param name="dataGridView">Компонент DataGridView для заполнения.</param>
        public void FillDataGridViewClientsFullName(string input, DataGridView dataGridView)
        {
            System.Data.DataTable dataTable = dbManager.GetData
                ($"SELECT * FROM client WHERE full_name LIKE '{input}%' ORDER BY full_name");
            dataGridView.DataSource = dataTable;
        }

        /// <summary>
        /// Заполняет DataGridView клиентами, чей номер телефона начинается с заданной строки.
        /// </summary>
        /// <param name="input">Начало номера телефона для фильтрации.</param>
        /// <param name="dataGridView">Компонент DataGridView для заполнения.</param>
        public void FillDataGridViewClientsPhone(string input, DataGridView dataGridView)
        {
            System.Data.DataTable dataTable = dbManager.GetData
                ($"SELECT * FROM client WHERE phone LIKE '{input}%' ORDER BY full_name");
            dataGridView.DataSource = dataTable;
        }
    }
}
