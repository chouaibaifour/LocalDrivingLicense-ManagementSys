namespace PresentationLayer.Users
{
    partial class frmUsersList
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
            this.ctrlUsersList1 = new PresentationLayer.Users.ctrlUsersList();
            this.SuspendLayout();
            // 
            // ctrlUsersList1
            // 
            this.ctrlUsersList1.BackColor = System.Drawing.Color.White;
            this.ctrlUsersList1.Location = new System.Drawing.Point(12, 139);
            this.ctrlUsersList1.Name = "ctrlUsersList1";
            this.ctrlUsersList1.Size = new System.Drawing.Size(599, 353);
            this.ctrlUsersList1.TabIndex = 0;
            // 
            // frmUsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 504);
            this.Controls.Add(this.ctrlUsersList1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsersList";
            this.Text = "Users";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlUsersList ctrlUsersList1;
    }
}