using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.TestAppointments
{
    public partial class frmAddUpdateTestAppointment : Form
    {
        public delegate void SendBackData();
        public event SendBackData sendBackData;


        public frmAddUpdateTestAppointment(int TestAppointmentID,int _LocalDrivingLicenseApplicationID,int TestTypeID,int _Mode)
        {
            InitializeComponent();

            this._LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplicationID;
            this._TestTypeID = TestTypeID;
            this._Mode = _Mode;
            this._TestAppointmentID = TestAppointmentID;

        }

        private int _TestAppointmentID;
        private int _LocalDrivingLicenseApplicationID;
        private int _TestTypeID;
        private int _Mode;

        private void frmAddUpdateTestAppointment_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (null != sendBackData)
                sendBackData.Invoke();
        }

        private void frmAddUpdateTestAppointment_Load(object sender, EventArgs e)
        {
            ctrlAddUpdateTestAppointment1.LoadAppointmentInfo(
                _TestAppointmentID,
                _Mode, 
                _LocalDrivingLicenseApplicationID, 
                _TestTypeID);
        }
    }
}
