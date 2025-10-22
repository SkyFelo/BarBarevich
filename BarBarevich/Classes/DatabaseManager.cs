using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarBarevich.Classes
{
    public class DatabaseManager
    {
        public static MySqlConnection connection;
        public static MySqlCommand myCommand;
        public static string connectionString;

        public string server;
        public string database;
        public string uid;
        public string password;

        /// <summary>
        /// Инициализация параметров подключения к базе данных.
        /// </summary> 
        public void Initialize()
        {
            server = "localhost";
            database = "kutsenko_the_barevich";
            uid = "root";
            password = "qwerty";
            connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
            myCommand = connection.CreateCommand();
        }

        /// <summary>
        /// Метод для открытия соединения с базой данных.
        /// </summary>
        /// <returns>True, если соединение успешно открыто; иначе False.</returns>
        public bool OpenConnection()
        {
            Initialize();

            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Невозможно подключиться к серверу.");
                        break;

                    case 1045:
                        Console.WriteLine("Некорректный логин/пароль сервера.");
                        break;
                }
                return false;
            }
        }

        /// <summary>
        /// Метод для закрытия соединения с базой данных.
        /// </summary>
        /// <returns>True, если соединение успешно закрыто; иначе False.</returns>
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Проверка учетных данных пользователя.
        /// </summary>
        /// <param name="login">Логин пользователя.</param>
        /// <param name="password">Пароль пользователя.</param>
        /// <returns>Кортеж, содержащий тип пользователя, ID сотрудника и статус сотрудника.</returns>
        public (int userType, int employeeId) CheckCredentials(string login, string password)
        {
            string query = "SELECT id_role, id_employee FROM employee " +
                "WHERE login = @login AND password = @password";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", password);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    int userType = Convert.ToInt32(dataReader["id_role"]);
                    int employeeId = Convert.ToInt32(dataReader["id_employee"]);
                    dataReader.Close();

                    return (userType, employeeId);
                }
                else
                {
                    dataReader.Close();
                    return (0, 0); 
                }
            }
            else
            {
                return (-1, 0); 
            }
        }

        /// <summary>
        /// Получение данных из базы данных.
        /// </summary>
        /// <param name="query">SQL-запрос для получения данных.</param>
        /// <returns>DataTable с данными из базы данных.</returns>
        public DataTable GetData(string query)
        {
            DataTable dataTable = new DataTable();

            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return dataTable;
        }

        public bool ExecuteNonQuery(string query)
        {
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public static bool ExecuteNonQuery(MySqlCommand command)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command.Connection = connection;
                command.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }


        /// <summary>
        /// Получение списка занятых столов на указанную дату.
        /// </summary>
        /// <param name="selectedDate">Дата, для которой нужно получить список занятых столов.</param>
        /// <returns>Список номеров столов, которые заняты на указанную дату.</returns>
        public List<int> GetOccupiedTables(DateTime selectedDate)
        {
            List<int> occupiedTables = new List<int>();

            string query = "SELECT DISTINCT t.id_table " +
                "FROM reservation r, tables_in_reservation t " +
                "WHERE r.id_reservation = t.id_reservation " +
                "AND r.date = @selectedDate";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@selectedDate", selectedDate.Date);

                try
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int tableId = Convert.ToInt32(reader["id_table"]);
                            occupiedTables.Add(tableId);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            return occupiedTables;
        }

        /// <summary>
        /// Получение деталей резервации для заданного номера стола.
        /// </summary>
        /// <param name="tableNumber">Номер стола, для которого нужно получить информацию о резервации.</param>
        /// <returns>DataTable с данными о резервации.</returns>
        public DataTable GetReservationDetails(int tableNumber, string reservationDate)
        {
            DataTable dataTable = new DataTable();

            try
            {
                if (OpenConnection())
                {
                    string query ="SELECT r.id_reservation, c.full_name, c.phone, " +
                                  "r.people_count, r.time,  " +
                                  "r.deposit " +
                                  "FROM reservation r, client c, tables_in_reservation t " +
                                  "WHERE r.id_client = c.id_client AND r.id_reservation = t.id_reservation " +
                                  "AND t.id_table = @tableNumber " +
                                  "AND r.date = @reservationDate";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@tableNumber", tableNumber);
                    cmd.Parameters.AddWithValue("@reservationDate", reservationDate);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return dataTable;
        }

        public List<int> GetSelectedTablesForReservation(string id_reservation)
        {
            List<int> selectedTablesForReservation = new List<int>();

            string query = @"
SELECT t.id_table 
FROM tables_in_reservation tr
JOIN tables t ON tr.id_table = t.id_table
WHERE tr.id_reservation = @id_reservation";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id_reservation", id_reservation);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            selectedTablesForReservation.Add(Convert.ToInt32(reader["id_table"]));
                        }
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Ошибка при получении данных о выбранных забронированных столах.");
            }

            return selectedTablesForReservation;
        }

    }
}
