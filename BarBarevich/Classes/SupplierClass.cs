using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BarBarevich.Classes
{
    public class SupplierClass
    {
        private DatabaseManager dbManager;

        public SupplierClass()
        {
            dbManager = new DatabaseManager();
        }

        /// <summary>
        /// Получает следующий доступный идентификатор поставщика (MAX + 1).
        /// </summary>
        /// <returns>Строка с новым идентификатором поставщика.</returns>
        public static string GetSupplierMaxId()
        {
            string maxId = "0";

            try
            {
                using (MySqlCommand command = new MySqlCommand("SELECT MAX(id_supplier) AS maxId FROM suppliers", DatabaseManager.connection))
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
                MessageBox.Show("Ошибка при получении максимального идентификатора поставщика.");
            }

            return maxId;
        }

        /// <summary>
        /// Добавляет нового поставщика в базу данных.
        /// </summary>
        /// <param name="id">Идентификатор поставщика.</param>
        /// <param name="name">Имя поставщика.</param>
        /// <param name="phone">Телефон поставщика.</param>
        /// <param name="address">Адрес поставщика.</param>
        /// <returns>True, если добавление прошло успешно; иначе — false.</returns>
        public static bool AddSupplier(string id, string name, string phone, string address)
        {
            try
            {
                DatabaseManager.myCommand.CommandText = $"INSERT INTO suppliers (id_supplier, supplier_name, phone, address) " +
                                                        $"VALUES ('{id}', '{name}', '{phone}', '{address}')";

                return DatabaseManager.myCommand.ExecuteNonQuery() > 0;
            }
            catch 
            {
                MessageBox.Show("Ошибка при добавлении информации о поставщике.");
                return false;
            }
        }

        /// <summary>
        /// Обновляет информацию о поставщике.
        /// </summary>
        /// <param name="id">Идентификатор поставщика.</param>
        /// <param name="name">Новое имя поставщика.</param>
        /// <param name="phone">Новый телефон поставщика.</param>
        /// <param name="address">Новый адрес поставщика.</param>
        /// <returns>True, если редактирование прошло успешно; иначе — false.</returns>
        public static bool EditSupplier(string id, string name, string phone, string address)
        {
            try
            {
                DatabaseManager.myCommand.CommandText = $"UPDATE suppliers SET supplier_name = '{name}', phone = '{phone}', address = '{address}' " +
                                                        $"WHERE id_supplier = '{id}'";

                return DatabaseManager.myCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при редактировании информации о поставщике");
                return false;
            }
        }

        /// <summary>
        /// Удаляет поставщика по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор поставщика.</param>
        /// <returns>True, если удаление прошло успешно; иначе — false.</returns>
        public static bool DeleteSupplier(string id)
        {
            try
            {
                DatabaseManager.myCommand.CommandText = $"DELETE FROM suppliers WHERE id_supplier = '{id}'";
                return DatabaseManager.myCommand.ExecuteNonQuery() > 0;
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении информации о поставщике.");
                return false;
            }
        }

        /// <summary>
        /// Получает идентификатор поставщика по номеру телефона.
        /// </summary>
        /// <param name="phone">Телефон поставщика.</param>
        /// <returns>Идентификатор поставщика как строка. Возвращает "0", если не найден.</returns>
        public static string GetSupplierId(string phone)
        {
            string id = "0";

            try
            {
                using (MySqlCommand command = new MySqlCommand
                    ($"SELECT id_supplier FROM suppliers WHERE phone = '{phone}'",
                    DatabaseManager.connection))
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
                MessageBox.Show("Ошибка при получении идентификатора поставщика.");
            }

            return id;
        }

        /// <summary>
        /// Загружает список поставщиков в указанный DataGridView.
        /// </summary>
        /// <param name="dataGridView">Элемент DataGridView для отображения списка поставщиков.</param>
        public void FillDataGridViewSuppliers(DataGridView dataGridView)
        {
            DataTable dataTable = dbManager.GetData("SELECT * FROM suppliers ORDER BY supplier_name");
            dataGridView.DataSource = dataTable;
        }
    }
}