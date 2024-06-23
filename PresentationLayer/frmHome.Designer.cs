namespace PresentationLayer
{
    partial class frmHome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAcountSettings = new System.Windows.Forms.Label();
            this.cmsAccountSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.smiCurrentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.smiChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.smiSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lblDrivers = new System.Windows.Forms.Label();
            this.lblPeople = new System.Windows.Forms.Label();
            this.lblApplication = new System.Windows.Forms.Label();
            this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.drivingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smiLocalLicenseApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reNewDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.replacmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetainedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.manageApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.manageTestTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.cmsAccountSettings.SuspendLayout();
            this.cmsApplications.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblAcountSettings);
            this.panel1.Controls.Add(this.lblUsers);
            this.panel1.Controls.Add(this.lblDrivers);
            this.panel1.Controls.Add(this.lblPeople);
            this.panel1.Controls.Add(this.lblApplication);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1441, 72);
            this.panel1.TabIndex = 0;
            // 
            // lblAcountSettings
            // 
            this.lblAcountSettings.ContextMenuStrip = this.cmsAccountSettings;
            this.lblAcountSettings.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcountSettings.Image = global::PresentationLayer.Properties.Resources.user_settings;
            this.lblAcountSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAcountSettings.Location = new System.Drawing.Point(675, 8);
            this.lblAcountSettings.Name = "lblAcountSettings";
            this.lblAcountSettings.Size = new System.Drawing.Size(209, 60);
            this.lblAcountSettings.TabIndex = 0;
            this.lblAcountSettings.Text = "Account Settings";
            this.lblAcountSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAcountSettings.Click += new System.EventHandler(this.lblAcountSettings_Click);
            this.lblAcountSettings.MouseEnter += new System.EventHandler(this.lblAcountSettings_MouseEnter);
            // 
            // cmsAccountSettings
            // 
            this.cmsAccountSettings.BackColor = System.Drawing.Color.White;
            this.cmsAccountSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiCurrentUserInfo,
            this.smiChangePassword,
            this.toolStripMenuItem1,
            this.smiSignOut});
            this.cmsAccountSettings.Name = "cmsAccountSettings";
            this.cmsAccountSettings.Size = new System.Drawing.Size(169, 76);
            // 
            // smiCurrentUserInfo
            // 
            this.smiCurrentUserInfo.Name = "smiCurrentUserInfo";
            this.smiCurrentUserInfo.Size = new System.Drawing.Size(168, 22);
            this.smiCurrentUserInfo.Text = "CurrentUser Info";
            this.smiCurrentUserInfo.Click += new System.EventHandler(this.smiCurrentUserInfo_Click);
            // 
            // smiChangePassword
            // 
            this.smiChangePassword.Name = "smiChangePassword";
            this.smiChangePassword.Size = new System.Drawing.Size(168, 22);
            this.smiChangePassword.Text = "Change Password";
            this.smiChangePassword.Click += new System.EventHandler(this.smiChangePassword_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 6);
            // 
            // smiSignOut
            // 
            this.smiSignOut.Name = "smiSignOut";
            this.smiSignOut.Size = new System.Drawing.Size(168, 22);
            this.smiSignOut.Text = "Sign Out";
            this.smiSignOut.Click += new System.EventHandler(this.smiSignOut_Click);
            // 
            // lblUsers
            // 
            this.lblUsers.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Image = global::PresentationLayer.Properties.Resources.users1;
            this.lblUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsers.Location = new System.Drawing.Point(524, 8);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(119, 60);
            this.lblUsers.TabIndex = 0;
            this.lblUsers.Text = "Users";
            this.lblUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUsers.Click += new System.EventHandler(this.lblUsers_Click);
            this.lblUsers.MouseEnter += new System.EventHandler(this.lblAcountSettings_MouseEnter);
            // 
            // lblDrivers
            // 
            this.lblDrivers.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrivers.Image = global::PresentationLayer.Properties.Resources.driver;
            this.lblDrivers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDrivers.Location = new System.Drawing.Point(370, 8);
            this.lblDrivers.Name = "lblDrivers";
            this.lblDrivers.Size = new System.Drawing.Size(122, 60);
            this.lblDrivers.TabIndex = 0;
            this.lblDrivers.Text = "Drivers";
            this.lblDrivers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDrivers.Click += new System.EventHandler(this.lblDrivers_Click);
            this.lblDrivers.MouseEnter += new System.EventHandler(this.lblAcountSettings_MouseEnter);
            // 
            // lblPeople
            // 
            this.lblPeople.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeople.Image = global::PresentationLayer.Properties.Resources.People;
            this.lblPeople.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPeople.Location = new System.Drawing.Point(212, 8);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(126, 60);
            this.lblPeople.TabIndex = 0;
            this.lblPeople.Text = "People";
            this.lblPeople.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPeople.Click += new System.EventHandler(this.lblPeople_Click);
            this.lblPeople.MouseEnter += new System.EventHandler(this.lblAcountSettings_MouseEnter);
            // 
            // lblApplication
            // 
            this.lblApplication.ContextMenuStrip = this.cmsApplications;
            this.lblApplication.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplication.Image = global::PresentationLayer.Properties.Resources.Application;
            this.lblApplication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblApplication.Location = new System.Drawing.Point(23, 8);
            this.lblApplication.Name = "lblApplication";
            this.lblApplication.Size = new System.Drawing.Size(157, 60);
            this.lblApplication.TabIndex = 0;
            this.lblApplication.Text = "Application";
            this.lblApplication.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblApplication.Click += new System.EventHandler(this.lblApplication_Click);
            this.lblApplication.MouseEnter += new System.EventHandler(this.lblAcountSettings_MouseEnter);
            // 
            // cmsApplications
            // 
            this.cmsApplications.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingToolStripMenuItem,
            this.toolStripMenuItem3,
            this.manageApplicationsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.detainLicensesToolStripMenuItem,
            this.toolStripMenuItem4,
            this.manageApplicationTypesToolStripMenuItem,
            this.toolStripMenuItem5,
            this.manageTestTToolStripMenuItem});
            this.cmsApplications.Name = "contextMenuStrip1";
            this.cmsApplications.Size = new System.Drawing.Size(226, 160);
            // 
            // drivingToolStripMenuItem
            // 
            this.drivingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem,
            this.reNewDrivingLicenseToolStripMenuItem,
            this.toolStripMenuItem6,
            this.replacmentToolStripMenuItem,
            this.toolStripMenuItem7,
            this.releaseDetainedToolStripMenuItem,
            this.retakeTestToolStripMenuItem});
            this.drivingToolStripMenuItem.Name = "drivingToolStripMenuItem";
            this.drivingToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.drivingToolStripMenuItem.Text = "Driving Licenses services";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiLocalLicenseApplication,
            this.internationalLicenseToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // smiLocalLicenseApplication
            // 
            this.smiLocalLicenseApplication.Name = "smiLocalLicenseApplication";
            this.smiLocalLicenseApplication.Size = new System.Drawing.Size(193, 22);
            this.smiLocalLicenseApplication.Text = "Local License";
            this.smiLocalLicenseApplication.Click += new System.EventHandler(this.smiLocalLicenseApplication_Click);
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.internationalLicenseToolStripMenuItem.Text = "International License";
            // 
            // reNewDrivingLicenseToolStripMenuItem
            // 
            this.reNewDrivingLicenseToolStripMenuItem.Name = "reNewDrivingLicenseToolStripMenuItem";
            this.reNewDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.reNewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(317, 6);
            // 
            // replacmentToolStripMenuItem
            // 
            this.replacmentToolStripMenuItem.Name = "replacmentToolStripMenuItem";
            this.replacmentToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.replacmentToolStripMenuItem.Text = "Replacement for Lost or Damaged License";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(317, 6);
            // 
            // releaseDetainedToolStripMenuItem
            // 
            this.releaseDetainedToolStripMenuItem.Name = "releaseDetainedToolStripMenuItem";
            this.releaseDetainedToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.releaseDetainedToolStripMenuItem.Text = "Release Detained Driving License";
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(222, 6);
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicenseApplicationsToolStripMenuItem,
            this.internationalLicenseApplicationsToolStripMenuItem});
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // localDrivingLicenseApplicationsToolStripMenuItem
            // 
            this.localDrivingLicenseApplicationsToolStripMenuItem.Name = "localDrivingLicenseApplicationsToolStripMenuItem";
            this.localDrivingLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.localDrivingLicenseApplicationsToolStripMenuItem.Text = "Local Driving License Applications";
            this.localDrivingLicenseApplicationsToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLicenseApplicationsToolStripMenuItem_Click);
            // 
            // internationalLicenseApplicationsToolStripMenuItem
            // 
            this.internationalLicenseApplicationsToolStripMenuItem.Name = "internationalLicenseApplicationsToolStripMenuItem";
            this.internationalLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.internationalLicenseApplicationsToolStripMenuItem.Text = "International License Applications";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(222, 6);
            // 
            // detainLicensesToolStripMenuItem
            // 
            this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(222, 6);
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            this.manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            this.manageApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            this.manageApplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationTypesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(222, 6);
            // 
            // manageTestTToolStripMenuItem
            // 
            this.manageTestTToolStripMenuItem.Name = "manageTestTToolStripMenuItem";
            this.manageTestTToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.manageTestTToolStripMenuItem.Text = "Manage Test Types";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1456, 808);
            this.panel2.TabIndex = 1;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 881);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHome_FormClosed);
            this.panel1.ResumeLayout(false);
            this.cmsAccountSettings.ResumeLayout(false);
            this.cmsApplications.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAcountSettings;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label lblDrivers;
        private System.Windows.Forms.Label lblPeople;
        private System.Windows.Forms.Label lblApplication;
        private System.Windows.Forms.ContextMenuStrip cmsAccountSettings;
        private System.Windows.Forms.ToolStripMenuItem smiCurrentUserInfo;
        private System.Windows.Forms.ToolStripMenuItem smiChangePassword;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem smiSignOut;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.ToolStripMenuItem drivingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem manageTestTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smiLocalLicenseApplication;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reNewDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem replacmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseApplicationsToolStripMenuItem;
    }
}