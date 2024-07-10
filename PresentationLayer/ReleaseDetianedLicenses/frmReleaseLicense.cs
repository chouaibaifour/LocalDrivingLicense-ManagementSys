using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.ReleaseDetianedLicenses
{
    public partial class frmReleaseLicense : Form
    {
        private int _LidcenseID;

        public frmReleaseLicense(int LicesneID)
        {
            InitializeComponent();
            _LidcenseID = LicesneID;
        }
    }
}
