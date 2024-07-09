using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsTest
    {
        private enum enMode { AddNew, Update };
        private enMode Mode = enMode.AddNew;
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }
        public bool TestResult { get; set; }

        public clsTest()
        {
            Mode = enMode.AddNew;

            TestID = -1;
            TestAppointmentID = -1;
            Notes = "";
            CreatedByUserID = -1;
            TestResult = false;

        }

        private clsTest(int TestID, int TestAppointmentID, string Notes, int CreatedByUserID, bool TestResult)
        {

            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
            this.TestResult = TestResult;
            Mode = enMode.Update;
        }

        private bool _AddNewTest()
        {
            this.TestID = clsTestDataAccess.AddNewTest(TestAppointmentID, TestResult, Notes, CreatedByUserID);

            return (this.TestID != -1);
        }

        private bool _UpdateTest()
        {
            return clsTestDataAccess.UpdateTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTest())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateTest();

            }
            return false;
        }

        static public clsTest Find(int TestID)
        {


            int TestAppointmentID = -1;
            string Notes = "";
            int CreatedByUserID = -1;
            bool TestResult = false;

            if (clsTestDataAccess.GetTestByID(ref TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
            {
                return new clsTest(TestID, TestAppointmentID, Notes, CreatedByUserID, TestResult);
            }
            else
            {
                return null;
            }
        }

        static public clsTest FindByTestAppointment(int TestAppointmentID)
        {

            int TestID = -1;
           
            string Notes = "";
            int CreatedByUserID = -1;
            bool TestResult = false;

            if (clsTestDataAccess.GetTestByTestAppointment(ref TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
            {
                return new clsTest(TestID, TestAppointmentID, Notes, CreatedByUserID, TestResult);
            }
            else
            {
                return null;
            }
        }

        static public bool DeleteTest(int TestID)
        {
            return clsTestDataAccess.DeleteTest(TestID);
        }

        static public DataTable GetAllTests()
        {
            return clsTestDataAccess.GetAllTests();
        }

        static public bool IsTestExists(int TestID)
        {
            return clsTestDataAccess.IsTestExists(TestID);
        }
        static public bool IsTestExistsbyTestAppointmentID(int TestAppointmentID)
        {
            return clsTestDataAccess.IsTestExistsbyTestAppointmentID(TestAppointmentID);
        }

        static public bool IsTestPassed(int TestID)
        {
            return clsTestDataAccess.IsTestPassed(TestID);
        }
        static public bool IsTestPassedbyTestAppointmentID(int TestAppointmentID)
        {
            return clsTestDataAccess.IsTestPassedbyTestAppointmentID(TestAppointmentID);
        }

        static public bool IsTestPassed(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            
            return clsTestDataAccess.IsTestPassed(LocalDrivingLicenseApplicationID, TestTypeID);
        }

        static public int Trials(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsTestDataAccess.Trials(LocalDrivingLicenseApplicationID, TestTypeID);
        }

        public static int PassedTests(int lDL_Application)
        {
           return clsTestDataAccess.PassedTests(lDL_Application);
        }
    }
}
