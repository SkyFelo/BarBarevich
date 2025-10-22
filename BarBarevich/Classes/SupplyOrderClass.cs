using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BarBarevich.Classes
{
    public class SupplyOrderClass
    {
        private DatabaseManager dbManager;

        public SupplyOrderClass()
        {
            dbManager = new DatabaseManager();
        }

        /// <summary>
        /// Заполняет DataGridView данными всех заказов на поставку с информацией о поставщике и статусе.
        /// </summary>
        /// <param name="dgv">Элемент DataGridView для отображения данных.</param>
        public void FillDataGridViewOrders(DataGridView dgv)
        {
            string query = @"
        SELECT 
            po.id_purchase_order, 
            s.supplier_name, 
            po.purchase_date,
            sup.invoice_number,
            sup.supply_date,
            sup.id_complete_status 
        FROM purchase_order po
        JOIN suppliers s ON po.id_supplier = s.id_supplier
        JOIN supply sup ON po.id_purchase_order = sup.id_purchase_order
        ORDER BY po.purchase_date DESC";

            dgv.DataSource = dbManager.GetData(query);
        }

        /// <summary>
        /// Заполняет DataGridView заказами на поставку, отфильтрованными по дате заказа.
        /// </summary>
        /// <param name="input">Начальная часть имени поставщика.</param>
        /// <param name="dgv">Элемент DataGridView для отображения данных.</param>
        public void FillDataGridViewByDate(DateTime start, DateTime end, DataGridView dgv)
        {
            string query = $@"        SELECT 
            po.id_purchase_order, 
            s.supplier_name, 
            po.purchase_date, 
            sup.invoice_number, 
            sup.supply_date, 
            sup.id_complete_status  
        FROM purchase_order po 
        JOIN suppliers s ON po.id_supplier = s.id_supplier 
        JOIN supply sup ON po.id_purchase_order = sup.id_purchase_order 
                              WHERE po.purchase_date  
                              BETWEEN '{start:yyyy-MM-dd}' AND '{end:yyyy-MM-dd}'
        ORDER BY po.purchase_date DESC ";
            dgv.DataSource = dbManager.GetData(query);
        }

        /// <summary>
        /// Проверяет, подтверждена ли поставка по заданному идентификатору заказа.
        /// </summary>
        /// <param name="orderId">Идентификатор заказа на поставку.</param>
        /// <returns>True, если поставка подтверждена; иначе — false.</returns>
        public bool IsSupplyConfirmed(string orderId)
        {
            try
            {
                string query = @"SELECT id_complete_status FROM supply WHERE id_purchase_order = @orderId";
                using (var cmd = new MySqlCommand(query, DatabaseManager.connection))
                {
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    object result = cmd.ExecuteScalar();
                    return result != null && Convert.ToInt32(result) == 2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при проверке статуса поставки: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Получает список товаров, включённых в заказ.
        /// </summary>
        /// <param name="orderId">Идентификатор заказа на поставку.</param>
        /// <returns>Таблица с товарами и их количеством.</returns>
        public DataTable GetOrderProducts(string orderId)
        {
            try
            {
                string query = @"
            SELECT pi.id_product, p.product_name, pi.quantity, u.unit  
            FROM product_in_order pi 
            JOIN product p ON pi.id_product = p.id_product 
            JOIN s_units u ON u.id_unit = p.id_unit 
            WHERE pi.id_purchase_order = @orderId";

                using (var cmd = new MySqlCommand(query, DatabaseManager.connection))
                {
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    var adapter = new MySqlDataAdapter(cmd);
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при загрузке товаров заказа.");
                return null;
            }
        }

        /// <summary>
        /// Получает список товаров, включённых в заказ, с единицей измерения в скобках.
        /// </summary>
        /// <param name="orderId">Идентификатор заказа на поставку.</param>
        /// <returns>Таблица с товарами и их количеством.</returns>
        public DataTable GetOrderProductsWithUnit(string orderId)
        {
            try
            {
                string query = @"
            SELECT 
                pi.id_product, 
                CONCAT(p.product_name, ' (', u.unit, ')') AS product_name, 
                pi.quantity 
            FROM product_in_order pi 
            JOIN product p ON pi.id_product = p.id_product 
            JOIN s_units u ON u.id_unit = p.id_unit 
            WHERE pi.id_purchase_order = @orderId";

                using (var cmd = new MySqlCommand(query, DatabaseManager.connection))
                {
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    var adapter = new MySqlDataAdapter(cmd);
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при загрузке товаров заказа.");
                return null;
            }
        }


        /// <summary>
        /// Удаляет заказ и связанные с ним записи из базы данных.
        /// </summary>
        /// <param name="orderId">Идентификатор удаляемого заказа.</param>
        /// <returns>True, если удаление прошло успешно; иначе — false.</returns>
        public bool DeleteOrderWithDetails(string orderId)
        {
            try
            {
                string[] queries = {
            "DELETE FROM product_in_order WHERE id_purchase_order = @orderId",
            "DELETE FROM supply WHERE id_purchase_order = @orderId",
            "DELETE FROM purchase_order WHERE id_purchase_order = @orderId"
        };

                foreach (string query in queries)
                {
                    using (var cmd = new MySqlCommand(query, DatabaseManager.connection))
                    {
                        cmd.Parameters.AddWithValue("@orderId", orderId);
                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении заказа.");
                return false;
            }
        }

        /// <summary>
        /// Подтверждает поставку: добавляет товары в поставку, обновляет остатки и устанавливает статус.
        /// </summary>
        /// <param name="orderId">Идентификатор заказа на поставку.</param>
        /// <param name="getProductInfo">Функция, возвращающая цену и количество для каждого товара.</param>
        /// <returns>True, если подтверждение прошло успешно; иначе — false.</returns>
        public bool ConfirmSupply(string orderId, Func<string, int, (decimal Price, int Quantity)?> getProductInfo)
        {
            try
            {
                string getSupplyIdQuery = "SELECT id_supply FROM supply WHERE id_purchase_order = @orderId";
                int supplyId = 0;
                using (var cmd = new MySqlCommand(getSupplyIdQuery, DatabaseManager.connection))
                {
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            supplyId = Convert.ToInt32(reader["id_supply"]);
                    }
                }

                if (supplyId == 0)
                {
                    return false;
                }

                DataTable products = GetOrderProducts(orderId);
                if (products == null) return false;

                foreach (DataRow row in products.Rows)
                {
                    int productId = Convert.ToInt32(row["id_product"]);
                    string productName = row["product_name"].ToString();
                    int quantity = Convert.ToInt32(row["quantity"]);

                    var result = getProductInfo(productName, quantity);
                    if (result.HasValue)
                    {
                        decimal price = result.Value.Price;
                        int quantityOrdered = result.Value.Quantity;

                        if (quantityOrdered > 0)
                        {
                            string insertProductQuery = @"
                        INSERT INTO product_in_supply (id_supply, id_product, price, quantity) 
                        VALUES (@id_supply, @id_product, @price, @quantity)";
                            using (var insertCmd = new MySqlCommand(insertProductQuery, DatabaseManager.connection))
                            {
                                insertCmd.Parameters.AddWithValue("@id_supply", supplyId);
                                insertCmd.Parameters.AddWithValue("@id_product", productId);
                                insertCmd.Parameters.AddWithValue("@price", price);
                                insertCmd.Parameters.AddWithValue("@quantity", quantityOrdered);
                                insertCmd.ExecuteNonQuery();
                            }

                            string updateProductQuery = @"
                        UPDATE product 
                        SET stock_quantity = stock_quantity + @quantity 
                        WHERE id_product = @id_product";
                            using (var updateCmd = new MySqlCommand(updateProductQuery, DatabaseManager.connection))
                            {
                                updateCmd.Parameters.AddWithValue("@quantity", quantityOrdered);
                                updateCmd.Parameters.AddWithValue("@id_product", productId);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                string updateSupplyStatusQuery = @"
    UPDATE supply 
    SET id_complete_status = 2, supply_date = @today 
    WHERE id_supply = @supplyId";

                using (var statusCmd = new MySqlCommand(updateSupplyStatusQuery, DatabaseManager.connection))
                {
                    statusCmd.Parameters.AddWithValue("@supplyId", supplyId);
                    statusCmd.Parameters.AddWithValue("@today", DateTime.Now.Date);
                    statusCmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подтверждения поставки.");
                return false;
            }
        }

        /// <summary>
        /// Получает список поставщиков для выбора в интерфейсе.
        /// </summary>
        /// <returns>Таблица с идентификаторами и названиями поставщиков.</returns>
        public DataTable GetSuppliers()
        {
            string query = "SELECT id_supplier, supplier_name FROM suppliers";
            return dbManager.GetData(query);
        }

        /// <summary>
        /// Получает список доступных товаров.
        /// </summary>
        /// <returns>Таблица с идентификаторами и названиями товаров.</returns>
        public DataTable GetProducts()
        {
            string query = "SELECT p.id_product, " +
                "CONCAT(p.product_name, ' (', u.unit, ')') AS product_display    " +
                "FROM product p       " +
                "JOIN s_units u ON p.id_unit = u.id_unit";
            return dbManager.GetData(query);
        }

        /// <summary>
        /// Добавляет новый заказ на поставку.
        /// </summary>
        /// <param name="supplierId">Идентификатор поставщика.</param>
        /// <param name="purchaseDate">Дата заказа.</param>
        /// <returns>Идентификатор созданного заказа.</returns>
        public int AddPurchaseOrder(int supplierId, DateTime purchaseDate)
        {
            try
            {
                string query = @"
            INSERT INTO purchase_order (id_supplier, purchase_date) 
            VALUES (@id_supplier, @purchase_date);
            SELECT LAST_INSERT_ID();";

                using (var cmd = new MySqlCommand(query, DatabaseManager.connection))
                {
                    cmd.Parameters.AddWithValue("@id_supplier", supplierId);
                    cmd.Parameters.AddWithValue("@purchase_date", purchaseDate);

                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int orderId))
                    {
                        return orderId;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при добавления заказа на поставку.");
                return -1;
            }
        }


        /// <summary>
        /// Добавляет запись о поставке, связанной с заказом.
        /// </summary>
        /// <param name="orderId">Идентификатор заказа на поставку.</param>
        /// <param name="supplyDate">Дата поставки.</param>
        public void AddSupply(int orderId, DateTime supplyDate)
        {
            string query = @"
            INSERT INTO supply (invoice_number, id_purchase_order, supply_date, id_complete_status) 
            VALUES (@invoice_number, @id_purchase_order, @supply_date, 1)";

            MySqlCommand cmd = new MySqlCommand(query, DatabaseManager.connection);
            cmd.Parameters.AddWithValue("@invoice_number", "INV" + DateTime.Now.Ticks.ToString());
            cmd.Parameters.AddWithValue("@id_purchase_order", orderId);
            cmd.Parameters.AddWithValue("@supply_date", supplyDate);
            DatabaseManager.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// Добавляет продукт к заказу на поставку.
        /// </summary>
        /// <param name="orderId">Идентификатор заказа.</param>
        /// <param name="productId">Идентификатор продукта.</param>
        /// <param name="quantity">Количество продукта.</param>
        public void AddProductToOrder(int orderId, int productId, int quantity)
        {
            string query = @"
            INSERT INTO product_in_order (id_purchase_order, id_product, quantity) 
            VALUES (@orderId, @productId, @quantity)";

            MySqlCommand cmd = new MySqlCommand(query, DatabaseManager.connection);
            cmd.Parameters.AddWithValue("@orderId", orderId);
            cmd.Parameters.AddWithValue("@productId", productId);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            DatabaseManager.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// Обновляет данные заказа на поставку.
        /// </summary>
        /// <param name="orderId">Идентификатор заказа.</param>
        /// <param name="supplierId">Новый идентификатор поставщика.</param>
        /// <param name="purchaseDate">Новая дата заказа.</param>
        public void UpdatePurchaseOrder(string orderId, int supplierId, DateTime purchaseDate)
        {
            string query = @"
            UPDATE purchase_order 
            SET id_supplier = @id_supplier, purchase_date = @purchase_date
            WHERE id_purchase_order = @orderId";

            MySqlCommand cmd = new MySqlCommand(query, DatabaseManager.connection);
            cmd.Parameters.AddWithValue("@id_supplier", supplierId);
            cmd.Parameters.AddWithValue("@purchase_date", purchaseDate);
            cmd.Parameters.AddWithValue("@orderId", orderId);
            DatabaseManager.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// Удаляет все продукты, связанные с заказом.
        /// </summary>
        /// <param name="orderId">Идентификатор заказа.</param>
        public void DeleteOrderProducts(string orderId)
        {
            string query = "DELETE FROM product_in_order WHERE id_purchase_order = @orderId";
            MySqlCommand cmd = new MySqlCommand(query, DatabaseManager.connection);
            cmd.Parameters.AddWithValue("@orderId", orderId);
            DatabaseManager.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// Получает идентификатор продукта по его названию (без учёта единицы измерения в скобках).
        /// </summary>
        /// <param name="productName">Название продукта, возможно с единицей измерения в скобках.</param>
        /// <returns>Идентификатор продукта, если найден; иначе — -1.</returns>
        public int GetProductIdByName(string productName)
        {
            try
            {
                // Удаление единицы измерения в скобках, если она есть
                int bracketIndex = productName.LastIndexOf(" (");
                if (bracketIndex != -1)
                    productName = productName.Substring(0, bracketIndex).Trim();

                string query = "SELECT id_product FROM product WHERE product_name = @productName LIMIT 1";
                using (var cmd = new MySqlCommand(query, DatabaseManager.connection))
                {
                    cmd.Parameters.AddWithValue("@productName", productName);
                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int id))
                        return id;
                    else
                        return -1;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при получение идентификатора продукта.");
                return -1;
            }
        }


    }
}
