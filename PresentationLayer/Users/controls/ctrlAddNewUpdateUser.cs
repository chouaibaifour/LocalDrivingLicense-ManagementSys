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
    public partial class ctrlAddNewUpdateUser : UserControl
    {
        public enum enMode { AddNew = 0, Update = 1 }

        private enMode _Mode;

        int _UserID;
        
        clsUser _User;

        public ctrlAddNewUpdateUser()
        {
            InitializeComponent();
        }

        public void Load_UserInfo(int UserID)
        {
            if (-1 == UserID)
            {
                _UserID = UserID;
                
                _Mode = enMode.AddNew;
               
            }
            else
            {
                _UserID = UserID;
                
                _Mode = enMode.Update;
            }

            _LoadData();
        }


        private void ValidatingEmptyOrNulltxt(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrEmpty(textBox.Text))
            {
                
                epEmptyOrNull.SetError(textBox, "should not be Empty!");
            }
            else
            {
                e.Cancel = false;

                epEmptyOrNull.SetError(textBox, "");

            }
        }

        private void _LoadData()
        {

            if (enMode.AddNew.Equals(_Mode))
            {
                // Add New User Mode 
                _User = new clsUser();
                return;

            }

            _User = clsUser.Find(_UserID);

            if (null == _User)
            {
                MessageBox.Show("This form will be Close because no User with UserID : " + _UserID.ToString());

                (this.FindForm()).Close();
                return;
            }
            // Update Mode 
            
            _FillFormWithData();
        }

        private void _FillFormWithData()
        {
            lblMode.Text = "Update User";
            txtUserName.Enabled = false;
            lblUserID.Text = _User.UserID.ToString();
            txtPassword.Text= _User.Password;
            txtUserName.Text= _User.UserName;
            txtPasswordConfirm.Text = _User.Password;
            chkIsActive.Checked = _User.isActive;
            ctrlFindPerson1.LoadPersonInfo(_User.PersonID,false);
        }

        private void GetUserInfoFromForm()
        {
            _User.UserName = txtUserName.Text;  
            _User.Password = txtPassword.Text;
            _User.isActive = chkIsActive.Checked;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (-1 == _User.PersonID)
            {
                MessageBox.Show("Unexpected Error, start over.");
                tablcontrol.SelectTab(tpPersonalInfo);
                return;
            }

                
            GetUserInfoFromForm();

            if(!txtPasswordConfirm.Text.Equals(txtPassword.Text))
            {
                MessageBox.Show("Password and Password confirm ! not much try again !");
                return;
            }    

            if (_User.Save())
            {
                _Mode = enMode.Update;
                MessageBox.Show("User Saved Successfully.");
            }

            else
            {
                MessageBox.Show("Error : Data is not Saved Successfully.");
                return;
            }

           
            lblUserID.Text = _User.UserID.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.FindForm().Close();

        }

        private void txtPasswordConfirm_Validating(object sender, CancelEventArgs e)
        {
            ValidatingEmptyOrNulltxt(sender, e);


            if (!txtPassword.Text.Equals(txtPasswordConfirm.Text))
            {
                

                epEmptyOrNull.SetError(txtPasswordConfirm, "not same as password ! Please enter same Password");
            }
            else
            {
                e.Cancel = false;

                epEmptyOrNull.SetError(txtPasswordConfirm, "");

            }

        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            ValidatingEmptyOrNulltxt(sender, e);

            if (8 > txtPassword.Text.Length && !txtPassword.Text.Equals(txtPasswordConfirm.Text))
            {
               
                epEmptyOrNull.SetError(txtPassword, "Password should be at least 8 characters long !");
            }
            else
            {
                e.Cancel = false;

                epEmptyOrNull.SetError(txtPassword, "");

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            

            switch (_Mode)
            {
                case enMode.AddNew:
                   
                    if (-1 == _User.PersonID)
                    {
                        MessageBox.Show("Please choose a Person !");
                        return;
                    }

                    if (clsUser.IsUserExistsbyPersonID(_User.PersonID))
                    {
                        MessageBox.Show("this Person already User choose another one !");
                        return;
                    }
                    
                    break;

                case enMode.Update:
                    
                    break;
            }

                tablcontrol.SelectTab(tpLoginIngo);

        }

        private void ctrlFindPerson1_OnPersonSelected(int obj)
        {
            this._User.PersonID = obj;
        }
    }
}
