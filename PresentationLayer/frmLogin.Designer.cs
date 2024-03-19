namespace PresentationLayer
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlLoginInterface = new System.Windows.Forms.Panel();
            this.lbLogo = new System.Windows.Forms.Label();
            this.pnlLoginForm = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.llblForgetPassword = new System.Windows.Forms.LinkLabel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.epEmptyOrNull = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlLoginInterface.SuspendLayout();
            this.pnlLoginForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epEmptyOrNull)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLoginInterface
            // 
            this.pnlLoginInterface.BackColor = System.Drawing.Color.Black;
            this.pnlLoginInterface.Controls.Add(this.lbLogo);
            this.pnlLoginInterface.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLoginInterface.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginInterface.MaximumSize = new System.Drawing.Size(191, 327);
            this.pnlLoginInterface.MinimumSize = new System.Drawing.Size(191, 327);
            this.pnlLoginInterface.Name = "pnlLoginInterface";
            this.pnlLoginInterface.Size = new System.Drawing.Size(191, 327);
            this.pnlLoginInterface.TabIndex = 1;
            // 
            // lbLogo
            // 
            this.lbLogo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogo.ForeColor = System.Drawing.Color.White;
            this.lbLogo.Image = ((System.Drawing.Image)(resources.GetObject("lbLogo.Image")));
            this.lbLogo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbLogo.Location = new System.Drawing.Point(0, 33);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(188, 230);
            this.lbLogo.TabIndex = 0;
            this.lbLogo.Text = "Welcome to  DLVD Mangement System";
            this.lbLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLoginForm
            // 
            this.pnlLoginForm.BackColor = System.Drawing.Color.White;
            this.pnlLoginForm.Controls.Add(this.lblClose);
            this.pnlLoginForm.Controls.Add(this.llblForgetPassword);
            this.pnlLoginForm.Controls.Add(this.txtUserName);
            this.pnlLoginForm.Controls.Add(this.txtPassword);
            this.pnlLoginForm.Controls.Add(this.btnLogin);
            this.pnlLoginForm.Controls.Add(this.chkRememberMe);
            this.pnlLoginForm.Controls.Add(this.label2);
            this.pnlLoginForm.Controls.Add(this.label3);
            this.pnlLoginForm.Controls.Add(this.label1);
            this.pnlLoginForm.Location = new System.Drawing.Point(191, 0);
            this.pnlLoginForm.MaximumSize = new System.Drawing.Size(306, 327);
            this.pnlLoginForm.MinimumSize = new System.Drawing.Size(306, 327);
            this.pnlLoginForm.Name = "pnlLoginForm";
            this.pnlLoginForm.Size = new System.Drawing.Size(306, 327);
            this.pnlLoginForm.TabIndex = 0;
            // 
            // lblClose
            // 
            this.lblClose.Image = global::PresentationLayer.Properties.Resources.close1;
            this.lblClose.Location = new System.Drawing.Point(270, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(24, 24);
            this.lblClose.TabIndex = 6;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // llblForgetPassword
            // 
            this.llblForgetPassword.AutoSize = true;
            this.llblForgetPassword.LinkColor = System.Drawing.Color.Black;
            this.llblForgetPassword.Location = new System.Drawing.Point(96, 197);
            this.llblForgetPassword.Name = "llblForgetPassword";
            this.llblForgetPassword.Size = new System.Drawing.Size(95, 13);
            this.llblForgetPassword.TabIndex = 4;
            this.llblForgetPassword.TabStop = true;
            this.llblForgetPassword.Text = "Forget Password ?";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(99, 86);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(151, 22);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(99, 126);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(151, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(148, 240);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(102, 31);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRememberMe.Location = new System.Drawing.Point(99, 167);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(111, 20);
            this.chkRememberMe.TabIndex = 3;
            this.chkRememberMe.Text = "Remember me";
            this.chkRememberMe.UseVisualStyleBackColor = true;
            this.chkRememberMe.CheckedChanged += new System.EventHandler(this.chkRememberMe_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Login to you account";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epEmptyOrNull
            // 
            this.epEmptyOrNull.ContainerControl = this;
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(497, 327);
            this.Controls.Add(this.pnlLoginForm);
            this.Controls.Add(this.pnlLoginInterface);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximumSize = new System.Drawing.Size(511, 366);
            this.MinimumSize = new System.Drawing.Size(497, 327);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlLoginInterface.ResumeLayout(false);
            this.pnlLoginForm.ResumeLayout(false);
            this.pnlLoginForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epEmptyOrNull)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoginInterface;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.Panel pnlLoginForm;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llblForgetPassword;
        private System.Windows.Forms.ErrorProvider epEmptyOrNull;
        private System.Windows.Forms.Label lblClose;
    }
}

