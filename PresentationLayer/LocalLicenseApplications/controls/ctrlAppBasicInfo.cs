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
    public partial class ctrlAppBasicInfo : UserControl
    {
        public ctrlAppBasicInfo()
        {
            InitializeComponent();
        }
        private clsApplication _Application;
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        public void LoadApplicationBasicInfo(int ApplicationID)
        {
            _Application = clsApplication.Find(ApplicationID);

            if (_Application != null)
            {
                lblAppID.Text = _Application.ApplicationID.ToString();
                lblAppStatus.Text = getAppStatus();
                lblAppFees.Text = _Application.PaidFees.ToString();
                lblAppType.Text = clsApplicationType.Find(_Application.ApplicationTypeID).ApplicationTypeTitle.ToString();
                lblApplicant.Text = clsPerson.Find(_Application.ApplicantPersonID).FullName.ToString();
                lblAppDate.Text = _Application.ApplicationDate.ToString("d");
                lblLastStatusDate.Text = _Application.LastStatusDate.ToString("d");
                lblCreatedBy.Text = clsPerson.Find(clsUser.Find(_Application.CreatedByUserID).PersonID).FullName;

            }
            else
                MessageBox.Show("Application with ID :" + ApplicationID.ToString()
                    + "Can not be Found !");
        }

        private string getAppStatus()
        {
            string[] status ={
                "New",
                "In Progress",
                "Completed",
                "Canceled"
            };

            return status[_Application.ApplicationStatus - 1];

        }

        private void llblShowPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonInfo frmPersonInfo = new frmPersonInfo(_Application.ApplicantPersonID);
            frmPersonInfo.ShowDialog();
        }
    }
}
