namespace PresentationLayer.Licenses
{
    partial class frmRenewLicense
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ctrlRenewLicense1 = new PresentationLayer.Licenses.controls.ctrlRenewLicense();
            this.SuspendLayout();
            // 
            // ctrlRenewLicense1
            // 
            this.ctrlRenewLicense1.BackColor = System.Drawing.Color.White;
            this.ctrlRenewLicense1.Location = new System.Drawing.Point(13, 15);
            this.ctrlRenewLicense1.Name = "ctrlRenewLicense1";
            this.ctrlRenewLicense1.Size = new System.Drawing.Size(714, 636);
            this.ctrlRenewLicense1.TabIndex = 0;
            // 
            // frmRenewLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(741, 667);
            this.Controls.Add(this.ctrlRenewLicense1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRenewLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRenewLicense";
            this.Load += new System.EventHandler(this.frmRenewLicense_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private controls.ctrlRenewLicense ctrlRenewLicense1;
    }
}