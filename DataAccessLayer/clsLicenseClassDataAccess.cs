﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class clsLicenseClassDataAccess
    {
        static public bool GetLicenseClassByID(ref int LicenseClassID, ref string LicenseClassName, ref string ClassDescription
            , ref int MinimumAllowedAge, ref int DefaultValidityLength, ref int ClassFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT LicenseClassID
                                      ,ClassName
                                      ,ClassDescription
                                      ,MinimumAllowedAge
                                      ,DefaultValidityLength
                                      ,CAST(ClassFees as int ) as ClassFees
                                             FROM LicenseClasses
                                                 WHERE LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    // the LicenseClass Was Successfully Found

                    isFound = true;

                    LicenseClassID = (int)reader["LicenseClassID"];

                    LicenseClassName = (string)reader["ClassName"];

                    ClassDescription = (string)reader["ClassDescription"];

                    MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];

                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];

                    ClassFees = (int)reader["ClassFees"];

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

        static public bool GetLicenseClassByLicenseClassName(ref int LicenseClassID, ref string LicenseClassName, ref string ClassDescription
            , ref int MinimumAllowedAge, ref int DefaultValidityLength, ref int ClassFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT LicenseClassID
                                      ,ClassName
                                      ,ClassDescription
                                      ,MinimumAllowedAge
                                      ,DefaultValidityLength
                                      ,CAST(ClassFees as int ) as ClassFees
                                             FROM LicenseClasses
                                                        WHERE ClassName = @ClassName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClassName", LicenseClassName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    // the LicenseClass Was Successfully Found

                    isFound = true;

                    LicenseClassID = (int)reader["LicenseClassID"];

                    LicenseClassName = (string)reader["ClassName"];

                    ClassDescription = (string)reader["ClassDescription"];

                    MinimumAllowedAge = (int)reader["MinimumAllowedAge"];

                    DefaultValidityLength = (int)reader["DefaultValidityLength"];

                    ClassFees = (int)reader["ClassFees"];

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

        static public int AddNewLicenseClass(string ClassName, string ClassDescription
            , int MinimumAllowedAge, int DefaultValidityLength, int ClassFees)
        {
            // the function will returns LicenseClassID or -1 if not 
            int LicenseClassID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO LicenseClasses(ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees)
                            VALUES
                            (@ClassName, @ClassDescription, @MinimumAllowedAge, @DefaultValidityLength, @ClassFees);
                               SELECT SCOPE_IDENTITY(); ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClassName", ClassName);

            command.Parameters.AddWithValue("@ClassDescription", ClassDescription);

            command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);

            command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);

            command.Parameters.AddWithValue("@ClassFees", ClassFees);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != DBNull.Value && int.TryParse(result.ToString(), out int InsertedID))
                {
                    LicenseClassID = InsertedID;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return LicenseClassID;

        }

        static public bool UpdateLicenseClass(int LicenseClassID, string ClassName, string ClassDescription
            , int MinimumAllowedAge, int DefaultValidityLength, int ClassFees)
        {
            int RowsAffected = -1;
            // this function returns true if Rows affected > 0 or false if no RowsAffected

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            //(,NationalityLicenseClassID,ImagePath)
            string query = @"UPDATE LicenseClasses
                                 SET ClassName = @ClassName ,

                                     ClassDescription = @ClassDescription,

                                      MinimumAllowedAge = @MinimumAllowedAge ,

                                      DefaultValidityLength = @DefaultValidityLength ,

                                      ClassFees = @ClassFees

                                                 WHERE LicenseClassID = @LicenseClassID;";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            command.Parameters.AddWithValue("@ClassName", ClassName);

            command.Parameters.AddWithValue("@ClassDescription", ClassDescription);

            command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);

            command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);

            command.Parameters.AddWithValue("@ClassFees", ClassFees);

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

        static public bool DeleteLicenseClass(int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // this fuction will returns true when RowsAffected > 0 and flase if not 

            int RowsAffected = 0;

            string query = @"DELETE LicenseClasses
                             WHERE LicenseClassID=@LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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

        public static DataTable GetAllLicenseClasses()
        {


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM LicenseClasses; ";

            SqlCommand command = new SqlCommand(query, connection);
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dataTable.Load(reader);
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
            return dataTable;

        }

        public static bool IsLicenseClassExists(int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // this fuction will returns true when RowsAffected > 0 and flase if not 

            bool isFound = false;

            string query = @"SELECT IsFound=1 FROM LicenseClasses
                             WHERE LicenseClassID=@LicenseClassID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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

        public static bool IsLicenseClassExist(string LicenseClassName)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // this fuction will returns true when RowsAffected > 0 and flase if not 

            bool isFound = false;

            string query = @"SELECT IsFound=1 FROM LicenseClasses
                             WHERE ClassName = @ClassName";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClassName", LicenseClassName);

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
