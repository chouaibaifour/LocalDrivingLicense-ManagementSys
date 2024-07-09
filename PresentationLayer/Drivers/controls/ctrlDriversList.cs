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

namespace PresentationLayer.Licenses.controls
{
    public partial class ctrlDriversList : UserControl
    {
        public ctrlDriversList()
        {
            InitializeComponent();
        }

        private string Filter;
        DataView dataView = clsDriver.GetAllDrivers().DefaultView;

        private void ctrlDriversList_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            _Fill_dgvDriversWithData();
        }

        private void _Fill_dgvDriversWithData()
        {
            DataTable dt = clsUser.GetAllUsers();

            dgvDrivers.DataSource = dt;

            lblRecordCount.Text = dgvDrivers.RowCount.ToString();
        }

        private void _getClomnName(int index)
        {
            Filter = "";

            string[] Filters = {
            "UserID",
            "PersonID",
            "FullName"};

            if (Filters.Length <= index && 0 > index)
                return;

            Filter = @Filters[index - 1];
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (0 != cbFilters.SelectedIndex)
            {
                
                txtFilterValue.Visible = true;

                return;
            }

            txtFilterValue.Visible = false;

            dgvDrivers.DataSource = dataView;

            lblRecordCount.Text = dgvDrivers.RowCount.ToString();
        }

        private void txtFilterValue_KeyUp(object sender, KeyEventArgs e)
        {
            _getClomnName(cbFilters.SelectedIndex);
            Filter = Filter.Replace(" ", "");

            if (!("UserID".Equals(Filter)||"PersonID".Equals(Filter)))
            {
                Filter += @" LIKE '%" + txtFilterValue.Text + "%'";
            }
            else
            {
                if (!int.TryParse(txtFilterValue.Text, out int ID))
                {

                    txtFilterValue.Text = string.Empty;
                    Filter += @"=0";

                }
                else
                {

                    Filter += @"=" +ID.ToString();
                }

            }

            try
            {
                dataView.RowFilter = Filter;

            }
            catch (Exception)
            {

            }

            dgvDrivers.DataSource = dataView.ToTable();

            lblRecordCount.Text = dgvDrivers.RowCount.ToString();
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;

                epEmptyOrNull.SetError(textBox, "Invalid input try again !");
            }
            else
            {
                e.Cancel = false;
                epEmptyOrNull.SetError(textBox, "");
            }
        }
    }
}
