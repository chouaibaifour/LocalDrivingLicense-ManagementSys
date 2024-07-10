using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsDetianedLicense
    {
        private enum enMode { AddNew, Update };
        private enMode Mode = enMode.AddNew;

        private int DetainID {  get; set; }
        private int LicenseID { get; set; }
        private DateTime DetainDate { get; set; }
        private int FineFees { get; set; }  
        private int CreatedByUserID { get; set; }
        private bool IsReleased { get; set; }
        private DateTime ReleaseDate { get; set; }
        private int ReleasedByUserID { get; set; }
        private int ReleaseApplicationID { get; set; }


        public clsDetianedLicense()
        {
            Mode = enMode.AddNew;
            DetainID = -1;
            LicenseID = -1;
            DetainDate = DateTime.Now;
            FineFees = -1;
            CreatedByUserID = -1;
            IsReleased = false;
            ReleaseDate = DateTime.Now;
            ReleasedByUserID = -1;
            ReleaseApplicationID = -1;
        }

        private clsDetianedLicense(int detainID, int licenseID, DateTime detainDate, int fineFees, int createdByUserID,
            bool isReleased, DateTime releaseDate, int releasedByUserID, int releaseApplicationID)
        {
            Mode = enMode.Update;
            DetainID = detainID;
            LicenseID = licenseID;
            DetainDate = detainDate;
            FineFees = fineFees;
            CreatedByUserID = createdByUserID;
            IsReleased = isReleased;
            ReleaseDate = releaseDate;
            ReleasedByUserID = releasedByUserID;
            ReleaseApplicationID = releaseApplicationID;
        }

        private bool _AddNewDetainLicense()
        {
            this.DetainID= clsDetainedLicenseDataAccess.AddNewDetainLicense(LicenseID,DetainDate,FineFees,CreatedByUserID,IsReleased,ReleaseDate, ReleasedByUserID,
                ReleaseApplicationID);
            return (DetainID != -1);
        }

        private bool _UpdateDetainLicense()
        {
            return clsDetainedLicenseDataAccess.UpdateDetainLicense(DetainID, LicenseID,DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID,
                ReleaseApplicationID);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDetainLicense())
                    {
                       
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;

                    }
                case enMode.Update:

                    return _UpdateDetainLicense();
            }

            return false;
        }

        public static clsDetianedLicense Find(int DetainID)
        {
            int LicenseID = -1;

            DateTime DetainDate = DateTime.Now;

            int FineFees = -1;

            int CreatedByUserID = -1;

            bool IsReleased = false;

            DateTime ReleaseDate = DateTime.Now;

            int ReleasedByUserID = -1;

            int ReleaseApplicationID = -1;

            if (clsDetainedLicenseDataAccess.GetDetainByID(ref DetainID, ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID,
                ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))

                return new clsDetianedLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate,
                    ReleasedByUserID, ReleaseApplicationID);

            else
                return null;

                   
        }

        public static clsDetianedLicense FindByLicense(int LicenseID)
        {
            int DetainID = -1;

            DateTime DetainDate = DateTime.Now;

            int FineFees = -1;

            int CreatedByUserID = -1;

            bool IsReleased = false;

            DateTime ReleaseDate = DateTime.Now;

            int ReleasedByUserID = -1;

            int ReleaseApplicationID = -1;

            if (clsDetainedLicenseDataAccess.GetDetainLicenseByLicenseID(ref DetainID, ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID,
                ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))

                return new clsDetianedLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate,
                    ReleasedByUserID, ReleaseApplicationID);

            else
                return null;


        }

        public static bool DeleteDetainLicense(int DetainID)
        {
            return clsDetainedLicenseDataAccess.DeleteDetainLicense(DetainID);
        }

        public static DataTable GetAllDetainLicenses()
        {
            return clsDetainedLicenseDataAccess.GetAllDetainLicenses();
        }

        public bool isDetainLicenseExists(int DetainID)
        {
            return clsDetainedLicenseDataAccess.IsDetainLicenseExists(DetainID);

        }

        public bool isDetainLicenseExistsByLicense(int LicenseID)
        {
            return clsDetainedLicenseDataAccess.IsDetainLicenseExistsByLicense(LicenseID);

        }

        public static bool isReleased(int LicenseID)
        {
            return clsDetainedLicenseDataAccess.IsReleased(LicenseID);
        }

    }
}
