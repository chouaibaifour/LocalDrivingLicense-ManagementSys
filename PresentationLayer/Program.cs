using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationLayer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Application.Run(new Users.frmUsersList());
            Application.Run(new TestTypes.frmTestTypeList());
            //frmLogin frmLogin = new frmLogin();
            //frmLogin.ShowDialog();
            //while (true)
            //{
            //    if (frmLogin.trynum <= 3)
            //    {
            //        if (frmLogin.DialogResult == DialogResult.OK)
            //        {
            //            frmHome frmHome = new frmHome(frmLogin.CurrentUserID);// go to next Page

            //            frmHome.ShowDialog();


            //        }
            //        frmLogin.ShowDialog();
            //        //DialogResult == No and trynum<3
            //    }
            //    else if (frmLogin.DialogResult == DialogResult.No)
            //    {
            //        frmLogin.Close();// close the login form
            //        //DialogResult==No and trynum<3
            //        return;
            //    }

            //}
        }
    }
}
