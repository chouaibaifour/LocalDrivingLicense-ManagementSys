namespace PresentationLayer.ApplicationTypes
{
    partial class frmApplicationTypeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApplicationTypeList));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctrlApplicationTypesList1 = new PresentationLayer.ApplicationTypes.ctrlApplicationTypesList();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(248, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ctrlApplicationTypesList1
            // 
            this.ctrlApplicationTypesList1.BackColor = System.Drawing.Color.White;
            this.ctrlApplicationTypesList1.Location = new System.Drawing.Point(12, 181);
            this.ctrlApplicationTypesList1.Name = "ctrlApplicationTypesList1";
            this.ctrlApplicationTypesList1.Size = new System.Drawing.Size(657, 370);
            this.ctrlApplicationTypesList1.TabIndex = 0;
            // 
            // frmApplicationTypeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 563);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctrlApplicationTypesList1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmApplicationTypeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmApplicationTypeList";
            this.Load += new System.EventHandler(this.frmApplicationTypeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlApplicationTypesList ctrlApplicationTypesList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}