using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsConnection;
namespace PeopleDataBaseLayer
{
    public class clsPeopleDataBaseLayer
    {
        static public DataTable GetAllPeople()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = "select People.PersonID,People.FirstName,People.SecondName,People.ThirdName,People.DateOfBirth,People.Address,People.Phone,People.Email,\r\nCASE \r\nWHEN People.Gendor = 0 then 'Male'\r\nELSE 'Female' End As Gendor,Countries.CountryName\r\nfrom People inner join Countries on People.NationalityCountryID = Countries.CountryID";
            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                dataTable.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                throw new Exception("Error in GetAllPeople: " + ex.Message, ex);

            }
            finally
            {
                connection.Close();
            }
            return dataTable;

        }
        static public bool IsPersonExist(int PersonID)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = "select 1 from People where People.PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                object value = command.ExecuteScalar();
                if (value != null)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                connection.Close();

            }
            return result;
        }
    }
}
