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
    public partial class frmTestAppointmentsList : Form
    {

        public delegate void SendBackData();
        public event SendBackData sendBackData;

        public frmTestAppointmentsList(int _LDL_Application,int _TestTypeID)
        {
            InitializeComponent();
            this._TestTypeID= _TestTypeID;
            this._LDL_Application = _LDL_Application;
        }

        private int _TestTypeID = -1;
        private int _LDL_Application = -1;

        private void _PrintTestType()
        {
            switch (_TestTypeID)
            {
                case 1:
                    lblTestType.Text = "Vision Test Appointment";
                    picTestType.Image = Image.FromFile("F:\\repos\\Icons\\64px\\eye.png");
                    break;
                case 2:
                    lblTestType.Text = "Written Test Appointment";
                    picTestType.Image = Image.FromFile("F:\\repos\\Icons\\64px\\papers.png");
                    break;
                 case 3:
                    lblTestType.Text = "Street Test Appointment";
                    picTestType.Image = Image.FromFile("F:\\repos\\Icons\\64px\\steering_wheel.png");
                    break;
            }
        }

        private void frmTestAppointmentsList_Load(object sender, EventArgs e)
        {
            _PrintTestType();
            ctrlTestAppointments1.LoadTestAppointmentInof(_LDL_Application, _TestTypeID);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTestAppointmentsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (null != sendBackData)
                sendBackData.Invoke();
        }
    }
}
