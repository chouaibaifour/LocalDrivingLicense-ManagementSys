using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsLicenseClass
    {
        //LicenseClassID
        //LicenseClassName

        private enum enMode { AddNew, Update };
        private enMode Mode = enMode.AddNew;

        public int LicenseClassID { get; set; }
        public string LicenseClassName { get; set; }

        public clsLicenseClass()
        {
            Mode = enMode.AddNew;

            LicenseClassID = -1;
            LicenseClassName = "";

        }

        private clsLicenseClass(int LicenseClassID, string LicenseClassName)
        {

            this.LicenseClassID = LicenseClassID;
            this.LicenseClassName = LicenseClassName;

            Mode = enMode.Update;
        }

        private bool _AddNewLicenseClass()
        {
            this.LicenseClassID = clsLicenseClassDataAccess.AddNewLicenseClass(LicenseClassName);

            return (this.LicenseClassID != -1);
        }

        private bool _UpdateLicenseClass()
        {
            return clsLicenseClassDataAccess.UpdateLicenseClass(LicenseClassID, LicenseClassName);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicenseClass())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateLicenseClass();

            }
            return false;
        }

        static public clsLicenseClass Find(int LicenseClassID)
        {

            string LicenseClassName = "";


            if (clsLicenseClassDataAccess.GetLicenseClassByID(ref LicenseClassID, ref LicenseClassName))
            {
                return new clsLicenseClass(LicenseClassID, LicenseClassName);
            }
            else
            {
                return null;
            }
        }

        static public clsLicenseClass Find(string LicenseClassName)
        {

            int LicenseClassID = -1;

            if (clsLicenseClassDataAccess.GetLicenseClassByLicenseClassName(ref LicenseClassID, ref LicenseClassName))
            {
                return new clsLicenseClass(LicenseClassID, LicenseClassName);
            }
            else
            {
                return null;
            }
        }

        static public bool DeleteLicenseClass(int LicenseClassID)
        {
            return clsLicenseClassDataAccess.DeleteLicenseClass(LicenseClassID);
        }

        static public DataTable GetAllLicenseClasses()
        {
            return clsLicenseClassDataAccess.GetAllLicenseClasses();
        }

        static public bool IsLicenseClassExists(int LicenseClassID)
        {
            return clsLicenseClassDataAccess.IsLicenseClassExists(LicenseClassID);
        }

    }
}
