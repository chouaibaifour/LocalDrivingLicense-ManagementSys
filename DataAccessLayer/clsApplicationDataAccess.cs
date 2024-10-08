﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static  class clsApplicationDataAccess
    {
        static public bool GetApplicationByID(ref int ApplicationID, ref int ApplicantPersonID, ref DateTime ApplicationDate,
            ref int ApplicationTypeID,ref byte ApplicationStatus,ref DateTime LastStatusDate,ref int PaidFees,ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT   ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID,
                                            ApplicationStatus, LastStatusDate, Cast(PaidFees as int)as PaidFees, CreatedByUserID
                                                    FROM   Applications 
                                                            WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    // the Application Was Successfully Found

                    isFound = true;

                    ApplicationID = (int)reader["ApplicationID"];

                    ApplicantPersonID = (int)reader["ApplicantPersonID"];

                    ApplicationTypeID = (int)reader["ApplicationTypeID"];

                    ApplicationStatus = (byte)reader["ApplicationStatus"];

                    PaidFees = (int)reader["PaidFees"];

                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    ApplicationDate = (DateTime)reader["ApplicationDate"];

                    LastStatusDate = (DateTime)reader["LastStatusDate"];


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

        static public bool GetApplicationByApplicantID(ref int ApplicationID, ref int ApplicantPersonID, ref DateTime ApplicationDate,
            ref int ApplicationTypeID, ref byte ApplicationStatus, ref DateTime LastStatusDate, ref int PaidFees, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM Applications WHERE ApplicantPersonID = @ApplicantPersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    // the Application Was Successfully Found
                    isFound = true;

                    ApplicationID = (int)reader["ApplicationID"];

                    ApplicantPersonID = (int)reader["ApplicantPersonID"];

                    ApplicationTypeID = (int)reader["ApplicationTypeID"];

                    ApplicationStatus = (byte)reader["ApplicationStatus"];

                    PaidFees = (int)reader["PaidFees"];

                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    ApplicationDate = (DateTime)reader["ApplicationDate"];

                    LastStatusDate = (DateTime)reader["LastStatusDate"];
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

        static public int AddNewApplication(  int ApplicantPersonID,  DateTime ApplicationDate,
             int ApplicationTypeID,  int ApplicationStatus,  DateTime LastStatusDate,  int PaidFees,  int CreatedByUserID)
        {
            // the function will returns ApplicationID or -1 if not 
            int ApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Applications
                            (ApplicantPersonID,  ApplicationDate,  ApplicationTypeID,  ApplicationStatus,  LastStatusDate,  PaidFees,  CreatedByUserID)
                            VALUES
                            ( @ApplicantPersonID,  @ApplicationDate,  @ApplicationTypeID, @ApplicationStatus,  @LastStatusDate,  @PaidFees,  @CreatedByUserID);

                               SELECT SCOPE_IDENTITY(); ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);

            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);

            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);

            command.Parameters.AddWithValue("@PaidFees", PaidFees);

            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != DBNull.Value && int.TryParse(result.ToString(), out int InsertedID))
                {
                    ApplicationID = InsertedID;
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

            return ApplicationID;

        }

        static public bool UpdateApplication( int ApplicationID, int ApplicantPersonID,  DateTime ApplicationDate,
             int ApplicationTypeID,  int ApplicationStatus,  DateTime LastStatusDate,  int PaidFees,  int CreatedByUserID)
        {
            int RowsAffected = -1;
            // this function returns true if Rows affected > 0 or false if no RowsAffected

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            //(,NationalityCountryID,ImagePath)
            string query = @"UPDATE Applications

                            SET 
                                ApplicationDate = @ApplicationDate, 

                                ApplicationTypeID = @ApplicationTypeID,

                                ApplicationStatus = @ApplicationStatus, 

                                LastStatusDate = @LastStatusDate,

                                PaidFees = @PaidFees,  

                                CreatedByUserID = @CreatedByUserID

                            WHERE ApplicationID = @ApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);

            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);

            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);

            command.Parameters.AddWithValue("@PaidFees", PaidFees);

            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

        static public bool DeleteApplication(int ApplicationID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // this fuction will returns true when RowsAffected > 0 and flase if not 

            int RowsAffected = 0;

            string query = @"DELETE Applications

                             WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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

        public static DataTable GetAllApplications()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT

                                LocalDrivingLicenseApplications.ApplicationID as 'L.D.L AppID', 

                                LicenseClasses.ClassName as 'Driving Class',

                                People.NationalNumber as 'National No.',

						        COALESCE(People.FirstName, '') + ' ' + 

						        COALESCE(People.SecondName, '') + ' ' + 

						        COALESCE(People.ThirdName, '') + ' ' + 

						        COALESCE(People.LastName, '') AS 'Full Name',

                                Applications.ApplicationDate,

                                count( Tests.TestResult) as 'Passed Tests',

								CASE

								WHEN  Applications.ApplicationStatus = 1 THEN 'New'

								WHEN  Applications.ApplicationStatus = 2 THEN 'In Progress'

								WHEN  Applications.ApplicationStatus = 3 THEN 'Completed'

								WHEN  Applications.ApplicationStatus = 4 THEN 'Canceled'

								ELSE 'Unknown'

								END as 'Status'

                            FROM 
                                Applications INNER JOIN People ON

                                        Applications.ApplicantPersonID = People.PersonID 

                                INNER JOIN LocalDrivingLicenseApplications ON 

                                        Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID

                                INNER JOIN LicenseClasses ON 

                                        LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID 

                                INNER JOIN ApplicationTypes ON 

                                        Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID

                                INNER JOIN TestAppointments ON 

                                        LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID

                                INNER JOIN Tests ON 

                                        TestAppointments.TestAppointmentID = Tests.TestAppointmentID

                                GROUP BY
                                        LocalDrivingLicenseApplications.ApplicationID,

                                         LicenseClasses.ClassName,

                                         People.NationalNumber,

                                         People.FirstName, 

                                         People.SecondName,

                                         People.ThirdName,

                                         People.LastName, 

                                         Applications.ApplicationDate,

										 Applications.ApplicationStatus;  ";

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

        public static bool IsApplicationExists(int ApplicationID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // this fuction will returns true when RowsAffected > 0 and flase if not 

            bool isFound = false;

            string query = @"SELECT IsFound = 1 FROM Applications
                             WHERE ApplicationID=@ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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

        public static bool IsApplicationExistsbyApplicantID(int ApplicantPersonID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // this fuction will returns true when RowsAffected > 0 and flase if not 

            bool isFound = false;

            string query = @"SELECT IsFound=1 FROM Applications

                             WHERE ApplicantPersonID = @ApplicantPersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);

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
