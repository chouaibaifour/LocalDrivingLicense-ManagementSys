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
    public partial class ctrlAddUpdateLicense : UserControl
    {
        public enum enMode { AddNew = 0, Update = 1 }

        private enMode _Mode;

        int _LicenseID;

        clsLicense _License;
        
        private cls_LDL_Application _LDL_Application;

        public ctrlAddUpdateLicense()
        {
            InitializeComponent();
        }

        public void LoadLicenseInfo(int LicenseID = -1, int LDL_ApplicationID = -1)
        {
            if(LicenseID == -1)
            {
                if(LDL_ApplicationID == -1)
                {
                    return;
                }
                else
                {
                    _LDL_Application =cls_LDL_Application.Find(LDL_ApplicationID);

                    if(_LDL_Application != null)

                    ctrlLDL_ApplicationInfo1.LoadLDLApplicationInfo(LDL_ApplicationID);

                    _Mode = enMode.AddNew;
                }

            }
            else
            {
                _LicenseID = LicenseID;
                _LDL_Application = cls_LDL_Application.Find(LDL_ApplicationID);
                _Mode = enMode.Update;
            }

            _LoadData();
        }

        private void _LoadData()
        {
           if(enMode.AddNew.Equals(_Mode))
            {
                _License = new clsLicense();
                return;
            }

           _License = clsLicense.Find(_LicenseID);

            if( _License == null )
            {
                MessageBox.Show("No License with License ID = " + _LicenseID.ToString());
                FindForm().Close();
                return;
            }
            _FillFormWithData();
        }

        private void _FillFormWithData()
        {
            ctrlLDL_ApplicationInfo1.LoadLDLApplicationInfo(_LDL_Application.LDL_ApplicationID);
            rtxtNotes.Text=_License.Notes;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FindForm().Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            _GetDataFromForm();
            if (_License.Save())
            {
                MessageBox.Show("Data Saved Successfully !");

            }
            else
                MessageBox.Show("Data was not Saved !");
        }

        private void _GetDataFromForm()
        {
            if (_Mode.Equals(enMode.AddNew))
            {
                clsApplication Application = clsApplication.Find(_LDL_Application.ApplicationID);
                if (Application != null)
                {
                    _AddNewDriver(Application.ApplicantPersonID);
                    _License.ApplicationID = Application.ApplicationID;
                }
                _License.CreatedByUserID = frmHome.auth.UserID;
                _License.IssueReason = 1;
                _License.LicenseClassID = _LDL_Application.LicenseClassID;
                _License.Notes = rtxtNotes.Text;
                _License.PaidFees = clsLicenseClass.Find(_LDL_Application.LicenseClassID).ClassFees;
                _License.ExpirationDate = DateTime.Now.AddYears(clsLicenseClass.Find(_LDL_Application.LicenseClassID).DefaultValidityLength);
                _License.IsActive = true;
            }
            else
                _License.Notes = rtxtNotes.Text;
           

        }

        private void _AddNewDriver(int applicantPersonID)
        {
            clsDriver Driver;

            Driver = clsDriver.FindByPersonID(applicantPersonID);
            if(Driver != null)
            {
                _License.DriverID = Driver.DriverID;
                return;
            }

            Driver = new clsDriver();

            Driver.PersonID = applicantPersonID;
            
            Driver.CreatedByUserID = frmHome.auth.UserID;
            if (!Driver.Save())
            {
                MessageBox.Show("oops! can't save new Driver ");
                return;
            }
            _License.DriverID=Driver.DriverID;

        }
    }
}
