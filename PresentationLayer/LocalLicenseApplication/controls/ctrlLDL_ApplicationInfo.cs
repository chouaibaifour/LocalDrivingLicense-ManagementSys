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

namespace PresentationLayer.LocalLicenseApplication.controls
{
    public partial class ctrlLDL_ApplicationInfo : UserControl
    {
        public ctrlLDL_ApplicationInfo()
        {
            InitializeComponent();
        }

        private int _LDL_ApplicationID = -1;
        private cls_LDL_Application _LDL_Application = null;

        public void LoadLDLApplicationInfo(int LDL_ApplicationInfo)
        {
            cls_LDL_Application _LDL_Application =cls_LDL_Application.Find(LDL_ApplicationInfo);

            if (_LDL_Application != null)
            {
                lblLDLAppID.Text = _LDL_Application.LDL_ApplicationID.ToString();
                lblLicenseClass.Text = clsLicenseClass.Find(_LDL_Application.LicenseClassID).LicenseClassName.ToString();
                // Passed Test todo later on 
              
            }
            else
            {

            }

        }

       
    }
}
