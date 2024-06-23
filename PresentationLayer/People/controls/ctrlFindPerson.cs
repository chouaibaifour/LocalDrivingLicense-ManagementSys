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

            
        }

        //Define a custom event handler delegte with parameters 
        public event Action<int> OnPersonSelected;
        //create protected method to raise the event with parameter
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;

            if(handler != null)

                handler(PersonID);// Raise the event with parameter

        }

        public void LoadPersonInfo(int PersonID)
        {
            personInfo.LoadPersonInfo(PersonID);
            if (OnPersonSelected != null)
                //Raise the event with paramter
                OnPersonSelected(personInfo.PersonID);
        }
        
        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            if ("".Equals(txtFilterValue.Text))
                return;

            switch (cbFilters.SelectedItem)
            {
                case "PersonID":

                    if (int.TryParse(txtFilterValue.Text, out int PersonID))
                        personInfo.LoadPersonInfo(PersonID);

                    break;
                case "NationalNo.":
                    personInfo.LoadPersonInfo(txtFilterValue.Text);
                    break;

            }

            if (OnPersonSelected != null)
                //Raise the event with paramter
                OnPersonSelected(personInfo.PersonID);

        }

        private void ctrlFindPerson_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            

        }

        public void toUpdate()
        {
            groupBox1.Enabled = false;
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddNewUpdatePerson frmUpdatePerson = new frmAddNewUpdatePerson(-1);

            frmUpdatePerson.SendDataBackWithPersonID += personInfo.LoadPersonInfo;

            frmUpdatePerson.ShowDialog();

            if (OnPersonSelected != null)
                //Raise the event with paramter
                OnPersonSelected(personInfo.PersonID);

        }
    }
}
