using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsTestAppointment
    {
        private enum enMode { AddNew, Update };
        private enMode Mode = enMode.AddNew;

        public int TestAppointmentID { get; set; }

        public int TestTypeID { get; set; }

        public int LocalDrivingLicenseApplicationID { get; set; }

        public DateTime AppointmentDate { get; set; }

        public int PaidFees { get; set; }

        public int CreatedByUserID { get; set; }

        public bool IsLocked { get; set; }


        public clsTestAppointment()
        {
            Mode = enMode.AddNew;

            TestAppointmentID = -1;

            TestTypeID = -1;

            AppointmentDate = DateTime.Now;

            LocalDrivingLicenseApplicationID = -1;

            IsLocked = false;

            PaidFees = -1;

            CreatedByUserID = -1;

        }

        private clsTestAppointment(int TestAppointmentID, int TestTypeID ,int LocalDrivingLicenseApplicationID

            , DateTime AppointmentDate, int PaidFees, int CreatedByUserID, bool IsLocked)
        {

            Mode = enMode.Update;

            this.TestAppointmentID = TestAppointmentID;

            this.TestTypeID = TestTypeID;

            this.AppointmentDate = AppointmentDate;

            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;

            this.IsLocked = IsLocked;

            this.PaidFees = PaidFees;

            this.CreatedByUserID = CreatedByUserID;
        }

        private bool _AddNewTestAppointment()
        {
            this.TestAppointmentID = clsTestAppointmentDataAccess.AddNewTestAppointment(TestTypeID,  LocalDrivingLicenseApplicationID,
              AppointmentDate, PaidFees,   CreatedByUserID,   IsLocked);

            return (this.TestAppointmentID != -1);
        }

        private bool _UpdateTestAppointment()
        {
            return clsTestAppointmentDataAccess.UpdateTestAppointment(TestAppointmentID,  TestTypeID,  LocalDrivingLicenseApplicationID,
              AppointmentDate, PaidFees,   CreatedByUserID,   IsLocked);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestAppointment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateTestAppointment();

            }
            return false;
        }

        static public clsTestAppointment Find(int TestAppointmentID)
        {

            DateTime AppointmentDate = DateTime.Now;

            int TestTypeID = -1;

            int LocalDrivingLicenseApplicationID = -1;

            bool IsLocked = false;

            int PaidFees = -1;

            int CreatedByUserID = -1;

            if (clsTestAppointmentDataAccess.GetTestAppointmentByID(ref TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID,
              ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked))
            {
                return new clsTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID
            , AppointmentDate, PaidFees, CreatedByUserID, IsLocked);
            }
            else
            {
                return null;
            }
        }

        static public bool DeleteTestAppointment(int TestAppointmentID)
        {
            return clsTestAppointmentDataAccess.DeleteTestAppointment(TestAppointmentID);
        }

        static public DataTable GetAllTestAppointments(int LocalDrivingLicenseApplicationID,int TestTypeID )
        {
            return clsTestAppointmentDataAccess.GetAllTestAppointmentsOfApplication(LocalDrivingLicenseApplicationID, TestTypeID);
        }

        static public bool IsTestAppointmentExists(int TestAppointmentID)
        {
            return clsTestAppointmentDataAccess.IsTestAppointmentExists(TestAppointmentID);
        }

        static public bool IsTestAppointmentExists(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsTestAppointmentDataAccess.IsTestAppointmentExists(LocalDrivingLicenseApplicationID, TestTypeID);
        }

        static public bool IsTestAppointmentLocked(int TestAppointmentID, int TestTypeID)
        {
            return clsTestAppointmentDataAccess.IsTestAppointmentLocked(TestAppointmentID,  TestTypeID);
        }
        static public bool IsTestAppointmentUnLockedByLDL_App(int LocalDrivingLicenseApplicationID,int TestTypeID)
        {
            return clsTestAppointmentDataAccess.IsTestAppointmentUnLockedByLDL_App(LocalDrivingLicenseApplicationID,TestTypeID);
        }
        
    }
}
