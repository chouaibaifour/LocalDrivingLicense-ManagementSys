using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;


namespace PresentationLayer.LocalLicenseApplication.controls
{
    public partial class ctrlAddUpdateLocal_L_Application : UserControl
    {
        public enum enMode { AddNew = 0, Update = 1 }

        private enMode _Mode;
        private int _LDL_ApplicationID = -1;
        private cls_LDL_Application _LDL_Application;
        private clsApplication _Application;
        private int _PersonID;

        
        public ctrlAddUpdateLocal_L_Application()
        {
            InitializeComponent();
        }

        private void _FillLicenseClasssInComboBox()
        {
            DataTable dt = clsLicenseClass.GetAllLicenseClasses();

            foreach (DataRow row in dt.Rows)
            {

                cbLicenseClasses.Items.Add(row["ClassName"]);

            }

            cbLicenseClasses.SelectedIndex = 2;

        }

        public void Load_LDL_ApplicationInfo(int LDL_ApplicationID)
        {
            if (-1 == LDL_ApplicationID)
            {
                this._LDL_ApplicationID = LDL_ApplicationID;

                _Mode = enMode.AddNew;

            }
            else
            {
                _LDL_ApplicationID = LDL_ApplicationID;
                
                _Mode = enMode.Update;
            }

            _LoadData();
        }

        public void CreateNewApplication()
        {
            _Application = new clsApplication();

            // Application Type 
            clsApplicationType ApplicationType = clsApplicationType.Find(1); // 1 means Local Driving License

            if (null!= ApplicationType)

            _Application.ApplicationTypeID = ApplicationType.ApplicationTypeID;

            _Application.PaidFees =ApplicationType.ApplicationFees;

            //_Application.CreatedByUserID = frmHome.auth.UserID;
            _Application.CreatedByUserID = 1;


        }

        private void _LoadData()
        {
            _FillLicenseClasssInComboBox();
            if (enMode.AddNew.Equals(_Mode))
            {
                // Add New LDL_Application Mode 
                _LDL_Application = new cls_LDL_Application();
                CreateNewApplication();

                //_LDL_Application.ApplicationID = _Application.ApplicationID;
                _FillFormWith_LDL_ApplicationData();

                return;

            }

            _LDL_Application = cls_LDL_Application.Find(_LDL_ApplicationID);
            


            if (null == _LDL_Application)
            {
                MessageBox.Show("This form will be Close because no User with LDL AppID : " + _LDL_ApplicationID.ToString());

                (this.FindForm()).Close();
                return;
            }
            _Application = clsApplication.Find(_LDL_Application.ApplicationID);
            if (null == _Application)
            {
                MessageBox.Show("This form will be Close because no User with ApplicationID : " + _LDL_Application.ApplicationID.ToString());

                (this.FindForm()).Close();

                return;
            }
            // Update Mode 
            lblMode.Text = "Update Local Driving License Application";
            _FillFormWith_LDL_ApplicationData();
        }

        private void _FillFormWith_LDL_ApplicationData()
        {
            if (_Mode.Equals(enMode.AddNew))
            {
                lblDLApplicationID.Text = "-1";
                lblApplicationDate.Text = _Application.ApplicationDate.ToString("d");
                lblApplicationFees.Text = clsApplicationType.Find(_Application.ApplicationTypeID).ApplicationFees.ToString();
                lblCreatedBy.Text = clsUser.Find(_Application.CreatedByUserID).UserName;

                return;
            }

            ctrlFindPerson1.LoadPersonInfo(_Application.ApplicantPersonID);
            lblDLApplicationID.Text =_LDL_Application.LDL_ApplicationID.ToString();
            lblApplicationDate.Text = _Application.ApplicationDate.ToString("d");
            cbLicenseClasses.SelectedIndex = cbLicenseClasses.FindString(clsLicenseClass.Find(_LDL_Application.LicenseClassID).LicenseClassName);
            lblApplicationFees.Text=clsApplicationType.Find(_Application.ApplicationTypeID).ApplicationFees.ToString();
            lblCreatedBy.Text = clsUser.Find(_Application.CreatedByUserID).UserName;
        }

        private void ctrlFindPerson1_OnPersonSelected(int obj)
        {
            this._PersonID = obj;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (0 == _PersonID||-1==_PersonID)
            {
                MessageBox.Show("Select an applicant !");
                tabControl1.SelectTab(tpPersonalInfo);
                return;
            }

            Get_LDL_ApplicationInfoFromForm();

            

            if (_Mode.Equals(enMode.AddNew)
                &&
                cls_LDL_Application.IsApplicantHasDoubleSameApp(_Application.ApplicantPersonID, _LDL_Application.LicenseClassID))
            {
                MessageBox.Show("The applicant has already apply to an application with same License Class!");
                return;
            } 

            if (_Application.Save())
            {
                _LDL_Application.ApplicationID = _Application.ApplicationID;
                if (!_LDL_Application.Save())
                {
                    MessageBox.Show("unSuccessfully, saved the application!");

                }
                MessageBox.Show("Successfully, saved the application!");

                lblMode.Text = "Update Local Driving License Application";
                lblDLApplicationID.Text = _LDL_Application.LDL_ApplicationID.ToString();
            }
            else
            {
                MessageBox.Show("Unexpected Error, start over.");
                tabControl1.SelectTab(tpPersonalInfo);
                return;
            }


        }

        private void Get_LDL_ApplicationInfoFromForm()
        {
            _Application.ApplicantPersonID= _PersonID;
            _LDL_Application.LicenseClassID = cbLicenseClasses.SelectedIndex+1;
            

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    if (0 == _PersonID || -1 == _PersonID)
                    {
                        MessageBox.Show("Please choose a Person !");
                        return;
                    }

                    break;

                case enMode.Update:

                    break;
            }

            tabControl1.SelectTab(tpApplicationInfo);
        }
    }
}
