using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsPerson
    {       
        //PersonID
        //NationalNumber
        //FirstName
        //SecondName
        //ThirdName
        //LastName
        //DateOfBirth
        //Gender
        //Address
        //Email
        //PhoneNumber
        //NationalityCountryID
        //ImagePath
        private enum enMode { AddNew, Update };
        private enMode Mode = enMode.AddNew;
        public int PersonID { get; set; }
        public string NationalNumber { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public string PhoneNumber { get; set; } 
        public string Address { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }

           

        public clsPerson()
        {
            Mode = enMode.AddNew;

            PersonID = -1;
            NationalNumber = "";
            FirstName="";
            SecondName="";
            ThirdName="";
            LastName="";
            DateOfBirth = DateTime.Now;
            Gender = true; //means male
            Address="";
            Email="";
            PhoneNumber="";
            NationalityCountryID = -1;
            ImagePath = "";

        }

        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }
        }
        public string CountryName()
        {
            clsCountry country = clsCountry.Find(NationalityCountryID);
            if (country != null){
                return (country.CountryName !="") ? country.CountryName : "";
            }

            return "";
            
            
        }

        private clsPerson(int PersonID, string NationalNumber, string FirstName, string SecondName,
             string ThirdName, string LastName, DateTime DateOfBirth, bool Gender, string Address, string Email,
              string PhoneNumber, int NationalityCountryID, string ImagePath)
        {

            this.PersonID= PersonID;
            this.NationalNumber=NationalNumber;
            this.FirstName=FirstName;
            this.SecondName=SecondName;
            this.ThirdName=ThirdName;
            this.LastName=LastName;
            this.DateOfBirth=DateOfBirth;
            this.Gender = Gender;
            this.Address=Address;
            this.Email=Email;
            this.PhoneNumber=PhoneNumber;
            this.NationalityCountryID=NationalityCountryID;
            this.ImagePath=ImagePath;

            Mode = enMode.Update;
        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonDataAccess.AddNewPerson(NationalNumber, FirstName, SecondName,ThirdName, LastName, 
                DateOfBirth, Gender, Address, Email,PhoneNumber, NationalityCountryID, ImagePath);

            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            return clsPersonDataAccess.UpdatePerson(PersonID, NationalNumber, FirstName, SecondName, ThirdName, LastName,
                DateOfBirth, Gender, Address, Email, PhoneNumber, NationalityCountryID, ImagePath);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePerson();

            }
            return false;
        }

        static public clsPerson Find(int PersonID)
        {

            string NationalNumber = "";
            string FirstName="";
            string SecondName="";
            string ThirdName="";
            string LastName="";
            DateTime DateOfBirth = DateTime.Now;
            bool Gender = true; //male
            string Address="";
            string Email="";
            string PhoneNumber="";
            int NationalityCountryID=-1;
            string ImagePath = "";

            if (clsPersonDataAccess.GetPersonByID(ref PersonID, ref NationalNumber, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref DateOfBirth, ref Gender, ref Address, ref Email, ref PhoneNumber, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNumber, FirstName, SecondName, ThirdName, LastName,
                DateOfBirth, Gender, Address, Email, PhoneNumber, NationalityCountryID, ImagePath);
            }
            else
            {
                return null;
            }
        }

        static public clsPerson Find(string NationalNumber)
        {

            int PersonID = -1;
            
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            bool Gender = true; //male
            string Address = "";
            string Email = "";
            string PhoneNumber = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            if (clsPersonDataAccess.GetPersonByNationalNumber(ref PersonID, ref NationalNumber, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref DateOfBirth, ref Gender, ref Address, ref Email, ref PhoneNumber, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNumber, FirstName, SecondName, ThirdName, LastName,
                DateOfBirth, Gender, Address, Email, PhoneNumber, NationalityCountryID, ImagePath);
            }
            else
            {
                return null;
            }
        }

        static public bool DeletePerson(int PersonID)
        {
            return clsPersonDataAccess.DeletePerson(PersonID);
        }

        static public DataTable GetAllPeople()
        {
            return clsPersonDataAccess.GetAllPeople();
        }

        static public bool IsPersonExists(int PersonID)
        {
            return clsPersonDataAccess.IsPersonExists(PersonID);
        }
        static public bool IsPersonExists(string NationalNumber)
        {
            return clsPersonDataAccess.IsPersonExist(NationalNumber);
        }

        static public bool IsEmailExists(string Email)
        {
            return clsPersonDataAccess.IsEmailExist(Email);
        }
    }
}
