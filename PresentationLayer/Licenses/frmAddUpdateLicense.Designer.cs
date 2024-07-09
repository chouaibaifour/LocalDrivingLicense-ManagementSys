namespace PresentationLayer.Licenses
{
    partial class frmAddUpdateLicense
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
            this.ctrlAddUpdateLicense1 = new PresentationLayer.Licenses.controls.ctrlAddUpdateLicense();
            this.SuspendLayout();
            // 
            // ctrlAddUpdateLicense1
            // 
            this.ctrlAddUpdateLicense1.BackColor = System.Drawing.Color.White;
            this.ctrlAddUpdateLicense1.Location = new System.Drawing.Point(11, 5);
            this.ctrlAddUpdateLicense1.Name = "ctrlAddUpdateLicense1";
            this.ctrlAddUpdateLicense1.Size = new System.Drawing.Size(670, 505);
            this.ctrlAddUpdateLicense1.TabIndex = 0;
            // 
            // frmAddUpdateLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 514);
            this.Controls.Add(this.ctrlAddUpdateLicense1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdateLicense";
            this.Text = "frmAddUpdateLicense";
            this.Load += new System.EventHandler(this.frmAddUpdateLicense_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private controls.ctrlAddUpdateLicense ctrlAddUpdateLicense1;
    }
}