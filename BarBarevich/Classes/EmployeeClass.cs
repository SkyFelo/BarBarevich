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
    public class EmployeeClass
    {
        private DatabaseManager dbManager;

        public EmployeeClass()
        {
            dbManager = new DatabaseManager();
        }

        /// <summary>
        /// Получает следующий доступный ID для нового сотрудника.
        /// </summary>
        /// <returns>Строка с новым ID сотрудника (на 1 больше текущего максимального).</returns>
        public static string GetEmployeetMaxId()
        {
            string maxId = "0";

            try
            {
                using (MySqlCommand command = new MySqlCommand
                    ("SELECT MAX(id_employee) AS maxId FROM employee", DatabaseManager.connection))
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
                MessageBox.Show("Ошибка при получении максимального значения идентификатора сотрудника.");
            }

            return maxId;
        }

        /// <summary>
        /// Возвращает список сотрудников в отформатированном виде (Ф.И.О. и роль).
        /// </summary>
        /// <returns>Список объектов EmployeeItem с Id и отформатированным FullName.</returns>
        public static List<EmployeeItem> GetFormattedEmployees()
        {
            var employees = new List<EmployeeItem>();

            string query = @"
        SELECT e.id_employee, e.first_name, e.middle_name, e.last_name, r.role_name
        FROM employee e
        JOIN s_employee_roles r ON e.id_role = r.id_role";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id_employee");
                        string first = reader.GetString("first_name");
                        string middle = reader.GetString("middle_name");
                        string last = reader.GetString("last_name");
                        string role = reader.GetString("role_name");

                        string fullName = $"{first[0]}. {middle[0]}. {last} ({role})";
                        employees.Add(new EmployeeItem { Id = id, FullName = fullName });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении информации о сотрудниках.");
            }

            return employees;
        }

        /// <summary>
        /// Представляет отформатированного сотрудника для отображения (Ф.И.О. и роль).
        /// </summary>
        public class EmployeeItem
        {
            public int Id { get; set; }
            public string FullName { get; set; }
        }

        /// <summary>
        /// Добавляет нового сотрудника в базу данных.
        /// </summary>
        /// <param name="id">ID сотрудника.</param>
        /// <param name="firstName">Имя.</param>
        /// <param name="middleName">Отчество.</param>
        /// <param name="lastName">Фамилия.</param>
        /// <param name="id_role">ID роли сотрудника.</param>
        /// <param name="phone">Номер телефона.</param>
        /// <param name="login">Логин для входа.</param>
        /// <param name="password">Пароль.</param>
        /// <returns>True, если операция выполнена успешно.</returns>
        public bool AddEmployee(string id, string firstName, string middleName, string lastName, string id_role,
                        string phone, string login, string password)
        {
            string query = $"INSERT INTO employee " +
                           $"(id_employee, first_name, middle_name, last_name, id_role, phone, login, password) " +
                           $"VALUES ('{id}', '{firstName}', '{middleName}', '{lastName}', '{id_role}', '{phone}', '{login}', '{password}')";

            return dbManager.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Обновляет данные существующего сотрудника.
        /// </summary>
        /// <param name="id">ID сотрудника.</param>
        /// <param name="firstName">Новое имя.</param>
        /// <param name="middleName">Новое отчество.</param>
        /// <param name="lastName">Новая фамилия.</param>
        /// <param name="id_role">Новая роль.</param>
        /// <param name="phone">Новый номер телефона.</param>
        /// <param name="login">Новый логин.</param>
        /// <param name="password">Новый пароль.</param>
        /// <returns>True, если обновление прошло успешно.</returns>
        public bool EditEmployee(string id, string firstName, string middleName, string lastName,
                                 string id_role, string phone, string login, string password)
        {
            string query = $"UPDATE employee SET " +
                           $"first_name = '{firstName}', middle_name = '{middleName}', last_name = '{lastName}', " +
                           $"id_role = '{id_role}', phone = '{phone}', login = '{login}', password = '{password}' " +
                           $"WHERE id_employee = '{id}'";

            return dbManager.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Удаляет сотрудника из базы данных по ID.
        /// </summary>
        /// <param name="id">ID сотрудника.</param>
        /// <returns>True, если удаление прошло успешно.</returns>
        public static bool DeleteEmployee(string id)
        {
            try
            {
                DatabaseManager.myCommand.CommandText =
                    $"DELETE FROM employee WHERE id_employee = '{id}'";

                return DatabaseManager.myCommand.ExecuteNonQuery() > 0;
            }
            catch 
            {
                MessageBox.Show("Ошибка при удалении информации о сотруднике.");
                return false;
            }
        }

        /// <summary>
        /// Заполняет DataGridView информацией о всех сотрудниках.
        /// </summary>
        /// <param name="dataGridView">Компонент DataGridView для отображения данных.</param>
        public void FillDataGridViewEmployees(DataGridView dataGridView)
        {
            string query =
                @"SELECT e.id_employee, e.first_name, e.last_name, e.middle_name, r.role_name, e.phone, e.login, e.password 
          FROM employee e 
          JOIN s_employee_roles r ON e.id_role = r.id_role       
          ORDER BY first_name";

            dataGridView.DataSource = dbManager.GetData(query);
        }

        /// <summary>
        /// Проверяет, используется ли сотрудник в других таблицах (reservation, work_datetime).
        /// </summary>
        /// <param name="id">ID сотрудника.</param>
        /// <returns>True, если сотрудник используется хотя бы в одной из таблиц.</returns>
        public bool IsEmployeeUsed(string id)
        {
            string queryReservation = $"SELECT id_employee FROM reservation WHERE id_employee = '{id}'";
            string queryWorkDateTime = $"SELECT id_employee FROM work_datetime WHERE id_employee = '{id}'";

            bool isUsedInReservation = dbManager.GetData(queryReservation).Rows.Count > 0;
            bool isUsedInWorkDatetime = dbManager.GetData(queryWorkDateTime).Rows.Count > 0;

            return isUsedInReservation || isUsedInWorkDatetime;
        }

        /// <summary>
        /// Получает ID роли по названию.
        /// </summary>
        /// <param name="roleName">Название роли.</param>
        /// <returns>Строка с ID роли, либо "0", если роль не найдена.</returns>
        public static string GetRoleId(string roleName)
        {
            string query = $"SELECT id_role FROM s_employee_roles WHERE role_name = '{roleName}'";
            DataTable dt = new DatabaseManager().GetData(query);

            if (dt.Rows.Count > 0)
                return dt.Rows[0]["id_role"].ToString();

            return "0";
        }

        /// <summary>
        /// Проверяет, используется ли указанный логин в системе.
        /// </summary>
        /// <param name="login">Логин для проверки.</param>
        /// <returns>True, если логин уже существует.</returns>
        public bool IsLoginUsed(string login)
        {
            string query = $"SELECT login FROM employee WHERE login = '{login}'";
            return dbManager.GetData(query).Rows.Count > 0;
        }

        /// <summary>
        /// Получает все роли сотрудников из справочника ролей.
        /// </summary>
        /// <returns>Таблица с колонками id_role и role_name.</returns>
        public DataTable GetAllRoles()
        {
            string query = "SELECT id_role, role_name FROM s_employee_roles";
            return dbManager.GetData(query);
        }

        /// <summary>
        /// Возвращает расписание смен сотрудника на текущую и будущие даты.
        /// </summary>
        /// <param name="employeeId">ID сотрудника.</param>
        /// <returns>DataTable с датами, временем начала и окончания смен.</returns>
        public DataTable GetWorkDatetimesForEmployee(string employeeId)
        {
            string query = @"
        SELECT id_employee, start_time, end_time, date 
        FROM work_datetime 
        WHERE id_employee = @id_employee
        AND date >= CURDATE()
        ORDER BY date ASC;";

            DataTable dt = new DataTable();

            try
            {
                if (dbManager.OpenConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, DatabaseManager.connection))
                    {
                        cmd.Parameters.AddWithValue("@id_employee", employeeId);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при отображении рабочего времени сотрудников.");
            }

            return dt;
        }

        /// <summary>
        /// Добавляет новую смену для сотрудника.
        /// </summary>
        /// <param name="employeeId">ID сотрудника.</param>
        /// <param name="date">Дата смены.</param>
        /// <param name="start">Время начала смены.</param>
        /// <param name="end">Время окончания смены.</param>
        /// <returns>True, если смена добавлена успешно.</returns>
        public bool AddShift(string employeeId, DateTime date, TimeSpan start, TimeSpan end)
        {
            string query = "INSERT INTO work_datetime (id_employee, date, start_time, end_time) " +
                           "VALUES (@id, @date, @start, @end)";

            try
            {
                DatabaseManager db = new DatabaseManager();
                if (db.OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, DatabaseManager.connection);
                    cmd.Parameters.AddWithValue("@id", employeeId);
                    cmd.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@start", start);
                    cmd.Parameters.AddWithValue("@end", end);

                    cmd.ExecuteNonQuery();
                    db.CloseConnection();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка при добавлении смены.");
                return false;
            }
        }

        /// <summary>
        /// Получает все смены указанного сотрудника.
        /// </summary>
        /// <param name="employeeId">ID сотрудника.</param>
        /// <returns>DataTable с датой, временем начала и окончания смен.</returns>
        public DataTable GetShifts(string employeeId)
        {
            string query = "SELECT date, start_time, end_time FROM work_datetime WHERE id_employee = @id";
            DataTable table = new DataTable();

            try
            {
                if (dbManager.OpenConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, DatabaseManager.connection))
                    {
                        cmd.Parameters.AddWithValue("@id", employeeId);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(table);
                        }
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Ошибка при получении информации о сменах.");
            }
            finally
            {
                dbManager.CloseConnection();
            }

            return table;
        }

        /// <summary>
        /// Удаляет все смены сотрудника, начиная с текущей даты.
        /// </summary>
        /// <param name="employeeId">ID сотрудника.</param>
        /// <returns>True, если хотя бы одна смена была удалена.</returns>
        public bool DeleteFutureShifts(string employeeId)
        {
            string query = "DELETE FROM work_datetime WHERE id_employee = @id AND date >= CURDATE()";

            try
            {
                if (dbManager.OpenConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, DatabaseManager.connection))
                    {
                        cmd.Parameters.AddWithValue("@id", employeeId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении смен.");
            }
            finally
            {
                dbManager.CloseConnection();
            }

            return false;
        }

    }
}
