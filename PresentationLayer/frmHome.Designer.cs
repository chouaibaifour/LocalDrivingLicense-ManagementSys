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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAcountSettings = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lblDrivers = new System.Windows.Forms.Label();
            this.lblPeople = new System.Windows.Forms.Label();
            this.lblApplication = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
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
            this.lblAcountSettings.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcountSettings.Image = global::PresentationLayer.Properties.Resources.user_settings;
            this.lblAcountSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAcountSettings.Location = new System.Drawing.Point(675, 8);
            this.lblAcountSettings.Name = "lblAcountSettings";
            this.lblAcountSettings.Size = new System.Drawing.Size(209, 50);
            this.lblAcountSettings.TabIndex = 0;
            this.lblAcountSettings.Text = "Account Settings";
            this.lblAcountSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAcountSettings.Click += new System.EventHandler(this.lblAcountSettings_Click);
            // 
            // lblUsers
            // 
            this.lblUsers.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Image = global::PresentationLayer.Properties.Resources.users1;
            this.lblUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsers.Location = new System.Drawing.Point(524, 8);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(119, 50);
            this.lblUsers.TabIndex = 0;
            this.lblUsers.Text = "Users";
            this.lblUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUsers.Click += new System.EventHandler(this.lblUsers_Click);
            // 
            // lblDrivers
            // 
            this.lblDrivers.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrivers.Image = global::PresentationLayer.Properties.Resources.driver;
            this.lblDrivers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDrivers.Location = new System.Drawing.Point(370, 8);
            this.lblDrivers.Name = "lblDrivers";
            this.lblDrivers.Size = new System.Drawing.Size(122, 50);
            this.lblDrivers.TabIndex = 0;
            this.lblDrivers.Text = "Drivers";
            this.lblDrivers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDrivers.Click += new System.EventHandler(this.lblDrivers_Click);
            // 
            // lblPeople
            // 
            this.lblPeople.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeople.Image = global::PresentationLayer.Properties.Resources.People;
            this.lblPeople.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPeople.Location = new System.Drawing.Point(212, 8);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(126, 50);
            this.lblPeople.TabIndex = 0;
            this.lblPeople.Text = "People";
            this.lblPeople.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPeople.Click += new System.EventHandler(this.lblPeople_Click);
            // 
            // lblApplication
            // 
            this.lblApplication.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplication.Image = global::PresentationLayer.Properties.Resources.Application;
            this.lblApplication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblApplication.Location = new System.Drawing.Point(23, 8);
            this.lblApplication.Name = "lblApplication";
            this.lblApplication.Size = new System.Drawing.Size(157, 50);
            this.lblApplication.TabIndex = 0;
            this.lblApplication.Text = "Application";
            this.lblApplication.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblApplication.Click += new System.EventHandler(this.lblApplication_Click);
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
            this.panel1.ResumeLayout(false);
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
    }
}