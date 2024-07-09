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
        public frmTestAppointmentsList(int _LDL_Application,int _TestTypeID)
        {
            InitializeComponent();
            this._TestTypeID= _TestTypeID;
            this._LDL_Application = _LDL_Application;
        }
        private int _TestTypeID = -1;
        private int _LDL_Application = -1;


        private void frmTestAppointmentsList_Load(object sender, EventArgs e)
        {
            ctrlTestAppointments1.LoadTestAppointmentInof(_LDL_Application, _TestTypeID);
        }

    }
}
