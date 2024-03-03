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
    public partial class ctrlAddNewUpdatePerson : UserControl
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;
        public ctrlAddNewUpdatePerson()
        {
            InitializeComponent();
        }

        int _PersonID;
        clsPerson _Person;

        public void Load_PersonInfo(int PersonID)
        {
            if (-1 == PersonID)
            {
                _PersonID = PersonID;
                _Mode = enMode.AddNew;
            }
            else
            {
                _PersonID = PersonID;
                _Mode = enMode.Update;
            }

            _LoadData();
        }

        private void _FillCountriesInComboBox()
        {
            DataTable dt = clsCountry.GetAllCountries();
            foreach (DataRow row in dt.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
            cbCountry.SelectedText = "Algeria";

        }

        private void ValidatingEmptyOrNulltxt(object sender, CancelEventArgs e)
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

            if (clsPerson.IsPersonExists(txtNationalNumber.Text))
            {
                e.Cancel = true;
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

            if (clsPerson.IsEmailExists(txtEmail.Text) || !IsEmailValid(txtEmail.Text))
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
                string FilePath = @"F:\\repos\\Icons\\PersonProfilePics\\" + Guid.NewGuid().ToString() + ".png";
                //Get the path of specified file
                File.Copy(openFileDialog.FileName, FilePath);
                picProfile.Image = Image.FromFile(FilePath);
                picProfile.ImageLocation = FilePath;
                llbRemove.Visible = true;

            }
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked)
            {
                lblGenderIcon.Image = Resources.person_man;

            }
            else if (rbFemale.Checked)
            {
                lblGenderIcon.Image = Resources.person_woman;
            }
        }

        private void _SelecteGender(bool Gender)
        {
            if (Gender)
            {
                rbMale.Checked = true;
                lblGenderIcon.Image = Resources.person_man;
                return;

            }
            else {
                rbFemale.Checked = true;
                lblGenderIcon.Image = Resources.person_woman;
            }
                
            picProfile.Image = Image.FromFile("F:\\repos\\Icons\\72px\\NoProfilePic.png");
        }
        
    

        private void _LoadData()
        {
            _FillCountriesInComboBox();
            cbCountry.SelectedIndex = 0;
            if (enMode.AddNew.Equals(_Mode))
            {
                // Add New Person Mode 
                lblMode.Text = "Add New Person";
                _Person = new clsPerson();
                return;

            }
            _Person = clsPerson.Find(_PersonID);

            if(null== _Person)
            {
                MessageBox.Show("This form will be Close because no Person with PersonID : " + _PersonID.ToString());
                (this.FindForm()).Close();
            }
            // Update Mode 
            lblMode.Text = "Edit Person Info";

            lblPersonID.Text = _Person.PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text =_Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNumber.Text = _Person.NationalNumber;
            dtpDateOfBirth.Value = _Person.DateOfBirth.Date;
            _SelecteGender(_Person.Gender);
            txtPhoneNumber.Text = _Person.PhoneNumber;
            txtEmail.Text = _Person.Email;
            rtxtAddress.Text = _Person.Address;
            
            if (!"".Equals(_Person.ImagePath))
            {
                picProfile.Image = Image.FromFile(_Person.ImagePath);

            }
            llbRemove.Visible = (!"".Equals(_Person.ImagePath));
            cbCountry.SelectedIndex =cbCountry.FindString( _Person.CountryName());

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
            _Person.NationalNumber = txtNationalNumber.Text;
            _Person.FirstName = txtFirstName.Text;
            _Person.SecondName = txtSecondName.Text;
            _Person.ThirdName = txtThirdName.Text;
            _Person.LastName = txtLastName.Text;
            _Person.Gender = rbMale.Checked;
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.Email = txtEmail.Text;
            _Person.Address = rtxtAddress.Text;
            _Person.PhoneNumber =txtPhoneNumber.Text;
            int CountryID;
            if ((CountryID = GetCountryID(cbCountry.Text)) > 0) 
                _Person.NationalityCountryID=CountryID;

            _Person.ImagePath = (null!=picProfile.ImageLocation)?picProfile.ImageLocation:"";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GetPersonInfoFromForm();
            if (_Person.Save())
                MessageBox.Show("Person Saved Successfully.");
            else
                MessageBox.Show("Error : Data is not Saved Successfully.");
            _Mode = enMode.Update;
            lblMode.Text = "Edit Person Info";
            lblPersonID.Text=_PersonID.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            (this.FindForm()).Close();
        }

        private void llbRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picProfile.Image=null;
        }
    }
}
