using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static  class clsAuthenticationDataAccess
    {

        public static bool Login( ref string UserName,  ref string Password,ref int UserID,ref int PersonID,ref bool isActive)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // this fuction will returns true when RowsAffected > 0 and flase if not 

            bool isFound = false;

            string query = @"SELECT isActive,PersonID,UserID FROM Users
                             WHERE UserName = @UserName AND Password = @Password ";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // the User Was Successfully Found

                    isFound = true;
                    isActive = (bool)reader["isActive"];
                    PersonID = (int)reader["PersonID"];
                    UserID = (int)reader["UserID"];
                    

                }else
                    isFound = false;
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
