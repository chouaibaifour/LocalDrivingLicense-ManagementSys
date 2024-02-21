using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public static class clsPersonDataAccess
    {
        static public bool GetPersonByID(ref int PersonID, ref string NationalNumber,ref string FirstName, ref string SecondName,
            ref string ThirdName,ref string LastName, ref DateTime DateOfBirth,ref bool Gender,
            ref string Address ,ref string Email, ref string PhoneNumber,ref int NationalityCountryID,ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    // the Person Was Successfully Found

                    isFound = true;

                    PersonID = (int)reader["PersonID"];

                    NationalNumber = (string)reader["NationalNumber"];

                    FirstName = (string)reader["FirstName"];

                    if (reader["SecondName"] != DBNull.Value)
                    {
                        SecondName = (string)reader["SecondName"];
                    }
                    else
                    {
                        SecondName = "";
                    }

                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)reader["ThirdName"];
                    }
                    else
                    {
                        ThirdName = "";
                    }

                    LastName = (string)reader["LastName"];

                    DateOfBirth = (DateTime)reader["DateOfBirth"];

                    Gender = (bool)reader["Gender"];

                    PhoneNumber = (string)reader["PhoneNumber"];                   

                    Address = (string)reader["Address"];

                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }

                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                    NationalityCountryID = (int)reader["NationalityCountryID"];

                }
                else
                    isFound = false;
                reader.Close();


            }
            catch (Exception ex)
            {
                isFound = false;
               
            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }

        static public bool GetPersonByNationalNumber(ref int PersonID, ref string NationalNumber, ref string FirstName, ref string SecondName,
            ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref bool Gender, 
            ref string Address,ref string Email, ref string PhoneNumber, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM People WHERE NationalNumber = @NationalNumber";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNumber", NationalNumber);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    // the Person Was Successfully Found

                    isFound = true;

                    PersonID = (int)reader["PersonID"];

                    NationalNumber = (string)reader["NationalNumber"];

                    FirstName = (string)reader["FirstName"];

                    if (reader["SecondName"] != DBNull.Value)
                    {
                        SecondName = (string)reader["SecondName"];
                    }
                    else
                    {
                        SecondName = "";
                    }

                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)reader["ThirdName"];
                    }
                    else
                    {
                        ThirdName = "";
                    }

                    LastName = (string)reader["LastName"];

                    DateOfBirth = (DateTime)reader["DateOfBirth"];

                    Gender = (bool)reader["Gender"];

                    PhoneNumber = (string)reader["PhoneNumber"];

                    Address = (string)reader["Address"];

                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }

                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                    NationalityCountryID = (int)reader["NationalityCountryID"];

                }
                else
                    isFound = false;
                reader.Close();


            }
            catch (Exception ex)
            {
                isFound = false;

            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }

        static public int AddNewPerson(string NationalNumber, string FirstName, string SecondName,
             string ThirdName, string LastName, DateTime DateOfBirth, bool Gender,string Address, string Email,
              string PhoneNumber, int NationalityCountryID, string ImagePath)
        {
            // the function will returns PersonID or -1 if not 
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
                
            string query = @"INSERT INTO People(NationalNumber,FirstName,SecondName,ThirdName,LastName, DateOfBirth, Gender,Address
                                Email,PhoneNumber,NationalityCountryID,ImagePath)
                            VALUES
                            (@NationalNumber,@FirstName,@SecondName,@ThirdName,@LastName, @DateOfBirth, @Gender,Address
                                @Email,@PhoneNumber,@NationalityCountryID,@ImagePath);
                               SELECT SCOPE_IDENTITY(); ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNumber", NationalNumber);

            command.Parameters.AddWithValue("@FirstName", FirstName);


            if (SecondName != "")
            {

                command.Parameters.AddWithValue("@SecondName", SecondName);

            }
            else
            {

                command.Parameters.AddWithValue("@SecondName", DBNull.Value);

            }

            if (ThirdName != "")
            {

                command.Parameters.AddWithValue("@ThirdName", ThirdName);

            }
            else
            {

                command.Parameters.AddWithValue("@ThirdName", DBNull.Value);

            }

            

            command.Parameters.AddWithValue("@LastName", LastName);

            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

            command.Parameters.AddWithValue("@Gender", Gender);

            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

            command.Parameters.AddWithValue("@Email", Address);

            if (Email != "")
            {

                command.Parameters.AddWithValue("@Email", Email);

            }
            else
            {

                command.Parameters.AddWithValue("@Email", DBNull.Value);

            }

            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (ImagePath != "")
            {

                command.Parameters.AddWithValue("@ImagePath", ImagePath);

            }
            else
            {

                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            }

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != DBNull.Value && int.TryParse(result.ToString(), out int InsertedID))
                {
                    PersonID = InsertedID;
                }

            }
            catch (Exception ex)
            {
                //clsDataAccessSettings.PrintExecptionErrorMessage(ex);
            }
            finally
            {
                connection.Close();
            }

            return PersonID;

        }

        static public bool UpdatePerson(int PersonID, string NationalNumber, string FirstName, string SecondName,
             string ThirdName, string LastName, DateTime DateOfBirth, bool Gender, string Address, string Email,
              string PhoneNumber, int NationalityCountryID, string ImagePath)
        {
            int RowsAffected = -1;
            // this function returns true if Rows affected > 0 or false if no RowsAffected

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            //(,NationalityCountryID,ImagePath)
            string query = @"UPDATE People
                            SET FirstName = @FirstName,
                            NationalNumber = @NationalNumber,
                            SecondName = @SecondName,
                            ThirdName = @ThirdName,
                            LastName = @LastName,
                            DateOfBirth = @DateOfBirth,
                            Gender = @Gender,
                            PhoneNumber = @PhoneNumber,
                            Email = @Email,
                            Address = @Address,
                            NationalityCountryID=@NationalityCountryID,
                            ImagePath=@ImagePath
                            WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@PersonID", PersonID);

            command.Parameters.AddWithValue("@NationalNumber", NationalNumber);

            command.Parameters.AddWithValue("@FirstName", FirstName);

            if (SecondName != "")
            {
                command.Parameters.AddWithValue("@SecondName", SecondName);
            }
            else
                command.Parameters.AddWithValue("@SecondName", DBNull.Value);

            if (ThirdName != "")
            {
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            }
            else
                command.Parameters.AddWithValue("@ThirdName", DBNull.Value); 

            command.Parameters.AddWithValue("@LastName", LastName);

            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

            command.Parameters.AddWithValue("@Gender", Gender);

            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

            command.Parameters.AddWithValue("@Address", Address);

            if (Email != "")
            {
                command.Parameters.AddWithValue("@Email", Email);
            }
            else
                command.Parameters.AddWithValue("@Email", DBNull.Value);

            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (ImagePath != "")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //clsDataAccessSettings.PrintExecptionErrorMessage(ex);
            }
            finally
            {
                connection.Close();
            }

            return (RowsAffected > 0);
        }

        static public bool DeletePerson(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // this fuction will returns true when RowsAffected > 0 and flase if not 

            int RowsAffected = 0;

            string query = @"DELETE People
                             WHERE PersonID=@PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                connection.Close();
            }

            return (RowsAffected > 0);

        }

        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM People ";

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
                //clsDataAccessSettings.PrintExecptionErrorMessage(ex);
            }
            finally
            {
                connection.Close();
            }
            return dt;

        }

        public static bool IsPersonExists(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // this fuction will returns true when RowsAffected > 0 and flase if not 

            bool isFound = false;

            string query = @"SELECT IsFound=1 FROM People
                             WHERE PersonID=@PersonID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
                //clsDataAccessSettings.PrintExecptionErrorMessage(ex);
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static bool IsPersonExist(string NationalNumber)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // this fuction will returns true when RowsAffected > 0 and flase if not 

            bool isFound = false;

            string query = @"SELECT IsFound=1 FROM People
                             WHERE NationalNumber = @NationalNumber";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNumber", NationalNumber);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
                //clsDataAccessSettings.PrintExecptionErrorMessage(ex);
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

    }
}
