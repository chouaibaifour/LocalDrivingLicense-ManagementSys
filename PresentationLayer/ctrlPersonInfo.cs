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
        public ctrlPersonInfo()
        {
            InitializeComponent();
        }

        private void selecteGender(bool Gender)
        {
            if (Gender)
            {
                lblGender.Text = "Male";
                lblGender.Image = Resources.person_man;
                return;

            }
            lblGender.Text = "Female";
            lblGender.Image = Resources.person_woman;
        }


        public void LoadPersonInfo(int PersonID)
        {
            clsPerson person = clsPerson.Find(PersonID);

            if(person != null)
            {
                lblPersonID.Text=person.PersonID.ToString();
                lblNationalNumber.Text = person.NationalNumber; 
                lblName.Text=person.FullName;
                selecteGender(person.Gender);
                lblEmail.Text = person.Email;
                lblAddress.Text= person.Address;
                lblDateOfBirth.Text = person.DateOfBirth.ToShortDateString();
                lblPhone.Text = person.PhoneNumber;
                lblCountryName.Text =person.CountryName();
                //picProfilePhoto.Image=Image.FromFile(person.ImagePath);
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

                //picProfilePhoto.Image = Image.FromFile(person.ImagePath);
            }
        }

        private void llbEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this will provide linkable label to update Person info
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
