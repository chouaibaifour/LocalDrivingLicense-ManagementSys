using BusinessLayer;
using PresentationLayer.Licenses;
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


        public event Action<int> OnLDLD_ApplicationSelected;

        protected virtual void LDL_ApplicationSelected(int LDL_ApplicationID)
        {
            Action<int> handler = OnLDLD_ApplicationSelected;

            if (handler != null)

                handler(LDL_ApplicationID);

        }

        private cls_LDL_Application _LDL_Application = null;

        public void LoadLDLApplicationInfo(int LDL_ApplicationInfo)
        {
             _LDL_Application =cls_LDL_Application.Find(LDL_ApplicationInfo);

            if (_LDL_Application != null)
            {
                lblLDLAppID.Text = _LDL_Application.LDL_ApplicationID.ToString();

                lblLicenseClass.Text = clsLicenseClass.Find(_LDL_Application.LicenseClassID).ClassName.ToString();

                lblPassedTest.Text = clsTest.PassedTests(_LDL_Application.LDL_ApplicationID).ToString();

                llblShowLicenseInfo.Enabled = clsLicense.IsLicenseExistsByApplicationID(_LDL_Application.ApplicationID);

                ctrlAppBasicInfo1.LoadApplicationBasicInfo(_LDL_Application.ApplicationID);

                if (OnLDLD_ApplicationSelected != null)
                {
                    LDL_ApplicationSelected(_LDL_Application.LDL_ApplicationID);
                }
            }
            else
            
                MessageBox.Show("Local Driving license Application with ID : " 
                    + _LDL_Application.LDL_ApplicationID.ToString()+ "Can not be Found !");

        }


        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           frmLicenseInfo frmLicenseInfo = new frmLicenseInfo(clsLicense.FindByApplicationID(_LDL_Application.ApplicationID).LicenseID);
            frmLicenseInfo.ShowDialog();
        }

        
    }
}
