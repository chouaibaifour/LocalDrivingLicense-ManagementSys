namespace PresentationLayer.Licenses
{
    partial class frmPersonLicenseHistory
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
            this.ctrlPersonLicenseHistory1 = new PresentationLayer.Licenses.controls.ctrlPersonLicenseHistory();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlPersonLicenseHistory1
            // 
            this.ctrlPersonLicenseHistory1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonLicenseHistory1.Location = new System.Drawing.Point(12, 36);
            this.ctrlPersonLicenseHistory1.Name = "ctrlPersonLicenseHistory1";
            this.ctrlPersonLicenseHistory1.Size = new System.Drawing.Size(893, 695);
            this.ctrlPersonLicenseHistory1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Red;
            this.lblClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(882, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(23, 22);
            this.lblClose.TabIndex = 2;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // frmPersonLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 731);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlPersonLicenseHistory1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonLicenseHistory";
            this.Text = "frmPersonLicenseHistory";
            this.Load += new System.EventHandler(this.frmPersonLicenseHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.ctrlPersonLicenseHistory ctrlPersonLicenseHistory1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClose;
    }
}