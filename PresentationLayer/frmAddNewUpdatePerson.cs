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
    public partial class frmAddNewUpdatePerson : Form
    {
        public frmAddNewUpdatePerson()
        {
            InitializeComponent();
            ctrlAddNewUpdatePerson1.Load_PersonInfo(1);

        }

        private void frmAddNewUpdatePerson_Load(object sender, EventArgs e)
        {
           // ctrlAddNewUpdatePerson1.Load_PersonInfo(-1);
        }

        
    }
}
