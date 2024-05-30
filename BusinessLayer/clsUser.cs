using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsUser
    {

            //UserID
            //PersonID
            //UserName
            //Password
            //isActive

        private enum enMode { AddNew, Update };
        private enMode Mode = enMode.AddNew;
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool isActive { get; set; }

        public clsUser()
        {
            Mode = enMode.AddNew;

            UserID = -1;
            PersonID = -1;
            UserName = "";
            Password = "";
            isActive = false;

        }

        private clsUser(int UserID, int PersonID, string UserName, string Password, bool isActive)
        {

            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.isActive = isActive;
            Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            this.UserID = clsUserDataAccess.AddNewUser(PersonID, UserName, Password, isActive);

            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            return clsUserDataAccess.UpdateUser(UserID, PersonID, UserName, Password, isActive);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUser();

            }
            return false;
        }

        static public clsUser Find(int UserID)
        {

            UserID = -1;
            int PersonID = -1;
            string UserName = "";
            string Password = "";
            bool isActive = false;

            if (clsUserDataAccess.GetUserByID(ref UserID, ref PersonID, ref UserName, ref Password, ref isActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, isActive);
            }
            else
            {
                return null;
            }
        }

        static public clsUser Find(string UserName)
        {

            int UserID = -1;
            int PersonID = -1;
            UserName = "";
            string Password = "";
            bool isActive = false;

            if (clsUserDataAccess.GetUserByID(ref UserID, ref PersonID, ref UserName, ref Password, ref isActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, isActive);
            }
            else
            {
                return null;
            }
        }

        static public bool DeleteUser(int UserID)
        {
            return clsUserDataAccess.DeleteUser(UserID);
        }

        static public DataTable GetAllUsers()
        {
            return clsUserDataAccess.GetAllUsers();
        }

        static public bool IsUserExists(int UserID)
        {
            return clsUserDataAccess.IsUserExists(UserID);
        }
        static public bool IsUserExistsbyPersonID(int PersonID)
        {
            return clsUserDataAccess.IsUserExistsbyPersonID(PersonID);
        }

    }
}
