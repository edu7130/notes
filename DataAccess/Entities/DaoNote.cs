using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DataAccess
{
    public class DaoNote
    {
        public static List<Note> GetNotesFromUser(User user)
        {
            List<Note> listNotes = new List<Note>();
            try
            {
                using (var conn = Connection.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand command = conn.CreateCommand())
                    {
                        command.CommandText = "SELECT n.* FROM note n INNER JOIN [user] u ON n.id_user = u.id WHERE u.id = @Id";
                        command.Parameters.Add("@Id", SqlDbType.Int).Value = user.Id;
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            listNotes.Add(new Note()
                            {
                                Id = (int)reader["id"],
                                Title = (string)reader["title"],
                                Body = (string)reader["body"],
                                Created = (DateTime)reader["created"],
                            });
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
            return listNotes;
        }

        public static bool InsertNote(Note note, User user)
        {
            bool success = false;
            try
            {
                using (var conn = Connection.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand command = conn.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO note VALUES(@UserId,@Title,@Body,@Created)";

                        command.Parameters.Add("@Title", SqlDbType.VarChar).Value = note.Title;
                        command.Parameters.Add("@Body", SqlDbType.VarChar).Value = note.Body;
                        command.Parameters.Add("@Created", SqlDbType.DateTime).Value = note.Created;
                        command.Parameters.Add("@UserId", SqlDbType.Int).Value = user.Id;

                        command.ExecuteNonQuery();
                        success = true;
                    }
                }
            }
            catch (SqlException e)
            {
                string ex = $"Error: {e.Number}\n {e.Message}";
                Console.Write(ex);
                success = false;
            }
            catch (Exception e)
            {
                string ex = $"Error:\n{e.Message}";
                Console.WriteLine(ex);
                success = false;
            }

            return success;
        }

        public static bool UpdateNote(Note note)
        {
            bool success = false;
            try
            {
                using (var conn = Connection.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand command = conn.CreateCommand())
                    {
                        command.CommandText = "UPDATE note SET " +
                            "title = @Title," +
                            "body =  @Body," +
                            "created = @Created " +
                            "WHERE id = @Id";

                        command.Parameters.Add("@Title", SqlDbType.VarChar).Value = note.Title;
                        command.Parameters.Add("@Body", SqlDbType.VarChar).Value = note.Body;
                        command.Parameters.Add("@Created", SqlDbType.DateTime).Value = note.Created;
                        command.Parameters.Add("@Id", SqlDbType.Int).Value = note.Id;

                        command.ExecuteNonQuery();
                        success = true;
                    }
                }
            }
            catch (SqlException e)
            {
                string ex = $"Error: {e.Number}\n {e.Message}";
                Console.Write(ex);
                success = false;
            }
            catch (Exception e)
            {
                string ex = $"Error:\n{e.Message}";
                Console.WriteLine(ex);
                success = false;
            }
            return success;
        }

        public static bool DeleteNote(Note note)
        {
            bool success = false;
            try
            {
                using (var conn = Connection.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand command = conn.CreateCommand())
                    {
                        command.CommandText = "DELETE note WHERE id = @Id";

                        command.Parameters.Add("@Id", SqlDbType.Int).Value = note.Id;

                        command.ExecuteNonQuery();
                        success = true;
                    }
                }
            }
            catch (SqlException e)
            {
                string ex = $"Error: {e.Number}\n {e.Message}";
                Console.Write(ex);
                success = false;
            }
            catch (Exception e)
            {
                string ex = $"Error:\n{e.Message}";
                Console.WriteLine(ex);
                success = false;
            }
            return success;

        }
    }
}
