using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace TournamentSystem
{
    public class DatabaseHelper
    {
        private string connectionString = "Server=localhost;Database=TournamentSystem;Uid=root;";

        public bool ValidateUser(string username, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public bool IsAdmin(string username)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT IsAdmin FROM Users WHERE Username = @username";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }
        }

        public int GetUserId(string username)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT UserId FROM Users WHERE Username = @username";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public bool RegisterUser(string username, string password, string email, string fullName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Users (Username, Password, Email, FullName) VALUES (@username, @password, @email, @fullName)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@fullName", fullName);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public DataTable GetAllUsers()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT UserId, Username, Email, FullName, IsAdmin FROM Users";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public bool UpdateUser(int userId, string username, string email, string fullName, bool isAdmin)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Users SET Username = @username, Email = @email, FullName = @fullName, IsAdmin = @isAdmin WHERE UserId = @userId";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@fullName", fullName);
                    cmd.Parameters.AddWithValue("@isAdmin", isAdmin);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public bool DeleteUser(int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Users WHERE UserId = @userId";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public DataTable GetUserInfo(int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Username, Email, FullName FROM Users WHERE UserId = @userId";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@userId", userId);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public bool UpdateUserInfo(int userId, string email, string fullName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Users SET Email = @email, FullName = @fullName WHERE UserId = @userId";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@fullName", fullName);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public bool ChangePassword(int userId, string newPassword)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Users SET Password = @password WHERE UserId = @userId";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@password", newPassword);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public DataTable GetAllTournaments()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT t.TournamentId, t.Name, t.Description, t.StartDate, t.EndDate, t.MaxParticipants, " +
                              "u.Username AS Creator, COUNT(tp.UserId) AS ParticipantsCount " +
                              "FROM Tournaments t " +
                              "LEFT JOIN Users u ON t.CreatedBy = u.UserId " +
                              "LEFT JOIN TournamentParticipants tp ON t.TournamentId = tp.TournamentId " +
                              "GROUP BY t.TournamentId";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public bool CreateTournament(string name, string description, DateTime startDate, DateTime endDate, int maxParticipants, int createdBy)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Tournaments (Name, Description, StartDate, EndDate, MaxParticipants, CreatedBy) " +
                                    "VALUES (@name, @description, @startDate, @endDate, @maxParticipants, @createdBy)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    cmd.Parameters.AddWithValue("@maxParticipants", maxParticipants);
                    cmd.Parameters.AddWithValue("@createdBy", createdBy);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public bool UpdateTournament(int tournamentId, string name, string description, DateTime startDate, DateTime endDate, int maxParticipants)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Tournaments SET Name = @name, Description = @description, " +
                                  "StartDate = @startDate, EndDate = @endDate, MaxParticipants = @maxParticipants " +
                                  "WHERE TournamentId = @tournamentId";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    cmd.Parameters.AddWithValue("@maxParticipants", maxParticipants);
                    cmd.Parameters.AddWithValue("@tournamentId", tournamentId);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public bool DeleteTournament(int tournamentId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Сначала удаляем участников турнира
                    string deleteParticipants = "DELETE FROM TournamentParticipants WHERE TournamentId = @tournamentId";
                    MySqlCommand cmd1 = new MySqlCommand(deleteParticipants, connection);
                    cmd1.Parameters.AddWithValue("@tournamentId", tournamentId);
                    cmd1.ExecuteNonQuery();

                    // Затем удаляем сам турнир
                    string deleteTournament = "DELETE FROM Tournaments WHERE TournamentId = @tournamentId";
                    MySqlCommand cmd2 = new MySqlCommand(deleteTournament, connection);
                    cmd2.Parameters.AddWithValue("@tournamentId", tournamentId);
                    return cmd2.ExecuteNonQuery() > 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public DataTable GetUserTournaments(int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT t.TournamentId, t.Name, t.Description, t.StartDate, t.EndDate, t.MaxParticipants, " +
                                "u.Username AS Creator, COUNT(tp2.UserId) AS ParticipantsCount " +
                                "FROM TournamentParticipants tp " +
                                "JOIN Tournaments t ON tp.TournamentId = t.TournamentId " +
                                "JOIN Users u ON t.CreatedBy = u.UserId " +
                                "LEFT JOIN TournamentParticipants tp2 ON t.TournamentId = tp2.TournamentId " +
                                "WHERE tp.UserId = @userId " +
                                "GROUP BY t.TournamentId";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@userId", userId);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetAvailableTournaments(int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT t.TournamentId, t.Name, t.Description, t.StartDate, t.EndDate, t.MaxParticipants, " +
                                "u.Username AS Creator, COUNT(tp.UserId) AS ParticipantsCount " +
                                "FROM Tournaments t " +
                                "LEFT JOIN Users u ON t.CreatedBy = u.UserId " +
                                "LEFT JOIN TournamentParticipants tp ON t.TournamentId = tp.TournamentId " +
                                "WHERE t.TournamentId NOT IN (SELECT TournamentId FROM TournamentParticipants WHERE UserId = @userId) " +
                                "GROUP BY t.TournamentId " +
                                "HAVING t.MaxParticipants > ParticipantsCount OR t.MaxParticipants = 0";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@userId", userId);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public bool JoinTournament(int tournamentId, int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO TournamentParticipants (TournamentId, UserId) VALUES (@tournamentId, @userId)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@tournamentId", tournamentId);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public bool LeaveTournament(int tournamentId, int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM TournamentParticipants WHERE TournamentId = @tournamentId AND UserId = @userId";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@tournamentId", tournamentId);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public DataTable GetTournamentParticipants(int tournamentId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT u.UserId, u.Username, u.FullName, u.Email, tp.RegistrationDate " +
                              "FROM TournamentParticipants tp " +
                              "JOIN Users u ON tp.UserId = u.UserId " +
                              "WHERE tp.TournamentId = @tournamentId";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@tournamentId", tournamentId);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}