using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsCountry
    {
        //CountryID
        //CountryName
        
        private enum enMode { AddNew, Update };
        private enMode Mode = enMode.AddNew;
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public clsCountry()
        {
            Mode = enMode.AddNew;

            CountryID = -1;
            CountryName = "";

        }

        private clsCountry(int CountryID, string CountryName)
        {

            this.CountryID = CountryID;
            this.CountryName = CountryName;

            Mode = enMode.Update;
        }

        private bool _AddNewCountry()
        {
            this.CountryID = clsCountryDataAccess.AddNewCountry(CountryName);

            return (this.CountryID != -1);
        }

        private bool _UpdateCountry()
        {
            return clsCountryDataAccess.UpdateCountry(CountryID, CountryName);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCountry())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateCountry();

            }
            return false;
        }

        static public clsCountry Find(int CountryID)
        {

            string CountryName = "";
            

            if (clsCountryDataAccess.GetCountryByID(ref CountryID, ref CountryName))
            {
                return new clsCountry(CountryID, CountryName);
            }
            else
            {
                return null;
            }
        }

        static public clsCountry Find(string CountryName)
        {

            int CountryID = -1;

            if (clsCountryDataAccess.GetCountryByCountryName(ref CountryID, ref CountryName))
            {
                return new clsCountry(CountryID, CountryName);
            }
            else
            {
                return null;
            }
        }

        static public bool DeleteCountry(int CountryID)
        {
            return clsCountryDataAccess.DeleteCountry(CountryID);
        }

        static public DataTable GetAllCountries()
        {
            return clsCountryDataAccess.GetAllCountries();
        }

        static public bool IsCountryExists(int CountryID)
        {
            return clsCountryDataAccess.IsCountryExists(CountryID);
        }

    }

}
