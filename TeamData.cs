using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace World_Cup___DataAccess
{
    static public class clsTeamData
    {
        static public bool GetTeamByID(ref int ID, string Name, ref string Continent, ref int Trophies)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ConnectionSettings.ConnectionString);

            string query = @"SELECT * FROM Teams WHERE Name = @Name;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);

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
                    if (reader["Continent"] != DBNull.Value)
                        Continent = (string)reader["Continent"];
                    else
                        Continent = "";
                    if (reader["World_Cup_Trophies"] != DBNull.Value)
                        Trophies = (int)reader["World_Cup_Trophies"];
                    else
                        Trophies = -1;
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
    
        static public DataTable GetAllTeams()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ConnectionSettings.ConnectionString);

            string query = @"SELECT * FROM Teams;";

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
                
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        static public DataTable GetAllTeamsNames()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ConnectionSettings.ConnectionString);

            string query = "SELECT Name FROM Teams;";

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

            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        static public int GetIDOfTeam(string Name)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(ConnectionSettings.ConnectionString);

            string query = @"SELECT TOP 1 ID
                             FROM Teams
                             WHERE Name = @Name;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int SelectedID))
                    ID = SelectedID;

            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }

            return ID;
        }

        static public string GetTeamNameWhereID(int ID)
        {
            string Name = "";

            SqlConnection connection = new SqlConnection(ConnectionSettings.ConnectionString);

            string query = @"SELECT TOP 1 Name
                             FROM Teams
                             WHERE ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    if (reader["Name"] != DBNull.Value)
                        Name = reader["Name"].ToString();
                    else
                        Name = "";
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                return "";
            }
            finally
            {
                connection.Close();
            }

            return Name;
        }

    }
}
