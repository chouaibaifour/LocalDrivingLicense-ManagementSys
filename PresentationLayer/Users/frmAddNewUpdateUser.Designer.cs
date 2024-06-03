namespace PresentationLayer.Users
{
    partial class frmAddNewUpdateUser
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
            this.ctrlAddNewUpdateUser1 = new PresentationLayer.Users.controls.ctrlAddNewUpdateUser();
            this.SuspendLayout();
            // 
            // ctrlAddNewUpdateUser1
            // 
            this.ctrlAddNewUpdateUser1.BackColor = System.Drawing.Color.White;
            this.ctrlAddNewUpdateUser1.Location = new System.Drawing.Point(12, 12);
            this.ctrlAddNewUpdateUser1.Name = "ctrlAddNewUpdateUser1";
            this.ctrlAddNewUpdateUser1.Size = new System.Drawing.Size(861, 598);
            this.ctrlAddNewUpdateUser1.TabIndex = 0;
            // 
            // frmAddNewUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 620);
            this.Controls.Add(this.ctrlAddNewUpdateUser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddNewUpdateUser";
            this.Text = "frmAddNewUpdateUser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddNewUpdateUser_FormClosed);
            this.Load += new System.EventHandler(this.frmAddNewUpdateUser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private controls.ctrlAddNewUpdateUser ctrlAddNewUpdateUser1;
    }
}