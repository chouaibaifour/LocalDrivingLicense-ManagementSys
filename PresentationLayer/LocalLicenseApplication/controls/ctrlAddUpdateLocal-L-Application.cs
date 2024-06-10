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
    public partial class ctrlAddUpdateLocal_L_Application : UserControl
    {
        public enum enMode { AddNew = 0, Update = 1 }

        private enMode _Mode;

        
        public ctrlAddUpdateLocal_L_Application()
        {
            InitializeComponent();
        }

       
    }
}
