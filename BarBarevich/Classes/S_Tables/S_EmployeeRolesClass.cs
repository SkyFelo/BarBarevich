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
    public class S_EmployeeRolesClass
    {
        private DatabaseManager dbManager;
        public S_EmployeeRolesClass()
        {
            dbManager = new DatabaseManager();
        }

        /// <summary>
        /// Получение всех ролей сотрудников.
        /// </summary>
        public DataTable GetEmployeeRoles()
        {
            string query = "SELECT * FROM s_employee_roles " +
                           "ORDER BY role_name;";
            return dbManager.GetData(query);
        }

        /// <summary>
        /// Проверка наличия роли в таблице employees перед удалением.
        /// </summary>
        public bool IsRoleInUse(string roleId)
        {
            string query = $"SELECT * FROM employee WHERE id_role = '{roleId}'";
            DataTable result = dbManager.GetData(query);
            return result.Rows.Count > 0;
        }

        /// <summary>
        /// Удаление роли сотрудника по ID.
        /// </summary>
        public bool DeleteEmployeeRole(string roleId)
        {
            string query = $"DELETE FROM s_employee_roles WHERE id_role = '{roleId}'";
            return dbManager.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Добавляет новую роль сотрудника в таблицу s_employee_roles.
        /// </summary>
        /// <param name="id">Идентификатор роли.</param>
        /// <param name="role">Наименование роли.</param>
        public void AddEmployeeRole(string id, string role)
        {
            string query = $"INSERT INTO s_employee_roles (id_role, role_name) VALUES ('{id}', '{role}')";
            dbManager.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Обновляет наименование роли сотрудника по заданному идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор роли.</param>
        /// <param name="role">Новое наименование роли.</param>
        public void EditEmployeeRole(string id, string role)
        {
            string query = $"UPDATE s_employee_roles SET role_name = '{role}' WHERE id_role = '{id}'";
            dbManager.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Получает следующий доступный идентификатор для новой роли сотрудника.
        /// </summary>
        /// <returns>Строка с новым идентификатором роли (на 1 больше текущего максимального).</returns>
        public string GetEmployeeMaxId()
        {
            var result = dbManager.GetData("SELECT MAX(id_role) AS maxId FROM s_employee_roles");
            if (result.Rows.Count > 0 && result.Rows[0]["maxId"] != DBNull.Value)
            {
                int maxId = Convert.ToInt32(result.Rows[0]["maxId"]);
                return (maxId + 1).ToString();
            }
            return "1"; 
        }

    }
}
