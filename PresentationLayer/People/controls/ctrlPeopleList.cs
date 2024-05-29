using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentationLayer
{
    public partial class ctrlPeopleList : UserControl
    {
        public ctrlPeopleList()
        {
            InitializeComponent();
        }

        string Filter;

        DataView dataView = clsPerson.GetAllPeople().DefaultView;

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddNewUpdatePerson addNewUpdatePerson=new frmAddNewUpdatePerson(-1);

            addNewUpdatePerson.SendDataBack += _FillAllPeopleTo_dgv;

            addNewUpdatePerson.ShowDialog(); 

        }

        private void _FillAllPeopleTo_dgv()
        {
            DataTable dt = clsPerson.GetAllPeople();
            dgvPeople.DataSource = dt;

            lblRecordCount.Text = dgvPeople.RowCount.ToString();
           
        }

        private void ctrlPeopleList_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            _FillAllPeopleTo_dgv();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        private void _getClomnName(int index)
        {
            Filter = "";

            string[] Filters = {
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

        }


        private void txtFilterValue_KeyUp(object sender, KeyEventArgs e)
        {

            _getClomnName(cbFilters.SelectedIndex);


            if (!"PersonID".Equals(Filter))
            {
                Filter += @" LIKE '%" + txtFilterValue.Text + "%'";
            }
            else
            {
                if (!int.TryParse(txtFilterValue.Text, out int PersonID))
                {

                    txtFilterValue.Text = string.Empty;
                    Filter += @"=0";

                }
                else
                {

                    Filter += @"=" + PersonID.ToString();
                }

            }

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

        private void ValidatingEmptyOrNulltxt(object sender, CancelEventArgs e)
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


        private void smiShowDetails_Click(object sender, EventArgs e)
        {
            if(int.TryParse(dgvPeople.CurrentRow.Cells[0].Value.ToString(),out int PersonID))
            {
                frmPersonInfo frmPersonInfo = new frmPersonInfo(PersonID);
                frmPersonInfo.ShowDialog();
            }

        }

        private void smiEdit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dgvPeople.CurrentRow.Cells[0].Value.ToString(), out int PersonID))
            {
                frmAddNewUpdatePerson frmUpdatePerson = new frmAddNewUpdatePerson(PersonID);
                frmUpdatePerson.SendDataBack += _FillAllPeopleTo_dgv;
                frmUpdatePerson.ShowDialog();
            }
            
        }

        private void smiDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dgvPeople.CurrentRow.Cells[0].Value.ToString(), out int PersonID))
            {
                if(clsPerson.IsPersonExists(PersonID))
                {
                    if(clsPerson.DeletePerson(PersonID))
                    {
                        MessageBox.Show("Person Deleted Successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Person is Not Deleted.");
                    }
                }
                else
                {
                    MessageBox.Show("Person is Not Deleted.");
                }
                _FillAllPeopleTo_dgv();
            }
        }

        private void smiAddNew_Click(object sender, EventArgs e)
        {

            frmAddNewUpdatePerson frmUpdatePerson = new frmAddNewUpdatePerson(-1);
            frmUpdatePerson.SendDataBack += _FillAllPeopleTo_dgv;
            frmUpdatePerson.ShowDialog();
            
        }

        private void smiCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this Feature is not implemented Yet !");
        }

        private void smiSendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this Feature is not implemented Yet !");
        }

       
    }
}
