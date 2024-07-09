using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Tests
{
    public partial class frmAddUpdateTest : Form
    {

        public delegate void DataBackEventHandler();
        public event DataBackEventHandler SendDataBack;

        public frmAddUpdateTest(int TestID,int TestAppointmentID)
        {
            InitializeComponent();
            
            _TestID = TestID;
            _TestAppointmentID= TestAppointmentID;
        }
        private int _TestID;
        private int _TestAppointmentID;

        private void frmAddUpdateTest_Load(object sender, EventArgs e)
        {
            ctrlAddUpdateTest1.LoadTestInfo(_TestID, _TestAppointmentID);
        }

        private void frmAddUpdateTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (SendDataBack != null)
                SendDataBack.Invoke();
        }
    }
}
