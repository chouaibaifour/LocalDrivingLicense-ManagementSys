using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Users.controls
{
    public partial class ctrlChangePassword : UserControl
    {
        public ctrlChangePassword()
        {
            InitializeComponent();
        }

        private clsUser _User;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        private void GetInfoFor()
        {
            _User.Password=txtNewPassword.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (_User != null)
            {

                if (!txtCurrentPassword.Text.Equals(_User.Password))
                {
                    MessageBox.Show("Current Password not match!");
                }
                else
                {
                    GetInfoFor();
                    if (_User.Save())
                    {
                        MessageBox.Show("Password was Changed Successfully!");
                    }else
                    MessageBox.Show("Password was not Changed Successfully!");
                }
            }
            else
                MessageBox.Show("No such user with is UserID");
        }

        public void LoadUserToChangePassword(int UserID)
        {
            _User=clsUser.Find(UserID);

            if( _User != null )
            {
                _FillFieldsWithUserData();
                return;
            }

            MessageBox.Show("ooops! something accured try agian!");
        }

        private void _FillFieldsWithUserData()
        {
            ctrlUserInfo1.LoadUserInfo(_User.UserID);
            
        }

        private void txtCurrentPassword_Leave(object sender, EventArgs e)
        {
            if (!txtCurrentPassword.Text.Equals(_User.Password))
            {

                epEmptyOrNull.SetError(txtCurrentPassword, "Current Password not match!");
            }
            else
            {

                epEmptyOrNull.SetError(txtCurrentPassword, "");

            }
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {

          
            if (8 > txtNewPassword.Text.Length && !txtNewPassword.Text.Equals(txtConfirmPassword.Text))
            {

                epEmptyOrNull.SetError(txtNewPassword, "Password should be at least 8 characters long !");
            }
            else
            {
                e.Cancel = false;

                epEmptyOrNull.SetError(txtNewPassword, "");

            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {

            if (!txtNewPassword.Text.Equals(txtConfirmPassword.Text))
            {


                epEmptyOrNull.SetError(txtConfirmPassword, "not same as password ! Please enter same Password");
            }
            else
            {
               

                epEmptyOrNull.SetError(txtConfirmPassword, "");

            }
        }
    }
}
