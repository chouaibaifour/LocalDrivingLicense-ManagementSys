using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Licenses
{
    public partial class frmAddUpdateLicense : Form
    {
        private int _LicenseID;
        private int _LDL_Application;

        public frmAddUpdateLicense(int LicenseID,int LDL_ApplicationID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
            _LDL_Application= LDL_ApplicationID;
        }


        private void frmAddUpdateLicense_Load(object sender, EventArgs e)
        {
            ctrlAddUpdateLicense1.LoadLicenseInfo(_LicenseID, _LDL_Application);
        }
    }
}
