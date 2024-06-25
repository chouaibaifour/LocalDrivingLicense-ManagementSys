namespace PresentationLayer
{
    partial class Test
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
            this.ctrlLDLApplicationList1 = new PresentationLayer.LocalLicenseApplication.controls.ctrlLDLApplicationList();
            this.SuspendLayout();
            // 
            // ctrlLDLApplicationList1
            // 
            this.ctrlLDLApplicationList1.BackColor = System.Drawing.Color.White;
            this.ctrlLDLApplicationList1.Location = new System.Drawing.Point(41, 39);
            this.ctrlLDLApplicationList1.Name = "ctrlLDLApplicationList1";
            this.ctrlLDLApplicationList1.Size = new System.Drawing.Size(975, 479);
            this.ctrlLDLApplicationList1.TabIndex = 0;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 692);
            this.Controls.Add(this.ctrlLDLApplicationList1);
            this.Name = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LocalLicenseApplication.controls.ctrlLDLApplicationList ctrlLDLApplicationList1;
    }
}