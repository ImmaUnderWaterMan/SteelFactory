using SteelFactoryForm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteelFactoryForm
{
    using System;
    using System.Data.SqlClient;

    namespace SteelFactoryForm
    {
        public class DatabaseConnection
        {
            private static DatabaseConnection _instance;
            private static readonly object _lock = new object();
            private readonly string _connectionString;

            private DatabaseConnection()
            {
                _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\romas\\Source\\Repos\\SteelFactoryForm\\SteelFactoryForm\\Database1.mdf;Integrated Security=True";
            }

            public static DatabaseConnection Instance
            {
                get
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DatabaseConnection();
                        }
                        return _instance;
                    }
                }
            }

            public SqlConnection GetConnection()
            {
                var connection = new SqlConnection(_connectionString);
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                return connection;
            }
        }


        public class DBManager
        {
            private readonly DatabaseConnection dbConnection = DatabaseConnection.Instance;

            public void SaveSelectedValueWarehouseToDatabase(int id, float ore, float nickel, float chrome, float manganese, string timeFurnace, string timeConverter, string timeRollingMachine)
            {
                try
                {
                    using (SqlConnection connection = dbConnection.GetConnection())
                    {
                        using (SqlCommand command = new SqlCommand(
                            "INSERT INTO [dbo].[Warehouse] (Id, Ore, Nickel, Chrome, Manganese, TimeFurnace, TimeConverter, TimeRollingMachine) " +
                            "VALUES (@Id, @Ore, @Nickel, @Chrome, @Manganese, @TimeFurnace, @TimeConverter, @TimeRollingMachine)",
                            connection))
                        {
                            command.Parameters.AddWithValue("@Id", id);
                            command.Parameters.AddWithValue("@Ore", ore);
                            command.Parameters.AddWithValue("@Nickel", nickel);
                            command.Parameters.AddWithValue("@Chrome", chrome);
                            command.Parameters.AddWithValue("@Manganese", manganese);
                            command.Parameters.AddWithValue("@TimeFurnace", timeFurnace);
                            command.Parameters.AddWithValue("@TimeConverter", timeConverter);
                            command.Parameters.AddWithValue("@TimeRollingMachine", timeRollingMachine);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Произошла ошибка: " + ex.Message);
                    MessageBox.Show("Произошла ошибка при сохранении данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public bool DoesIdExistInWarehouse(int id)
            {
                try
                {
                    using (SqlConnection connection = dbConnection.GetConnection())
                    {
                        string query = "SELECT COUNT(*) FROM Warehouse WHERE Id = @Id";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Id", id);
                            int count = (int)command.ExecuteScalar();
                            return count > 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Произошла ошибка: " + ex.Message);
                    return false;
                }
            }

            public int SaveOrderToDatabase(string nameOrg, string statusOrder, int id)
            {
                int orderId = -1;
                try
                {
                    using (SqlConnection connection = dbConnection.GetConnection())
                    {
                        using (SqlCommand command = new SqlCommand(
                            "INSERT INTO [dbo].[Orders] (NameOrg, StatusOrder, Id) OUTPUT INSERTED.Id VALUES (@NameOrg, @StatusOrder, @Id)",
                            connection))
                        {
                            command.Parameters.AddWithValue("@NameOrg", nameOrg);
                            command.Parameters.AddWithValue("@StatusOrder", statusOrder);
                            command.Parameters.AddWithValue("@Id", id);
                            orderId = (int)command.ExecuteScalar();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Произошла ошибка: " + ex.Message);
                    MessageBox.Show("Произошла ошибка при сохранении данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return orderId;
            }

            public DataTable GetOrderData()
            {
                DataTable dataTable = new DataTable();

                try
                {
                    using (SqlConnection connection = dbConnection.GetConnection())
                    {
                        string query = "SELECT * FROM [dbo].[Orders]";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(dataTable);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Произошла ошибка: " + ex.Message);
                    MessageBox.Show("Произошла ошибка при загрузке данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return dataTable;
            }

            public void SaveSteelRequirements(string steelGrade, float ore, float nickel, float chrome, float manganese, string timeFurnace, string timeConverter, string timeRollingMachine, float productionVolume, float price, int id)
            {
                try
                {
                    using (SqlConnection connection = dbConnection.GetConnection())
                    {
                        string tableName;
                        switch (steelGrade)
                        {
                            case "A":
                                tableName = "[dbo].[SteelGradeA]";
                                break;
                            case "B":
                                tableName = "[dbo].[SteelGradeB]";
                                break;
                            case "C":
                                tableName = "[dbo].[SteelGradeC]";
                                break;
                            default:
                                throw new ArgumentException("Некорректная марка стали");
                        }


                        if (!DoesIdExistInWarehouse(id))
                        {
                            throw new ArgumentException("Id не существует в таблице Warehouse");
                        }

                        using (SqlCommand command = new SqlCommand(
                            $"INSERT INTO {tableName} (Id, SteelGrade, Ore, Nickel, Chrome, Manganese, TimeFurnace, TimeConverter, TimeRollingMachine, ProductionVolume, Price) " +
                            "VALUES (@Id, @SteelGrade, @Ore, @Nickel, @Chrome, @Manganese, @TimeFurnace, @TimeConverter, @TimeRollingMachine, @ProductionVolume, @Price)",
                            connection))
                        {
                            command.Parameters.AddWithValue("@Id", id);
                            command.Parameters.AddWithValue("@SteelGrade", steelGrade);
                            command.Parameters.AddWithValue("@Ore", ore);
                            command.Parameters.AddWithValue("@Nickel", nickel);
                            command.Parameters.AddWithValue("@Chrome", chrome);
                            command.Parameters.AddWithValue("@Manganese", manganese);
                            command.Parameters.AddWithValue("@TimeFurnace", timeFurnace);
                            command.Parameters.AddWithValue("@TimeConverter", timeConverter);
                            command.Parameters.AddWithValue("@TimeRollingMachine", timeRollingMachine);
                            command.Parameters.AddWithValue("@ProductionVolume", productionVolume);
                            command.Parameters.AddWithValue("@Price", price);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Произошла ошибка: " + ex.Message);
                    MessageBox.Show("Произошла ошибка при сохранении данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public void UpdateWarehouseResources(int orderId)
            {
                try
                {
                    using (SqlConnection connection = dbConnection.GetConnection())
                    {
                        string queryOrder = "SELECT * FROM [dbo].[Orders] WHERE Id = @OrderId";
                        using (SqlCommand commandOrder = new SqlCommand(queryOrder, connection))
                        {
                            commandOrder.Parameters.AddWithValue("@OrderId", orderId);
                            using (SqlDataReader readerOrder = commandOrder.ExecuteReader())
                            {
                                if (readerOrder.Read())
                                {
                                    string statusOrder = readerOrder["StatusOrder"].ToString();
                                    if (statusOrder.Equals("выполнено", StringComparison.OrdinalIgnoreCase))
                                    {
                                        return;
                                    }

                                    string steelGrade = readerOrder["NameOrg"].ToString();
                                    readerOrder.Close();

                                    string steelGradeTable;
                                    switch (steelGrade)
                                    {
                                        case "A":
                                            steelGradeTable = "[dbo].[SteelGradeA]";
                                            break;
                                        case "B":
                                            steelGradeTable = "[dbo].[SteelGradeB]";
                                            break;
                                        case "C":
                                            steelGradeTable = "[dbo].[SteelGradeC]";
                                            break;
                                        default:
                                            throw new ArgumentException("Неизвестная марка стали: " + steelGrade);
                                    }

                                    string queryWarehouse = "SELECT * FROM [dbo].[Warehouse] WHERE Id = @OrderId";
                                    using (SqlCommand commandWarehouse = new SqlCommand(queryWarehouse, connection))
                                    {
                                        commandWarehouse.Parameters.AddWithValue("@OrderId", orderId);
                                        using (SqlDataReader readerWarehouse = commandWarehouse.ExecuteReader())
                                        {
                                            if (readerWarehouse.Read())
                                            {
                                                float availableOre = (float)readerWarehouse["Ore"];
                                                float availableNickel = (float)readerWarehouse["Nickel"];
                                                float availableChrome = (float)readerWarehouse["Chrome"];
                                                float availableManganese = (float)readerWarehouse["Manganese"];

                                                string queryRequirements = $"SELECT Ore, Nickel, Chrome, Manganese FROM {steelGradeTable} WHERE Id = @OrderId";
                                                using (SqlCommand commandRequirements = new SqlCommand(queryRequirements, connection))
                                                {
                                                    commandRequirements.Parameters.AddWithValue("@OrderId", orderId);
                                                    using (SqlDataReader readerRequirements = commandRequirements.ExecuteReader())
                                                    {
                                                        if (readerRequirements.Read())
                                                        {
                                                            float requiredOre = (float)readerRequirements["Ore"];
                                                            float requiredNickel = (float)readerRequirements["Nickel"];
                                                            float requiredChrome = (float)readerRequirements["Chrome"];
                                                            float requiredManganese = (float)readerRequirements["Manganese"];

                                                            availableOre -= requiredOre;
                                                            availableNickel -= requiredNickel;
                                                            availableChrome -= requiredChrome;
                                                            availableManganese -= requiredManganese;

                                                            string updateQuery = "UPDATE [dbo].[Warehouse] SET Ore = @Ore, Nickel = @Nickel, Chrome = @Chrome, Manganese = @Manganese WHERE Id = @Id";
                                                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                                                            {
                                                                updateCommand.Parameters.AddWithValue("@Ore", availableOre);
                                                                updateCommand.Parameters.AddWithValue("@Nickel", availableNickel);
                                                                updateCommand.Parameters.AddWithValue("@Chrome", availableChrome);
                                                                updateCommand.Parameters.AddWithValue("@Manganese", availableManganese);
                                                                updateCommand.Parameters.AddWithValue("@Id", orderId);
                                                                updateCommand.ExecuteNonQuery();
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Произошла ошибка: " + ex.Message);
                    MessageBox.Show("Произошла ошибка при обновлении ресурсов на складе: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}