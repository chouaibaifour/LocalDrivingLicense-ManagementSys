using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using PresentationLayer.Properties;
namespace PresentationLayer
{
    public partial class ctrlPersonInfo : UserControl
    {
        private clsPerson _Person;

        public int PersonID { get; set; }

        public ctrlPersonInfo()
        {
            InitializeComponent();
        }

        private void selecteGender(bool Gender)
        {
            if (Gender)
            {
                lblGender.Text = "Male";

                lblGenderIcon.Image = Resources.person_man;

                return;

            }
            lblGender.Text = "Female";

            lblGenderIcon.Image = Resources.person_woman;
        }

        public void EmptyPersonInfo()
        {
            lblPersonID.Text = "N/A";

            lblNationalNumber.Text = "N/A";

            lblName.Text = "N/A";

            lblGender.Text = "N/A";

            lblGenderIcon.Image = Resources.person_man;

            lblEmail.Text = "N/A";

            lblAddress.Text = "N/A";

            lblDateOfBirth.Text = "N/A";

            lblPhone.Text = "N/A";

            lblCountryName.Text = "N/A";

            //picProfilePhoto.Image=Image.FromFile(_Person.ImagePath);

            this.PersonID = -1;
        }

        public void LoadPersonInfo(int PersonID)
        {
             _Person = clsPerson.Find(PersonID);


            if(_Person != null)
            {
                lblPersonID.Text = _Person.PersonID.ToString();

                lblNationalNumber.Text = _Person.NationalNumber;

                lblName.Text = _Person.FullName;

                selecteGender(_Person.Gender);

                lblEmail.Text = _Person.Email;

                lblAddress.Text = _Person.Address;

                lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();

                lblPhone.Text = _Person.PhoneNumber;

                lblCountryName.Text = _Person.CountryName();

                //picProfilePhoto.Image=Image.FromFile(_Person.ImagePath);

                this.PersonID = _Person.PersonID;
            }
            else
            {
                MessageBox.Show("No Person with PersonID : " + PersonID.ToString());

                EmptyPersonInfo();
            }

        }

        public void LoadPersonInfo(string NationalNumber)
        {
            _Person = clsPerson.Find(NationalNumber);

            if (_Person != null)
            {
                lblPersonID.Text = _Person.PersonID.ToString();

                lblNationalNumber.Text = _Person.NationalNumber;

                lblName.Text = _Person.FullName;

                selecteGender(_Person.Gender);

                lblEmail.Text = _Person.Email;

                lblAddress.Text = _Person.Address;

                lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();

                lblPhone.Text = _Person.PhoneNumber;

                lblCountryName.Text = _Person.CountryName();

                //picProfilePhoto.Image=Image.FromFile(_Person.ImagePath);

                this.PersonID = _Person.PersonID;

            }else
            {
                MessageBox.Show("No Person with NationalNo. : " + NationalNumber.ToString());

                EmptyPersonInfo();
            }


        }

        private void llbEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddNewUpdatePerson frmUpdatePerson = new frmAddNewUpdatePerson(_Person.PersonID);

            frmUpdatePerson.SendDataBackWithPersonID += LoadPersonInfo;

            frmUpdatePerson.ShowDialog();
        }
    }
}
