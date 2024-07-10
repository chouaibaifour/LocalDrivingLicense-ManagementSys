using BusinessLayer;
using PresentationLayer.Licenses;
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

namespace PresentationLayer.InternationalLicenses.controls
{
    public partial class ctrlInternationalLicenseList : UserControl
    {
        public ctrlInternationalLicenseList()
        {
            InitializeComponent();
        }

        string Filter = "";

        private DataView DataView = clsInternationalLicense.GetAllInternationalLicenses().DefaultView;


        private void btnAddNewInternationalLicense_Click(object sender, EventArgs e)
        {
            frmAddUpdateInternationalLicense frmAddUpdateInternationalLicense = new frmAddUpdateInternationalLicense(-1);
            // delegete
            frmAddUpdateInternationalLicense.ShowDialog();
        }

        private void ctrlInternationalLicenseList_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            cbLicenseStatus.SelectedIndex = 0;
            _FillDataTo_dgvInternationalLicenses();
        }

        private void _FillDataTo_dgvInternationalLicenses()
        {
            DataTable dt = clsInternationalLicense.GetAllInternationalLicenses();

            dgvInternationalLicenses.DataSource= dt;

            lblRecordsCount.Text = dgvInternationalLicenses.RowCount.ToString();

        }

        private void _getClomnName(int index)
        {
            Filter = "";

            string[] Filters = {
            "InternationalLicenseID",
            "ApplicationID",
            "DriverID",
            "LicenseID "};

            if (Filters.Length <= index && 0 > index)
                return;

            Filter = @Filters[index - 1];
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (0 != cbFilters.SelectedIndex)
            {
                if (cbFilters.SelectedItem.ToString().Equals("License Status"))
                {
                    txtFilterValue.Visible = false;

                    cbLicenseStatus.Visible = true;
                    return;
                }
                txtFilterValue.Visible = true;

                return;
            }

            txtFilterValue.Visible = false;
            cbLicenseStatus.Visible = false;

            dgvInternationalLicenses.DataSource = DataView;

            lblRecordsCount.Text = dgvInternationalLicenses.RowCount.ToString();

        }

        private void txtFilterValue_KeyUp(object sender, KeyEventArgs e)
        {

            _getClomnName(cbFilters.SelectedIndex);
            Filter = Filter.Replace(" ", "");


            if (!int.TryParse(txtFilterValue.Text, out int UserID))
            {

                txtFilterValue.Text = string.Empty;
                Filter += @"=0";

            }
            else
            {

                Filter += @"=" + UserID.ToString();
            }

            try
            {
                DataView.RowFilter = Filter;

            }
            catch (Exception)
            {

            }

            dgvInternationalLicenses.DataSource = DataView.ToTable();

            lblRecordsCount.Text = dgvInternationalLicenses.RowCount.ToString();
        }

        private void cbLicenseStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cbLicenseStatus.SelectedIndex)
                {
                    case 1:
                        DataView.RowFilter = "IsActive = 1";
                     break;

                    case 2:
                        DataView.RowFilter = "IsActive = 0";
                    break;

                    default:
                        DataView.RowFilter = "IsActive = 0 or IsActive = 1";
                    break;

                };

            }
            catch (Exception)
            {

            }

            dgvInternationalLicenses.DataSource = DataView.ToTable();

            lblRecordsCount.Text = dgvInternationalLicenses.RowCount.ToString();
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
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
            e.Cancel = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FindForm().Close();
        }

        private void smiShowPersonDetails_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dgvInternationalLicenses.CurrentRow.Cells[2].Value.ToString(),out int DriverID ))
            {
                frmPersonInfo frmPersonInfo = new frmPersonInfo(clsDriver.Find(DriverID).PersonID);
                frmPersonInfo.ShowDialog();
            }
        }

        private void smiShowLicenseInfo_Click(object sender, EventArgs e)
        {

            if (int.TryParse(dgvInternationalLicenses.CurrentRow.Cells[0].Value.ToString(), out int InternationalLicenseID))
            {
               frmInternationalLicenseInfo frmInternationalLicenseInfo =new frmInternationalLicenseInfo(InternationalLicenseID);
                frmInternationalLicenseInfo.ShowDialog();

            }
        }

        private void smiShowPersonLicenseHitory_Click(object sender, EventArgs e)
        {

            if (int.TryParse(dgvInternationalLicenses.CurrentRow.Cells[2].Value.ToString(), out int DriverID))
            {
                frmPersonLicenseHistory frmPersonLicenseHistory = new frmPersonLicenseHistory(clsDriver.Find(DriverID).PersonID);
                frmPersonLicenseHistory.ShowDialog();
            }
        }
    }
}
