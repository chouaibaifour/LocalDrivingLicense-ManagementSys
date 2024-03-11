using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ctrlPeopleList : UserControl
    {
        public ctrlPeopleList()
        {
            InitializeComponent();
        }

        string Filter;

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddNewUpdatePerson addNewUpdatePerson=new frmAddNewUpdatePerson(-1);

            addNewUpdatePerson.SendDataBack += _GetAllPeople;

            addNewUpdatePerson.ShowDialog(); 

        }

        private void _GetAllPeople()
        {
            DataTable dt = clsPerson.GetAllPeople();
            dgvPeople.DataSource = dt;

            lblRecordCount.Text = dgvPeople.RowCount.ToString();
           
        }

        private void ctrlPeopleList_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            _GetAllPeople();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        private void _getClomnName(int index)
        {
            Filter = "";

            string[] Filters = {"None",
            "PersonID",
            "NationalNumber",
            "FirstName",
            "SecondName",
            "ThirdName",
            "LastName",
            "Gender",
            "Nationality",
            "Phone",
            "Email"};

            if (Filters.Length <= index && 0 > index) 
                return ;

            Filter = @Filters[index - 1];
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (0 != cbFilters.SelectedIndex)
            {
                txtFilterValue.Visible = true;

                btnFindRow.Visible = true;

                return;
            }

            txtFilterValue.Visible = false;

            btnFindRow.Visible = false;
            
            dgvPeople.DataSource = clsPerson.GetAllPeople();

        }

        private void btnFindRow_Click(object sender, EventArgs e)
        {
            DataView dataView = clsPerson.GetAllPeople().DefaultView;
            
            _getClomnName(cbFilters.SelectedIndex);

            if (!"PersonID".Equals(Filter))
            {
                Filter += @"='" + txtFilterValue.Text+"'";
            }
            else
            Filter += @"=" + txtFilterValue.Text;
            try
            {
                dataView.RowFilter = Filter;
                
            }
            catch (Exception)
            {
               
            }
            dgvPeople.DataSource = dataView.ToTable();

            lblRecordCount.Text = dgvPeople.RowCount.ToString();

        }

    }
}
