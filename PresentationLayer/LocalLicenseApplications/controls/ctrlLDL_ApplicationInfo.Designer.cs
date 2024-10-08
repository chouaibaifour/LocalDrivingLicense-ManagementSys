﻿namespace PresentationLayer.LocalLicenseApplication.controls
{
    partial class ctrlLDL_ApplicationInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llblShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lblLicenseClass = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPassedTest = new System.Windows.Forms.Label();
            this.lblLDLAppID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlAppBasicInfo1 = new PresentationLayer.LocalLicenseApplication.controls.ctrlAppBasicInfo();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.llblShowLicenseInfo);
            this.groupBox1.Controls.Add(this.lblLicenseClass);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblPassedTest);
            this.groupBox1.Controls.Add(this.lblLDLAppID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driving License Application Info";
            // 
            // llblShowLicenseInfo
            // 
            this.llblShowLicenseInfo.Image = global::PresentationLayer.Properties.Resources.License;
            this.llblShowLicenseInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.llblShowLicenseInfo.Location = new System.Drawing.Point(121, 59);
            this.llblShowLicenseInfo.Name = "llblShowLicenseInfo";
            this.llblShowLicenseInfo.Size = new System.Drawing.Size(139, 16);
            this.llblShowLicenseInfo.TabIndex = 1;
            this.llblShowLicenseInfo.TabStop = true;
            this.llblShowLicenseInfo.Text = "Show License Info";
            this.llblShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowLicenseInfo_LinkClicked);
            // 
            // lblLicenseClass
            // 
            this.lblLicenseClass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLicenseClass.Location = new System.Drawing.Point(425, 27);
            this.lblLicenseClass.Name = "lblLicenseClass";
            this.lblLicenseClass.Size = new System.Drawing.Size(222, 16);
            this.lblLicenseClass.TabIndex = 0;
            this.lblLicenseClass.Text = "N/A";
            // 
            // label9
            // 
            this.label9.Image = global::PresentationLayer.Properties.Resources.License;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(263, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Applied for License :";
            // 
            // label6
            // 
            this.label6.Image = global::PresentationLayer.Properties.Resources.Test;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(271, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Passed Tests :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassedTest
            // 
            this.lblPassedTest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPassedTest.Location = new System.Drawing.Point(425, 59);
            this.lblPassedTest.Name = "lblPassedTest";
            this.lblPassedTest.Size = new System.Drawing.Size(57, 16);
            this.lblPassedTest.TabIndex = 0;
            this.lblPassedTest.Text = "N/A";
            // 
            // lblLDLAppID
            // 
            this.lblLDLAppID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLDLAppID.Location = new System.Drawing.Point(121, 27);
            this.lblLDLAppID.Name = "lblLDLAppID";
            this.lblLDLAppID.Size = new System.Drawing.Size(41, 16);
            this.lblLDLAppID.TabIndex = 0;
            this.lblLDLAppID.Text = "N/A";
            this.lblLDLAppID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Image = global::PresentationLayer.Properties.Resources.id;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "D.L.App.ID : ";
            // 
            // ctrlAppBasicInfo1
            // 
            this.ctrlAppBasicInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlAppBasicInfo1.Location = new System.Drawing.Point(3, 98);
            this.ctrlAppBasicInfo1.Name = "ctrlAppBasicInfo1";
            this.ctrlAppBasicInfo1.Size = new System.Drawing.Size(661, 208);
            this.ctrlAppBasicInfo1.TabIndex = 1;
            // 
            // ctrlLDL_ApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlAppBasicInfo1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlLDL_ApplicationInfo";
            this.Size = new System.Drawing.Size(667, 306);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.LinkLabel llblShowLicenseInfo;
        private System.Windows.Forms.Label lblLicenseClass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPassedTest;
        private System.Windows.Forms.Label lblLDLAppID;
        private System.Windows.Forms.Label label1;
        private ctrlAppBasicInfo ctrlAppBasicInfo1;
    }
}
