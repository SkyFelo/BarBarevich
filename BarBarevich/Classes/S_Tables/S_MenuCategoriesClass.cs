using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarBarevich.Classes.S_Tables
{
    public class S_MenuCategoriesClass
    {
        private DatabaseManager dbManager;
        public S_MenuCategoriesClass()
        {
            dbManager = new DatabaseManager();
        }

        /// <summary>
        /// Получает все категории меню из таблицы s_menu_categories.
        /// </summary>
        /// <returns>Таблица с перечнем категорий, отсортированных по названию.</returns>
        public DataTable GetMenuCategories()
        {
            string query = "SELECT * FROM s_menu_categories " +
                "ORDER BY category_name;";
            return dbManager.GetData(query);
        }

        /// <summary>
        /// Проверяет, используется ли категория меню в таблице menu_items.
        /// </summary>
        /// <param name="categoryId">Идентификатор категории.</param>
        /// <returns>True, если категория используется; иначе False.</returns>
        public bool IsMenuCategoryInUse(string categoryId)
        {
            string query = $"SELECT * FROM menu_items WHERE id_category = '{categoryId}'";
            DataTable result = dbManager.GetData(query);
            return result.Rows.Count > 0;
        }

        /// <summary>
        /// Удаляет категорию меню по её идентификатору.
        /// </summary>
        /// <param name="categoryId">Идентификатор категории.</param>
        /// <returns>True, если удаление прошло успешно; иначе False.</returns>
        public bool DeleteMenuCategory(string categoryId)
        {
            string query = $"DELETE FROM s_menu_categories WHERE id_category = '{categoryId}'";
            return dbManager.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Добавляет новую категорию в справочную таблицу.
        /// </summary>
        /// <param name="id">Идентификатор категории.</param>
        /// <param name="category">Название категории.</param>
        public void AddMenuCategory(string id, string category)
        {
            string query = $"INSERT INTO s_menu_categories (id_category, category_name) " +
                $"VALUES ('{id}', '{category}')";
            dbManager.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Обновляет название категории меню по заданному идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор категории.</param>
        /// <param name="category">Новое название категории.</param>
        public void EditMenuCategory(string id, string category)
        {
            string query = $"UPDATE s_menu_categories SET category_name = '{category}' " +
                $"WHERE id_category = '{id}'";
            dbManager.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Получает следующий доступный идентификатор для новой категории меню.
        /// </summary>
        /// <returns>Строка с новым идентификатором (на 1 больше текущего максимального).</returns>
        public string GetMenuCategoryMaxId()
        {
            var result = dbManager.GetData("SELECT MAX(id_category) AS maxId" +
                " FROM s_menu_categories");
            if (result.Rows.Count > 0 && result.Rows[0]["maxId"] != DBNull.Value)
            {
                int maxId = Convert.ToInt32(result.Rows[0]["maxId"]);
                return (maxId + 1).ToString();
            }
            return "1";
        }
    }
}
