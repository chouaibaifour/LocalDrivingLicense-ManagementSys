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

namespace PresentationLayer.Users.controls
{
    public partial class ctrlAddNewUpdateUser : UserControl
    {
        public ctrlAddNewUpdateUser()
        {
            InitializeComponent();
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (-1 == ctrlFindPerson1.PersonID)
            {
                MessageBox.Show("Please choose a Person !");
                return;
            }

            if (clsUser.IsUserExistsbyPersonID(ctrlFindPerson1.PersonID))
            {
                MessageBox.Show("this Person already User choose another one !");
                return; 
            }

        }
    }
}
