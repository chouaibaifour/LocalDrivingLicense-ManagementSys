using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using BusinessLayer;
namespace PresentationLayer
{
    public partial class frmLogin : Form
    {

        public int trynum = 1;
        private string RememberMeFilePath = "F:\\repos\\Projects\\Implementation\\DLVD-ManagmentSys\\PresentationLayer\\RememberMe.txt";
        public frmLogin()
        {
            InitializeComponent();
        }
        public int CurrentUserID;
         private bool _Authenticate()
        {
            clsAuthentication authentication = clsAuthentication.Login(txtUserName.Text, txtPassword.Text);

            if (authentication != null)
            {
                if (authentication.isActive)
                {
                    CurrentUserID=authentication.UserID;
                    return true;
                }
                else
                    MessageBox.Show("your Account is Dis-Activeted please Contact your Admin !");
                return false;
            }
            else
                trynum++;
                MessageBox.Show("Invalid UserName or Password");
            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            RemmeberMe();
            if (_Authenticate())
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;

        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox =(TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                epEmptyOrNull.SetError(textBox, "Invalid input try again !");
            }
            else
            {
                e.Cancel = false;
                epEmptyOrNull.SetError(textBox, "");
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            trynum = 100;
            DialogResult = DialogResult.No;
            this.Close();
        }

        private void RemmeberMe()
        {
            string Token="";
            if (chkRememberMe.Checked)
            {
                Token = txtUserName.Text + "###" + txtPassword.Text;

            }

            File.WriteAllText(RememberMeFilePath, Token);

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string[] TokenValues;
            string Token = File.ReadAllText(RememberMeFilePath);
            if (!Token.Equals(""))
            {
                TokenValues = Token.Split(new string[] { "###" }, StringSplitOptions.None);
                txtUserName.Text = TokenValues[0];
                txtPassword.Text = TokenValues[1];
                chkRememberMe.Checked= true;
            }

        }
    }
}
