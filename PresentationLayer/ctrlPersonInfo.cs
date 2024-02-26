using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
namespace PresentationLayer
{
    public partial class ctrlPersonInfo : UserControl
    {
        public ctrlPersonInfo()
        {
            InitializeComponent();
        }

        private void LoadPersonInfo(int PersonID)
        {
            clsPerson person = clsPerson.Find(PersonID);

            if(person == null)
            {
                lblPersonID.Text=person.PersonID.ToString();
                lblNationalNumber.Text = person.NationalNumber; 
            }
        }

        private void LoadPersonInfo(string NationalNumber)
        {

        }


    }
}
