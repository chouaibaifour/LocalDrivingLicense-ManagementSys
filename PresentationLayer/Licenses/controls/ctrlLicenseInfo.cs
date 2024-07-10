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

namespace PresentationLayer.Licenses.controls
{
    public partial class ctrlLicenseInfo : UserControl
    {

        public event Action<int> OnLicenseSelected;

        protected virtual void OnlicenseSelected(int licenseID)
        {
            Action<int> handler = OnLicenseSelected;

            if (handler != null)
                handler(licenseID);
        }

        public ctrlLicenseInfo()
        {
            InitializeComponent();
        }

        private clsPerson _Person;
        private int _LicenseID;
        private clsLicense _License;

        public bool LoadLicenseInfo(int LicenseID)
        {
            _License = clsLicense.Find(LicenseID);

            if (_License != null)
            {
                _Person = clsPerson.Find(clsDriver.Find(_License.DriverID).PersonID);

                if (_Person != null)
                {
                    lblClassName.Text = clsLicenseClass.Find(_License.LicenseClassID).ClassName;
                    lblDateOfBirth.Text = _Person.DateOfBirth.ToString("d");
                    lblDriverID.Text = _License.DriverID.ToString();
                    lblExpirationDate.Text = _License.ExpirationDate.ToString("d");
                    lblFullName.Text = _Person.FullName;
                    lblGender.Text = (_Person.Gender) ? "Male" : "Female";
                    lblIsActive.Text = (_License.IsActive) ? "Yes" : "No";
                    lblIsDetained.Text = "Not ImplementedYet";
                    lblIssueDate.Text = _License.IssueDate.ToString("d");
                    lblIssueDate.Text = _License.IssueDate.ToString("d");
                    lblIssueReason.Text = _GetIssueReason();
                    lblLicenseID.Text = _License.LicenseID.ToString();
                    lblNationalNumber.Text = _Person.NationalNumber;
                    lblNotes.Text = (_License.Notes!="")?_License.Notes:"No Notes";
                    pbProfilePicture.Image = Image.FromFile("F:\\repos\\Icons\\72px\\person_man.png");

                    if (OnLicenseSelected != null)
                        OnLicenseSelected(_License.LicenseID);

                    return true;

                }
                return false;
            }
            else
                MessageBox.Show("No License With LicenseID = " + _LicenseID.ToString());
            return false;

        }

        private string _GetIssueReason()
        {
            string[] IssueReasons = { "FirstTime", "ReNew", "Replacement For Damage","Replacement For Lost" };
             return IssueReasons[_License.IssueReason-1];
        }
    }
}
