using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BarBarevich.Classes
{
    public class ReservationClass
    {
        private DatabaseManager dbManager;

        public ReservationClass()
        {
            dbManager = new DatabaseManager();
        }

        /// <summary>
        /// Получает все данные бронирований с информацией о клиенте, сотруднике и статусом.
        /// </summary>
        /// <returns>Таблица данных бронирований.</returns>
        public static DataTable GetReservationData()
        {
            string query = $@"
    SELECT 
        r.id_reservation,
        r.id_client,
        c.full_name,
        c.phone,
        r.people_count,
        r.`date`,
        r.`time`,
        r.deposit,
        r.extra_info,
        r.id_employee,
        e.first_name,
        MAX(mo.id_complete_status) AS id_complete_status
    FROM reservation r
    JOIN `client` c ON r.id_client = c.id_client
    LEFT JOIN employee e ON r.id_employee = e.id_employee
    LEFT JOIN menu_in_order mo ON r.id_reservation = mo.id_reservation 
    GROUP BY r.id_reservation
    ORDER BY r.id_reservation DESC";  

            return new DatabaseManager().GetData(query);
        }

        /// <summary>
        /// Получает список столов для конкретного бронирования.
        /// </summary>
        /// <param name="reservationId">Идентификатор бронирования.</param>
        /// <returns>Таблица с идентификаторами и количеством мест столов.</returns>
        public static DataTable GetTablesForReservationDetails(string reservationId)
        {
            string query = $@"
        SELECT t.id_table, t.seats_count 
        FROM `tables` t
        JOIN tables_in_reservation tr ON tr.id_table = t.id_table
        WHERE tr.id_reservation = '{reservationId}'";

            return new DatabaseManager().GetData(query);
        }

        /// <summary>
        /// Получает пункты меню для конкретного бронирования.
        /// </summary>
        /// <param name="reservationId">Идентификатор бронирования.</param>
        /// <returns>Таблица с названиями, ценами и количеством заказанных пунктов меню.</returns>
        public static DataTable GetMenuItemsForReservationDetails(string reservationId)
        {
            string query = $@"
        SELECT mi.name, pl.price, mo.quantity 
                         FROM menu_items mi, menu_in_order mo, price_list pl 
                         WHERE mi.id_item = pl.id_item AND pl.id_price = mo.id_price
                         AND mo.id_reservation = '{reservationId}'";

            return new DatabaseManager().GetData(query);
        }

        /// <summary>
        /// Получает бронирования, отфильтрованные по дате.
        /// </summary>
        /// <param name="startDate">Дата начала фильтрации.</param>
        /// <param name="endDate">Дата конца фильтрации.</param>
        /// <returns>Таблица бронирований в заданном диапазоне дат.</returns>
        public static DataTable GetReservationsByDate(DateTime startDate, DateTime endDate)
        {
            string query = $@"
        SELECT 
        r.id_reservation,
        r.id_client,
        c.full_name,
        c.phone,
        r.people_count,
        r.`date`,
        r.`time`,
        r.deposit,
        r.extra_info,
        r.id_employee,
        e.first_name,
        MAX(mo.id_complete_status) AS id_complete_status
    FROM reservation r
    JOIN `client` c ON r.id_client = c.id_client
    LEFT JOIN employee e ON r.id_employee = e.id_employee
    LEFT JOIN menu_in_order mo ON r.id_reservation = mo.id_reservation 
    WHERE r.`date` BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}' 
    GROUP BY r.id_reservation 
";

            return new DatabaseManager().GetData(query);
        }

        /// <summary>
        /// Добавляет новое бронирование в базу данных.
        /// </summary>
        /// <param name="id_reservation">Идентификатор бронирования.</param>
        /// <param name="id_client">Идентификатор клиента.</param>
        /// <param name="people_count">Количество людей.</param>
        /// <param name="date">Дата бронирования.</param>
        /// <param name="time">Время бронирования.</param>
        /// <param name="deposit">Залог.</param>
        /// <returns>True, если добавление успешно; иначе false.</returns>
        public static bool AddReservation(string id_reservation, string id_client,
        string people_count, string date, string time, string deposit)
        {
            try
            {
                DatabaseManager.myCommand.CommandText
                    = $"INSERT INTO reservation (id_reservation, id_client, people_count, date, time, deposit) " +
                      $"VALUES ('{id_reservation}', '{id_client}', '{people_count}', '{date}', '{time}', '{deposit}')";

                return DatabaseManager.myCommand.ExecuteNonQuery() > 0;
            }
            catch 
            {
                MessageBox.Show("Ошибка при добавлении информации о бронировании.");
                return false;
            }
        }

        /// <summary>
        /// Добавляет новое бронирование с дополнительными полями: сотрудник и дополнительная информация.
        /// </summary>
        /// <param name="id_reservation">Идентификатор бронирования.</param>
        /// <param name="id_client">Идентификатор клиента.</param>
        /// <param name="people_count">Количество людей.</param>
        /// <param name="date">Дата бронирования.</param>
        /// <param name="time">Время бронирования.</param>
        /// <param name="deposit">Залог.</param>
        /// <param name="id_employee">Идентификатор сотрудника.</param>
        /// <param name="extra_info">Дополнительная информация.</param>
        /// <returns>True, если добавление успешно; иначе false.</returns>
        public static bool AddReservationExtra(string id_reservation, string id_client,
        string people_count, string date, string time, string deposit, string id_employee, string extra_info)
        {
            try
            {
                DatabaseManager.myCommand.CommandText
                    = $"INSERT INTO reservation (id_reservation, id_client, people_count, date, " +
                    $"time, deposit, id_employee, extra_info) " +
                      $"VALUES ('{id_reservation}', '{id_client}', '{people_count}', '{date}', " +
                      $"'{time}', '{deposit}', '{id_employee}', '{extra_info}')";

                return DatabaseManager.myCommand.ExecuteNonQuery() > 0;
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении данных о бронировании с дополнением.");
                return false;
            }
        }

        /// <summary>
        /// Добавляет связь столов с бронированием.
        /// </summary>
        /// <param name="id_reservation">Идентификатор бронирования.</param>
        /// <param name="id_table">Идентификатор стола.</param>
        /// <returns>True, если добавление успешно; иначе false.</returns>
        public static bool AddTablesToReservation(string id_reservation, int id_table)
        {
            try
            {
                DatabaseManager.myCommand.CommandText
                    = $"INSERT INTO tables_in_reservation (id_reservation, id_table) " +
                    $"VALUES ('{id_reservation}', '{id_table}')";

                return DatabaseManager.myCommand.ExecuteNonQuery() > 0;
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении столов в бронирование.");
                return false;
            }
        }

        /// <summary>
        /// Получает следующий доступный идентификатор бронирования (максимум + 1).
        /// </summary>
        /// <returns>Строка с новым идентификатором бронирования.</returns>
        public static string GetMaxReservationId()
        {
            string maxId = "0";

            try
            {
                using (MySqlCommand command = new MySqlCommand
                    ("SELECT MAX(id_reservation) AS maxId FROM reservation", DatabaseManager.connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        maxId = (Convert.ToInt32(result) + 1).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении максимального идентификатора бронирования.");
            }

            return maxId;
        }

        /// <summary>
        /// Удаляет бронирование по идентификатору.
        /// </summary>
        /// <param name="id_reservation">Идентификатор бронирования.</param>
        /// <returns>True, если удаление прошло успешно; иначе false.</returns>
        public static bool DeleteReservation(string id_reservation)
        {
            try
            {
                DatabaseManager.myCommand.CommandText
                    = $"DELETE FROM reservation WHERE id_reservation = '{id_reservation}'";

                return DatabaseManager.myCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении информации о бронировании.");
                return false;
            }
        }

        /// <summary>
        /// Проверяет, связаны ли столы с указанным бронированием.
        /// </summary>
        /// <param name="id_reservation">Идентификатор бронирования.</param>
        /// <returns>True, если есть связанные столы; иначе false.</returns>
        public static bool HasTablesForReservation(string id_reservation)
        {
            string query = $"SELECT COUNT(*) FROM tables_in_reservation " +
                $"WHERE id_reservation = '{id_reservation}'";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, DatabaseManager.connection))
                {
                    object result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result) > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при проверке наличия столов у бронирования.");
                return false;
            }
        }

        /// <summary>
        /// Удаляет все связанные столы для указанного бронирования.
        /// </summary>
        /// <param name="id_reservation">Идентификатор бронирования.</param>
        /// <returns>True, если удаление прошло успешно; иначе false.</returns>
        public static bool DeleteTablesFromReservation(string id_reservation)
        {
            try
            {
                DatabaseManager.myCommand.CommandText
                    = $"DELETE FROM tables_in_reservation WHERE id_reservation = '{id_reservation}'";

                return DatabaseManager.myCommand.ExecuteNonQuery() > 0;
            }
            catch 
            {
                MessageBox.Show("Ошибка при удаления столов из бронирования.");
                return false;
            }
        }

        /// <summary>
        /// Редактирует данные бронирования без дополнительных полей.
        /// </summary>
        /// <param name="id_reservation">Идентификатор бронирования.</param>
        /// <param name="id_client">Идентификатор клиента.</param>
        /// <param name="people_count">Количество людей.</param>
        /// <param name="actual_people_count">Фактическое количество людей.</param>
        /// <param name="date">Дата бронирования.</param>
        /// <param name="time">Время бронирования.</param>
        /// <param name="deposit">Залог.</param>
        /// <returns>True, если редактирование успешно; иначе false.</returns>
        public bool EditReservation(string id_reservation, string id_client, string people_count,
            string actual_people_count, string date, string time, string deposit)
        {
            try
            {
                string query = $@"UPDATE reservation
                          SET id_client = '{id_client}', people_count = '{people_count}',
                              actual_people_count = '{actual_people_count}', `date` = '{date}', `time` = '{time}', 
                              deposit = '{deposit.ToString().Replace(',', '.')}'
                          WHERE id_reservation = '{id_reservation}'";

                return dbManager.ExecuteNonQuery(query);
            }
            catch 
            {
                MessageBox.Show("Ошибка при редактировании информации о бронировании.");
                return false;
            }
        }

        /// <summary>
        /// Редактирует данные бронирования с дополнительными полями: сотрудник и дополнительная информация.
        /// </summary>
        /// <param name="id_reservation">Идентификатор бронирования.</param>
        /// <param name="id_client">Идентификатор клиента.</param>
        /// <param name="people_count">Количество людей.</param>
        /// <param name="actual_people_count">Фактическое количество людей.</param>
        /// <param name="date">Дата бронирования.</param>
        /// <param name="time">Время бронирования.</param>
        /// <param name="deposit">Залог.</param>
        /// <param name="id_employee">Идентификатор сотрудника или null.</param>
        /// <param name="extra_info">Дополнительная информация или null.</param>
        /// <returns>True, если редактирование успешно; иначе false.</returns>
        public bool EditReservationExtra(string id_reservation, string id_client, string people_count,
    string actual_people_count, string date, string time, string deposit, string id_employee, string extra_info)
        {
            try
            {
                string id_employee_sql = string.IsNullOrEmpty(id_employee) ? "NULL" : $"'{id_employee}'";
                string extra_info_sql = string.IsNullOrEmpty(extra_info) ? "NULL" : $"'{extra_info}'";

                string query = $@"UPDATE reservation
                  SET id_client = '{id_client}', 
                      people_count = '{people_count}',
                      actual_people_count = '{actual_people_count}', 
                      date = '{date}', 
                      time = '{time}', 
                      deposit = '{deposit.ToString().Replace(',', '.')}', 
                      id_employee = {id_employee_sql}, 
                      extra_info = {extra_info_sql}
                  WHERE id_reservation = '{id_reservation}'";

                return dbManager.ExecuteNonQuery(query);
            }
            catch 
            {
                MessageBox.Show("Ошибка при редактировании информации о бронировании.");
                return false;
            }
        }

        /// <summary>
        /// Очищает (удаляет) все столы, связанные с указанным бронированием.
        /// </summary>
        /// <param name="id_reservation">Идентификатор бронирования.</param>
        /// <returns>True, если удаление прошло успешно; иначе false.</returns>
        public static bool ClearTablesForReservation(string id_reservation)
        {
            try
            {
                string query = $"DELETE FROM tables_in_reservation WHERE id_reservation = @id_reservation";

                MySqlCommand cmd = new MySqlCommand(query, DatabaseManager.connection);
                cmd.Parameters.AddWithValue("@id_reservation", id_reservation);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch 
            {
                MessageBox.Show("Ошибка при удалении столов из бронирования.");
                return false;
            }
        }

        /// <summary>
        /// Проверяет, существует ли клиент с указанным номером телефона.
        /// </summary>
        /// <param name="phone">Телефон клиента.</param>
        /// <returns>True, если клиент найден; иначе false.</returns>
        public static bool CheckIfClientExistsByPhone(string phone)
        {
            string query = "SELECT * FROM client WHERE phone = @phone";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, DatabaseManager.connection);
                cmd.Parameters.AddWithValue("@phone", phone);
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                return dt.Rows.Count > 0; 
            }
            catch
            {
                MessageBox.Show("Ошибка при проверке клиента по телефону.");
                return false;
            }
        }

        /// <summary>
        /// Обновляет статус выполнения бронирования для заданного идентификатора.
        /// </summary>
        /// <param name="reservationId">Идентификатор бронирования.</param>
        /// <param name="statusId">Идентификатор статуса.</param>
        /// <returns>True, если обновление успешно; иначе false.</returns>
        public static bool UpdateReservationStatus(string reservationId, int statusId)
        {
            string query = $"UPDATE menu_in_order SET id_complete_status = {statusId} WHERE id_reservation = {reservationId}";
            return new DatabaseManager().ExecuteNonQuery(query);
        }

        /// <summary>
        /// Получает пункты меню и их количество для заданного бронирования.
        /// </summary>
        /// <param name="reservationId">Идентификатор бронирования.</param>
        /// <returns>Таблица с пунктами меню и количеством.</returns>
        public static DataTable GetMenuItemsForReservation(string reservationId)
        {
            string query = @"
        SELECT mo.id_product, mo.quantity
        FROM menu_in_order mo
        WHERE mo.id_reservation = @reservationId";

            query = query.Replace("@reservationId", reservationId);

            return new DatabaseManager().GetData(query); 
        }

        /// <summary>
        /// Подтверждает выдачу меню для бронирования, проверяет наличие товара и списывает со склада.
        /// </summary>
        /// <param name="reservationId">Идентификатор бронирования.</param>
        /// <returns>True, если операция успешна; иначе false.</returns>
        public static bool ConfirmMenuIssuance(string reservationId)
        {

                MySqlConnection connection = DatabaseManager.connection;
                MySqlTransaction transaction = connection.BeginTransaction();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.Transaction = transaction;

                string query = @"SELECT pimi.id_product, SUM(pimi.quantity * mo.quantity) AS total_quantity
FROM reservation r
JOIN menu_in_order mo ON r.id_reservation = mo.id_reservation
JOIN price_list pl ON mo.id_price = pl.id_price
JOIN menu_items mi ON pl.id_item = mi.id_item
JOIN product_in_menu_items pimi ON mi.id_item = pimi.id_item
JOIN product p ON pimi.id_product = p.id_product
WHERE mo.id_reservation = @reservationId
AND mo.id_complete_status != 2
GROUP BY pimi.id_product;";  

                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@reservationId", reservationId);

                DataTable orderedItems = new DataTable();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    orderedItems.Load(reader);
                }

                foreach (DataRow row in orderedItems.Rows)
                {
                    int productId = Convert.ToInt32(row["id_product"]);
                    decimal quantityOrdered = Convert.ToDecimal(row["total_quantity"]);

                    decimal stockQuantity = GetProductStockQuantity(productId);
                    if (stockQuantity < quantityOrdered)
                    {
                        MessageBox.Show("Недостаточно товара на складе для выполнения этого заказа.");
                        transaction.Rollback(); 
                        return false;
                    }
                }

                string updateStatusQuery = @"
                    UPDATE menu_in_order
                    SET id_complete_status = 2
                    WHERE id_reservation = @reservationId
                    AND id_complete_status != 2";

                cmd.CommandText = updateStatusQuery;
                cmd.ExecuteNonQuery();

                foreach (DataRow row in orderedItems.Rows)
                {
                    int productId = Convert.ToInt32(row["id_product"]);
                    decimal quantityOrdered = Convert.ToDecimal(row["total_quantity"]);

                    string updateStockQuery = @"
                        UPDATE product
                        SET stock_quantity = stock_quantity - @quantity
                        WHERE id_product = @productId";

                    cmd.CommandText = updateStockQuery;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@quantity", quantityOrdered);
                    cmd.Parameters.AddWithValue("@productId", productId);
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
                return true;

        }

        /// <summary>
        /// Получает количество товара на складе по его идентификатору.
        /// </summary>
        /// <param name="productId">Идентификатор продукта.</param>
        /// <returns>Количество товара на складе. Возвращает 0, если товар не найден.</returns>
        private static decimal GetProductStockQuantity(int productId)
        {
            string query = @"
                SELECT stock_quantity
                FROM product
                WHERE id_product = @productId";

            MySqlCommand cmd = new MySqlCommand(query, DatabaseManager.connection);
            cmd.Parameters.AddWithValue("@productId", productId);

            object result = cmd.ExecuteScalar();
            return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
        }
    }
}
