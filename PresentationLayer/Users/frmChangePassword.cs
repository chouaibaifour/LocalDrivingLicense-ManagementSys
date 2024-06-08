using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Users
{
    public partial class frmChangePassword : Form
    {
        public delegate void DataBackEventHandler();
        public event DataBackEventHandler DataBack;

            
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }
       private int _UserID;

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            ctrlChangePassword1.LoadUserToChangePassword(_UserID);
        }

        private void frmChangePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DataBack != null)
                this.Invoke(DataBack);
        }
    }
}
