using BusinessLayer;
using PresentationLayer.People.controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BusinessLayer.clsApplication;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace PresentationLayer.TestAppointments.controls
{
    public partial class ctrlAddUpdateTestAppointment : UserControl
    {

        public enum enMode { AddNew = 0, Update = 1 ,Locked=2,Retake=3}

        private enMode _Mode;

        int _AppointmentID;

        clsTestAppointment _Appointment;

        public ctrlAddUpdateTestAppointment()
        {
            InitializeComponent();
        }

        private int _LDL_ApplicationID;

        private int _TestTypeID;

        private void _SetAppointmentTheme(int TestTypeID)
        {
            switch (TestTypeID)
            {
                case 1:
                    
                    picTestType.Image = Image.FromFile("F:\\repos\\Icons\\64px\\eye.png");
                    lblTestType.Text = "Schedule Eye Test";
                    break;
                case 2:
                    
                    picTestType.Image = Image.FromFile("F:\\repos\\Icons\\64px\\papers.png");
                    lblTestType.Text = "Schedule Written Test";
                    break;
                case 3:
                    lblTestType.Text = "Schedule Street Test";
                    picTestType.Image = Image.FromFile("F:\\repos\\Icons\\64px\\steering_wheel.png");
                    break;
            }
        }

        private void _LoadData()
        {
            switch ((int)_Mode)
            {
                case 0:
                    _FillDataInForm_AddNew();
                    _SetAppointmentTheme(_TestTypeID);
                break;
                   
                case 1:
                    _FillDataInForm_Update();
                    _SetAppointmentTheme(_Appointment.TestTypeID);
                break;

                case 2:
                    
                    _FillDataInForm_Locked();
                    _SetAppointmentTheme(_Appointment.TestTypeID);
                break;

                case 3:
                    _SetAppointmentTheme(_TestTypeID);
                    _FillDataInForm_Retake();
                break;
            }

           
        }

        private void _FillDataInForm_AddNew()
        {
            _Appointment = new clsTestAppointment();

            lblLDLAppID.Text = _LDL_ApplicationID.ToString();

            lblLicenseClass.Text = clsLicenseClass.Find(cls_LDL_Application
                                                  .Find(_LDL_ApplicationID)
                                                  .LicenseClassID)
                                                  .ClassName;

            lblApplicantName.Text = clsPerson.Find(Find(cls_LDL_Application
                .Find(_LDL_ApplicationID)
                .ApplicationID)
                .ApplicantPersonID)
                .FullName;

            lblTrail.Text = clsTest.Trials(_LDL_ApplicationID, _TestTypeID).ToString();

            lblAppointmentFees.Text = clsTestType.Find(_TestTypeID).TestFees.ToString();

            lblTotalFees.Text = lblAppointmentFees.Text;

            

        }

        private void _FillDataInForm_Update()
        {
            _Appointment = clsTestAppointment.Find(_AppointmentID);

            if (null == _Appointment)
            {
                MessageBox.Show("this Form with be closed because no Appointment with ID :" + _AppointmentID.ToString());

                this.FindForm().Close();

                return;
            }

            lblLDLAppID.Text = _Appointment.LocalDrivingLicenseApplicationID.ToString();

            lblLicenseClass.Text = clsLicenseClass.Find(cls_LDL_Application
                                                  .Find(_Appointment.LocalDrivingLicenseApplicationID)
                                                  .LicenseClassID)
                                                  .ClassName;

            lblApplicantName.Text = clsPerson.Find(clsApplication
                                             .Find(cls_LDL_Application.Find(_Appointment.LocalDrivingLicenseApplicationID)
                                             .ApplicationID)
                                             .ApplicantPersonID)
                                             .FullName;

            lblTrail.Text = clsTest.Trials(_Appointment.LocalDrivingLicenseApplicationID, _Appointment.TestTypeID).ToString();

            dtpAppointmentDate.Value = _Appointment.AppointmentDate;

            lblAppointmentFees.Text = clsTestType.Find(_Appointment.TestTypeID).TestFees.ToString();

            if (clsRetakeTest.IsRetakeTestExistsbyAppointmentID(_AppointmentID))
            {
                clsRetakeTest _Retaktake = clsRetakeTest.FindByAppointmentID(_AppointmentID);

                if (null != _Retaktake)
                {
                    lblRetakeAppID.Text = _Retaktake.RetakeTestID.ToString();

                    lblRetakeFees.Text = clsApplication.Find(_Retaktake.ApplicationID).PaidFees.ToString();
                }               

                if (int.TryParse(lblAppointmentFees.Text, out int AppointmentFees))

                    lblTotalFees.Text = clsApplicationType.Find(8).ApplicationFees + AppointmentFees.ToString();

                

            }
            else
            {
                lblRetakeAppID.Text = "N/A";

                lblTotalFees.Text = lblAppointmentFees.Text;

                lblRetakeFees.Text=0.ToString();

                

            }



        }

        private void _FillDataInForm_Locked()
        {
            _Appointment = clsTestAppointment.Find(_AppointmentID);

            if (null == _Appointment)
            {
                MessageBox.Show("this Form with be closed because no Appointment with ID :" + _AppointmentID.ToString());

                this.FindForm().Close();

                return;
            }

            lblLDLAppID.Text = _Appointment.LocalDrivingLicenseApplicationID.ToString();

            lblLicenseClass.Text = clsLicenseClass.Find(cls_LDL_Application
                                                  .Find(_Appointment.LocalDrivingLicenseApplicationID)
                                                  .LicenseClassID)
                                                  .ClassName;

            lblApplicantName.Text = clsPerson.Find(Find(cls_LDL_Application.Find(_Appointment.LocalDrivingLicenseApplicationID)
                                             .ApplicationID)
                                             .ApplicantPersonID)
                                             .FullName;

            lblTrail.Text = clsTest.Trials(_Appointment.LocalDrivingLicenseApplicationID, _Appointment.TestTypeID).ToString();

            dtpAppointmentDate.Value = _Appointment.AppointmentDate;

            dtpAppointmentDate.Enabled = false;

            lblAppointmentFees.Text = clsTestType.Find(_Appointment.TestTypeID).TestFees.ToString();

            if (clsRetakeTest.IsRetakeTestExistsbyAppointmentID(_AppointmentID))
            {
                clsRetakeTest _Retaktake = clsRetakeTest.FindByAppointmentID(_AppointmentID);

                if (null != _Retaktake)
                {
                    lblRetakeAppID.Text = _Retaktake.RetakeTestID.ToString();

                    lblRetakeFees.Text = Find(_Retaktake.ApplicationID).PaidFees.ToString();
                }

                if (int.TryParse(lblAppointmentFees.Text, out int AppointmentFees))

                    lblTotalFees.Text = clsApplicationType.Find(8).ApplicationFees + AppointmentFees.ToString();

                

            }
            else
            {
                lblRetakeAppID.Text = "N/A";

                lblTotalFees.Text = lblAppointmentFees.Text;

                lblRetakeFees.Text = 0.ToString();

                

            }

            lblNotification.Text = "this Person Already sat for the test, Appointment locked.";

            btnSave.Enabled = false;

        }

        private void _FillDataInForm_Retake()
        {
            _Appointment = new clsTestAppointment();


            lblLDLAppID.Text = _LDL_ApplicationID.ToString();

            lblLicenseClass.Text = clsLicenseClass.Find(cls_LDL_Application
                                                  .Find(_LDL_ApplicationID)
                                                  .LicenseClassID)
                                                  .ClassName;
            lblApplicantName.Text = clsPerson.Find(Find(cls_LDL_Application.Find(_LDL_ApplicationID).
                ApplicationID).
                ApplicantPersonID).
                FullName;

            lblTrail.Text = clsTest.Trials(_LDL_ApplicationID, _TestTypeID).ToString();

            lblAppointmentFees.Text = clsTestType.Find(_TestTypeID).TestFees.ToString();

            if (
                int.TryParse(lblAppointmentFees.Text, out int AppointmentFees)

                && 
                
                int.TryParse(clsApplicationType.Find(8).ApplicationFees.ToString(), out int RetakeFees)
                )
            {

                lblTotalFees.Text = (RetakeFees + AppointmentFees).ToString();

                lblRetakeFees.Text = RetakeFees.ToString();
            }

           

            lblRetakeAppID.Text = "N/A";


        }

        public void LoadAppointmentInfo(int AppointmentID, int Mode, int LDL_ApplicationID = -1, int TestTypeID = -1)
        {

            switch (Mode)
            {
                case 0:
                    this._LDL_ApplicationID = LDL_ApplicationID;
                    this._TestTypeID = TestTypeID;

                    _Mode = enMode.AddNew;
                    break;
                case 1:
                    _AppointmentID = AppointmentID;
                    _Mode = enMode.Update;
                    break;

                case 2:
                    _AppointmentID = AppointmentID;
                    _Mode = enMode.Locked;
                    break;

                case 3:
                    this._LDL_ApplicationID = LDL_ApplicationID;
                    this._TestTypeID = TestTypeID;
                    _Mode = enMode.Retake;

                    break;
            }

            _LoadData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindForm().Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch ((int)_Mode)
            {
                case 0:
                    _SaveAppointment_AddNew();
                    break;

                case 1:
                    _SaveAppointment_Update();
                    break;

                case 3:
                    _SaveAppointment_Retake();
                    break;
            }
        }

        private void _SaveAppointment_Retake()
        {
            int _AppID = _AddNewApplication();

            if (-1!= _AppID)
            {
                clsRetakeTest _RetakeTest = new clsRetakeTest();
                _RetakeTest.ApplicationID = _AppID;
                _SaveAppointment_AddNew();
                _RetakeTest.TestAppointmentID = _Appointment.TestAppointmentID;

                if (_RetakeTest.Save())
                {
                    MessageBox.Show("Appointment has been successfully Updated.");
                    _Mode = enMode.Update;
                    lblRetakeAppID.Text = _RetakeTest.RetakeTestID.ToString();
                }
                else
                    MessageBox.Show("Something happen try agian !");

            }
        }

        private int _AddNewApplication()
        {
            clsApplication _Application = new clsApplication();



            _Application.ApplicantPersonID = Find(cls_LDL_Application.Find(_LDL_ApplicationID).ApplicationID).ApplicantPersonID;

            _Application.ApplicationDate = DateTime.Now;

            _Application.ApplicationTypeID = 8;// Retake Test

            _Application.ApplicationStatus = (byte)enStatus.InProgerss;

            _Application.LastStatusDate = DateTime.Now;

            _Application.PaidFees = clsApplicationType.Find(8).ApplicationFees;

            _Application.CreatedByUserID = frmHome.auth.UserID;

            if (_Application.Save())
            {
                return _Application.ApplicationID;
            }
            return -1;
        }

        private void _SaveAppointment_Update()
        {
            
            _Appointment.AppointmentDate = dtpAppointmentDate.Value;
            

            if (_Appointment.Save())
            {
                MessageBox.Show("Appointment has been successfully Updated.");
                _Mode = enMode.Update;
            }
            else
                MessageBox.Show("Something happen try agian !");
        }

        private void _SaveAppointment_AddNew()
        {

            _Appointment.LocalDrivingLicenseApplicationID = _LDL_ApplicationID;
            _Appointment.IsLocked = false;
            _Appointment.PaidFees = clsTestType.Find(_TestTypeID).TestFees;
            _Appointment.AppointmentDate = dtpAppointmentDate.Value;

            _Appointment.CreatedByUserID = frmHome.auth.UserID;
            _Appointment.TestTypeID = _TestTypeID;

            if (!_Mode.Equals(enMode.Retake))
                if (_Appointment.Save())
                {
                    MessageBox.Show("Appointment has been successfully scheduled.");
                    _Mode = enMode.Update;
                }
                else
                    MessageBox.Show("Something happen try agian !");

        }

    }
}
