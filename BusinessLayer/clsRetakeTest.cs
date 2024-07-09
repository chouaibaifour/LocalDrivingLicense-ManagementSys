using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsRetakeTest
    {
        private enum enMode { AddNew, Update };
        private enMode Mode = enMode.AddNew;
        public int RetakeTestID { get; set; }
        public int ApplicationID { get; set; }
        public int TestAppointmentID { get; set; }


        public clsRetakeTest()
        {
            Mode = enMode.AddNew;

            RetakeTestID = -1;
            ApplicationID = -1;
            TestAppointmentID =-1;
            

        }

        private clsRetakeTest(int RetakeTestID, int ApplicationID, int TestAppointmentID)
        {

            this.RetakeTestID = RetakeTestID;
            this.ApplicationID = ApplicationID;
            this.TestAppointmentID = TestAppointmentID;

            Mode = enMode.Update;
        }

        private bool _AddNewRetakeTest()
        {
            this.RetakeTestID = clsRetakeTestDataAccess.AddNewRetakeTest(ApplicationID, TestAppointmentID);

            return (this.RetakeTestID != -1);
        }

        private bool _UpdateRetakeTest()
        {
            return clsRetakeTestDataAccess.UpdateRetakeTest(RetakeTestID, ApplicationID, TestAppointmentID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRetakeTest())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateRetakeTest();

            }
            return false;
        }

        static public clsRetakeTest Find(int RetakeTestID)
        {


            int ApplicationID = -1;
            int TestAppointmentID =-1;
            string Password = "";
            bool isActive = false;

            if (clsRetakeTestDataAccess.GetRetakeTestByID(ref RetakeTestID, ref ApplicationID, ref TestAppointmentID))
            {
                return new clsRetakeTest(RetakeTestID, ApplicationID, TestAppointmentID);
            }
            else
            {
                return null;
            }
        }

        static public clsRetakeTest FindByAppointmentID(int TestAppointmentID)
        {

            int RetakeTestID = -1;
            int ApplicationID = -1;


            if (clsRetakeTestDataAccess.GetRetakeTestByTestAppointmentID(ref RetakeTestID, ref ApplicationID, ref TestAppointmentID))
            {
                return new clsRetakeTest(RetakeTestID, ApplicationID, TestAppointmentID);
            }
            else
            {
                return null;
            }
        }

        static public bool DeleteRetakeTest(int RetakeTestID)
        {
            return clsRetakeTestDataAccess.DeleteRetakeTest(RetakeTestID);
        }

        static public DataTable GetAllRetakeTests()
        {
            return clsRetakeTestDataAccess.GetAllRetakeTests();
        }

        static public bool IsRetakeTestExists(int RetakeTestID)
        {
            return clsRetakeTestDataAccess.IsRetakeTestExists(RetakeTestID);
        }
        static public bool IsRetakeTestExistsbyAppointmentID(int TestAppointmentID)
        {
            return clsRetakeTestDataAccess.IsRetakeTestExistsByAppointmentID(TestAppointmentID);
        }
    }
}
