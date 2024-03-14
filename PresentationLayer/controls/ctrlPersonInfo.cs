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


        public void LoadPersonInfo(int PersonID)
        {
             _Person = clsPerson.Find(PersonID);

            if(_Person != null)
            {
                lblPersonID.Text=_Person.PersonID.ToString();
                lblNationalNumber.Text = _Person.NationalNumber; 
                lblName.Text=_Person.FullName;
                selecteGender(_Person.Gender);
                lblEmail.Text = _Person.Email;
                lblAddress.Text= _Person.Address;
                lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
                lblPhone.Text = _Person.PhoneNumber;
                lblCountryName.Text =_Person.CountryName();
                //picProfilePhoto.Image=Image.FromFile(_Person.ImagePath);
            }
        }

        public void LoadPersonInfo(string NationalNumber)
        {
            clsPerson person = clsPerson.Find(NationalNumber);

            if (person != null)
            {
                lblPersonID.Text = person.PersonID.ToString();
                lblNationalNumber.Text = person.NationalNumber;
                lblName.Text = person.FullName;
                selecteGender(person.Gender);
                lblEmail.Text = person.Email;
                lblAddress.Text = person.Address;
                lblDateOfBirth.Text = person.DateOfBirth.ToShortDateString();
                lblPhone.Text = person.PhoneNumber;
                lblCountryName.Text = person.CountryName();

                //picProfilePhoto.Image = Image.FromFile(_Person.ImagePath);
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
