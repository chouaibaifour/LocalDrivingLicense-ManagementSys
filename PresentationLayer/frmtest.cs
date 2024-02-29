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
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

       

        private void frmTest_Load(object sender, EventArgs e)
        {

        }

        private void ctrlAddNewPerson1_Load(object sender, EventArgs e)
        {
            ctrlAddNewPerson1.UpdateOrAddNewPerson(-1);
        }
    }
}
