﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace DataAccessLayer
{
    public static class clsApplicationTypeDataAccess
    {
        static public bool GetApplicationTypeByID(ref int ApplicationTypeID, ref string ApplicationTypeTitle, ref int ApplicationFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            //string query = @"SELECT * FROM ApplicationTypes";
            string query = @"SELECT ApplicationTypeID,
                                    ApplicationTypeTitle,
                                    CAST(ApplicationFees as int ) as ApplicationFees
                                            FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    // the ApplicationType Was Successfully Found

                    isFound = true;

                    ApplicationTypeID = (int)reader["ApplicationTypeID"];

                    ApplicationFees = (int)reader["ApplicationFees"];

                    ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];



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

        static public bool UpdateApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            int RowsAffected = -1;
            // this function returns true if Rows affected > 0 or false if no RowsAffected

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            
            string query = @"UPDATE ApplicationTypes
                            SET 
                            ApplicationFees = @ApplicationFees,
                            ApplicationTypeTitle = @ApplicationTypeTitle
                            WHERE ApplicationTypeID = @ApplicationTypeID;";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);

            command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);


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

       

        public static DataTable GetAllApplicationTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT  * FROM  ApplicationTypes;";

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
