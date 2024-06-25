using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.LocalLicenseApplication
{
    public partial class frmAddUpdateLocal_L_Application : Form
    {
        public delegate void DataBackEventHandler();
        public event DataBackEventHandler SendDataBack;

        public frmAddUpdateLocal_L_Application(int LDL_ApplicationID)

        {
            this._LDL_ApplicationID = LDL_ApplicationID;
            InitializeComponent();
        }

        private int _LDL_ApplicationID;

        private void frmAddUpdateLocal_L_Application_Load(object sender, EventArgs e)
        {
            ctrlAddUpdateLocal_L_Application1.Load_LDL_ApplicationInfo(_LDL_ApplicationID);
        }

        private void frmAddUpdateLocal_L_Application_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (SendDataBack != null)
                SendDataBack.Invoke();
        }
    }
}
