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

namespace PresentationLayer.ReleaseDetianedLicenses.controls
{
    public partial class ctrlDetainedLicenseList : UserControl
    {
        public ctrlDetainedLicenseList()
        {
            InitializeComponent();
        }

        string Filter;

        DataView dataView = clsDetianedLicense.GetAllDetainLicenses().DefaultView;

        private void btnClose_Click(object sender, EventArgs e)
        {
            FindForm().Close();
        }

        private void ctrlDetainedLicenseList_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            cbIsReleased.SelectedIndex = 0;
            _FillAllDetainLicensesTo_dgv();
        }

        private void _FillAllDetainLicensesTo_dgv()
        {
            DataTable dt = clsDetianedLicense.GetAllDetainLicenses();

            dgvDetainedLicenses.DataSource = dt;

            lblRecordCount.Text = dgvDetainedLicenses.RowCount.ToString();
        }

        private void _getClomnName(int index)
        {
            Filter = "";

            string[] Filters = {
            "DetainID",
            "LicenseID",
            "IsReleased",
            "NationalNumber",
            "FullName",
            "ReleaseApplicationID",
            };

            if (Filters.Length <= index && 0 > index)
                return;

            Filter = @Filters[index - 1];
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (0 != cbFilters.SelectedIndex)
            {
                if(cbFilters.SelectedItem.ToString().Equals("Is Released"))
                {

                    txtFilterValue.Visible = false;

                    cbIsReleased.Visible = true;

                    return;

                }

                txtFilterValue.Visible = true;

                return;
            }

            txtFilterValue.Visible=false;

            dgvDetainedLicenses.DataSource = dataView;

            lblRecordCount.Text = dgvDetainedLicenses.RowCount.ToString();

        }

        private void txtFilterValue_KeyUp(object sender, KeyEventArgs e)
        {
            _getClomnName(cbFilters.SelectedIndex);

            if ("NationalNumber".Equals(Filter) || "FullName".Equals(Filter)) 
            {
                Filter += @" LIKE '%" + txtFilterValue.Text + "%'";
            }
            else
            {
                if (!int.TryParse(txtFilterValue.Text, out int obj))
                {

                    txtFilterValue.Text = string.Empty;
                    Filter += @"=0";

                }
                else
                {

                    Filter += @"=" + obj.ToString();
                }

            }
            try
            {
                dataView.RowFilter = Filter;

            }
            catch (Exception)
            {

            }

            dgvDetainedLicenses.DataSource = dataView.ToTable();

            lblRecordCount.Text = dgvDetainedLicenses.RowCount.ToString();

        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = false;

                epEmptyOrNull.SetError(textBox, "Invalid input try again !");
            }
            else
            {
                e.Cancel = false;
                epEmptyOrNull.SetError(textBox, "");
            }
        }

        private void cbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cbIsReleased.SelectedIndex)
                {
                    case 1:
                        dataView.RowFilter = "IsReleased = 1";
                        break;
                    case 2:
                        dataView.RowFilter = "IsReleased = 0";
                        break;
                    default:
                        dataView.RowFilter = "IsReleased = 0 or IsReleased = 1";
                        break;

                };

            }
            catch (Exception ex)
            {

            }

            dgvDetainedLicenses.DataSource = dataView.ToTable();

            lblRecordCount.Text = dgvDetainedLicenses.RowCount.ToString();
        }

        private void btnDetianeLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense frmDetainLicense = new frmDetainLicense(-1);
            frmDetainLicense.ShowDialog();
        }

        private void btnReleaseLicense_Click(object sender, EventArgs e)
        {
            frmReleaseLicense frmReleaseLicense= new frmReleaseLicense(-1);
            frmReleaseLicense.ShowDialog();
        }
    }
}
