namespace PresentationLayer.TestAppointments
{
    partial class frmTestAppointmentsList
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
            this.ctrlTestAppointments1 = new PresentationLayer.TestAppointments.controls.ctrlTestAppointments();
            this.SuspendLayout();
            // 
            // ctrlTestAppointments1
            // 
            this.ctrlTestAppointments1.BackColor = System.Drawing.Color.White;
            this.ctrlTestAppointments1.Location = new System.Drawing.Point(65, 91);
            this.ctrlTestAppointments1.Name = "ctrlTestAppointments1";
            this.ctrlTestAppointments1.Size = new System.Drawing.Size(670, 675);
            this.ctrlTestAppointments1.TabIndex = 0;
            // 
            // frmTestAppointmentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 768);
            this.Controls.Add(this.ctrlTestAppointments1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTestAppointmentsList";
            this.Text = "frmTestAppointmentsList";
            this.Load += new System.EventHandler(this.frmTestAppointmentsList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private controls.ctrlTestAppointments ctrlTestAppointments1;
    }
}