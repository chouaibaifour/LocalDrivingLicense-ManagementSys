using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using static System.Net.Mime.MediaTypeNames;

namespace PresentationLayer.Licenses.controls
{
    public partial class ctrlRenewLicense : UserControl
    {
        public ctrlRenewLicense()
        {
            InitializeComponent();
        }
        public enum enMode { AddNew = 0, Update = 1 }

        private enMode _Mode;

        private clsApplication _RenewApplication;

        private int _RenewApplicationID = -1;

        private clsLicense _License;

        private clsLicense _RenewedLicense;

        private int _PersonID;

        public void LoadRenewLicenseInfo(int RenewApplicationID)
        {
            if (-1 == RenewApplicationID)
            {
                _Mode = enMode.AddNew;

            }
            else
            {
                _RenewApplicationID = RenewApplicationID;

                _Mode = enMode.Update;
            }

            _LoadData();
        }

        private void _LoadData()
        {
            if (_Mode == enMode.AddNew)
            {
                _RenewApplication = new clsApplication();

                _License = new clsLicense();

                _RenewedLicense = new clsLicense();

                llblShowRenewLicense.Enabled = false;

                llblShowLicensesHistory.Enabled = false;
            }
            else
            {
                _RenewApplication = clsApplication.Find(_RenewApplicationID);

                if (null == _RenewApplication)
                {
                    MessageBox.Show($"this Form Will be Closed, \n no Renew Application With ID {_RenewApplicationID}");

                    FindForm().Close();

                    return;
                }

                _License = clsLicense.FindByApplicationID(_RenewApplicationID);

                if (null == _License)
                {
                    MessageBox.Show($"this Form Will be Closed linked with Renew Application ID {_RenewApplicationID}");

                    FindForm().Close();

                    return;
                }

            }

            _FillFormWithData();
        }

        private void _FillFormWithData()
        {
            if (enMode.Update.Equals(_Mode)) 
            {

                _FillFormWithData_Update();
            }
            else
            {

                lblApplicationDate.Text = DateTime.Now.ToString("d");

                lblApplicationFees.Text = clsApplicationType.Find(2).ApplicationFees.ToString();

                lblCreatedBy.Text = frmHome.auth.UserName;

                lblIssueDate.Text = DateTime.Now.ToString("d");
                
            }
        }

        private void _FillFormWithData_Update()
        {
            lblRenewLicenseApplicationID.Text = _RenewApplication.ApplicationID.ToString();

            lblApplicationDate.Text = _RenewApplication.ApplicationDate.ToString();

            lblApplicationFees.Text = _RenewApplication.PaidFees.ToString();

            lblCreatedBy.Text = clsUser.Find(_RenewApplication.CreatedByUserID).UserName;

            lblExpirationDate.Text = _License.ExpirationDate.ToString("d");

            lblIssueDate.Text = _License.IssueDate.ToString("d");

            lblTotalFees.Text = (_License.PaidFees + _RenewApplication.PaidFees).ToString();

            lblLicenseFees.Text = _License.PaidFees.ToString("d");

            lblOldLicenseID.Text = _License.LicenseID.ToString();

            lblRenewedLicenseID.Text = _License.LicenseID.ToString();

            rtxtNotes.Text = _License.Notes.ToString();

            rtxtNotes.Visible = false;
            
            ctrlFindLicense1.LoadLicenseInfo(_License.LicenseID);

            ctrlFindLicense1.toUpdate(true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FindForm().Close();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (!_ValidateRenew_License())
            {
                return;
            }

            _SaveData();
        }

        private void _SaveData()
        {

            _GetDataFromForm_RenewApplication();

            if (!_RenewApplication.Save())
            {
                MessageBox.Show("Unexpected Error !");

                FindForm().Close();

                return;
            }


            _GetDataFromForm_ReneweLicense();
           
            
            if (!_RenewedLicense.Save())
            {
                MessageBox.Show($"Data Could not be Saved !");

                return;
            }
            else
            {
                MessageBox.Show($"License Renewed Successfully with ID = {_RenewedLicense.LicenseID}");

                lblRenewLicenseApplicationID.Text = _RenewApplication.ApplicationID.ToString();

                lblRenewedLicenseID.Text= _RenewedLicense.LicenseID.ToString();

                llblShowRenewLicense.Enabled = true;

                _Mode = enMode.Update;

                ctrlFindLicense1.toUpdate(true);

            }
               
        }

        private void _GetDataFromForm_ReneweLicense()
        { 
            _License.IsActive = false;

            if (_License.Save()) {

                _RenewedLicense.DriverID = _License.DriverID;

                _RenewedLicense.LicenseClassID = _License.LicenseClassID;

                _RenewedLicense.ApplicationID = _RenewApplication.ApplicationID;

                _RenewedLicense.CreatedByUserID = _RenewApplication.CreatedByUserID;

                if (DateTime.TryParse(lblExpirationDate.Text, out DateTime ExpirationDate))

                    _RenewedLicense.ExpirationDate = ExpirationDate;

                _RenewedLicense.Notes = rtxtNotes.Text;

                _RenewedLicense.IssueDate = DateTime.Now;

                _RenewedLicense.IssueReason = 2;

                if (int.TryParse(lblLicenseFees.Text, out int LicenseFees))

                    _RenewedLicense.PaidFees = LicenseFees;

                _RenewedLicense.IsActive = true;
            }


        }

        private void _GetDataFromForm_RenewApplication()
        {
            _RenewApplication.ApplicantPersonID = _PersonID;

            _RenewApplication.ApplicationDate = DateTime.Now;

            _RenewApplication.ApplicationTypeID = 2; // Renew License

            _RenewApplication.PaidFees = clsApplicationType.Find(2).ApplicationFees;

            _RenewApplication.ApplicationStatus = 3;

            _RenewApplication.CreatedByUserID = frmHome.auth.UserID;

        }

        private bool _ValidateRenew_License()
        {
            if (null == _License)
            {
                MessageBox.Show("please Select License !");
                return false;
            }
            if (!_License.IsActive)
            {
                MessageBox.Show("License already has copy !");
                return false;
            }
            return true;
            
        }

        private void ctrlFindLicense1_OnLicenseSelected(int obj)
        {
            if (!_Validate(obj))
            {
                return;
            }

            lblOldLicenseID.Text = _License.LicenseID.ToString();

            lblLicenseFees.Text = clsLicenseClass.Find(_License.LicenseClassID).ClassFees.ToString();

            if (int.TryParse(lblLicenseFees.Text, out int LicesneFees) && int.TryParse(lblApplicationFees.Text, out int ApplicationFees))
            {
                lblTotalFees.Text = (LicesneFees + ApplicationFees).ToString();
            }

            lblExpirationDate.Text = DateTime.Now.AddYears(clsLicenseClass.Find(_License.LicenseClassID).DefaultValidityLength).ToString("d");

            llblShowLicensesHistory.Enabled = true;

            this._PersonID = clsApplication.Find(_License.ApplicationID).ApplicantPersonID;

        }

        private bool _Validate(int obj)
        {

            _License = clsLicense.Find(obj);

            if( _License == null )

                return false;

            if (_License.ExpirationDate >= DateTime.Now)
            {
                MessageBox.Show($"this License is not Expired Yet\n it will expired in {_License.ExpirationDate} ");

                return false;
            };
            return true;
        }

        private void llblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonLicenseHistory frmPersonLicenseHistory = new frmPersonLicenseHistory(_PersonID) ;

            frmPersonLicenseHistory.ShowDialog();
        }

        private void llblShowRenewLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frmLicenseInfo = new frmLicenseInfo(_RenewedLicense.LicenseID);

            frmLicenseInfo.ShowDialog();
        }
    }
}
