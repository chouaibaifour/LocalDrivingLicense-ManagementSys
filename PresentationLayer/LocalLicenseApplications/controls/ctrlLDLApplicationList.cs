using BusinessLayer;
using PresentationLayer.Licenses;
using PresentationLayer.LocalLicenseApplications;
using PresentationLayer.TestAppointments;
using PresentationLayer.Users;
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
    public partial class ctrlLDLApplicationList : UserControl
    {
        public ctrlLDLApplicationList()
        {
            InitializeComponent();
        }

        string Filter;

        DataView dataView = cls_LDL_Application.GetAllApplications().DefaultView;


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }


        private void _FillAll_LDLApplicationsTo_dgv()
        {
            DataTable dt = cls_LDL_Application.GetAllApplications();

           dgvLDLApplications.DataSource = dt;

            lblRecordCount.Text =dgvLDLApplications.RowCount.ToString();

        }

        private void _getClomnName(int index)
        {
            Filter = "";

            string[] Filters = {
            "L.D.L.AppID",
            "NationalNo",
            "FullName",
            "Status"};

            if (Filters.Length <= index && 0 > index)
                return;

            Filter = @Filters[index - 1];
        }

        private void ValidatingEmptyOrNulltxt(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
               

                epEmptyOrNull.SetError(textBox, "Invalid input try again !");
            }
            else
            {
                
                epEmptyOrNull.SetError(textBox, "");
            }
        }

        private void ctrlLDLApplicationList_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;

            _FillAll_LDLApplicationsTo_dgv();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                switch (cbStatus.SelectedIndex) {

                case 0:
                        dgvLDLApplications.DataSource = cls_LDL_Application.GetAllApplications();
                        return;
                case 1:
                        dataView.RowFilter = "Status  LIKE 'New' ";
                    break;
                case 2:

                     dataView.RowFilter="Status  LIKE 'In Progress' ";
                    break;
                case 3:
                     dataView.RowFilter="Status  LIKE 'Completed' ";
                    break;
                case 4:
                     dataView.RowFilter="Status  LIKE 'Canceled' ";
                    break;

                }

                    
                   
            }
            catch (Exception)
            {

            }

            dgvLDLApplications.DataSource = dataView.ToTable();

            lblRecordCount.Text = dgvLDLApplications.RowCount.ToString();
        }

        private void cbFilters_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (0 != cbFilters.SelectedIndex)
            {
                if (cbFilters.SelectedItem.ToString().Equals("Status"))
                {

                    txtFilterValue.Visible = false;

                    cbStatus.Visible = true;

                }
                else
                {
                    txtFilterValue.Visible = true;

                    cbStatus.Visible = false;

                    txtFilterValue.Text = string.Empty;

                }

                return;


            }

            txtFilterValue.Visible = false;

            txtFilterValue.Text = string.Empty;

            dgvLDLApplications.DataSource = cls_LDL_Application.GetAllApplications().DefaultView;

            lblRecordCount.Text = dgvLDLApplications.RowCount.ToString();
        }

        private void txtFilterValue_KeyUp_1(object sender, KeyEventArgs e)
        {
            _getClomnName(cbFilters.SelectedIndex);
            //Filter = Filter.Replace(" ", "");

            if (!"L.D.L.AppID".Equals(Filter))
            {
                Filter += @" LIKE '%" + txtFilterValue.Text + "%'";
            }
            else
            {
                if (!int.TryParse(txtFilterValue.Text, out int AppID))
                {

                    txtFilterValue.Text = string.Empty;
                    Filter += @"=0";

                }
                else
                {

                    Filter += @"=" + AppID.ToString();
                }

            }

            try
            {
                dataView.RowFilter = Filter;

            }
            catch (Exception)
            {

            }

          dgvLDLApplications.DataSource = dataView.ToTable();

            lblRecordCount.Text = dgvLDLApplications.RowCount.ToString();
        }

        private void btnAddApplication_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocal_L_Application frmAddUpdateLocal_L_Application = new frmAddUpdateLocal_L_Application(-1);

            frmAddUpdateLocal_L_Application.SendDataBack += _FillAll_LDLApplicationsTo_dgv;

            frmAddUpdateLocal_L_Application.ShowDialog();
            
        }

        private void smiApplicationDetails_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dgvLDLApplications.CurrentRow.Cells[0].Value.ToString(), out int LDL_ApplicationID))
            {
                frmLDLApplicationInfo frmLDLApplicationInfo = new frmLDLApplicationInfo(LDL_ApplicationID);

                frmLDLApplicationInfo.ShowDialog();
            }


        }

        private void smiEditApplication_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dgvLDLApplications.CurrentRow.Cells[0].Value.ToString(), out int LDL_ApplicationID))
            {
                frmAddUpdateLocal_L_Application frmAddUpdateLocal_L_Application = new frmAddUpdateLocal_L_Application(LDL_ApplicationID);
                frmAddUpdateLocal_L_Application.SendDataBack += _FillAll_LDLApplicationsTo_dgv;
                frmAddUpdateLocal_L_Application.ShowDialog();
            }
        }

        private void smiDeleteApplication_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dgvLDLApplications.CurrentRow.Cells[0].Value.ToString(),out int LDL_ApplicationID))
            {
                if(cls_LDL_Application.IsApplicationExists(LDL_ApplicationID))
                {
                    if (MessageBox.Show("Do you want to delete this Application ?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        int ApplicationID = cls_LDL_Application.Find(LDL_ApplicationID).ApplicationID;

                        if (cls_LDL_Application.DeleteApplication(LDL_ApplicationID))
                        {
                            if (clsApplication.DeleteApplication(ApplicationID))
                            {
                                MessageBox.Show("Application has Been Deleted Successfully !");
                            }
                            else
                                MessageBox.Show("this Application is related with Data can not be Deleted !");
                        }
                        else
                            MessageBox.Show("this Application is related with Data can not be Deleted !");
                    }
                   
                }
            }
            _FillAll_LDLApplicationsTo_dgv();
        }

        private void CancelApplication_Click(object sender, EventArgs e)
        {

            if (int.TryParse(dgvLDLApplications.CurrentRow.Cells[0].Value.ToString(), out int LDL_ApplicationID))
                if (_CancelApplication(LDL_ApplicationID))

                    MessageBox.Show("the Application Canceled Successfully!");
                else
                    MessageBox.Show("oops! Unexpected Error, Try again");
            _FillAll_LDLApplicationsTo_dgv();

        }

        private bool _CancelApplication(int LDL_ApplicationID)
        {
            cls_LDL_Application _LDL_Application = cls_LDL_Application.Find(LDL_ApplicationID);

            if (_LDL_Application != null)
            {
                clsApplication _Application = clsApplication.Find(_LDL_Application.ApplicationID);

                if (_Application != null)
                {
                    // updating Status to canceled 
                    _Application.ApplicationStatus = 4;
                    _Application.LastStatusDate = DateTime.Now;

                    if (MessageBox.Show("are you sure do want to Cancel this Application", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (_Application.Save())
                        {
                            return true;
                        }
                        return false;
                    }
                    return false;
                }
                return false;
            }

            return false;
        }

        private void smiIssueDrivingLicesne_Click(object sender, EventArgs e)
        {

            if (int.TryParse(dgvLDLApplications.CurrentRow.Cells[0].Value.ToString(), out int LDL_ApplicationID))
            {
                frmAddUpdateLicense frmAddUpdateLicense = new frmAddUpdateLicense(-1, LDL_ApplicationID);
                frmAddUpdateLicense.ShowDialog();
            }
                
        }

        private void smiShowLicense_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dgvLDLApplications.CurrentRow.Cells[0].Value.ToString(), out int LDL_ApplicationID))
            {
                frmLicenseInfo frmLicenseInfo = new frmLicenseInfo(clsLicense
                                                                            .FindByApplicationID(cls_LDL_Application
                                                                            .Find(LDL_ApplicationID)
                                                                            .ApplicationID)
                                                                            .LicenseID);
                frmLicenseInfo.ShowDialog();
            }

        }

        private void smiShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
           
            frmPersonLicenseHistory frmPersonLicenseHistory = new frmPersonLicenseHistory(clsPerson.Find(dgvLDLApplications.CurrentRow.Cells[2].Value.ToString()).PersonID);

            frmPersonLicenseHistory.ShowDialog();

        }

        private void cmsLDLApplicationList_Opening(object sender, CancelEventArgs e)
        {
            bool isVisionTestEnable;
            bool isWrittenTestEnable;
            bool isStreetTestEnable;

            if (int.TryParse(dgvLDLApplications.CurrentRow.Cells[0].Value.ToString(), out int LDL_ApplicationID))
            {

                smiScheduleTest.Enabled = true;
                smiApplicationDetails.Enabled = true;
                smiDeleteApplication.Enabled = true;
                smiEditApplication.Enabled = true;
                CancelApplication.Enabled = true;
                smiShowLicense.Enabled = false;
                smiIssueDrivingLicesne.Enabled = false;

                isVisionTestEnable = clsTest.IsTestPassed(LDL_ApplicationID, 1);
                if (!isVisionTestEnable)
                {
                    smiIssueDrivingLicesne.Enabled = false;
                    smiScheduleTest.Enabled = true;
                    smiVisionTest.Enabled = true;
                    smiWrittenTest.Enabled = false;
                    smiStreetTest.Enabled = false;
                }
                else
                {
                    isWrittenTestEnable = clsTest.IsTestPassed(LDL_ApplicationID, 2);
                    if (!isWrittenTestEnable)
                    {
                        smiIssueDrivingLicesne.Enabled = false;
                        smiScheduleTest.Enabled = true;
                        smiVisionTest.Enabled = false;
                        smiWrittenTest.Enabled = true;
                        smiStreetTest.Enabled = false;
                    }
                    else
                    {
                        isStreetTestEnable = clsTest.IsTestPassed(LDL_ApplicationID, 3);
                        if (!isStreetTestEnable)
                        {
                            smiIssueDrivingLicesne.Enabled = false;
                            smiScheduleTest.Enabled = true;
                            smiVisionTest.Enabled = false;
                            smiWrittenTest.Enabled = false;
                            smiStreetTest.Enabled = true;
                        }
                        else
                        {
                            smiScheduleTest.Enabled = false;
                            smiVisionTest.Enabled = false;
                            smiWrittenTest.Enabled = false;
                            smiStreetTest.Enabled = false;
                            smiIssueDrivingLicesne.Enabled = true;
                        }
                    }
                    if (clsLicense.IsLicenseExistsByApplicationID(cls_LDL_Application.Find(LDL_ApplicationID).ApplicationID))
                    {
                        smiShowLicense.Enabled = true;
                        smiScheduleTest.Enabled = false;
                        smiApplicationDetails.Enabled = false;
                        smiDeleteApplication.Enabled = false;
                        smiEditApplication.Enabled = false;
                        CancelApplication.Enabled= false;
                        smiIssueDrivingLicesne.Enabled = false;
                    }
                    else
                    {
                        smiShowLicense.Enabled = false;
                    }

                       
                }


            }
        }

        private void smiVisionTest_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dgvLDLApplications.CurrentRow.Cells[0].Value.ToString(), out int LDL_ApplicationID))
            {
                frmTestAppointmentsList frmTestAppointmentsList = new frmTestAppointmentsList(LDL_ApplicationID, 1);

                frmTestAppointmentsList.sendBackData += _FillAll_LDLApplicationsTo_dgv;

                frmTestAppointmentsList.ShowDialog();
            }
                
        }

        private void smiWrittenTest_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dgvLDLApplications.CurrentRow.Cells[0].Value.ToString(), out int LDL_ApplicationID))
            {
                frmTestAppointmentsList frmTestAppointmentsList = new frmTestAppointmentsList(LDL_ApplicationID, 2);

                frmTestAppointmentsList.sendBackData += _FillAll_LDLApplicationsTo_dgv;

                frmTestAppointmentsList.ShowDialog();

            }
        }

        private void smiStreetTest_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dgvLDLApplications.CurrentRow.Cells[0].Value.ToString(), out int LDL_ApplicationID))
            {
                frmTestAppointmentsList frmTestAppointmentsList = new frmTestAppointmentsList(LDL_ApplicationID, 3);

                frmTestAppointmentsList.sendBackData += _FillAll_LDLApplicationsTo_dgv;

                frmTestAppointmentsList.ShowDialog();

            }
        }
    }
}
