using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using PresentationLayer.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace PresentationLayer
{
    public partial class ctrlAddNewPerson : UserControl
    {
        public ctrlAddNewPerson()
        {
            InitializeComponent();
        }
        clsPerson person;

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = clsCountry.GetAllCountries();
            cbCountry.DataSource = dt.Columns["CountryName"];
            cbCountry.Text = "Algeria";
        }
        
        private void ValidatingEmptyOrNulltxt(object sender,CancelEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                epEmptyOrNull.SetError(textBox, "Invalid input try again !");
            }
            else
            {
                e.Cancel = false;
                epEmptyOrNull.SetError(textBox, "");
            }
        }

        private void txtNationalNumber_Validating(object sender, CancelEventArgs e)
        {
            ValidatingEmptyOrNulltxt(sender, e);

            if(clsPerson.IsPersonExists(txtNationalNumber.Text))
            {
                e.Cancel=true;
                epEmptyOrNull.SetError(txtNationalNumber, "InValid National Number try agian !");
            }
            else
            {
                e.Cancel = false;
                epEmptyOrNull.SetError(txtNationalNumber, "");
            }
        }

        private bool IsEmailValid(string Email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(Email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            ValidatingEmptyOrNulltxt(sender, e);
            
            if (clsPerson.IsEmailExists(txtEmail.Text)|| !IsEmailValid(txtEmail.Text))
            {
                e.Cancel = true;
                epEmptyOrNull.SetError(txtEmail, "InValid Email try agian !");
            }
            else
            {
                e.Cancel = false;
                epEmptyOrNull.SetError(txtEmail, "");
            }
        }

        private void rtxtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(rtxtAddress.Text))
            {
                e.Cancel = true;
                rtxtAddress.Focus();
                epEmptyOrNull.SetError(rtxtAddress, "Invalid input try again !");
            }
            else
            {
                e.Cancel = false;
                epEmptyOrNull.SetError(rtxtAddress, "");
            }
        }

        private void llbSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog.InitialDirectory = "F:\\repos\\Icons\\figures";
            openFileDialog.Filter = "png files (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string FilePath = @"F:\\repos\\Icons\\PeopleProfiles\\" + Guid.NewGuid().ToString() + ".png";
                //Get the path of specified file
                File.Copy(openFileDialog.FileName,FilePath);
                picProfile.Image = Image.FromFile(FilePath);

            }
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMale.Checked)
            {
                lblGenderIcon.Image = Resources.person_man;

            }else if(rbFemale.Checked)
            {
                lblGenderIcon.Image = Resources.person_woman;
            }
        }

       public void UpdateOrAddNewPerson(int PersonID)
        {
            if (PersonID>0)
            {
                 person = clsPerson.Find(PersonID);

                if(person != null)
                {
                    FillForm();
                }
            }
            else {
                person = new clsPerson();
            }
        }

        private void selecteGender(bool Gender)
        {
            if (Gender)
            {
               rbMale.Checked = true;
                lblGenderIcon.Image = Resources.person_man;
                return;

            }
            rbFemale.Checked = true;
            lblGenderIcon.Image = Resources.person_woman;
        }

        private void FillForm()
        {
            lblPersonID.Text = person.PersonID.ToString();
            txtFirstName.Text = person.FirstName.ToString();
            txtSecondName.Text =person.SecondName.ToString();
            txtThirdName.Text = person.ThirdName.ToString();
            txtLastName.Text = person.LastName.ToString();
            txtNationalNumber.Text = person.NationalNumber.ToString();
            dtpDateOfBirth.Value = person.DateOfBirth;
            selecteGender(person.Gender);
            txtPhoneNumber.Text = person.PhoneNumber.ToString();
            txtEmail.Text = person.Email.ToString();
            rtxtAddress.Text = person.Address.ToString();
            cbCountry.DataSource = clsCountry.GetAllCountries();
            cbCountry.SelectedText = person.CountryName();

            picProfile.Image = (person.ImagePath != "") ? Image.FromFile(person.ImagePath) :
                (person.Gender) ? Image.FromFile("F:\\repos\\Icons\\72px\\person_man.png") :
                Image.FromFile("F:\\repos\\Icons\\72px\\person_woman.png");


        }
        private int GetCountryID(string CountryName)
        {
            clsCountry country = clsCountry.Find(CountryName);

            if (null!=country)
            {
                return country.CountryID;
            }
            
            return -1;
        }

        private void GetPersonInfoFromForm()
        {
            person.NationalNumber = txtNationalNumber.Text;
            person.FirstName = txtFirstName.Text;
            person.SecondName = txtSecondName.Text;
            person.ThirdName = txtThirdName.Text;
            person.LastName = txtLastName.Text;
            person.Gender = rbMale.Checked;
            person.DateOfBirth = dtpDateOfBirth.Value;
            person.Email = txtEmail.Text;
            person.Address = rtxtAddress.Text;
            person.PhoneNumber =txtPhoneNumber.Text;
            int CountryID;
            if ((CountryID = GetCountryID(cbCountry.SelectedText)) > 0) 
                person.NationalityCountryID=CountryID;
            person.ImagePath = openFileDialog.FileName;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GetPersonInfoFromForm();
            person.Save();

        }

        
    }
}
