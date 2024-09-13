using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        ShowBasicADO();


        // Define your connection string here
        string connectionString = @"Server=DESKTOP-PF8IQ0D\SQLEXPRESS;Database=collegeCanteen;User Id=sa;Password=pix@123;";

        // Define your query to retrieve data from the Student table
        string query = "SELECT StdId, StudentName, EmailID FROM BCAStudents";

        // Open a connection to the database
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                // Create a SqlCommand to execute the query
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Open the connection
                    connection.Open();

                    // Execute the query and obtain a SqlDataReader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Check if there are rows and read them
                        while (reader.Read())
                        {
                            // Read and display each column value
                            int studentId = reader.GetInt32(reader.GetOrdinal("StdId"));
                            string firstName = reader.GetString(reader.GetOrdinal("StudentName"));
                            string email = reader.GetString(reader.GetOrdinal("EmailID"));

                            // Output the data to the console
                            //Console.WriteLine($"ID: {studentId}, Name: {firstName}, Email: {email}");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Handle any SQL-related errors
                Console.WriteLine("An error occurred while accessing the database: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle any other errors
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            Console.ReadKey();
        }
    }

    public static void ShowBasicADO()
    {
        int StudentId = 0;
        Console.Write("Enter StudentId");


        StudentId = Convert.ToInt32(Console.ReadLine());



        string connectionString = @"Server=DESKTOP-PF8IQ0D\SQLEXPRESS;Database=collegeCanteen;User Id=sa;Password=pix@123;";

        string query = @"SELECT StdId, StudentName, EmailID FROM BCAStudents
where StdId="+StudentId;

        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command = new SqlCommand(query, connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            int studentId = (int)reader[0];
            string firstName = reader[1].ToString();
            string email = reader[2].ToString();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"ID: {studentId}, Name: {firstName}, Email: {email}");
        }

        reader.Close();
        connection.Close();
        Console.ReadKey();
    }

    public static void AdoNetSingleValue()
    {
        string connectionString = "Server=your_server_name;Database=your_database_name;User Id=your_username;Password=your_password;";

        string query = "SELECT FirstName FROM Student WHERE StudentId = 1"; // Static value for demonstration

        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command = new SqlCommand(query, connection);

        connection.Open();

        object result = command.ExecuteScalar();

        if (result != null)
        {
            string firstName = result.ToString();
            Console.WriteLine($"First Name: {firstName}");
        }
        else
        {
            Console.WriteLine("No result found.");
        }

        connection.Close();
    }


}
