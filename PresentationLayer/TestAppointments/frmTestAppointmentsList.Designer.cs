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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestAppointmentsList));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTestType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picTestType = new System.Windows.Forms.PictureBox();
            this.ctrlTestAppointments1 = new PresentationLayer.TestAppointments.controls.ctrlTestAppointments();
            ((System.ComponentModel.ISupportInitialize)(this.picTestType)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(196, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vision Test Appointment";
            // 
            // lblTestType
            // 
            this.lblTestType.AutoSize = true;
            this.lblTestType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestType.Location = new System.Drawing.Point(12, 9);
            this.lblTestType.Name = "lblTestType";
            this.lblTestType.Size = new System.Drawing.Size(138, 15);
            this.lblTestType.TabIndex = 2;
            this.lblTestType.Text = "Vision Test Appointment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(638, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // picTestType
            // 
            this.picTestType.Image = ((System.Drawing.Image)(resources.GetObject("picTestType.Image")));
            this.picTestType.Location = new System.Drawing.Point(273, 47);
            this.picTestType.Name = "picTestType";
            this.picTestType.Size = new System.Drawing.Size(64, 64);
            this.picTestType.TabIndex = 3;
            this.picTestType.TabStop = false;
            // 
            // ctrlTestAppointments1
            // 
            this.ctrlTestAppointments1.BackColor = System.Drawing.Color.White;
            this.ctrlTestAppointments1.Location = new System.Drawing.Point(3, 163);
            this.ctrlTestAppointments1.Name = "ctrlTestAppointments1";
            this.ctrlTestAppointments1.Size = new System.Drawing.Size(670, 602);
            this.ctrlTestAppointments1.TabIndex = 0;
            // 
            // frmTestAppointmentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 768);
            this.Controls.Add(this.picTestType);
            this.Controls.Add(this.lblTestType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlTestAppointments1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTestAppointmentsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTestAppointmentsList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTestAppointmentsList_FormClosed);
            this.Load += new System.EventHandler(this.frmTestAppointmentsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTestType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.ctrlTestAppointments ctrlTestAppointments1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTestType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picTestType;
    }
}