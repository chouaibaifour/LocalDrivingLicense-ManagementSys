using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace DataAccessLayer
{
    public static class clsTestTypeDataAccess
    {
        static public bool GetTestTypeByID(ref int TestTypeID, ref string TestTypeTitle,ref string TestTypeDescription, ref int TestTypeFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            //string query = @"SELECT * FROM TestTypes";
            string query = @"SELECT TestTypeID,
                                    TestTypeTitle,
                                    TestTypeDescription,
                                    CAST(TestTypeFees as int ) as TestTypeFees
                                            FROM TestTypes WHERE TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    // the TestType Was Successfully Found

                    isFound = true;

                    TestTypeID = (int)reader["TestTypeID"];

                    TestTypeFees = (int)reader["TestTypeFees"];

                    TestTypeDescription = (string)reader["TestTypeDescription"];

                    TestTypeTitle = (string)reader["TestTypeTitle"];



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

        static public bool UpdateTestType( int TestTypeID,  string TestTypeTitle,  string TestTypeDescription,  int TestTypeFees)
        {
            int RowsAffected = -1;
            // this function returns true if Rows affected > 0 or false if no RowsAffected

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            
            string query = @"UPDATE TestTypes
                            SET 
                            TestTypeFees = @TestTypeFees,

                            TestTypeDescription = @TestTypeDescription,

                            TestTypeTitle = @TestTypeTitle

                            WHERE TestTypeID = @TestTypeID;";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);

            command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);

            command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);


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

        public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT  * FROM  TestTypes;";

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

        
    }
}
