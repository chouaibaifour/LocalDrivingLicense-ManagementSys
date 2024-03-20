using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void lblApplication_Click(object sender, EventArgs e)
        {

        }

        private void lblPeople_Click(object sender, EventArgs e)
        {
            frmPeopleList frmPeopleList = new frmPeopleList();  
            frmPeopleList.ShowDialog();
        }

        private void lblDriver_Click(object sender, EventArgs e)
        {

        }

        private void lblAcountSettings_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
