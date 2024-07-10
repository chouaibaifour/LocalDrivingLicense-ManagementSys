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
    public partial class frmReplacementDamagedLostLicense : Form
    {
        private int _ReplacementID;

        public frmReplacementDamagedLostLicense(int ReplacementID)
        {
            InitializeComponent();

            _ReplacementID = ReplacementID;
        }

        private void frmReplacementDamagedLostLicense_Load(object sender, EventArgs e)
        {
            ctrlReplacementDamagedOrLostLicense1.LoadReplacementInfo(_ReplacementID);
        }
    }
}
