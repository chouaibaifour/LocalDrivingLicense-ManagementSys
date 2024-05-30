using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.People.controls
{
    public partial class ctrlFindPerson : UserControl
    {
        public ctrlFindPerson()
        {
            InitializeComponent();
            this.PersonID = -1;
        }

       public int PersonID { get; set; }
        

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            if ("".Equals(txtFilterValue.Text))
                return;

            if (cbFilters.SelectedIndex == 0)

                personInfo.LoadPersonInfo(txtFilterValue.Text);

            else if(cbFilters.SelectedIndex == 1&&int.TryParse(txtFilterValue.Text,out int PersonID))

                personInfo.LoadPersonInfo(PersonID);

            this.PersonID=personInfo.PersonID;

        }

        private void ctrlFindPerson_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddNewUpdatePerson frmUpdatePerson = new frmAddNewUpdatePerson(-1);
            frmUpdatePerson.SendDataBackWithPersonID += personInfo.LoadPersonInfo;
            frmUpdatePerson.ShowDialog();
            this.PersonID = personInfo.PersonID;
        }
    }
}
