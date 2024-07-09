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
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public int MinimumAllowedAge { get; set; }
        public int DefaultValidityLength { get; set; }
        public int ClassFees { get; set; }

        public clsLicenseClass()
        {
            Mode = enMode.AddNew;

            LicenseClassID = -1;
            ClassName = "";
            ClassDescription = "";
            MinimumAllowedAge = -1;
            DefaultValidityLength = -1;
            ClassFees = -1;

        }

        private clsLicenseClass(int LicenseClassID, string ClassName, string ClassDescription,
            int MinimumAllowedAge, int DefaultValidityLength, int ClassFees)
        {

            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;

            Mode = enMode.Update;
        }

        private bool _AddNewLicenseClass()
        {
            this.LicenseClassID = clsLicenseClassDataAccess.AddNewLicenseClass(ClassName, ClassDescription
            , MinimumAllowedAge, DefaultValidityLength, ClassFees);

            return (this.LicenseClassID != -1);
        }

        private bool _UpdateLicenseClass()
        {
            return clsLicenseClassDataAccess.UpdateLicenseClass(LicenseClassID,ClassName, ClassDescription
            , MinimumAllowedAge, DefaultValidityLength, ClassFees);
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

            string ClassName = "";
            string ClassDescription = "";
            int MinimumAllowedAge = -1;
            int DefaultValidityLength=-1;
            int ClassFees = -1;


            if (clsLicenseClassDataAccess.GetLicenseClassByID(ref LicenseClassID, ref ClassName,  ref  ClassDescription
            , ref  MinimumAllowedAge, ref  DefaultValidityLength, ref  ClassFees))
            {
                return new clsLicenseClass(LicenseClassID,ClassName, ClassDescription
            , MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else
            {
                return null;
            }
        }

        static public clsLicenseClass Find(string ClassName)
        {

            int LicenseClassID = -1;
            string ClassDescription = "";
            int MinimumAllowedAge = -1;
            int DefaultValidityLength = -1;
            int ClassFees = -1;


            if (clsLicenseClassDataAccess.GetLicenseClassByID(ref LicenseClassID, ref ClassName, ref ClassDescription
            , ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription
            , MinimumAllowedAge, DefaultValidityLength, ClassFees);
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
