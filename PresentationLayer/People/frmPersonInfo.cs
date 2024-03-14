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
    public partial class frmPersonInfo : Form
    {
        private int _PersonID;

        public frmPersonInfo(int PersonID)
        {
            InitializeComponent();
            this._PersonID = PersonID;
        }

        private void ctrlPersonInfo1_Load(object sender, EventArgs e)
        {
            ctrlPersonInfo1.LoadPersonInfo(_PersonID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
