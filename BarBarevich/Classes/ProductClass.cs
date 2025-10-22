using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarBarevich.Classes
{
    public class ProductClass
    {
        private DatabaseManager dbManager;
        public ProductClass()
        {
            dbManager = new DatabaseManager();
        }
        /// <summary>
        /// Заполняет DataGridView информацией о продуктах.
        /// </summary>
        /// <param name="dataGridView">Элемент управления DataGridView, в который загружаются данные.</param>
        public void FillDataGridViewProducts(DataGridView dataGridView)
        {
            string query = "SELECT p.id_product, p.product_name, u.unit, p.stock_quantity " +
                           "FROM product p JOIN s_units u ON p.id_unit = u.id_unit " +
                           "ORDER BY p.product_name;";
            dataGridView.DataSource = dbManager.GetData(query);
        }

        /// <summary>
        /// Заполняет DataGridView информацией о продуктах по названию.
        /// </summary>
        /// <param name="dataGridView">Элемент управления DataGridView, в который загружаются данные.</param>
        public void FillDataGridViewProductsByName(DataGridView dataGridView, string name)
        {
            string query = "SELECT p.id_product, p.product_name, u.unit, p.stock_quantity " +
                           "FROM product p JOIN s_units u ON p.id_unit = u.id_unit " +
                           $"WHERE p.product_name LIKE '%{name}%' " +
                           "ORDER BY p.product_name;";
            dataGridView.DataSource = dbManager.GetData(query);
        }
            /// <summary>
            /// Получает максимальный идентификатор продукта из таблицы product.
            /// </summary>
            /// <returns>Следующий доступный идентификатор в виде строки.</returns>
            public static string GetMaxProductId()
        {
            try
            {
                string query = "SELECT MAX(id_product) FROM product";
                object result = new DatabaseManager().GetData(query).Rows[0][0];
                return result == DBNull.Value ? "1" : (Convert.ToInt32(result) + 1).ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка при получении идентификатора продукта.");
                return "1";
            }
        }

        /// <summary>
        /// Добавляет новый продукт в таблицу product.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <param name="name">Название продукта.</param>
        /// <param name="unitId">Идентификатор единицы измерения.</param>
        /// <param name="quantity">Начальное количество на складе.</param>
        /// <returns>True, если продукт успешно добавлен; иначе false.</returns>
        public static bool AddProduct(string id, string name, string unitId, string quantity)
        {
            try
            {
                string query = $"INSERT INTO product (id_product, product_name, id_unit, stock_quantity) " +
                               $"VALUES ('{id}', '{name}', '{unitId}', '{quantity}')";
                return new DatabaseManager().ExecuteNonQuery(query);
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении информации о продукте.");
                return false;
            }
        }

        /// <summary>
        /// Обновляет информацию о продукте.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <param name="name">Новое название продукта.</param>
        /// <param name="unitId">Новая единица измерения.</param>
        /// <param name="quantity">Новое количество на складе.</param>
        /// <returns>True, если обновление прошло успешно; иначе false.</returns>
        public static bool EditProduct(string id, string name, string unitId, string quantity)
        {
            try
            {
                string query = $"UPDATE product SET product_name = '{name}', id_unit = '{unitId}', " +
                               $"stock_quantity = '{quantity}' WHERE id_product = '{id}'";
                return new DatabaseManager().ExecuteNonQuery(query);
            }
            catch 
            {
                MessageBox.Show("Ошибка при редактировании информации о продукте.");
                return false;
            }
        }

        /// <summary>
        /// Удаляет продукт из базы данных.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <returns>True, если продукт успешно удалён; иначе false.</returns>
        public static bool DeleteProduct(string id)
        {
            try
            {
                string query = $"DELETE FROM product WHERE id_product = '{id}'";
                return new DatabaseManager().ExecuteNonQuery(query);
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении информации о продукте.");
                return false;
            }
        }

        /// <summary>
        /// Проверяет, используется ли продукт в рецептах.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <returns>True, если продукт используется; иначе false.</returns>
        public bool IsProductUsed(string id)
        {
            string query = $"SELECT * FROM product_in_menu_items WHERE id_product = '{id}'";
            return dbManager.GetData(query).Rows.Count > 0;
        }

        /// <summary>
        /// Возвращает список всех единиц измерения из справочника.
        /// </summary>
        /// <returns>DataTable с данными из таблицы s_units.</returns>
        public DataTable GetUnits()
        {
            return dbManager.GetData("SELECT * FROM s_units");
        }

        /// <summary>
        /// Проверяет, существует ли продукт с указанным названием.
        /// </summary>
        /// <param name="name">Название продукта для проверки.</param>
        /// <returns>True, если продукт с таким названием уже существует; иначе false.</returns>
        public bool IsProductNameExists(string name)
        {
            string query = $"SELECT COUNT(*) FROM product WHERE product_name = '{name}'";
            var result = dbManager.GetData(query);
            return Convert.ToInt32(result.Rows[0][0]) > 0;
        }

        /// <summary>
        /// Получает название продукта по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <returns>Название продукта или пустая строка, если не найден.</returns>
        public string GetProductNameById(string id)
        {
            string query = $"SELECT product_name FROM product WHERE id_product = '{id}'";
            var result = dbManager.GetData(query);
            return result.Rows.Count > 0 ? result.Rows[0]["product_name"].ToString() : "";
        }

        /// <summary>
        /// Получает список всех продуктов с сортировкой по названию.
        /// </summary>
        /// <returns>DataTable с идентификатором, названием и единицей измерения каждого продукта.</returns>
        public DataTable GetAllProductsSorted()
        {
            string query = @"
        SELECT p.id_product, p.product_name, u.unit
        FROM product p
        JOIN s_units u ON p.id_unit = u.id_unit
        ORDER BY p.product_name ASC";

            return dbManager.GetData(query);
        }

        /// <summary>
        /// Добавляет продукт в рецептуру блюда.
        /// </summary>
        /// <param name="id_product">Идентификатор продукта.</param>
        /// <param name="id_item">Идентификатор блюда.</param>
        /// <param name="quantity">Количество продукта.</param>
        /// <returns>True, если продукт успешно добавлен в рецептуру; иначе false.</returns>
        public bool AddProductToRecipe(int id_product, int id_item, double quantity)
        {
            string query = $"INSERT INTO product_in_menu_items (id_product, id_item, quantity) " +
                           $"VALUES ('{id_product}', '{id_item}', '{quantity.ToString().Replace(',', '.')}')";
            return dbManager.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Получить рецептуру по ID блюда.
        /// </summary>
        /// <param name="id_menu">ID блюда из таблицы menu_items.</param>
        /// <returns>DataTable с полями product_name и quantity.</returns>
        public DataTable GetRecipeByMenuId(string id_menu)
        {
            string query = $@"
        SELECT p.product_name, pr.quantity, p.id_product
        FROM product_in_menu_items pr
        JOIN product p ON pr.id_product = p.id_product
        WHERE pr.id_item = '{id_menu}'";
            return dbManager.GetData(query);
        }

        /// <summary>
        /// Удаляет рецептуру (все ингредиенты) для указанного блюда.
        /// </summary>
        /// <param name="id_menu">ID блюда, у которого очищается рецептура.</param>
        /// <returns>True, если успешно удалено.</returns>
        public bool ClearRecipeForMenu(string id_menu)
        {
            string query = $"DELETE FROM product_in_menu_items WHERE id_item = '{id_menu}'";
            return dbManager.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Выполняет списание продукции с учётом типа списания.
        /// </summary>
        /// <param name="productId">Идентификатор продукта.</param>
        /// <param name="quantity">Количество списываемой продукции.</param>
        /// <param name="writeOffTypeId">Идентификатор типа списания.</param>
        /// <returns>True, если списание выполнено успешно; иначе false.</returns>
        public static bool WriteOffProduct(string productId, decimal quantity, string writeOffTypeId)
        {
            try
            {
                string insertQuery = $@"
        INSERT INTO written_off_products (id_product, quantity, write_off_date, id_write_off_type)
        VALUES ('{productId}', '{quantity.ToString("0.00").Replace(',', '.')}', NOW(), '{writeOffTypeId}')";

                bool isInserted = new DatabaseManager().ExecuteNonQuery(insertQuery);

                if (isInserted)
                {
                    string updateQuery = $@"
            UPDATE product
            SET stock_quantity = stock_quantity - {quantity.ToString("0.00").Replace(',', '.')}
            WHERE id_product = '{productId}'";

                    new DatabaseManager().ExecuteNonQuery(updateQuery);
                }

                return isInserted;
            }
            catch 
            {
                MessageBox.Show("Ошибка при списании продукта");
                return false;
            }
        }

        /// <summary>
        /// Получает список типов списания из справочника.
        /// </summary>
        /// <returns>Список объектов WriteOffType.</returns>
        public List<WriteOffType> GetWriteOffTypes()
        {
            var writeOffTypes = new List<WriteOffType>();

            string query = "SELECT id_writeoff_type, writeoff_type FROM s_writeoff_type";

            try
            {
                var dataTable = dbManager.GetData(query);
                foreach (DataRow row in dataTable.Rows)
                {
                    writeOffTypes.Add(new WriteOffType
                    {
                        Id = row["id_writeoff_type"].ToString(),
                        Type = row["writeoff_type"].ToString()
                    });
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при получении типов списания.");
            }

            return writeOffTypes;
        }

        /// <summary>
        /// Получает список списанных продуктов, с фильтрацией по типу списания при необходимости.
        /// </summary>
        /// <param name="writeOffTypeId">Необязательный идентификатор типа списания.</param>
        /// <returns>DataTable со списком списанных продуктов.</returns>
        public class WriteOffType
        {
            public string Id { get; set; }
            public string Type { get; set; }
        }

        /// <summary>
        /// Получает количество продукта на складе по идентификатору.
        /// </summary>
        /// <param name="productId">Идентификатор продукта.</param>
        /// <returns>Текущее количество продукта на складе.</returns>
        public DataTable GetWrittenOffProducts(string writeOffTypeId = null)
        {
            string query = @"
            SELECT w.id_written_off_product, p.product_name, w.quantity, w.write_off_date, t.writeoff_type
            FROM written_off_products w
            JOIN product p ON w.id_product = p.id_product
            JOIN s_writeoff_type t ON w.id_write_off_type = t.id_writeoff_type ";

            if (writeOffTypeId != null)
            {
                query += $" WHERE w.id_write_off_type = '{writeOffTypeId}'";
            }

            query += " ORDER BY w.write_off_date DESC;";

            return dbManager.GetData(query);
        }
    }
}