using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessLayer
{
    public class clsLicense
    {
        private enum enMode { AddNew, Update };
        private enMode Mode = enMode.AddNew;

        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClassID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public int PaidFees { get; set; }
        public bool IsActive { get; set; }
        public byte IssueReason { get; set; }
        public int CreatedByUserID { get; set; }

        public clsLicense()
        {
            Mode = enMode.AddNew;

            LicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            LicenseClassID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            Notes = "";
            PaidFees = -1;
            IsActive = false;
            IssueReason = 1;
            CreatedByUserID = -1;
        }

        private clsLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate,
             DateTime ExpirationDate, string Notes, int PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {

            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClassID = LicenseClassID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
            
            Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            this.LicenseID = clsLicenseDataAccess.AddNewLicense(ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes,
                PaidFees, IsActive, IssueReason, CreatedByUserID);

            return (this.LicenseID != -1);
        }

        private bool _UpdateUser()
        {
            return clsLicenseDataAccess.UpdateLicense(LicenseID ,ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes,
                PaidFees, IsActive, IssueReason, CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUser();

            }
            return false;
        }

        static public clsLicense Find(int LicenseID)
        {
            int ApplicationID = -1;

            int DriverID = -1;

            int LicenseClassID = -1;

            DateTime IssueDate = DateTime.Now;

            DateTime ExpirationDate = DateTime.Now;

            string Notes = "";

            int PaidFees = -1;

            bool IsActive = false;

            byte IssueReason = 1;

            int CreatedByUserID = -1;

            if (clsLicenseDataAccess.GetLicenseByID(ref LicenseID, ref ApplicationID, ref DriverID, ref LicenseClassID, ref IssueDate, ref ExpirationDate,
                ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID)) 
            {
                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes,
                PaidFees, IsActive, IssueReason, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        static public clsLicense FindByApplicationID(int ApplicationID)
        {
            int LicenseID = -1;

            int DriverID = -1;

            int LicenseClassID = -1;

            DateTime IssueDate = DateTime.Now;

            DateTime ExpirationDate = DateTime.Now;

            string Notes = "";

            int PaidFees = -1;

            bool IsActive = false;

            byte IssueReason = 1;

            int CreatedByUserID = -1;

            if (clsLicenseDataAccess.GetLicenseByApplicationID(ref LicenseID, ref ApplicationID, ref DriverID, ref LicenseClassID, ref IssueDate, ref ExpirationDate,
                ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes,
                PaidFees, IsActive, IssueReason, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        static public bool DeleteLicense(int LicenseID)
        {
            return clsLicenseDataAccess.DeleteLicense(LicenseID);
        }

        static public DataTable GetAllLicenses()
        {
            return clsLicenseDataAccess.GetAllLicenses();
        }

        static public bool IsLicenseExists(int LicenseID)
        {
            return clsLicenseDataAccess.IsLicenseExists(LicenseID);
        }
        static public bool IsLicenseExistsByApplicationID(int ApplicationID)
        {
            return clsLicenseDataAccess.IsLicenseExistsByApplicationID(ApplicationID);
        }

        public static DataTable GetAllLicensesOfPerson(int personID)
        {
            return clsLicenseDataAccess.GetAllLicensesOfPerson(personID);
        }

        public static bool IsLicenseActive(int LicenseID)
        {
            return clsLicenseDataAccess.IsLicenseActive(LicenseID);
        }

        public static bool isExpired(int issuedUsingLicenseID)
        {
           return clsLicenseDataAccess.isExpired(issuedUsingLicenseID);
        }
    }
}
