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
            this.ctrlAddUpdateLocal_L_Application1 = new PresentationLayer.LocalLicenseApplication.controls.ctrlAddUpdateLocal_L_Application();
            this.SuspendLayout();
            // 
            // ctrlAddUpdateLocal_L_Application1
            // 
            this.ctrlAddUpdateLocal_L_Application1.BackColor = System.Drawing.Color.White;
            this.ctrlAddUpdateLocal_L_Application1.Location = new System.Drawing.Point(10, 12);
            this.ctrlAddUpdateLocal_L_Application1.Name = "ctrlAddUpdateLocal_L_Application1";
            this.ctrlAddUpdateLocal_L_Application1.Size = new System.Drawing.Size(872, 652);
            this.ctrlAddUpdateLocal_L_Application1.TabIndex = 0;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 692);
            this.Controls.Add(this.ctrlAddUpdateLocal_L_Application1);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LocalLicenseApplication.controls.ctrlAddUpdateLocal_L_Application ctrlAddUpdateLocal_L_Application1;
    }
}