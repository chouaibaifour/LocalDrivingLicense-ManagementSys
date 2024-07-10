using BusinessLayer;
using PresentationLayer.Licenses;
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

namespace PresentationLayer.InternationalLicenses.controls
{
    public partial class ctrlAddUpdateInternationalLicense : UserControl
    {
        public enum enMode { AddNew = 0, Update = 1 }

        private enMode _Mode;

        private int _InternationalLicenseID;
        private clsInternationalLicense _InternationalLicense;
        private clsApplication _Application;
        private int _IssuedUsingLicenseID = -1;

        public ctrlAddUpdateInternationalLicense()
        {
            InitializeComponent();
        }

        public void LoadInternationalLicenseInfo(int InternationalLicenseID)
        {
            if (InternationalLicenseID == -1)
            {
                _Mode= enMode.AddNew;
            }
            else
            {
                _InternationalLicenseID= InternationalLicenseID;
                _Mode= enMode.Update;
            }

            _LoadData();
        }

        private void _LoadData()
        {
            if (_Mode.Equals(enMode.AddNew))
            {
                _InternationalLicense = new clsInternationalLicense();
                _Application = new clsApplication();
                llblShowLicenseInfo.Enabled = false;
                
            }
            else
            {
                _InternationalLicense = clsInternationalLicense.Find(_InternationalLicenseID);

                if (_InternationalLicense == null)
                {
                    MessageBox.Show($"this Form will be closed because,\nNo International License With ID ={_InternationalLicenseID}");

                    FindForm().Close();

                    return;
                }

                _Application = clsApplication.Find(_InternationalLicenseID);

                if (_Application == null)
                {
                    MessageBox.Show($"Unexpected Error, this Form will be closed!");
                    FindForm().Close();
                    return;
                }
            }



            _FillDataToForm();
        }

        private void _FillDataToForm()
        {
            if (enMode.Update.Equals(_Mode))
            {
                lbl_ILicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();

                lbl_ILApplicationID.Text = _Application.ApplicationID.ToString();

                ctrlFindLicense1.LoadLicenseInfo(_InternationalLicense.IssuedUsingLocalLicenseID);

                lblExpirationDate.Text = _InternationalLicense.ExpirationDate.ToString();

                lblCreatedBy.Text = clsUser.Find(_InternationalLicense.CreatedByUserID).UserName;

                lblApplicationDate.Text = _Application.ApplicationDate.ToString();

                lblApplicationFees.Text = _Application.PaidFees.ToString();

                lblIssueDate.Text = _InternationalLicense.IssueDate.ToString("d");
            }
            else
            {
                lblExpirationDate.Text = _InternationalLicense.IssueDate.AddYears(1).ToString();

                lblCreatedBy.Text = clsUser.Find(frmHome.auth.UserID).UserName;

                lblApplicationDate.Text = _Application.ApplicationDate.ToString();

                lblApplicationFees.Text = clsApplicationType.Find(6).ApplicationFees.ToString("d");

                lblIssueDate.Text = _InternationalLicense.IssueDate.ToString("d");
            }



        }

        private void ctrlFindLicense1_OnLicenseSelected(int obj)
        {
            _IssuedUsingLicenseID = obj;
            lblLocalLicenseID.Text=_IssuedUsingLicenseID.ToString();
            _Application.ApplicantPersonID = clsDriver.Find(clsLicense.Find(_IssuedUsingLicenseID).DriverID).PersonID;
            lblExpirationDate.Text = DateTime.Now.AddYears(clsLicenseClass.Find(3).DefaultValidityLength).ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FindForm().Close();
        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            _SaveInternationalLicense();
           
        }

        private void _SaveInternationalLicense()
        {
            if (!_validateData())
            {
                return;
            }
            _GetDataFormForm_Application();

            if (!_Application.Save())
            {
                MessageBox.Show("Unexpected Error, try again !");

                FindForm().Close();

                return;

            }
            _GetDataFormForm_InternationalLicense();

            if (!_InternationalLicense.Save())
            {

                MessageBox.Show($"Data Could not be Saved !");
                return;
            }
            MessageBox.Show($"International License Issued Successfully with ID {_InternationalLicense.InternationalLicenseID}");
            llblShowLicenseInfo.Enabled = true;
            lbl_ILApplicationID.Text = _Application.ApplicationID.ToString();
            lbl_ILicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
            _Mode = enMode.Update;

        }

        private bool _validateData()
        {
            if (-1 == _IssuedUsingLicenseID)
            {
                MessageBox.Show("Please choose a License !");
                return false;
            }
            if(clsInternationalLicense.IsInternationalLicenseExistsByLocalLicenseID(_IssuedUsingLicenseID))
            {
                MessageBox.Show("this license already has International Copy, Choose another license !");
                return false;
            }
            if (3 != clsLicense.Find(_IssuedUsingLicenseID).LicenseClassID)
            {
                MessageBox.Show("this Service Only for ordinary License,  Please choose another License !");
                return false;
            }

            if (!clsLicense.IsLicenseActive(_IssuedUsingLicenseID)) 
            {
                MessageBox.Show("this License is DisActive, Please choose another License !");
                return false;
            }

            if (clsLicense.isExpired(_IssuedUsingLicenseID))
            {
                MessageBox.Show("this License is Expired, Please choose another License !");
                return false;
            }

            if (MessageBox.Show("are you sure do want to continue ?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK) 
            {
                return true;
            }
                
                return false;
            
        }

        private void _GetDataFormForm_InternationalLicense()
        {
            _InternationalLicense.ApplicationID = _Application.ApplicationID;

            _InternationalLicense.DriverID = clsLicense.Find(_IssuedUsingLicenseID).DriverID;

            _InternationalLicense.IssuedUsingLocalLicenseID = _IssuedUsingLicenseID;

            if (DateTime.TryParse(lblExpirationDate.Text, out DateTime ExpirationDate))

                _InternationalLicense.ExpirationDate = ExpirationDate;

            _InternationalLicense.IssueDate = DateTime.Now;

            _InternationalLicense.IsActive = true;

            _InternationalLicense.CreatedByUserID = frmHome.auth.UserID;
        }

        private void _GetDataFormForm_Application()
        {
            

            _Application.ApplicationStatus = 3;

            if (DateTime.TryParse(lblApplicationDate.Text, out DateTime ApplicationDate))

                _Application.ApplicationDate = ApplicationDate;

            _Application.LastStatusDate= DateTime.Now;

            _Application.ApplicationTypeID = 6; // New International License

            if (int.TryParse(lblApplicationFees.Text, out int ApplicationFees))

                _Application.PaidFees = ApplicationFees;

            _Application.CreatedByUserID = frmHome.auth.UserID;

        }

        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInternationalLicenseInfo frmInternationalLicenseInfo = new frmInternationalLicenseInfo(_InternationalLicense.InternationalLicenseID);
            frmInternationalLicenseInfo.ShowDialog();
        }

        private void llblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (-1 == _IssuedUsingLicenseID)
            {
                MessageBox.Show("Please choose a License !");

                return;
            }

            frmPersonLicenseHistory _frmPersonLicenseHistory = new frmPersonLicenseHistory(_Application.ApplicantPersonID);

            _frmPersonLicenseHistory.ShowDialog();
        }
    }
}
