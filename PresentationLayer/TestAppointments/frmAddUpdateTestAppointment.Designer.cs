namespace PresentationLayer.TestAppointments
{
    partial class frmAddUpdateTestAppointment
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
            this.ctrlAddUpdateTestAppointment1 = new PresentationLayer.TestAppointments.controls.ctrlAddUpdateTestAppointment();
            this.SuspendLayout();
            // 
            // ctrlAddUpdateTestAppointment1
            // 
            this.ctrlAddUpdateTestAppointment1.BackColor = System.Drawing.Color.White;
            this.ctrlAddUpdateTestAppointment1.Location = new System.Drawing.Point(6, 12);
            this.ctrlAddUpdateTestAppointment1.Name = "ctrlAddUpdateTestAppointment1";
            this.ctrlAddUpdateTestAppointment1.Size = new System.Drawing.Size(414, 552);
            this.ctrlAddUpdateTestAppointment1.TabIndex = 0;
            // 
            // frmAddUpdateTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(426, 564);
            this.Controls.Add(this.ctrlAddUpdateTestAppointment1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdateTestAppointment";
            this.Text = "frmAddUpdateTestAppointment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddUpdateTestAppointment_FormClosed);
            this.Load += new System.EventHandler(this.frmAddUpdateTestAppointment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private controls.ctrlAddUpdateTestAppointment ctrlAddUpdateTestAppointment1;
    }
}