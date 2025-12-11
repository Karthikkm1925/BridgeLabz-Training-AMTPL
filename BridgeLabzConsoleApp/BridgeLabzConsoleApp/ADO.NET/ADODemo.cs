using System;
using Azure;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BridgeLabzConsoleApp.ADO.NET
{
        public class ADODemo
        {

            static string connectionString = @"Server=(localdb)\MSSQLLocalDB; Database=PracticeDb; Integrated Security=True;";

            static void Main()
            {

                Console.WriteLine("Program started here...");

            /* InsertEmployee(502,"Akash",23,"Accouunts");
               InsertEmployee(503, "Avinash", 32, "Research");
               InsertEmployee(504, "Haneesh",42, "Development");
               InsertEmployee(505, "Hardik", 31, "Development");
               InsertEmployee(506, "Virat", 25, "Testing");
               InsertEmployee(507, "Mogli", 20, "Testing");
               InsertEmployee(508, "Manish", 22, "Consultant");
               InsertEmployee(509, "Lavakush", 21, "Development");
               InsertEmployee(510, "Lakky", 23, "Devops");
               InsertEmployee(511, "Akhil", 27, "Devopes");
               InsertEmployee(512, "Zameer", 28, "Testing");
               InsertEmployee(513, "Jhon", 30, "Development"); */

            //GetEmployees();

            //UpdateEmployee(501, "Karthik KM", 23, "Development");

            //DeleteEmployee(513);

            //GetEmployeeById(501);

            //InsertEmployee_SP(513, "Bruce", 35, "Research");

            //GetAllEmployees_SP();

            //GetEmployeeById_SP(501);

            //UpdateEmployee_SP(513, "Bruce Machle", 23, "DevOps");

            //DeleteEmployee_SP(508);



            Console.WriteLine("Program Ended here...");

            }
            static void InsertEmployee(int id, string name, int age, string dept)
            {
                string query = "INSERT INTO Employees (EmpID,Name,Age,Department) VALUES (@Id,@Name,@Age,@Dept)";
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Dept", dept);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    Console.WriteLine($"{rows} row inserted.");
                }
            }

            static void GetEmployees()
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT EmpId, Name, Age, Department FROM Employees";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("=== Employee List ===");

                        while (reader.Read())
                        {

                            Console.WriteLine(
                                $"{reader["EmpId"]} | {reader["Name"]} | {reader["Age"]} | {reader["Department"]}"
                            );
                        }
                    }
                }
            }


            static void UpdateEmployee(int id, string newName, int newAge, string newDept)
            {
                string query = "UPDATE Employees SET Name=@Name, Age=@Age, Department=@Dept WHERE EmpID=@Id";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Name", newName);
                    cmd.Parameters.AddWithValue("@Age", newAge);
                    cmd.Parameters.AddWithValue("@Dept", newDept);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        Console.WriteLine("Update successful!");
                    else
                        Console.WriteLine("No employee found with given ID.");
                }
            }


            static void DeleteEmployee(int id)
            {
                string query = "DELETE FROM Employees WHERE EmpID=@Id";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        Console.WriteLine("Employee deleted successfully!");
                    else
                        Console.WriteLine("No employee found with that ID.");
                }
            }

            static void GetEmployeeById(int id)
            {
                string query = "SELECT EmpId, Name, Age, DEpartment FROM Employees WHERE EmpId=@Id";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    conn.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Console.WriteLine("Employe Found");
                            Console.WriteLine($"EmpId : {reader["EmpId"]}");
                            Console.WriteLine($"Name : {reader["Name"]}");
                            Console.WriteLine($"Age : {reader["Age"]}");
                            Console.WriteLine($"Department : {reader["Department"]}");
                        }
                        else
                        {
                            Console.WriteLine($"Employee with Id {id} Not Found ");
                        }
                    }


                }
            }

            static void InsertEmployee_SP(int id, string name, int age, string dept)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("InsertEmployeeSP", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Dept", dept);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    Console.WriteLine($"{rows} row inserted via SP.");
                }
            }


            static void GetAllEmployees_SP()
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("GetAllEmployees", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(
                                $"{reader["EmpID"]} | {reader["Name"]} | {reader["Age"]} | {reader["Department"]}"
                            );
                        }
                    }
                }
            }

            static void GetEmployeeById_SP(int id)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("GetEmployeeById_SP", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Console.WriteLine("Employee Found:");
                            Console.WriteLine($"{reader["EmpID"]} | {reader["Name"]} | {reader["Age"]} | {reader["Department"]}");
                        }
                        else
                        {
                            Console.WriteLine("Employee not found.");
                        }
                    }
                }
            }


            static void UpdateEmployee_SP(int id, string name, int age, string dept)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("UpdateEmployee_SP", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Dept", dept);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    Console.WriteLine(rows > 0 ? "Employee updated via SP!" : "No employee found.");
                }
            }

            static void DeleteEmployee_SP(int id)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("DeleteEmployee_SP", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    Console.WriteLine(rows > 0
                        ? "Employee deleted via SP!"
                        : "No employee found with that ID.");
                }
            }


        }
    }
