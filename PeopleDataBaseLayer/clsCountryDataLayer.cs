using clsConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DVLD_DataAccessLayer
{
    public class clsCountryDataLayer
    {
        static public DataTable GetAllCountry()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = "select * from Countries";
            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                dataTable.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                throw new Exception("Error in GetAllCountry: " + ex.Message, ex);

            }
            finally
            {
                connection.Close();
            }
            return dataTable;

        }
       
        public static bool GetCountrybyID(int CountryID,ref string CountryName)
        {
            bool isFound = false;

            string query = @"SELECT * FROM Countries WHERE CountryID = @CountryID";
            SqlConnection sqlConnection = new SqlConnection(clsConnectionString.ConnectionString);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@CountryID", CountryID);
            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    CountryName = (string)reader["CountryName"];
                   
                    isFound = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { sqlConnection.Close(); }
            return isFound;
        }



}
}
