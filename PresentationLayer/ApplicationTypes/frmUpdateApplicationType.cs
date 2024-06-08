using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.ApplicationTypes
{
    public partial class frmUpdateApplicationType : Form
    {
        public frmUpdateApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();

            _ApplicationTypeID = ApplicationTypeID;

        }

        private int _ApplicationTypeID;

        private clsApplicationType _ApplicationType;
        
        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {

        }
    }
}
