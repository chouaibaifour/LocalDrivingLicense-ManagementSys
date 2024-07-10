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

namespace PresentationLayer.Licenses.controls
{
    public partial class ctrlReplacementDamagedOrLostLicense : UserControl
    {
        public ctrlReplacementDamagedOrLostLicense()
        {
            InitializeComponent();
        }

        public enum enMode { AddNew = 0, Update = 1 }

        private enMode _Mode;

        private clsApplication _ReplacementApp;

        private int _ReplacementAppID;

        private clsLicense _License;

        private clsLicense _ReplacedLicense;

        private int _PersonID;

        public void LoadReplacementInfo(int ReplacementID)
        {
            if (-1 == ReplacementID)
            {
                _Mode = enMode.AddNew;

            }
            else
            {
                _Mode = enMode.Update;

                ctrlFindLicense1.toUpdate(false);

                gbRepalcementOption.Enabled = false;

            }

            _LoadData();
        }

        private void _LoadData()
        {
            if (_Mode.Equals(enMode.AddNew))
            {
                _ReplacementApp =new clsApplication();

                _License = new clsLicense();

                _ReplacedLicense = new clsLicense();

                llblShowPersonLicenseHistory.Enabled = false;

                llblShowLicenseInfo.Enabled = false;

                btnIssueReplacement.Enabled = false;


            }
            else
            {
                _ReplacementApp = clsApplication.Find(_ReplacementAppID);

                _PersonID = _ReplacementApp.ApplicantPersonID;

                if(_ReplacementApp == null)
                {
                    MessageBox.Show($"this Form Will be Closed, \n no Renew Application With ID {_ReplacementAppID}");

                    FindForm().Close();

                    return;
                }

                _License = clsLicense.FindByApplicationID(_ReplacementAppID);

                

                if (null == _License)
                {
                    MessageBox.Show($"this Form Will be Closed linked with Renew Application ID {_ReplacementAppID}");

                    FindForm().Close();

                    return;
                }
            }

            _FillFormWithData();
        }

        private void _FillFormWithData()
        {
            if(_Mode.Equals(enMode.AddNew))
            {
                lblApplicationDate.Text = DateTime.Now.ToString("d");

                lblApplicationFees.Text = ((rbDamagedLicense.Checked) ?

                    clsApplicationType.Find(4).ApplicationFees 
                    :
                    clsApplicationType.Find(3).ApplicationFees)

                    .ToString();

                lblCreatedBy.Text = frmHome.auth.UserName;
            }
            else
            {
                lblReplaceLicenseApplicationID.Text = _ReplacementApp.ApplicationID.ToString();

                lblOldLicenseID.Text = _License.LicenseID.ToString();

                lblReplacedLicenseID.Text = _License.LicenseID.ToString();

                lblCreatedBy.Text = clsUser.Find(_ReplacementApp.CreatedByUserID).UserName;

                lblApplicationFees.Text = _ReplacementApp.PaidFees.ToString();

                lblApplicationDate.Text = _ReplacementApp.ApplicationDate.ToString("d");

                ctrlFindLicense1.LoadLicenseInfo(_License.LicenseID);

            }
        }

        private void ctrlFindLicense1_OnLicenseSelected(int obj)
        {
            if (_Mode.Equals(enMode.AddNew))

                _License = clsLicense.Find(obj);

            if (_License != null)
            {
                if (!_License.IsActive)
                {
                    MessageBox.Show("this License is Not Active ,Choose another one !");

                    return;

                }

                lblOldLicenseID.Text = _License.LicenseID.ToString();

                btnIssueReplacement.Enabled = true;
                llblShowPersonLicenseHistory.Enabled = true;

                _PersonID = clsApplication.Find(_License.ApplicationID).ApplicantPersonID;

            }
        }

        private void llblShowPersonLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonLicenseHistory frmPersonLicenseHistory = new frmPersonLicenseHistory(_PersonID);
             
            frmPersonLicenseHistory.ShowDialog();
        }

        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frmLicenseInfo = new frmLicenseInfo(_ReplacedLicense.LicenseID);

            frmLicenseInfo.ShowDialog(); 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FindForm().Close();
        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {

            if (!_ValidateData())
            {
                return;
            
            }

            _SaveData();

           
        }

        private void _SaveData()
        {
            _GetDataFromForm_ReplacementApplication();

            if (!_ReplacementApp.Save())
            {
                MessageBox.Show("Unexpected Error !");

                FindForm().Close();

                return;
            }

            _GetDataFromForm_ReplacementLicense();

            if (MessageBox.Show("Are you sure you want to Replace this Licesne cause of "

                + ((rbDamagedLicense.Checked) ? "Damaged" : "Lost") + " License ?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK) 
            {
                if (!_ReplacedLicense.Save())
                {
                    MessageBox.Show($"Data Could not be Saved !");

                    return;
                }

                MessageBox.Show($"License Renewed Successfully with ID = {_ReplacedLicense.LicenseID}");

                lblReplaceLicenseApplicationID.Text = _ReplacementApp.ApplicationID.ToString();

                lblReplacedLicenseID.Text = _ReplacedLicense.LicenseID.ToString();

                llblShowLicenseInfo.Enabled = true;

                _Mode = enMode.Update;

                ctrlFindLicense1.toUpdate(true);

                gbRepalcementOption.Enabled = false;

                btnIssueReplacement.Enabled = false;

            }
            

        }

        private void _GetDataFromForm_ReplacementLicense()
        {
            
            _License.IsActive = false;

            if (_License.Save())
            {
                _ReplacedLicense.ApplicationID = _ReplacementApp.ApplicationID;

                _ReplacedLicense.DriverID = _License.DriverID;

                _ReplacedLicense.LicenseClassID = _License.LicenseClassID;

                _ReplacedLicense.IssueDate = DateTime.Now;

                _ReplacedLicense.ExpirationDate = DateTime.Now.AddYears(clsLicenseClass.Find(_License.LicenseClassID).DefaultValidityLength);

                _ReplacedLicense.Notes = _License.Notes;

                _ReplacedLicense.PaidFees = clsLicenseClass.Find(_License.LicenseClassID).ClassFees;

                _ReplacedLicense.IsActive = true;

                _ReplacedLicense.IssueReason = (byte)((rbDamagedLicense.Checked) ? 3 : 4);

                _ReplacedLicense.CreatedByUserID = frmHome.auth.UserID;

            }
           

        }

        private void _GetDataFromForm_ReplacementApplication()
        {
            _ReplacementApp.ApplicationDate = DateTime.Now;

            _ReplacementApp.ApplicationStatus = 3;// Completed

            _ReplacementApp.ApplicantPersonID = _PersonID;

            _ReplacementApp.ApplicationTypeID = (rbDamagedLicense.Checked) ? 4 : 3;

            _ReplacementApp.CreatedByUserID = frmHome.auth.UserID;

            _ReplacementApp.LastStatusDate = DateTime.Now;

            _ReplacementApp.PaidFees = clsApplicationType.Find((rbDamagedLicense.Checked) ? 4 : 3).ApplicationFees;

        }

        private bool _ValidateData()
        {
            if (null == _License)
            {
                MessageBox.Show("this License is Not Active ,Choose another one !");

                return false;
            }

            if (!rbDamagedLicense.Checked && !rbLostLicense.Checked)
            {
                MessageBox.Show("Choose Replacement Type Please !");

                return false;
            }

            return true;
        }

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton checkBox = (RadioButton)sender;

            if(int.TryParse(checkBox.Tag.ToString(),out int ApplicationTypeID))

            lblApplicationFees.Text = clsApplicationType.Find(ApplicationTypeID).ApplicationFees.ToString();
        }
    }
}
