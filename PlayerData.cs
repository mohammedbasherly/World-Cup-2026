using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_Cup___DataAccess
{
    static public class clsPlayerData
    {
        static public bool GetPlayerByID(int ID, ref string FirstName, ref string LastName, ref int KitNumber,
            ref int NationalTeamID, ref string Club, ref string Position, ref short Age)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ConnectionSettings.ConnectionString);

            string query = @"SELECT *
                             FROM Players
                             WHERE ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    if (reader["FirstName"] != DBNull.Value)
                        FirstName = (string)reader["FirstName"];
                    else
                        FirstName = "";
                    if (reader["LastName"] != DBNull.Value)
                        LastName = (string)reader["LastName"];
                    else
                        LastName = "";
                    if (reader["KitNumber"] != DBNull.Value)
                        KitNumber = (int)reader["KitNumber"];
                    else
                        KitNumber = -1;
                    if (reader["NationalTeamID"] != DBNull.Value)
                        NationalTeamID = (int)reader["NationalTeamID"];
                    else
                        NationalTeamID = -1;
                    if (reader["Club"] != DBNull.Value)
                        Club = (string)reader["Club"];
                    else
                        Club = "";
                    if (reader["Position"] != DBNull.Value)
                        Position = (string)reader["Position"];
                    else
                        Position = "";
                    if (reader["Age"] != DBNull.Value)
                        Age = (short)reader["Age"];
                    else
                        Age = -1;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        static public bool GetPlayerByFirstName(ref int ID, string FirstName, ref string LastName, ref int KitNumber,
            ref int NationalTeamID, ref string Club, ref string Position, ref short Age)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ConnectionSettings.ConnectionString);

            string query = @"SELECT *
                             FROM Players
                             WHERE FirstName = @FirstName;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    if (reader["ID"] != DBNull.Value)
                        ID = (int)reader["ID"];
                    else
                        ID = -1;
                    if (reader["LastName"] != DBNull.Value)
                        LastName = (string)reader["LastName"];
                    else
                        LastName = "";
                    if (reader["KitNumber"] != DBNull.Value)
                        KitNumber = (int)reader["KitNumber"];
                    else
                        KitNumber = -1;
                    if (reader["NationalTeamID"] != DBNull.Value)
                        NationalTeamID = (int)reader["NationalTeamID"];
                    else
                        NationalTeamID = -1;
                    if (reader["Club"] != DBNull.Value)
                        Club = (string)reader["Club"];
                    else
                        Club = "";
                    if (reader["Position"] != DBNull.Value)
                        Position = (string)reader["Position"];
                    else
                        Position = "";
                    if (reader["Age"] != DBNull.Value)
                        Age = (short)reader["Age"];
                    else
                        Age = -1;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        static public bool GetPlayerByLastName(ref int ID, ref string FirstName, string LastName, ref int KitNumber,
            ref int NationalTeamID, ref string Club, ref string Position, ref short Age)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ConnectionSettings.ConnectionString);

            string query = @"SELECT *
                             FROM Players
                             WHERE LastName = @LastName;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LastName", LastName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    if (reader["ID"] != DBNull.Value)
                        ID = (int)reader["ID"];
                    else
                        ID = -1;
                    if (reader["FirstName"] != DBNull.Value)
                        FirstName = (string)reader["FirstName"];
                    else
                        FirstName = "";
                    if (reader["KitNumber"] != DBNull.Value)
                        KitNumber = (int)reader["KitNumber"];
                    else
                        KitNumber = -1;
                    if (reader["NationalTeamID"] != DBNull.Value)
                        NationalTeamID = (int)reader["NationalTeamID"];
                    else
                        NationalTeamID = -1;
                    if (reader["Club"] != DBNull.Value)
                        Club = (string)reader["Club"];
                    else
                        Club = "";
                    if (reader["Position"] != DBNull.Value)
                        Position = (string)reader["Position"];
                    else
                        Position = "";
                    if (reader["Age"] != DBNull.Value)
                        Age = (short)reader["Age"];
                    else
                        Age = -1;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        static public bool GetPlayerByNationalTeamID(ref int ID, ref string FirstName, ref string LastName, ref int KitNumber,
             int NationalTeamID, ref string Club, ref string Position, ref short Age)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ConnectionSettings.ConnectionString);

            string query = @"SELECT *
                             FROM Players
                             WHERE NationalTeamID = @NationalTeamID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalTeamID", NationalTeamID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    if (reader["ID"] != DBNull.Value)
                        ID = (int)reader["ID"];
                    else
                        ID = -1;
                    if (reader["FirstName"] != DBNull.Value)
                        FirstName = (string)reader["FirstName"];
                    else
                        FirstName = "";
                    if (reader["LastName"] != DBNull.Value)
                        LastName = (string)reader["LastName"];
                    else
                        LastName = "";
                    if (reader["KitNumber"] != DBNull.Value)
                        KitNumber = (int)reader["KitNumber"];
                    else
                        KitNumber = -1;
                    if (reader["Club"] != DBNull.Value)
                        Club = (string)reader["Club"];
                    else
                        Club = "";
                    if (reader["Position"] != DBNull.Value)
                        Position = (string)reader["Position"];
                    else
                        Position = "";
                    if (reader["Age"] != DBNull.Value)
                        Age = (short)reader["Age"];
                    else
                        Age = -1;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        static public bool GetPlayerByClub(ref int ID, ref string FirstName, ref string LastName, ref int KitNumber,
             ref int NationalTeamID,  string Club, ref string Position, ref short Age)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ConnectionSettings.ConnectionString);

            string query = @"SELECT *
                             FROM Players
                             WHERE Club = @Club;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Club", NationalTeamID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    if (reader["ID"] != DBNull.Value)
                        ID = (int)reader["ID"];
                    else
                        ID = -1;
                    if (reader["FirstName"] != DBNull.Value)
                        FirstName = (string)reader["FirstName"];
                    else
                        FirstName = "";
                    if (reader["LastName"] != DBNull.Value)
                        LastName = (string)reader["LastName"];
                    else
                        LastName = "";
                    if (reader["KitNumber"] != DBNull.Value)
                        KitNumber = (int)reader["KitNumber"];
                    else
                        KitNumber = -1;
                    if (reader["NationalTeamID"] != DBNull.Value)
                        NationalTeamID = (int)reader["NationalTeamID"];
                    else
                        NationalTeamID = -1;
                    if (reader["Position"] != DBNull.Value)
                        Position = (string)reader["Position"];
                    else
                        Position = "";
                    if (reader["Age"] != DBNull.Value)
                        Age = (short)reader["Age"];
                    else
                        Age = -1;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        static public bool GetPlayerByPosition(ref int ID, ref string FirstName, ref string LastName, ref int KitNumber,
             ref int NationalTeamID, ref string Club,  string Position, ref short Age)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ConnectionSettings.ConnectionString);

            string query = @"SELECT *
                             FROM Players
                             WHERE Position = @Position;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Position", NationalTeamID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    if (reader["ID"] != DBNull.Value)
                        ID = (int)reader["ID"];
                    else
                        ID = -1;
                    if (reader["FirstName"] != DBNull.Value)
                        FirstName = (string)reader["FirstName"];
                    else
                        FirstName = "";
                    if (reader["LastName"] != DBNull.Value)
                        LastName = (string)reader["LastName"];
                    else
                        LastName = "";
                    if (reader["KitNumber"] != DBNull.Value)
                        KitNumber = (int)reader["KitNumber"];
                    else
                        KitNumber = -1;
                    if (reader["NationalTeamID"] != DBNull.Value)
                        NationalTeamID = (int)reader["NationalTeamID"];
                    else
                        NationalTeamID = -1;
                    if (reader["Club"] != DBNull.Value)
                        Club = (string)reader["Club"];
                    else
                        Club = "";
                    if (reader["Age"] != DBNull.Value)
                        Age = (short)reader["Age"];
                    else
                        Age = -1;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        static public bool GetPlayerByAge(ref int ID, ref string FirstName, ref string LastName, ref int KitNumber,
             ref int NationalTeamID, ref string Club, ref string Position, short Age)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ConnectionSettings.ConnectionString);

            string query = @"SELECT *
                             FROM Players
                             WHERE Age = @Age;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Age", NationalTeamID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    if (reader["ID"] != DBNull.Value)
                        ID = (int)reader["ID"];
                    else
                        ID = -1;
                    if (reader["FirstName"] != DBNull.Value)
                        FirstName = (string)reader["FirstName"];
                    else
                        FirstName = "";
                    if (reader["LastName"] != DBNull.Value)
                        LastName = (string)reader["LastName"];
                    else
                        LastName = "";
                    if (reader["KitNumber"] != DBNull.Value)
                        KitNumber = (int)reader["KitNumber"];
                    else
                        KitNumber = -1;
                    if (reader["NationalTeamID"] != DBNull.Value)
                        NationalTeamID = (int)reader["NationalTeamID"];
                    else
                        NationalTeamID = -1;
                    if (reader["Club"] != DBNull.Value)
                        Club = (string)reader["Club"];
                    else
                        Club = "";
                    if (reader["Position"] != DBNull.Value)
                        Position = (string)reader["Position"];
                    else
                        Position = "";
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        static public DataTable GetAllPlayers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ConnectionSettings.ConnectionString);

            string query = @"SELECT Players.*, Teams.Name as TeamName 
                             FROM Players
                             INNER JOIN Teams
                             ON Teams.ID = Players.NationalTeamID;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                return dt;
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        static public DataTable GetAllPlayersWhereFirstName(string FirstName)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ConnectionSettings.ConnectionString);

            string query = @"SELECT Players.*, Teams.Name as TeamName 
                             FROM Players
                             INNER JOIN Teams
                             ON Teams.ID = Players.NationalTeamID
                             WHERE FirstName like '%" + FirstName + "%';";

            SqlCommand command = new SqlCommand(query, connection);

            // command.Parameters.AddWithValue("@FirstName", FirstName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                return dt;
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        static public DataTable GetAllPlayersWhereLastName(string LastName)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ConnectionSettings.ConnectionString);

            string query = @"SELECT Players.*, Teams.Name as TeamName 
                             FROM Players
                             INNER JOIN Teams
                             ON Teams.ID = Players.NationalTeamID
                             WHERE LastName like '%" + LastName + "%';";

            SqlCommand command = new SqlCommand(query, connection);
            //command.Parameters.AddWithValue("@LastName", LastName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                return dt;
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        static public DataTable GetAllPlayersWhereNationalTeamID(int NationalTeamID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ConnectionSettings.ConnectionString);

            string query = @"SELECT Players.*, Teams.Name as TeamName 
                             FROM Players
                             INNER JOIN Teams
                             ON Teams.ID = Players.NationalTeamID
                             WHERE NationalTeamID = @NationalTeamID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalTeamID", NationalTeamID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                return dt;
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        static public DataTable GetAllPlayersWhereKitNumber(int KitNumber)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ConnectionSettings.ConnectionString);

            string query = @"SELECT Players.*, Teams.Name as TeamName 
                             FROM Players
                             INNER JOIN Teams
                             ON Teams.ID = Players.NationalTeamID
                             WHERE KitNumber = @KitNumber;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@KitNumber", KitNumber);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                return dt;
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        static public DataTable GetAllPlayersWhereClub(string Club)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ConnectionSettings.ConnectionString);

            string query = @"SELECT Players.*, Teams.Name as TeamName 
                             FROM Players
                             INNER JOIN Teams
                             ON Teams.ID = Players.NationalTeamID
                             WHERE Club like '%" + Club + "%';";

            SqlCommand command = new SqlCommand(query, connection);
            //command.Parameters.AddWithValue("@Club", Club);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                return dt;
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        static public DataTable GetAllPlayersWherePosition(string Position)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ConnectionSettings.ConnectionString);

            string query = @"SELECT Players.*, Teams.Name as TeamName 
                             FROM Players
                             INNER JOIN Teams
                             ON Teams.ID = Players.NationalTeamID
                             WHERE Position like '%" + Position + "%';";

            SqlCommand command = new SqlCommand(query, connection);
            // command.Parameters.AddWithValue("@Position", Position);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                return dt;
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        static public DataTable GetAllPlayersWhereAge(short Age)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ConnectionSettings.ConnectionString);

            string query = @"SELECT Players.*, Teams.Name as TeamName 
                             FROM Players
                             INNER JOIN Teams
                             ON Teams.ID = Players.NationalTeamID
                             WHERE Age = @Age;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Age", Age);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                return dt;
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        static public string AddNewPlayer(string FirstName, string LastName, int KitNumber,
            int NationalTeamID, string Club, string Position, short Age)
        {
            string msg = "";

            SqlConnection connection = new SqlConnection(ConnectionSettings.ConnectionString);

            string query = @"INSERT INTO Players (FirstName, LastName, KitNumber, NationalTeamID, Club, [Position], Age)
                             VALUES (@FirstName, @LastName, @KitNumber, @NationalTeamID, @Club, @Position, @Age);";

            SqlCommand command = new SqlCommand(@query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@KitNumber", KitNumber);
            command.Parameters.AddWithValue("@NationalTeamID", NationalTeamID);
            command.Parameters.AddWithValue("@Club", Club);
            command.Parameters.AddWithValue("@Position", Position);
            command.Parameters.AddWithValue("@Age", Age);

            try
            {
                connection.Open();

                int rowsEffected = command.ExecuteNonQuery();

                if (rowsEffected > 0)
                    msg = "done";
                else
                    msg = "failed";

            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
            finally
            {
                connection.Close();
            }

            return msg;
        }

    }
}
