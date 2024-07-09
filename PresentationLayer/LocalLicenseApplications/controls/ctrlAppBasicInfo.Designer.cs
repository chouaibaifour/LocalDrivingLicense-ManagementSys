namespace PresentationLayer.LocalLicenseApplication.controls
{
    partial class ctrlAppBasicInfo
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
            this.llblShowPersonInfo = new System.Windows.Forms.LinkLabel();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblLastStatusDate = new System.Windows.Forms.Label();
            this.lblApplicant = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAppType = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAppStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAppID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.llblShowPersonInfo);
            this.groupBox1.Controls.Add(this.lblAppDate);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblCreatedBy);
            this.groupBox1.Controls.Add(this.lblLastStatusDate);
            this.groupBox1.Controls.Add(this.lblApplicant);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblAppType);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblAppFees);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblAppStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblAppID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 250);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Basic Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // llblShowPersonInfo
            // 
            this.llblShowPersonInfo.Image = global::PresentationLayer.Properties.Resources.user;
            this.llblShowPersonInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.llblShowPersonInfo.Location = new System.Drawing.Point(481, 214);
            this.llblShowPersonInfo.Name = "llblShowPersonInfo";
            this.llblShowPersonInfo.Size = new System.Drawing.Size(128, 22);
            this.llblShowPersonInfo.TabIndex = 1;
            this.llblShowPersonInfo.TabStop = true;
            this.llblShowPersonInfo.Text = "View Person Info";
            this.llblShowPersonInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llblShowPersonInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowPersonInfo_LinkClicked);
            // 
            // lblAppDate
            // 
            this.lblAppDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAppDate.Location = new System.Drawing.Point(481, 35);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(163, 22);
            this.lblAppDate.TabIndex = 0;
            this.lblAppDate.Text = "N/A";
            this.lblAppDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Image = global::PresentationLayer.Properties.Resources.DateOfBirth;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(392, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Date :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Image = global::PresentationLayer.Properties.Resources.user;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Location = new System.Drawing.Point(354, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 22);
            this.label13.TabIndex = 0;
            this.label13.Text = "Created by :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Image = global::PresentationLayer.Properties.Resources.DateOfBirth;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(351, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Status Date :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCreatedBy.Location = new System.Drawing.Point(481, 109);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(163, 22);
            this.lblCreatedBy.TabIndex = 0;
            this.lblCreatedBy.Text = "N/A";
            this.lblCreatedBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastStatusDate
            // 
            this.lblLastStatusDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLastStatusDate.Location = new System.Drawing.Point(481, 73);
            this.lblLastStatusDate.Name = "lblLastStatusDate";
            this.lblLastStatusDate.Size = new System.Drawing.Size(163, 22);
            this.lblLastStatusDate.TabIndex = 0;
            this.lblLastStatusDate.Text = "N/A";
            this.lblLastStatusDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApplicant
            // 
            this.lblApplicant.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblApplicant.Location = new System.Drawing.Point(130, 214);
            this.lblApplicant.Name = "lblApplicant";
            this.lblApplicant.Size = new System.Drawing.Size(220, 22);
            this.lblApplicant.TabIndex = 0;
            this.lblApplicant.Text = "N/A";
            this.lblApplicant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Image = global::PresentationLayer.Properties.Resources.user;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(6, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Applicant : ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppType
            // 
            this.lblAppType.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAppType.Location = new System.Drawing.Point(130, 161);
            this.lblAppType.Name = "lblAppType";
            this.lblAppType.Size = new System.Drawing.Size(220, 22);
            this.lblAppType.TabIndex = 0;
            this.lblAppType.Text = "N/A";
            this.lblAppType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Image = global::PresentationLayer.Properties.Resources.Test;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(31, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Type : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppFees
            // 
            this.lblAppFees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAppFees.Location = new System.Drawing.Point(130, 109);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(220, 22);
            this.lblAppFees.TabIndex = 0;
            this.lblAppFees.Text = "N/A";
            this.lblAppFees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Image = global::PresentationLayer.Properties.Resources.money;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(28, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fees : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppStatus
            // 
            this.lblAppStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAppStatus.Location = new System.Drawing.Point(130, 73);
            this.lblAppStatus.Name = "lblAppStatus";
            this.lblAppStatus.Size = new System.Drawing.Size(220, 22);
            this.lblAppStatus.TabIndex = 0;
            this.lblAppStatus.Text = "N/A";
            this.lblAppStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Image = global::PresentationLayer.Properties.Resources.id1;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Status : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppID
            // 
            this.lblAppID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAppID.Location = new System.Drawing.Point(130, 35);
            this.lblAppID.Name = "lblAppID";
            this.lblAppID.Size = new System.Drawing.Size(220, 22);
            this.lblAppID.TabIndex = 0;
            this.lblAppID.Text = "N/A";
            this.lblAppID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Image = global::PresentationLayer.Properties.Resources.id1;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlAppBasicInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlAppBasicInfo";
            this.Size = new System.Drawing.Size(663, 250);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel llblShowPersonInfo;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblLastStatusDate;
        private System.Windows.Forms.Label lblApplicant;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAppType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAppStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAppID;
        private System.Windows.Forms.Label label1;
    }
}
