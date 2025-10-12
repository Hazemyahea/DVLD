using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsConnection;
namespace DVLD_DataAccessLayer
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


        // insert 
        public static int AddNewPerson(string NationalNO, string FirstName, string SecondName, string ThiredName, string LastName,
    DateTime dateOfBirth, int Gendor, string Address, string Phone, string Email, int NationalCountryID, string ImagePath)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = @"
            INSERT INTO People (NationalNO, FirstName, SecondName, ThiredName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalCountryID, ImagePath)
            VALUES (@NationalNO, @FirstName, @SecondName, @ThiredName, @LastName, @DateOfBirth, @Gendor, @Address, @Phone, @Email, @NationalCountryID, @ImagePath);
            SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNO", NationalNO);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThiredName", ThiredName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalCountryID", NationalCountryID);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
            try
            {
                connection.Open();
                object obj = command.ExecuteScalar();
                result = Convert.ToInt32(obj);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        // update
        public static bool UpdatePerson(int PersonID, string NationalNO, string FirstName, string SecondName, string ThiredName, string LastName,
    DateTime dateOfBirth, int Gendor, string Address, string Phone, string Email, int NationalCountryID, string ImagePath)
        {
            bool isUpdated = false;

            string query = @"
        UPDATE People
        SET NationalNO = @NationalNO,
            FirstName = @FirstName,
            SecondName = @SecondName,
            ThiredName = @ThiredName,
            LastName = @LastName,
            DateOfBirth = @DateOfBirth,
            Gendor = @Gendor,
            Address = @Address,
            Phone = @Phone,
            Email = @Email,
            NationalCountryID = @NationalCountryID,
            ImagePath = @ImagePath
        WHERE PersonID = @PersonID;";

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@NationalNO", NationalNO);
                command.Parameters.AddWithValue("@FirstName", FirstName);
                command.Parameters.AddWithValue("@SecondName", SecondName);
                command.Parameters.AddWithValue("@ThiredName", ThiredName);
                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                command.Parameters.AddWithValue("@Gendor", Gendor);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@Phone", Phone);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@NationalCountryID", NationalCountryID);
                command.Parameters.AddWithValue("@ImagePath", ImagePath);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                    isUpdated = true;
            }

            return isUpdated;
        }

        static public bool Delete(int PersonID)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = "delete  from People where PersonID = @PersonID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
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
        // get person by id
        public static bool FindPersonByID(int PersonID, ref string NationalNO, ref string FirstName, ref string SecondName,
    ref string ThiredName, ref string LastName, ref DateTime DateOfBirth, ref int Gendor,
    ref string Address, ref string Phone, ref string Email, ref int NationalCountryID, ref string ImagePath)
        {
            bool isFound = false;

            string query = @"SELECT * FROM People WHERE PersonID = @PersonID";
            SqlConnection sqlConnection = new SqlConnection(clsConnectionString.ConnectionString);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    NationalNO = (string)reader["NationalNO"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThiredName = (string)reader["ThiredName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = Convert.ToInt32(reader["Gendor"]);
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    NationalCountryID = Convert.ToInt32(reader["NationalCountryID"]);
                    ImagePath = reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : string.Empty;
                    isFound = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }finally { sqlConnection.Close(); }
            return isFound;
        }


        // get persin by nationalId
        public static bool FindPersonByNationalID(string NationalNO, ref int PersonID, ref string FirstName, ref string SecondName,
  ref string ThiredName, ref string LastName, ref DateTime DateOfBirth, ref int Gendor,
  ref string Address, ref string Phone, ref string Email, ref int NationalCountryID, ref string ImagePath)
        {
            bool isFound = false;

            string query = @"select * from People where NationalNo = @NationalNO";
            SqlConnection sqlConnection = new SqlConnection(clsConnectionString.ConnectionString);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@NationalNO", NationalNO);
            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    PersonID = Convert.ToInt32(reader["PersonID"]);
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThiredName = (string)reader["ThiredName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = Convert.ToInt32(reader["Gendor"]);
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    NationalCountryID = Convert.ToInt32(reader["NationalCountryID"]);
                    ImagePath = reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : string.Empty;
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
