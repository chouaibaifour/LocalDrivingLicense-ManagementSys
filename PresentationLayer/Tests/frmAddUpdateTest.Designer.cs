namespace PresentationLayer.Tests
{
    partial class frmAddUpdateTest
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
            this.ctrlAddUpdateTest1 = new PresentationLayer.Tests.controls.ctrlAddUpdateTest();
            this.SuspendLayout();
            // 
            // ctrlAddUpdateTest1
            // 
            this.ctrlAddUpdateTest1.BackColor = System.Drawing.Color.White;
            this.ctrlAddUpdateTest1.Location = new System.Drawing.Point(3, 7);
            this.ctrlAddUpdateTest1.Name = "ctrlAddUpdateTest1";
            this.ctrlAddUpdateTest1.Size = new System.Drawing.Size(400, 600);
            this.ctrlAddUpdateTest1.TabIndex = 0;
            // 
            // frmAddUpdateTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(407, 614);
            this.Controls.Add(this.ctrlAddUpdateTest1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdateTest";
            this.Text = "frmAddUpdateTest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddUpdateTest_FormClosed);
            this.Load += new System.EventHandler(this.frmAddUpdateTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private controls.ctrlAddUpdateTest ctrlAddUpdateTest1;
    }
}