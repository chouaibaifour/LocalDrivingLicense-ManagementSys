using BusinessLayer;
using PresentationLayer.ApplicationTypes;
using PresentationLayer.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmHome : Form
    {
      
       
        public frmHome(int CurrentUserID)
        {
            InitializeComponent();
            auth=clsAuthentication.FindCurrentUser(CurrentUserID);
        }
        public static  clsAuthentication auth;
       

        private void lblApplication_Click(object sender, EventArgs e)
        {
            lblApplication.ContextMenuStrip.Show(new Point(lblApplication.Left, lblApplication.Bottom + 35));
        }

        private void lblPeople_Click(object sender, EventArgs e)
        {
            frmPeopleList frmPeopleList = new frmPeopleList();  
            frmPeopleList.ShowDialog();
        }

        private void lblDrivers_Click(object sender, EventArgs e)
        {

        }

        private void lblAcountSettings_Click(object sender, EventArgs e)
        {
            lblAcountSettings.ContextMenuStrip.Show(new Point(lblAcountSettings.Left, lblAcountSettings.Bottom+35));
        }

        private void lblUsers_Click(object sender, EventArgs e)
        {
            frmUsersList frmUsersList = new frmUsersList(); 
            frmUsersList.ShowDialog();
        }

        private void smiCurrentUserInfo_Click(object sender, EventArgs e)
        {
            frmUserInfo frmCurrentUserInfo = new frmUserInfo(auth.UserID);
            frmCurrentUserInfo.ShowDialog();
        }

        private void smiChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword(auth.UserID);
            frmChangePassword.ShowDialog();
        }

        private void smiSignOut_Click(object sender, EventArgs e)
        {
           this.Close();
            
        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
          

        }

        private void lblAcountSettings_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = (sender) as Label;
            lbl.Focus();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApplicationTypeList frmApplicationTypeList = new frmApplicationTypeList();
            frmApplicationTypeList.ShowDialog();
        }

        private void smiLocalLicenseApplication_Click(object sender, EventArgs e)
        {

        }
    }
}
