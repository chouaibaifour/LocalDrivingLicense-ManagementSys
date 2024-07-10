using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsInternationalLicense
    {
        private enum enMode { AddNew, Update };
        private enMode Mode = enMode.AddNew;
        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public clsInternationalLicense()
        {
            Mode = enMode.AddNew;

            InternationalLicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            IssuedUsingLocalLicenseID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            IsActive = false;
            CreatedByUserID = -1;
        }

        private clsInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID,
             DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {

            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
            Mode = enMode.Update;
        }

        private bool _AddNewInternationalLicense()
        {
            this.InternationalLicenseID = clsInternationalLicenseDataAccess.AddNewInternationalLicense(ApplicationID, DriverID, IssuedUsingLocalLicenseID,
              IssueDate, ExpirationDate, IsActive, CreatedByUserID);

            return (this.InternationalLicenseID != -1);
        }

        private bool _UpdateInternationalLicense()
        {
            return clsInternationalLicenseDataAccess.UpdateInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID,
              IssueDate, ExpirationDate, IsActive, CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInternationalLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateInternationalLicense();

            }
            return false;
        }

        static public clsInternationalLicense Find(int InternationalLicenseID)
        {


           
            int ApplicationID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            bool IsActive = false;
            int CreatedByUserID = -1;

            if (clsInternationalLicenseDataAccess.GetInternationalLicenseByID(ref InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID,
              ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID)) 
            {
                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID,
              IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

       

        static public bool DeleteInternationalLicense(int InternationalLicenseID)
        {
            return clsInternationalLicenseDataAccess.DeleteInternationalLicense(InternationalLicenseID);
        }

        static public DataTable GetAllInternationalLicenses()
        {
            return clsInternationalLicenseDataAccess.GetAllInternationalLicenses();
        }

        static public bool IsInternationalLicenseExists(int InternationalLicenseID)
        {
            return clsInternationalLicenseDataAccess.IsInternationalLicenseExists(InternationalLicenseID);
        }

        public static bool IsInternationalLicenseExistsByLocalLicenseID(int LicenseID)
        {
            return clsInternationalLicenseDataAccess.IsInternationalLicenseExistsByLocalLicenseID(LicenseID);
        }

        public static DataTable GetAllInternationalLicensesOfPerson(int personID)
        {
            return clsInternationalLicenseDataAccess.GetAllInternationalLicensesOfPerson(personID);
        }
    }
}
