namespace PresentationLayer
{
    partial class frmPeopleList
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
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlPeopleList1 = new PresentationLayer.ctrlPeopleList();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Image = global::PresentationLayer.Properties.Resources.users;
            this.label1.Location = new System.Drawing.Point(430, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 135);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mange People";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ctrlPeopleList1
            // 
            this.ctrlPeopleList1.BackColor = System.Drawing.Color.White;
            this.ctrlPeopleList1.Location = new System.Drawing.Point(14, 137);
            this.ctrlPeopleList1.Name = "ctrlPeopleList1";
            this.ctrlPeopleList1.Size = new System.Drawing.Size(1150, 491);
            this.ctrlPeopleList1.TabIndex = 0;
            // 
            // frmPeopleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 630);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlPeopleList1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1167, 630);
            this.MinimumSize = new System.Drawing.Size(1167, 630);
            this.Name = "frmPeopleList";
            this.Text = "frmPeopleList";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPeopleList ctrlPeopleList1;
        private System.Windows.Forms.Label label1;
    }
}