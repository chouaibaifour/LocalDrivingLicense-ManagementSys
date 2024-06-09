using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsTestType
    {
        private enum enMode { AddNew, Update };
        private enMode _Mode = enMode.AddNew;
        public int TestTypeID { get; set; }
        public int TestFees { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }

        private clsTestType()
        {
            _Mode = enMode.AddNew;
            TestTypeID = -1;
            TestFees = -1;
            TestTypeTitle = "";
            TestTypeDescription = "";
        }

        private clsTestType(int TestTypeID,string TestTypeTitle,string TestTypeDescription,int TestFees)
        {
            _Mode = enMode.Update;
            this.TestTypeID = TestTypeID;
            this.TestFees = TestFees;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
        }

        static public clsTestType Find(int TestTypeID)
        {

            int TestFees = -1;

            string TestTypeTitle = "";

            string TestTypeDescription = "";

            if (clsTestTypeDataAccess.GetTestTypeByID(ref TestTypeID, ref TestTypeTitle, ref TestTypeDescription, ref TestFees))
            {
                return new clsTestType(TestTypeID, TestTypeTitle, TestTypeDescription, TestFees);
            }
            else
            {
                return null;
            }
        }

        private bool _UpdateTestType()
        {
            return clsTestTypeDataAccess.UpdateTestType(TestTypeID, TestTypeTitle, TestTypeDescription, TestFees);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    break;
                case enMode.Update:

                    return _UpdateTestType();

            }
            return false;
        }

        static public DataTable GetAllTestTypes()
        {
            return clsTestTypeDataAccess.GetAllTestTypes();
        }
    }
}
