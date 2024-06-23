using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class cls_LDL_Application
    {
        private enum enMode { AddNew, Update };
        private enMode Mode = enMode.AddNew;
        public int LDL_ApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        public cls_LDL_Application()
        {
            Mode = enMode.AddNew;

            LDL_ApplicationID = -1;

            ApplicationID = -1;

            LicenseClassID = -1;

        }

        private cls_LDL_Application(int LDL_ApplicationID, int ApplicationID, int LicenseClassID)
        {

            Mode = enMode.Update;
            this.LDL_ApplicationID = LDL_ApplicationID;
            this.ApplicationID = ApplicationID;

            this.LicenseClassID = LicenseClassID;
        }

        private bool _AddNewApplication()
        {
            this.LDL_ApplicationID = cls_LDL_ApplicationDataAccess.AddNewApplication(ApplicationID, LicenseClassID);

            return (this.LDL_ApplicationID != -1);
        }

        private bool _UpdateApplication()
        {
            return cls_LDL_ApplicationDataAccess.UpdateApplication(LDL_ApplicationID, ApplicationID,LicenseClassID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateApplication();

            }
            return false;
        }

        static public cls_LDL_Application Find(int LDL_ApplicationID)
        {

            int ApplicationID = -1;

            int LicenseClassID = -1;

            if (cls_LDL_ApplicationDataAccess.GetApplicationByID(ref LDL_ApplicationID, ref ApplicationID, ref LicenseClassID))
            {
                return new cls_LDL_Application(LDL_ApplicationID, ApplicationID, LicenseClassID);
            }
            else
            {
                return null;
            }
        }

        static public bool DeleteApplication(int LDL_ApplicationID)
        {
            return cls_LDL_ApplicationDataAccess.DeleteApplication(LDL_ApplicationID);
        }

        static public DataTable GetAllApplications()
        {
            return cls_LDL_ApplicationDataAccess.GetAllApplications();
        }

        static public bool IsApplicationExists(int LDL_ApplicationID)
        {
            return cls_LDL_ApplicationDataAccess.IsApplicationExists(LDL_ApplicationID);
        }

        public static bool IsApplicantHasDoubleSameApp(int applicantPersonID, int licenseClassID, byte[] bytes)
        {
            return cls_LDL_ApplicationDataAccess.IsApplicantHasDoubleSameApp(applicantPersonID, licenseClassID, bytes);
        }
    }
}
