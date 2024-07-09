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

namespace PresentationLayer.Tests.controls
{
    public partial class ctrlAddUpdateTest : UserControl
    {
        public ctrlAddUpdateTest()
        {
            InitializeComponent();
        }
        private enum enMode { AddNew = 1, Update=2 }

        private enMode _Mode;

        private clsTest _Test;

        private int _AppointmentID;

        private int _TestID;

        private clsTestAppointment _Appointment;

        public void LoadTestInfo(int TestID,int TestAppointmentID)
        {
            if (-1 == TestID)
            {
                _AppointmentID = TestAppointmentID;
                _TestID = TestID;
                _Mode = enMode.AddNew;
            }
            else
            {
                _Mode = enMode.Update;
                _TestID = TestID;
            }
            _LoadData();
        }

        private void _LoadData()
        {
            if (_Mode.Equals(enMode.AddNew))
            {
                _Test = new clsTest();
                _LoadTestAppointmentDate();
                return;
            }
            _Test =clsTest.Find(_TestID);
            
            if(null== _Test)
            {
                MessageBox.Show("this Form will be Closed because not such Test with ID : " + _TestID.ToString());
                FindForm().Close();
                return;
            }
            _AppointmentID = _Test.TestID;

            _LoadTestAppointmentDate();
            rbPass.Checked=_Test.TestResult;
            rbFail.Checked = !rbPass.Checked;
            rtxtNotes.Text = _Test.Notes;
        }

        private void _LoadTestAppointmentDate()
        {
             _Appointment = clsTestAppointment.Find(_AppointmentID);

            if( _Appointment != null )
            {
                lblLDLAppID.Text = _Appointment.LocalDrivingLicenseApplicationID.ToString();
                lblLicenseClass.Text = clsLicenseClass.Find(cls_LDL_Application
                                                      .Find(_Appointment.LocalDrivingLicenseApplicationID)
                                                      .LicenseClassID).ClassName;
                lblApplicantName.Text = clsPerson.Find(clsApplication
                                                 .Find(cls_LDL_Application
                                                 .Find(_Appointment.LocalDrivingLicenseApplicationID)
                                                 .ApplicationID)
                                                 .ApplicantPersonID)
                                                 .FullName;
                lblAppointmentFees.Text = _Appointment.PaidFees.ToString();
                lblAppointmentDate.Text= _Appointment.AppointmentDate.ToString("d");
                lblTrail.Text = clsTest.Trials(_Appointment.LocalDrivingLicenseApplicationID, _Appointment.TestTypeID)
                                       .ToString();

                rbFail.Checked = true;
                rtxtNotes.Text = "";

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _GetTestResult();

            if (_Test.Save())
            {
                _Appointment.IsLocked = true;

                if (_Test.TestResult)
                {
                    if (_Appointment.TestTypeID != 3)
                {
                        clsApplication Application = clsApplication
                                                        .Find(cls_LDL_Application
                                                        .Find(_Appointment.LocalDrivingLicenseApplicationID)
                                                        .ApplicationID);
                        if (null != Application)
                        {

                        Application.ApplicationStatus = 2;

                        Application.LastStatusDate= DateTime.Now;

                        Application.Save();

                        }
                   
                    }else 
                    {
                        clsApplication Application = clsApplication
                                                        .Find(cls_LDL_Application
                                                        .Find(_Appointment.LocalDrivingLicenseApplicationID)
                                                        .ApplicationID);
                    
                        Application.ApplicationStatus = 3;

                        Application.LastStatusDate = DateTime.Now;

                        Application.Save();

                    }
                }
                    


                if (_Appointment.Save())

                MessageBox.Show("Test was Saved Successfully !");

                _Mode = enMode.Update;

                lblTestID.Text = _Test.TestID.ToString();
            }
            else

                MessageBox.Show("Test was not saved Successfully !");
        }

        private void _GetTestResult()
        {
            if (rbPass.Checked)

                _Test.TestResult = true;

            else

                _Test.TestResult = false;

            _Test.Notes = rtxtNotes.Text;

            _Test.TestAppointmentID = _AppointmentID;

            _Test.CreatedByUserID = frmHome.auth.UserID;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FindForm().Close();
        }
    }
}
