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
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            while (true)
            {
                if (frmLogin.trynum <= 3)
                {
                    if (frmLogin.DialogResult == DialogResult.OK)
                    {
                        Application.Run(new frmHome());// go to next Page
                        //DialogResult == Yes and trynum<3
                        return;// try again
                    }
                    frmLogin.ShowDialog();
                    //DialogResult==No and trynum<3
                }
                else if (frmLogin.DialogResult == DialogResult.No)
                {
                    frmLogin.Close();// close the login form
                    //DialogResult==No and trynum<3
                    return;
                }

            }


        }
    }
}
