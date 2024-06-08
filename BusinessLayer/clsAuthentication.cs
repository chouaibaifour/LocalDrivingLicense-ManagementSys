using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLayer
{
    public class clsAuthentication
    {
        public int UserID { get; set; }
        public string UserName {  get; set; }
        public string Password { get; set; }
        public bool isActive { get; } 
        public int PersonID { get; set; }

        public clsAuthentication() {

            UserID = -1;
            UserName = "";

            Password = "";

            PersonID = -1;

            isActive = false;
        
        }

        private clsAuthentication(int UserID,int PersonID,bool isActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;

            this.isActive = isActive;
        }
        
        
        public static clsAuthentication Login(string UserName, string Password)
        {
            bool isActive = false;
            int PersonID = -1;
            int UserID = -1;
            if(clsAuthenticationDataAccess.Login(UserName,Password,ref UserID,ref PersonID,ref isActive))
            {
                return new clsAuthentication(UserID,PersonID,isActive);

            }
            else
            {
                return null;
            }
        }

        public static clsAuthentication FindCurrentUser(int UserID)
        {
           clsUser user= clsUser.Find(UserID);

            if (user != null)
                return new clsAuthentication(user.UserID, user.PersonID, user.isActive);

            return null;
        }


    }
}
