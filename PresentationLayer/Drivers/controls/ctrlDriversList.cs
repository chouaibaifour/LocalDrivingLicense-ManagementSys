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
            DataTable dt = clsDriver.GetAllDrivers();

            dgvDrivers.DataSource = dt;

            lblRecordCount.Text = dgvDrivers.RowCount.ToString();
        }

        private void _getClomnName(int index)
        {
            Filter = "";

            string[] Filters = {
            
            "DriverID",
            "PersonID",
            "National No",
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
                txtFilterValue.Text = "";
                
            }
            else
            {
                txtFilterValue.Visible = false;
            }

            

            dataView.RowFilter = "NationalNo LIKE '%%'";

            dgvDrivers.DataSource = dataView.ToTable();

            lblRecordCount.Text = dgvDrivers.RowCount.ToString();
        }

        private void txtFilterValue_KeyUp(object sender, KeyEventArgs e)
        {
            _getClomnName(cbFilters.SelectedIndex);
            Filter = Filter.Replace(" ", "");

            if (!("DriverID".Equals(Filter)||"PersonID".Equals(Filter)))
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
                dataView.RowFilter = "NationalNo LIKE '%%'";
            }

            dgvDrivers.DataSource = dataView.ToTable();

            lblRecordCount.Text = dgvDrivers.RowCount.ToString();
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
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
    }
}
