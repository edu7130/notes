using Domain;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Entities
{
    public class DaoUser
    {
        public static User GetUserfromName(string name)
        {
            User user = null;
            
            try
            {
                using (var conn = Connection.GetConnection())
                {
                    conn.Open();
                    using (var command = conn.CreateCommand())
                    {
                        command.CommandText = "SELECT * FROM [dbo].[user] WHERE name = @Name";
                        command.Parameters.Add("@Name", SqlDbType.VarChar).Value = name;
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            user = new User()
                            {
                                Id = (int)reader["id"],
                                Name = (string)reader["name"]
                            };
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine($"Error: {e.Number}.\n{e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            return user;
        }
        
        public static User GetUserfromId(int id)
        {
            User user = null;
            
            try
            {
                using (var conn = Connection.GetConnection())
                {
                    conn.Open();
                    using (var command = conn.CreateCommand())
                    {
                        command.CommandText = "SELECT * FROM [dbo].[user] WHERE id = @Id";
                        command.Parameters.Add("@Id", SqlDbType.VarChar).Value = id;
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            user = new User()
                            {
                                Id = (int)reader["id"],
                                Name = (string)reader["name"]
                            };
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine($"Error: {e.Number}.\n{e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            return user;
        }

        public static bool InsertUser(string name)
        {
            bool success = false;
            try
            {
                using (var conn = Connection.GetConnection())
                {
                    conn.Open();
                    using (var command = conn.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO [dbo].[user] VALUES(@Name)";
                        command.Parameters.Add("@Name", SqlDbType.VarChar).Value = name;
                        command.ExecuteNonQuery();
                        success = true;
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine($"Error: {e.Number}.\n{e.Message}");
                success = false;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                success = false;
            }
            return success;
        }
    }
}
