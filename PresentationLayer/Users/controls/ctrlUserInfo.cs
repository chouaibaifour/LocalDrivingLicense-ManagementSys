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
    public partial class ctrlUserInfo : UserControl
    {
        public ctrlUserInfo()
        {
            InitializeComponent();
        }
        private clsUser _User;

        public void LoadUserInfo(int UserID)
        {
            _User = clsUser.Find(UserID);

            if (_User != null)
            {
                ctrlPersonInfo1.LoadPersonInfo(_User.PersonID);
                _FillUserData();
                return;

            }
            MessageBox.Show("No User with UserID : " + UserID.ToString());
        }

        private void _FillUserData()
        {
            lblUserID.Text = _User.UserID.ToString();

            lblUsername.Text = _User.UserName.ToString();

            lblisActive.Text = (_User.isActive) ? "Yes" : "No";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }
    }
}
