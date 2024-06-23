using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsApplication
    {
        private enum enMode { AddNew, Update };
        private enMode Mode = enMode.AddNew;

        public  enum enStatus
        {
            New=1,
            InProgerss=2,
            Completed=3,
            Canceled=4
        }

        

        public int ApplicationID  {get;set;} 

        public int ApplicantPersonID  {get;set;}

        public DateTime ApplicationDate  {get;set;}

        public int ApplicationTypeID  {get;set;}

        public byte ApplicationStatus  {get;set;} 

        public DateTime LastStatusDate  {get;set;} 

        public int PaidFees  {get;set;}

        public int CreatedByUserID  {get;set;}

        public clsApplication()
        {
            Mode = enMode.AddNew;

            ApplicationID = -1;

            ApplicantPersonID = -1;

            ApplicationDate = DateTime.Now;

            ApplicationTypeID = -1;

            ApplicationStatus = (byte)enStatus.New;

            LastStatusDate = DateTime.Now;

            PaidFees = -1;

            CreatedByUserID = -1;

        }

        private clsApplication( int ApplicationID,  int ApplicantPersonID,  DateTime ApplicationDate, int ApplicatinTypeID,

            byte ApplicationStatus,  DateTime LastStatusDate,  int PaidFees,  int CreatedByUserID)
        {

            Mode = enMode.Update;

            this.ApplicationID = ApplicationID;

            this.ApplicantPersonID = ApplicantPersonID;

            this.ApplicationDate = ApplicationDate;

            this.ApplicationTypeID = ApplicatinTypeID;

            this.ApplicationStatus = ApplicationStatus;

            this.LastStatusDate = LastStatusDate;

            this.PaidFees = PaidFees;

            this.CreatedByUserID = CreatedByUserID;
        }

        private bool _AddNewApplication()
        {
            this.ApplicationID = clsApplicationDataAccess.AddNewApplication( ApplicantPersonID, ApplicationDate,
             ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);

            return (this.ApplicationID != -1);
        }

        private bool _UpdateApplication()
        {
            return clsApplicationDataAccess.UpdateApplication(ApplicationID, ApplicantPersonID, ApplicationDate,
              ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
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

        static public clsApplication Find(int ApplicationID)
        {

            int ApplicantPersonID = -1;

            DateTime ApplicationDate = DateTime.Now;

            int ApplicatinTypeID = -1;

            byte ApplicationStatus=255;

            DateTime LastStatusDate = DateTime.Now;

            int PaidFees = -1;

            int CreatedByUserID = -1;

            if (clsApplicationDataAccess.GetApplicationByID(ref ApplicationID, ref ApplicantPersonID,ref  ApplicationDate,
              ref ApplicatinTypeID,ref  ApplicationStatus, ref LastStatusDate,ref  PaidFees, ref CreatedByUserID))
            {
                return new clsApplication(ApplicationID, ApplicantPersonID, ApplicationDate,
              ApplicatinTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        static public clsApplication Find(int ApplicantPersonID, int ApplicationID =-1)
        {

            DateTime ApplicationDate = DateTime.Now;

            int ApplicatinTypeID = -1;

            byte ApplicationStatus = 255;

            DateTime LastStatusDate = DateTime.Now;

            int PaidFees = -1;

            int CreatedByUserID = -1;

            if (clsApplicationDataAccess.GetApplicationByApplicantID(ref ApplicationID, ref ApplicantPersonID, ref ApplicationDate,
              ref ApplicatinTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {
                return new clsApplication(ApplicationID, ApplicantPersonID, ApplicationDate,
              ApplicatinTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        static public bool DeleteApplication(int ApplicationID)
        {
            return clsApplicationDataAccess.DeleteApplication(ApplicationID);
        }

        static public DataTable GetAllApplications()
        {
            return clsApplicationDataAccess.GetAllApplications();
        }

        static public bool IsApplicationExists(int ApplicationID)
        {
            return clsApplicationDataAccess.IsApplicationExists(ApplicationID);
        }

        static public bool IsApplicationExistsbyApplicantID(int PersonID)
        {
            return clsApplicationDataAccess.IsApplicationExistsbyApplicantID(PersonID);
        }
    }
}
