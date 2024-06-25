namespace PresentationLayer.LocalLicenseApplication
{
    partial class frmLDLApplicationList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLDLApplicationList));
            this.ctrlLDLApplicationList1 = new PresentationLayer.LocalLicenseApplication.controls.ctrlLDLApplicationList();
            this.pbApplications = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplications)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlLDLApplicationList1
            // 
            this.ctrlLDLApplicationList1.BackColor = System.Drawing.Color.White;
            this.ctrlLDLApplicationList1.Location = new System.Drawing.Point(12, 254);
            this.ctrlLDLApplicationList1.Name = "ctrlLDLApplicationList1";
            this.ctrlLDLApplicationList1.Size = new System.Drawing.Size(975, 479);
            this.ctrlLDLApplicationList1.TabIndex = 0;
            // 
            // pbApplications
            // 
            this.pbApplications.Image = ((System.Drawing.Image)(resources.GetObject("pbApplications.Image")));
            this.pbApplications.Location = new System.Drawing.Point(391, 26);
            this.pbApplications.Name = "pbApplications";
            this.pbApplications.Size = new System.Drawing.Size(181, 139);
            this.pbApplications.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApplications.TabIndex = 1;
            this.pbApplications.TabStop = false;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Local Driving License Applications";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Local Driving License Applcations";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(963, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmLDLApplicationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(999, 742);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbApplications);
            this.Controls.Add(this.ctrlLDLApplicationList1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLDLApplicationList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLDLApplicationList";
            ((System.ComponentModel.ISupportInitialize)(this.pbApplications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.ctrlLDLApplicationList ctrlLDLApplicationList1;
        private System.Windows.Forms.PictureBox pbApplications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}