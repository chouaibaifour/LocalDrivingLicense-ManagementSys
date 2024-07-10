using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Licenses.controls
{
    public partial class ctrlFindLicense : UserControl
    {

        public event Action<int> OnLicenseSelected;

        protected virtual void OnlicenseSelected(int licenseID)
        {
            Action<int> handler = OnLicenseSelected;

            if(handler != null)
                handler(licenseID);
        } 
         
        public ctrlFindLicense()
        {
            InitializeComponent();
        }

        private void btnFindLicense_Click(object sender, EventArgs e)
        {
            if ("".Equals(txtFilterValue.Text))
                return;

            if(int.TryParse(txtFilterValue.Text,out int LicenseID))
            {
                ctrlLicenseInfo1.LoadLicenseInfo(LicenseID);


            }
        }

        public void LoadLicenseInfo(int LicenseID)
        {
            
           if( ctrlLicenseInfo1.LoadLicenseInfo(LicenseID))

            groupBox1.Enabled = false;
            txtFilterValue.Text = LicenseID.ToString();
        }

        private void ctrlLicenseInfo1_OnLicenseSelected(int obj)
        {
            if(OnLicenseSelected != null) 
                OnLicenseSelected(obj);
        }

        public void toUpdate(bool toUpdate)
        {
            groupBox1.Enabled = !toUpdate;
        }
    }
}
