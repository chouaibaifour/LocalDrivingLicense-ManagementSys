namespace PresentationLayer.InternationalLicenses.controls
{
    partial class frmInternationalLicenseList
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
            this.ctrlInternationalLicenseList1 = new PresentationLayer.InternationalLicenses.controls.ctrlInternationalLicenseList();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlInternationalLicenseList1
            // 
            this.ctrlInternationalLicenseList1.BackColor = System.Drawing.Color.White;
            this.ctrlInternationalLicenseList1.Location = new System.Drawing.Point(12, 112);
            this.ctrlInternationalLicenseList1.Name = "ctrlInternationalLicenseList1";
            this.ctrlInternationalLicenseList1.Size = new System.Drawing.Size(857, 359);
            this.ctrlInternationalLicenseList1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(239, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "International License Applications";
            // 
            // frmInternationalLicenseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(883, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlInternationalLicenseList1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInternationalLicenseList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInternationalLicenseList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlInternationalLicenseList ctrlInternationalLicenseList1;
        private System.Windows.Forms.Label label1;
    }
}