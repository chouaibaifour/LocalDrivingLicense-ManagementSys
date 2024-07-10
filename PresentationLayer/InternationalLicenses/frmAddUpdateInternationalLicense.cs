using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.InternationalLicenses
{
    public partial class frmAddUpdateInternationalLicense : Form
    {

        public delegate void SendBackData();

        public event SendBackData sendBackData;

        private int _InternationalLicenseID;

        public frmAddUpdateInternationalLicense(int InternationalLicenseID)
        {
            InitializeComponent();
            _InternationalLicenseID = InternationalLicenseID;
        }

        private void frmAddUpdateInternationalLicense_Load(object sender, EventArgs e)
        {
            ctrlAddUpdateInternationalLicense1.LoadInternationalLicenseInfo(_InternationalLicenseID);
        }

        private void frmAddUpdateInternationalLicense_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sendBackData != null)
                sendBackData.Invoke();

        }
    }
}
