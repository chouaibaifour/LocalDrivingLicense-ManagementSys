using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DataAccessLayer
{
    public static class clsDetainedLicenseDataAccess
    {
        static public bool GetDetainByID(ref int DetainID, ref int LicenseID, ref DateTime DetainDate, ref int FineFees, ref int CreatedByUserID,
            ref bool IsReleased, ref DateTime ReleaseDate ,ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT   DetainID, LicenseID, DetainDate, CAST(FineFees AS int) AS FineFees, CreatedByDetainID,
                                                    IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID
                                                            FROM    DetainedLicenses
                                                                    WHERE    (DetainID = @DetainID)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DetainID", DetainID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    // the User Was Successfully Found

                    isFound = true;

                    DetainID = (int)reader["DetainID"];

                    LicenseID = (int)reader["LicenseID"];

                    DetainDate = (DateTime)reader["DetainDate"];

                    FineFees = (int)reader["FineFees"];

                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    IsReleased = (bool)reader["IsReleased"];

                    ReleasedByUserID = (int)reader["ReleasedByUserID"];

                    ReleaseDate = (DateTime)reader["ReleaseDate"];

                    ReleaseApplicationID = (int)reader["ReleaseApplicationID"];

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

        static public bool GetDetainLicenseByLicenseID(ref int DetainID, ref int LicenseID, ref DateTime DetainDate, ref int FineFees, ref int CreatedByUserID,
           ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT   DetainID, LicenseID, DetainDate, CAST(FineFees AS int) AS FineFees, CreatedByDetainID,
                                                    IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID
                                                            FROM    DetainedLicenses
                                                                    WHERE    (LicenseID = @LicenseID)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    // the User Was Successfully Found

                    isFound = true;

                    DetainID = (int)reader["DetainID"];

                    LicenseID = (int)reader["LicenseID"];

                    DetainDate = (DateTime)reader["DetainDate"];

                    FineFees = (int)reader["FineFees"];

                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    IsReleased = (bool)reader["IsReleased"];

                    ReleaseDate = (DateTime)reader["ReleaseDate"];

                    ReleasedByUserID = (int)reader["ReleasedByUserID"];

                    ReleaseApplicationID = (int)reader["ReleaseApplicationID"];

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

        static public int AddNewDetainLicense(int LicenseID, DateTime DetainDate, int FineFees, int CreatedByUserID,
             bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            // the function will returns UserID or -1 if not 
            int UserID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO DetainedLicenses
                                   (LicenseID
                                   ,DetainDate
                                   ,FineFees
                                   ,CreatedByUserID
                                   ,IsReleased
                                   ,ReleaseDate
                                   ,ReleasedByUserID
                                   ,ReleaseApplicationID)
                             VALUES
                                   (@LicenseID
                                   ,@DetainDate
                                   ,@FineFees
                                   ,@CreatedByUserID
                                   ,@IsReleased
                                   ,@ReleaseDate
                                   ,@ReleasedByUserID
                                   ,@ReleaseApplicationID);
                               SELECT SCOPE_IDENTITY(); ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            command.Parameters.AddWithValue("@DetainDate", DetainDate);

            command.Parameters.AddWithValue("@FineFees", FineFees);

            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            command.Parameters.AddWithValue("@IsReleased", IsReleased);

            command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);

            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);

            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != DBNull.Value && int.TryParse(result.ToString(), out int InsertedID))
                {
                    UserID = InsertedID;
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

            return UserID;

        }

        static public bool UpdateDetainLicense(int DetainID, int LicenseID, DateTime DetainDate, int FineFees, int CreatedByUserID,
             bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int RowsAffected = -1;
            // this function returns true if Rows affected > 0 or false if no RowsAffected

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE DetainedLicenses
		                                    SET
                                                LicenseID = @LicenseID

                                               ,DetainDate = @DetainDate

                                               ,FineFees = @FineFees

                                               ,CreatedByUserID = @CreatedByUserID

                                               ,IsReleased = @IsReleased

                                               ,ReleaseDate = @ReleaseDate

                                               ,ReleasedByUserID = @ReleasedByUserID

                                               ,ReleaseApplicationID = @ReleaseApplicationID

					                                    WHERE (DetainID = @DetainID);";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@DetainID", DetainID);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            command.Parameters.AddWithValue("@DetainDate", DetainDate);

            command.Parameters.AddWithValue("@FineFees", FineFees);

            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            command.Parameters.AddWithValue("@IsReleased", IsReleased);

            command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);

            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);

            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

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

        static public bool DeleteDetainLicense(int DetainID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // this fuction will returns true when RowsAffected > 0 and flase if not 

            int RowsAffected = 0;

            string query = @"DELETE FROM DetainedLicenses
                                         WHERE ( DetainID = @DetainID)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);

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

        public static DataTable GetAllDetainLicenses()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT   DetainedLicenses.DetainID, DetainedLicenses.LicenseID, DetainedLicenses.DetainDate, DetainedLicenses.IsReleased,
                                            DetainedLicenses.FineFees, DetainedLicenses.ReleaseDate, People.NationalNumber, 
                                                 COALESCE (People.FirstName, '') + ' ' +
                                                 COALESCE (People.SecondName, '') + ' ' +
                                                 COALESCE (People.ThirdName, '') + ' ' + 
                                                 COALESCE (People.LastName, '') AS FullName, DetainedLicenses.ReleaseApplicationID
                                                         FROM            People INNER JOIN
                                                             Applications ON People.PersonID = Applications.ApplicantPersonID INNER JOIN
                                                             Licenses ON Applications.ApplicationID = Licenses.ApplicationID INNER JOIN
                                                             DetainedLicenses ON Licenses.LicenseID = DetainedLicenses.LicenseID";

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

        public static bool IsDetainLicenseExists(int DetainID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // this fuction will returns true when RowsAffected > 0 and flase if not 

            bool isFound = false;

            string query = @"SELECT IsFound=1 FROM DetainedLicenses
                             WHERE DetainID = @DetainID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);

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

        public static bool IsDetainLicenseExistsByLicense(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // this fuction will returns true when RowsAffected > 0 and flase if not 

            bool isFound = false;

            string query = @"SELECT IsFound=1 FROM DetainedLicenses
                             WHERE LicenseID = @LicenseID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

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

        public static bool IsReleased(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // this fuction will returns true when RowsAffected > 0 and flase if not 

            bool isFound = false;

            string query = @"SELECT IsFound=1 FROM DetainedLicenses
                             WHERE (LicenseID = @LicenseID AND IsReleased = 1)";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

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
