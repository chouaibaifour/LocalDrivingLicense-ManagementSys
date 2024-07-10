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

namespace PresentationLayer.InternationalLicenses.controls
{
    public partial class ctrlInternationalLicenseInfo : UserControl
    {
        public ctrlInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        private clsInternationalLicense _InternationalLicense;

        public void LoadInternationlLicneseInfo(int _InternationalLicenseID)
        {
            _InternationalLicense = clsInternationalLicense.Find(_InternationalLicenseID);

            if (null != _InternationalLicense)
            {
                lblInternationalApplicationID.Text = _InternationalLicense.ApplicationID.ToString();
                lblInterLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
                lblIssueDate.Text = _InternationalLicense.IssueDate.ToString("d");
                lblExpirationDate.Text = _InternationalLicense.ExpirationDate.ToString("d");
                lblDriverID.Text = _InternationalLicense.DriverID.ToString();
                lblIsActive.Text = (_InternationalLicense.IsActive) ? "Yes" : "No";
                lblLicenseID.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();

                clsPerson _Person = clsPerson.Find(clsDriver.Find(_InternationalLicense.DriverID).PersonID);

                if (_Person != null)
                {
                    lblFullName.Text = _Person.FullName;
                    lblDateOfBirth.Text = _Person.DateOfBirth.ToString("d");
                    lblNationalNumber.Text = _Person.NationalNumber.ToString();
                    lblGender.Text = (_Person.Gender) ? "Male" : "Female";
                    picPersonalImage.Image = (_Person.ImagePath != "") ? 
                        Image.FromFile(_Person.ImagePath) 
                        : 
                        Image.FromFile("F:\\repos\\Icons\\72px\\drivers.png");
                }
                else
                {
                    MessageBox.Show("No Person Found !");
                    return;
                }
                    



            }
            else
            {

                MessageBox.Show("No International License Found With ID " + _InternationalLicenseID.ToString());
                return;
            }

        }
        

    }
}
