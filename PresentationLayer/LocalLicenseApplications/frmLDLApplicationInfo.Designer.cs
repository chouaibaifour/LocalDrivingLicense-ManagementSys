namespace PresentationLayer.LocalLicenseApplications
{
    partial class frmLDLApplicationInfo
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
            this.ctrlLDL_ApplicationInfo1 = new PresentationLayer.LocalLicenseApplication.controls.ctrlLDL_ApplicationInfo();
            this.lblClose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlLDL_ApplicationInfo1
            // 
            this.ctrlLDL_ApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlLDL_ApplicationInfo1.Location = new System.Drawing.Point(12, 46);
            this.ctrlLDL_ApplicationInfo1.Name = "ctrlLDL_ApplicationInfo1";
            this.ctrlLDL_ApplicationInfo1.Size = new System.Drawing.Size(667, 306);
            this.ctrlLDL_ApplicationInfo1.TabIndex = 0;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Red;
            this.lblClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(654, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(23, 22);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // frmLDLApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(689, 364);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.ctrlLDL_ApplicationInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLDLApplicationInfo";
            this.Text = "frmLDLApplicationInfo";
            this.Load += new System.EventHandler(this.frmLDLApplicationInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LocalLicenseApplication.controls.ctrlLDL_ApplicationInfo ctrlLDL_ApplicationInfo1;
        private System.Windows.Forms.Label lblClose;
    }
}