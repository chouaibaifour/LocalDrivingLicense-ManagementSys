using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Users
{
    public partial class frmInternationalLicenseInfo : Form
    {
        private int _IntetnationalLicenseID;

        public frmInternationalLicenseInfo(int InternationalLicenseID)
        {
            InitializeComponent();
            _IntetnationalLicenseID = InternationalLicenseID;

        }

        private void InternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlInternationalLicenseInfo1.LoadInternationlLicneseInfo(_IntetnationalLicenseID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
