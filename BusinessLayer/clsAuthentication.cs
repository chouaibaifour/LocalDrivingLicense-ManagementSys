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
        public string UserName {  get; set; }
        public string Password { get; set; }
        public bool isActive { get; } 

        public clsAuthentication() {

            UserName = "";

            Password = "";

            isActive = false;
        
        }

        private clsAuthentication(bool isActive)
        {
            this.isActive = isActive;
        }
        
        public static clsAuthentication Login(string UserName, string Password)
        {
            bool isActive = false;

            if(clsAuthenticationDataAccess.Login(UserName,Password,ref isActive))
            {
                return new clsAuthentication(isActive);

            }
            else
            {
                return null;
            }
        }



    }
}
