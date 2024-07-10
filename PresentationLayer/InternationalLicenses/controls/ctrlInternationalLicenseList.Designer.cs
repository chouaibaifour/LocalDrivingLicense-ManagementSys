namespace PresentationLayer.InternationalLicenses.controls
{
    partial class ctrlInternationalLicenseList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvInternationalLicenses = new System.Windows.Forms.DataGridView();
            this.cmsInternationalLicense = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.smiShowPersonDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.smiShowLicenseInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.smiShowPersonLicenseHitory = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.cbLicenseStatus = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.epEmptyOrNull = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAddNewInternationalLicense = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).BeginInit();
            this.cmsInternationalLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epEmptyOrNull)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInternationalLicenses
            // 
            this.dgvInternationalLicenses.AllowUserToAddRows = false;
            this.dgvInternationalLicenses.AllowUserToDeleteRows = false;
            this.dgvInternationalLicenses.AllowUserToOrderColumns = true;
            this.dgvInternationalLicenses.AllowUserToResizeColumns = false;
            this.dgvInternationalLicenses.AllowUserToResizeRows = false;
            this.dgvInternationalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInternationalLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicenses.ContextMenuStrip = this.cmsInternationalLicense;
            this.dgvInternationalLicenses.Location = new System.Drawing.Point(3, 62);
            this.dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            this.dgvInternationalLicenses.ReadOnly = true;
            this.dgvInternationalLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternationalLicenses.Size = new System.Drawing.Size(851, 252);
            this.dgvInternationalLicenses.TabIndex = 0;
            // 
            // cmsInternationalLicense
            // 
            this.cmsInternationalLicense.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsInternationalLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiShowPersonDetails,
            this.smiShowLicenseInfo,
            this.smiShowPersonLicenseHitory});
            this.cmsInternationalLicense.Name = "cmsInternationalLicense";
            this.cmsInternationalLicense.Size = new System.Drawing.Size(246, 70);
            // 
            // smiShowPersonDetails
            // 
            this.smiShowPersonDetails.Name = "smiShowPersonDetails";
            this.smiShowPersonDetails.Size = new System.Drawing.Size(245, 22);
            this.smiShowPersonDetails.Text = "Show Person Details";
            this.smiShowPersonDetails.Click += new System.EventHandler(this.smiShowPersonDetails_Click);
            // 
            // smiShowLicenseInfo
            // 
            this.smiShowLicenseInfo.Name = "smiShowLicenseInfo";
            this.smiShowLicenseInfo.Size = new System.Drawing.Size(245, 22);
            this.smiShowLicenseInfo.Text = "Show License Info";
            this.smiShowLicenseInfo.Click += new System.EventHandler(this.smiShowLicenseInfo_Click);
            // 
            // smiShowPersonLicenseHitory
            // 
            this.smiShowPersonLicenseHitory.Name = "smiShowPersonLicenseHitory";
            this.smiShowPersonLicenseHitory.Size = new System.Drawing.Size(245, 22);
            this.smiShowPersonLicenseHitory.Text = "Show Person License History";
            this.smiShowPersonLicenseHitory.Click += new System.EventHandler(this.smiShowPersonLicenseHitory_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "# Records : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(97, 327);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(83, 20);
            this.lblRecordsCount.TabIndex = 2;
            this.lblRecordsCount.Text = "N/A";
            this.lblRecordsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filter By : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbFilters
            // 
            this.cbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilters.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbFilters.Items.AddRange(new object[] {
            "None",
            "Int.LicenseID",
            "Application ID",
            "Driver ID",
            "License ID ",
            "License Status"});
            this.cbFilters.Location = new System.Drawing.Point(87, 24);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(121, 24);
            this.cbFilters.TabIndex = 6;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // cbLicenseStatus
            // 
            this.cbLicenseStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLicenseStatus.FormattingEnabled = true;
            this.cbLicenseStatus.Items.AddRange(new object[] {
            "All",
            "Active",
            "Disactive"});
            this.cbLicenseStatus.Location = new System.Drawing.Point(239, 24);
            this.cbLicenseStatus.Name = "cbLicenseStatus";
            this.cbLicenseStatus.Size = new System.Drawing.Size(121, 24);
            this.cbLicenseStatus.TabIndex = 8;
            this.cbLicenseStatus.Visible = false;
            this.cbLicenseStatus.SelectedIndexChanged += new System.EventHandler(this.cbLicenseStatus_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValue.Location = new System.Drawing.Point(239, 24);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(121, 22);
            this.txtFilterValue.TabIndex = 9;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFilterValue_KeyUp);
            this.txtFilterValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterValue_Validating);
            // 
            // epEmptyOrNull
            // 
            this.epEmptyOrNull.ContainerControl = this;
            // 
            // btnAddNewInternationalLicense
            // 
            this.btnAddNewInternationalLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewInternationalLicense.Image = global::PresentationLayer.Properties.Resources.AddApplications;
            this.btnAddNewInternationalLicense.Location = new System.Drawing.Point(792, 6);
            this.btnAddNewInternationalLicense.Name = "btnAddNewInternationalLicense";
            this.btnAddNewInternationalLicense.Size = new System.Drawing.Size(50, 50);
            this.btnAddNewInternationalLicense.TabIndex = 3;
            this.btnAddNewInternationalLicense.UseVisualStyleBackColor = true;
            this.btnAddNewInternationalLicense.Click += new System.EventHandler(this.btnAddNewInternationalLicense_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::PresentationLayer.Properties.Resources.close1;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(767, 326);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlInternationalLicenseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbLicenseStatus);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddNewInternationalLicense);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInternationalLicenses);
            this.Name = "ctrlInternationalLicenseList";
            this.Size = new System.Drawing.Size(857, 359);
            this.Load += new System.EventHandler(this.ctrlInternationalLicenseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).EndInit();
            this.cmsInternationalLicense.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epEmptyOrNull)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInternationalLicenses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Button btnAddNewInternationalLicense;
        private System.Windows.Forms.ContextMenuStrip cmsInternationalLicense;
        private System.Windows.Forms.ToolStripMenuItem smiShowPersonDetails;
        private System.Windows.Forms.ToolStripMenuItem smiShowLicenseInfo;
        private System.Windows.Forms.ToolStripMenuItem smiShowPersonLicenseHitory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.ComboBox cbLicenseStatus;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ErrorProvider epEmptyOrNull;
        private System.Windows.Forms.Button btnClose;
    }
}
