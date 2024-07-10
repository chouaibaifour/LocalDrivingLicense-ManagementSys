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
    public partial class frmRenewLicense : Form
    {
        private int _RenewLicenseApplicationID;

        public frmRenewLicense(int RenewLicenseApplicationID)
        {
            InitializeComponent();

            _RenewLicenseApplicationID = RenewLicenseApplicationID;
        }

        private void frmRenewLicense_Load(object sender, EventArgs e)
        {
            ctrlRenewLicense1.LoadRenewLicenseInfo(_RenewLicenseApplicationID);
        }
    }
}
