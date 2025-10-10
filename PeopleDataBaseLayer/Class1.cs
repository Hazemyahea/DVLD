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
    }
}
