namespace PresentationLayer
{
    partial class frmAddNewUpdatePerson
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
            this.ctrlAddNewUpdatePerson1 = new PresentationLayer.ctrlAddNewUpdatePerson();
            this.SuspendLayout();
            // 
            // ctrlAddNewUpdatePerson1
            // 
            this.ctrlAddNewUpdatePerson1.AutoSize = true;
            this.ctrlAddNewUpdatePerson1.BackColor = System.Drawing.Color.White;
            this.ctrlAddNewUpdatePerson1.Location = new System.Drawing.Point(0, 0);
            this.ctrlAddNewUpdatePerson1.Name = "ctrlAddNewUpdatePerson1";
            this.ctrlAddNewUpdatePerson1.Size = new System.Drawing.Size(793, 402);
            this.ctrlAddNewUpdatePerson1.TabIndex = 0;
            // 
            // frmAddNewUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 402);
            this.Controls.Add(this.ctrlAddNewUpdatePerson1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddNewUpdatePerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddNewUpdatePerson_FormClosed);
            this.Load += new System.EventHandler(this.frmAddNewUpdatePerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlAddNewUpdatePerson ctrlAddNewUpdatePerson1;
    }
}