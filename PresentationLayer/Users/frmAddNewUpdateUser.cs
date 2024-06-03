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
    public partial class frmAddNewUpdateUser : Form
    {
        public delegate void DataBackEventHandler();
        public event DataBackEventHandler SendDataBack;

        public frmAddNewUpdateUser(int UserID)
        {
            InitializeComponent();
            this._UserID = UserID;
        }

        private int _UserID;

        private void frmAddNewUpdateUser_Load(object sender, EventArgs e)
        {
            ctrlAddNewUpdateUser1.Load_UserInfo(_UserID);
        }

        private void frmAddNewUpdateUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (SendDataBack != null)
                this.Invoke(SendDataBack);
        }
    }
}
