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
    public partial class frmPersonLicenseHistory : Form
    {
        private int _PersonID;

        public frmPersonLicenseHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            FindForm().Close();
        }

        private void frmPersonLicenseHistory_Load(object sender, EventArgs e)
        {
            ctrlPersonLicenseHistory1.LoadPersonLicenseHistory(_PersonID);
        }
    }
}
