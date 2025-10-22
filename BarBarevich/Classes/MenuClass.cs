using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarBarevich.Classes
{
    public class MenuClass
    {
        private DatabaseManager dbManager;

        public MenuClass()
        {
            dbManager = new DatabaseManager();
        }

        /// <summary>
        /// Получает список всех блюд меню с актуальными ценами.
        /// </summary>
        /// <returns>Таблица данных с блюдами меню.</returns>
        public DataTable GetMenuItems()
        {
            string query = @"
        SELECT c.id_item, c.name, s.category_name, p.price, c.grams_ml, c.calories 
        FROM menu_items c
        JOIN s_menu_categories s ON c.id_category = s.id_category
        JOIN price_list p ON c.id_item = p.id_item
        WHERE p.date = (
           SELECT MAX(date) 
            FROM price_list 
            WHERE id_item = c.id_item
           )
        ORDER BY c.name;
        ";

            return dbManager.GetData(query);
        }

        /// <summary>
        /// Получает список всех блюд меню с актуальными ценами.
        /// </summary>
        /// <returns>Таблица данных с блюдами меню.</returns>
        public DataTable GetMenuItemsByName(string name)
        {
            string query = $@"
        SELECT c.id_item, c.name, s.category_name, p.price, c.grams_ml, c.calories 
        FROM menu_items c
        JOIN s_menu_categories s ON c.id_category = s.id_category
        JOIN price_list p ON c.id_item = p.id_item
        WHERE c.name LIKE '%{name}%' 
        AND p.date = (
           SELECT MAX(date) 
            FROM price_list 
            WHERE id_item = c.id_item
           )
        ORDER BY c.name;
        ";

            return dbManager.GetData(query);
        }

        /// <summary>
        /// Получает блюда меню по указанной категории с актуальными ценами.
        /// </summary>
        /// <param name="category">Название категории.</param>
        /// <returns>Таблица данных с блюдами из указанной категории.</returns>
        public DataTable GetMenuItemsByCategory(string category)
        {
            string query = $@"
        SELECT c.id_item, c.name, s.category_name, p.price, c.grams_ml, c.calories 
        FROM menu_items c
        JOIN s_menu_categories s ON c.id_category = s.id_category
        JOIN price_list p ON c.id_item = p.id_item
        WHERE s.category_name = '{category}'
        AND p.date = (
            SELECT MAX(date)
            FROM price_list
            WHERE id_item = c.id_item
        )
        ORDER BY c.name;";

            return dbManager.GetData(query);
        }

        /// <summary>
        /// Проверяет, используется ли блюдо в каком-либо заказе.
        /// </summary>
        /// <param name="id">ID блюда.</param>
        /// <returns>True, если блюдо используется.</returns>

        public bool IsMenuItemUsed(string id)
        {
            string query = $"SELECT * FROM menu_in_order mio, price_list pl  " +
                $"WHERE mio.id_price = pl.id_price AND id_item = '{id}'";
            return dbManager.GetData(query).Rows.Count > 0;
        }

        /// <summary>
        /// Получает список всех названий категорий меню.
        /// </summary>
        /// <returns>Список названий категорий.</returns>
        public List<string> GetAllCategories()
        {
            var list = new List<string>();
            string query = "SELECT category_name FROM s_menu_categories";
            DataTable table = dbManager.GetData(query);
            foreach (DataRow row in table.Rows)
                list.Add(row["category_name"].ToString());
            return list;
        }

        /// <summary>
        /// Получает идентификатор категории по её названию.
        /// </summary>
        /// <param name="categoryName">Название категории.</param>
        /// <returns>ID категории или null, если не найдена.</returns>
        public string GetCategoryId(string categoryName)
        {
            string query = $"SELECT id_category FROM s_menu_categories WHERE category_name = '{categoryName}'";
            DataTable dt = dbManager.GetData(query);
            if (dt.Rows.Count > 0)
                return dt.Rows[0]["id_category"].ToString();
            return null;
        }

        /// <summary>
        /// Проверяет, существует ли блюдо с таким названием, исключая указанное ID.
        /// </summary>
        /// <param name="name">Название блюда.</param>
        /// <param name="exceptId">ID, которое нужно исключить из проверки.</param>
        /// <returns>True, если блюдо уже существует.</returns>
        public bool IsMenuItemExists(string name, string exceptId)
        {
            string query = $"SELECT * FROM menu_items WHERE name = '{name}' AND id_item != '{exceptId}'";
            return dbManager.GetData(query).Rows.Count > 0;
        }

        /// <summary>
        /// Получает следующий доступный ID для нового блюда.
        /// </summary>
        /// <returns>Следующий ID блюда в виде строки.</returns>
        public string GetNextItemId()
        {
            string query = "SELECT MAX(id_item) FROM menu_items";
            DataTable dt = dbManager.GetData(query);
            if (dt.Rows[0][0] != DBNull.Value)
                return (Convert.ToInt32(dt.Rows[0][0]) + 1).ToString();
            return "1";
        }

        /// <summary>
        /// Добавляет новое блюдо в меню и устанавливает цену.
        /// </summary>
        /// <param name="id">ID блюда.</param>
        /// <param name="name">Название блюда.</param>
        /// <param name="id_category">ID категории.</param>
        /// <param name="price">Цена блюда.</param>
        /// <param name="grams">Масса/объём блюда.</param>
        /// <param name="calories">Калорийность.</param>
        /// <returns>True, если добавление прошло успешно.</returns>
        public bool AddMenuItem(string id, string name, string id_category, string price, string grams, string calories)
        {
            string query1 = $"INSERT INTO menu_items (id_item, name, id_category, grams_ml, calories) " +
                            $"VALUES ('{id}', '{name}', '{id_category}', '{grams}', '{calories}')";

            string query2 = $"INSERT INTO price_list (id_item, price, date) " +
                            $"VALUES ('{id}', '{price}', NOW())";

            return dbManager.ExecuteNonQuery(query1) && dbManager.ExecuteNonQuery(query2);
        }

        /// <summary>
        /// Обновляет данные существующего блюда и устанавливает новую цену.
        /// </summary>
        /// <param name="id">ID блюда.</param>
        /// <param name="name">Название блюда.</param>
        /// <param name="id_category">ID категории.</param>
        /// <param name="price">Новая цена.</param>
        /// <param name="grams">Масса/объём блюда.</param>
        /// <param name="calories">Калорийность.</param>
        /// <returns>True, если обновление прошло успешно.</returns>
        public bool EditMenuItem(string id, string name, string id_category, string price, string grams, string calories)
        {
            string query1 = $"UPDATE menu_items SET name = '{name}', id_category = '{id_category}', grams_ml = '{grams}', calories = '{calories}' " +
                            $"WHERE id_item = '{id}'";

            string query2 = $"INSERT INTO price_list (id_item, price, date) " +
                            $"VALUES ('{id}', '{price}', NOW())";

            return dbManager.ExecuteNonQuery(query1) && dbManager.ExecuteNonQuery(query2);
        }

        /// <summary>
        /// Удаляет блюдо из меню вместе с его ценами.
        /// </summary>
        /// <param name="id">ID блюда.</param>
        /// <returns>True, если удаление прошло успешно.</returns>
        public bool DeleteMenuItem(string id)
        {
            string deletePriceQuery = $"DELETE FROM price_list WHERE id_item = '{id}'";
            string deleteProductListQuery = $"DELETE FROM product_in_menu_items WHERE id_item = '{id}'";
            string deleteItemQuery = $"DELETE FROM menu_items WHERE id_item = '{id}'";

            bool priceDeleted = dbManager.ExecuteNonQuery(deletePriceQuery);
            bool productListDeleted = dbManager.ExecuteNonQuery(deleteProductListQuery);
            bool itemDeleted = dbManager.ExecuteNonQuery(deleteItemQuery);

            return priceDeleted && itemDeleted && productListDeleted;
        }

        /// <summary>
        /// Получает список названий всех категорий меню.
        /// </summary>
        /// <returns>Список названий категорий.</returns>
        public List<string> GetMenuCategories()
        {
            var categories = new List<string>();
            string query = "SELECT category_name FROM s_menu_categories";
            DataTable dt = dbManager.GetData(query);

            foreach (DataRow row in dt.Rows)
                categories.Add(row["category_name"].ToString());

            return categories;
        }

        /// <summary>
        /// Добавление позиции в таблицу menu_in_order.
        /// </summary>
        /// <param name="id_reservation">ID резервации.</param>
        /// <param name="id_price">ID цены блюда.</param>
        /// <param name="quantity">Количество порций.</param>
        /// <returns>True, если добавление прошло успешно.</returns>
        public static bool AddMenuItemToOrder(int id_reservation, int id_price, int quantity)
        {
            try
            {
                DatabaseManager.myCommand.CommandText = @"
                    INSERT INTO menu_in_order (id_reservation, id_price, quantity, id_complete_status)
                    VALUES (@id_reservation, @id_price, @quantity, 1)";

                DatabaseManager.myCommand.Parameters.Clear();
                DatabaseManager.myCommand.Parameters.AddWithValue("@id_reservation", id_reservation);
                DatabaseManager.myCommand.Parameters.AddWithValue("@id_price", id_price);
                DatabaseManager.myCommand.Parameters.AddWithValue("@quantity", quantity);

                return DatabaseManager.myCommand.ExecuteNonQuery() > 0;
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении блюда в заказ.");
                return false;
            }
        }

        /// <summary>
        /// Удаляет все позиции из menu_in_order для конкретного заказа.
        /// </summary>
        /// <param name="id_reservation">ID резервации.</param>
        /// <returns>True, если удаление прошло успешно.</returns>
        public static bool ClearMenuItemsForReservation(int id_reservation)
        {
            try
            {
                DatabaseManager.myCommand.CommandText = @"
            DELETE FROM menu_in_order WHERE id_reservation = @id_reservation";

                DatabaseManager.myCommand.Parameters.Clear();
                DatabaseManager.myCommand.Parameters.AddWithValue("@id_reservation", id_reservation);

                DatabaseManager.myCommand.ExecuteNonQuery(); 
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении старых позиций меню.");
                return false;
            }
        }

        /// <summary>
        /// Получает таблицу всех блюд меню с актуальными ценами.
        /// </summary>
        /// <returns>Таблица данных с блюдами и ценами.</returns>
        public DataTable GetMenuItemsWithPrices()
        {
            string query = @"
        SELECT 
            mi.id_item, 
            mi.name, 
            cat.category_name AS category,
            mi.grams_ml,
            mi.calories,
            pl.price
        FROM 
            menu_items mi
        JOIN 
            s_menu_categories cat ON mi.id_category = cat.id_category
        JOIN 
            price_list pl ON mi.id_item = pl.id_item
        WHERE 
            pl.date = (
                SELECT MAX(date)
                FROM price_list
                WHERE id_item = mi.id_item
            );";

            return dbManager.GetData(query);
        }

        /// <summary>
        /// Получает ID последней установленной цены по названию блюда.
        /// </summary>
        /// <param name="name">Название блюда.</param>
        /// <returns>ID последней цены или null, если не найден.</returns>
        public static int? GetLatestPriceIdByItemName(string name)
        {
            try
            {
                string query = @"
            SELECT pl.id_price
            FROM price_list pl
            JOIN menu_items mi ON pl.id_item = mi.id_item
            WHERE mi.name = @name
            ORDER BY pl.date DESC
            LIMIT 1";

                using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    object result = command.ExecuteScalar();

                    return result == null || result == DBNull.Value
                        ? (int?)null
                        : Convert.ToInt32(result);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при получении идентификатора цены пункта меню.");
                return null;
            }
        }

        /// <summary>
        /// Получает рецептуру блюда по его ID.
        /// </summary>
        /// <param name="itemId">ID блюда.</param>
        /// <returns>Таблица с ингредиентами и их количеством.</returns>
        public DataTable GetRecipeForMenuItem(string itemId)
        {
            string query = @"
        SELECT p.product_name, u.unit, pm.quantity
        FROM product_in_menu_items pm
        JOIN product p ON pm.id_product = p.id_product
        JOIN s_units u ON u.id_unit = p.id_unit
        WHERE pm.id_item = @itemId";

            DataTable table = new DataTable();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, DatabaseManager.connection))
                {
                    cmd.Parameters.AddWithValue("@itemId", itemId);

                    if (dbManager.OpenConnection())
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(table);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении рецептуры пункта меню.");
            }

            return table;
        }

        /// <summary>
        /// Получает список заказанных блюд, их цену и количество по ID резервации.
        /// </summary>
        /// <param name="id_reservation">ID резервации.</param>
        /// <returns>Таблица с данными о заказанных блюдах.</returns>
        public DataTable GetMenuItemsForReservation(string id_reservation)
        {
            string query = $@"
SELECT mi.name, pl.price, mo.quantity 
                         FROM menu_items mi, menu_in_order mo, price_list pl 
                         WHERE mi.id_item = pl.id_item AND pl.id_price = mo.id_price
                         AND mo.id_reservation = '{id_reservation}';";

            try
            {
                return dbManager.GetData(query);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных меню для бронирования.");
                return null;
            }
        }


    }
}
