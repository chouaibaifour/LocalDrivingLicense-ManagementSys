using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.LocalLicenseApplication.controls
{
    public partial class ctrlAppBasicInfo : UserControl
    {
        public ctrlAppBasicInfo()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        public void LoadApplicationBasicInfo(int ApplicationID)
        {
            throw new NotImplementedException();
        }
    }
}
