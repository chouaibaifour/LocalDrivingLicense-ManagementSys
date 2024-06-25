using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class cls_LDL_ApplicationDataAccess
    {
        static public bool GetApplicationByID(ref int LocalDrivingLicenseApplicationID, ref int ApplicationID, ref int LicenseClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT LocalDrivingLicenseApplicationID,ApplicationID,LicenseClassID 
                                    FROM LocalDrivingLicenseApplications 
                                            WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    // the Application Was Successfully Found

                    isFound = true;

                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];

                    ApplicationID = (int)reader["ApplicationID"];

                    LicenseClassID = (int)reader["LicenseClassID"];

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

        static public int AddNewApplication(int ApplicationID, int LicenseClassID)
        {
            // the function will returns LDL_ApplicationID or -1 if not 
            int LDL_ApplicationID = -1; 

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO LocalDrivingLicenseApplications 
                            (ApplicationID,  LicenseClassID)
                            VALUES
                            ( @ApplicationID,  @LicenseClassID);
                               SELECT SCOPE_IDENTITY(); ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != DBNull.Value && int.TryParse(result.ToString(), out int InsertedID))
                {
                    LDL_ApplicationID = InsertedID;
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

            return LDL_ApplicationID;

        }

        static public bool UpdateApplication( int LDL_ApplicationID,  int ApplicationID,  int LicenseClassID)
        {
            int RowsAffected = -1;
            // this function returns true if Rows affected > 0 or false if no RowsAffected

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            //(,NationalityCountryID,ImagePath)
            string query = @"UPDATE Applications

                            SET 
                                ApplicationID, 

                                LicenseClassID
                              
                            WHERE LDL_ApplicationID = @LDL_ApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDL_ApplicationID", LDL_ApplicationID);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


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

        static public bool DeleteApplication(int LDL_ApplicationID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // this fuction will returns true when RowsAffected > 0 and flase if not 

            int RowsAffected = 0;

            string query = @"DELETE Applications

                             WHERE LDL_ApplicationID = @LDL_ApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDL_ApplicationID", LDL_ApplicationID);

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

                                LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID as 'L.D.L.AppID', 

                                LicenseClasses.ClassName as 'Driving Class',

                                People.NationalNumber as 'NationalNo',

						        COALESCE(People.FirstName, '') + ' ' + 

						        COALESCE(People.SecondName, '') + ' ' + 

						        COALESCE(People.ThirdName, '') + ' ' + 

						        COALESCE(People.LastName, '') AS 'FullName',

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

                                LEFT OUTER JOIN TestAppointments ON 

                                        LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID

                                LEFT OUTER JOIN Tests ON 

                                        TestAppointments.TestAppointmentID = Tests.TestAppointmentID

                                GROUP BY
                                        LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID,

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

        public static bool IsApplicationExists(int LDL_ApplicationID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // this fuction will returns true when RowsAffected > 0 and flase if not 

            bool isFound = false;

            string query = @"SELECT IsFound = 1 FROM Applications

                             WHERE LDL_ApplicationID = @LDL_ApplicationID;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDL_ApplicationID", LDL_ApplicationID);

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

        public static bool IsApplicantHasDoubleSameApp(int ApplicantPersonID, int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // this fuction will returns true when RowsAffected > 0 and flase if not 

            bool isFound = false;

            string query = @"SELECT isFound=1  FROM  Applications INNER JOIN

                                 LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID INNER JOIN

                                             LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID

                                                        WHERE  (Applications.ApplicationStatus != 4)
                                                                         AND 
                                                               (LicenseClasses.LicenseClassID = @LicenseClassID) 
                                                                         AND 
                                                                (Applications.ApplicantPersonID = @ApplicantPersonID);";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
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
