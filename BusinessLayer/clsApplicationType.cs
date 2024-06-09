using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsApplicationType
    {
        private enum enMode { AddNew, Update };
        private enMode _Mode = enMode.AddNew;
        public int ApplicationTypeID { get; set; }
        public int ApplicationFees { get; set; }
        public string ApplicationTypeTitle { get; set; }

        private clsApplicationType()
        {
            _Mode = enMode.AddNew;
            ApplicationTypeID = -1;
            ApplicationFees = -1;
            ApplicationTypeTitle = "";
        }

        private clsApplicationType(int ApplicationTypeID,string ApplicationTypeTitle,int ApplicationFees)
        {
            _Mode = enMode.Update;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationFees = ApplicationFees;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
        }

        static public clsApplicationType Find(int ApplicationTypeID)
        {

            int ApplicationFees = -1;

            string ApplicationTypeTitle = "";

            if (clsApplicationTypeDataAccess.GetApplicationTypeByID(ref ApplicationTypeID, ref ApplicationTypeTitle, ref ApplicationFees))
            {
                return new clsApplicationType(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
            }
            else
            {
                return null;
            }
        }

        private bool _UpdateApplicationType()
        {
            return clsApplicationTypeDataAccess.UpdateApplicationType(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    break;
                case enMode.Update:

                    return _UpdateApplicationType();

            }
            return false;
        }

        static public DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypeDataAccess.GetAllApplicationTypes();
        }
    }
}
