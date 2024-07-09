namespace PresentationLayer.LocalLicenseApplication.controls
{
    partial class ctrlLDLApplicationList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLDLApplications = new System.Windows.Forms.DataGridView();
            this.cmsLDLApplicationList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.smiApplicationDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.smiEditApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.smiDeleteApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.smiScheduleTest = new System.Windows.Forms.ToolStripMenuItem();
            this.smiVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.smiWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.smiStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.smiIssueDrivingLicesne = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.smiShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.smiShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.btnAddApplication = new System.Windows.Forms.Button();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.epEmptyOrNull = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.CancelApplication = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApplications)).BeginInit();
            this.cmsLDLApplicationList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epEmptyOrNull)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLDLApplications
            // 
            this.dgvLDLApplications.AllowUserToAddRows = false;
            this.dgvLDLApplications.AllowUserToDeleteRows = false;
            this.dgvLDLApplications.AllowUserToResizeColumns = false;
            this.dgvLDLApplications.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLDLApplications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLDLApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLDLApplications.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLDLApplications.BackgroundColor = System.Drawing.Color.White;
            this.dgvLDLApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLDLApplications.ContextMenuStrip = this.cmsLDLApplicationList;
            this.dgvLDLApplications.Location = new System.Drawing.Point(6, 63);
            this.dgvLDLApplications.MultiSelect = false;
            this.dgvLDLApplications.Name = "dgvLDLApplications";
            this.dgvLDLApplications.ReadOnly = true;
            this.dgvLDLApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLDLApplications.Size = new System.Drawing.Size(964, 377);
            this.dgvLDLApplications.TabIndex = 0;
            // 
            // cmsLDLApplicationList
            // 
            this.cmsLDLApplicationList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsLDLApplicationList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiApplicationDetails,
            this.toolStripMenuItem1,
            this.smiEditApplication,
            this.toolStripMenuItem2,
            this.smiDeleteApplication,
            this.toolStripMenuItem3,
            this.CancelApplication,
            this.toolStripMenuItem4,
            this.smiScheduleTest,
            this.toolStripMenuItem5,
            this.smiIssueDrivingLicesne,
            this.toolStripMenuItem6,
            this.smiShowLicense,
            this.toolStripMenuItem7,
            this.smiShowPersonLicenseHistory});
            this.cmsLDLApplicationList.Name = "cmsLDLApplicationList";
            this.cmsLDLApplicationList.Size = new System.Drawing.Size(267, 244);
            this.cmsLDLApplicationList.Opening += new System.ComponentModel.CancelEventHandler(this.cmsLDLApplicationList_Opening);
            // 
            // smiApplicationDetails
            // 
            this.smiApplicationDetails.Name = "smiApplicationDetails";
            this.smiApplicationDetails.Size = new System.Drawing.Size(266, 22);
            this.smiApplicationDetails.Text = "Show Application Details";
            this.smiApplicationDetails.Click += new System.EventHandler(this.smiApplicationDetails_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(263, 6);
            // 
            // smiEditApplication
            // 
            this.smiEditApplication.Name = "smiEditApplication";
            this.smiEditApplication.Size = new System.Drawing.Size(266, 22);
            this.smiEditApplication.Text = "Edit Application ";
            this.smiEditApplication.Click += new System.EventHandler(this.smiEditApplication_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(263, 6);
            // 
            // smiDeleteApplication
            // 
            this.smiDeleteApplication.Name = "smiDeleteApplication";
            this.smiDeleteApplication.Size = new System.Drawing.Size(266, 22);
            this.smiDeleteApplication.Text = "Delete Application";
            this.smiDeleteApplication.Click += new System.EventHandler(this.smiDeleteApplication_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(263, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(263, 6);
            // 
            // smiScheduleTest
            // 
            this.smiScheduleTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiVisionTest,
            this.smiWrittenTest,
            this.smiStreetTest});
            this.smiScheduleTest.Name = "smiScheduleTest";
            this.smiScheduleTest.Size = new System.Drawing.Size(266, 22);
            this.smiScheduleTest.Text = "Schedule Tests";
            // 
            // smiVisionTest
            // 
            this.smiVisionTest.Name = "smiVisionTest";
            this.smiVisionTest.Size = new System.Drawing.Size(202, 22);
            this.smiVisionTest.Text = "Schedule Vision Test";
            this.smiVisionTest.Click += new System.EventHandler(this.smiVisionTest_Click);
            // 
            // smiWrittenTest
            // 
            this.smiWrittenTest.Name = "smiWrittenTest";
            this.smiWrittenTest.Size = new System.Drawing.Size(202, 22);
            this.smiWrittenTest.Text = "Schedule Written Test";
            this.smiWrittenTest.Click += new System.EventHandler(this.smiWrittenTest_Click);
            // 
            // smiStreetTest
            // 
            this.smiStreetTest.Name = "smiStreetTest";
            this.smiStreetTest.Size = new System.Drawing.Size(202, 22);
            this.smiStreetTest.Text = "Schedule Street Test";
            this.smiStreetTest.Click += new System.EventHandler(this.smiStreetTest_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(263, 6);
            // 
            // smiIssueDrivingLicesne
            // 
            this.smiIssueDrivingLicesne.Enabled = false;
            this.smiIssueDrivingLicesne.Name = "smiIssueDrivingLicesne";
            this.smiIssueDrivingLicesne.Size = new System.Drawing.Size(266, 22);
            this.smiIssueDrivingLicesne.Text = "Issue Driving License (First Time)";
            this.smiIssueDrivingLicesne.Click += new System.EventHandler(this.smiIssueDrivingLicesne_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(263, 6);
            // 
            // smiShowLicense
            // 
            this.smiShowLicense.Enabled = false;
            this.smiShowLicense.Name = "smiShowLicense";
            this.smiShowLicense.Size = new System.Drawing.Size(266, 22);
            this.smiShowLicense.Text = "Show License";
            this.smiShowLicense.Click += new System.EventHandler(this.smiShowLicense_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(263, 6);
            // 
            // smiShowPersonLicenseHistory
            // 
            this.smiShowPersonLicenseHistory.Name = "smiShowPersonLicenseHistory";
            this.smiShowPersonLicenseHistory.Size = new System.Drawing.Size(266, 22);
            this.smiShowPersonLicenseHistory.Text = "Show Person License History";
            this.smiShowPersonLicenseHistory.Click += new System.EventHandler(this.smiShowPersonLicenseHistory_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "# Records :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filter By : ";
            // 
            // cbFilters
            // 
            this.cbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilters.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Items.AddRange(new object[] {
            "None",
            "L.D.L.AppID",
            "NationalNo",
            "FullName",
            "Status"});
            this.cbFilters.Location = new System.Drawing.Point(88, 26);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(121, 24);
            this.cbFilters.TabIndex = 2;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged_1);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.Location = new System.Drawing.Point(103, 452);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(59, 18);
            this.lblRecordCount.TabIndex = 1;
            this.lblRecordCount.Text = "N/A";
            // 
            // btnAddApplication
            // 
            this.btnAddApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddApplication.Image = global::PresentationLayer.Properties.Resources.AddApplications;
            this.btnAddApplication.Location = new System.Drawing.Point(910, 7);
            this.btnAddApplication.Name = "btnAddApplication";
            this.btnAddApplication.Size = new System.Drawing.Size(50, 50);
            this.btnAddApplication.TabIndex = 3;
            this.btnAddApplication.UseVisualStyleBackColor = true;
            this.btnAddApplication.Click += new System.EventHandler(this.btnAddApplication_Click);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValue.Location = new System.Drawing.Point(226, 26);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(132, 22);
            this.txtFilterValue.TabIndex = 4;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFilterValue_KeyUp_1);
            this.txtFilterValue.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingEmptyOrNulltxt);
            // 
            // epEmptyOrNull
            // 
            this.epEmptyOrNull.ContainerControl = this;
            // 
            // cbStatus
            // 
            this.cbStatus.AllowDrop = true;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "All",
            "New",
            "In Progress",
            "Completed",
            "Canceled"});
            this.cbStatus.Location = new System.Drawing.Point(226, 26);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(132, 24);
            this.cbStatus.TabIndex = 5;
            this.cbStatus.Visible = false;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // CancelApplication
            // 
            this.CancelApplication.Name = "CancelApplication";
            this.CancelApplication.Size = new System.Drawing.Size(266, 22);
            this.CancelApplication.Text = "Cancel Application";
            this.CancelApplication.Click += new System.EventHandler(this.CancelApplication_Click);
            // 
            // ctrlLDLApplicationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.btnAddApplication);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLDLApplications);
            this.Name = "ctrlLDLApplicationList";
            this.Size = new System.Drawing.Size(975, 479);
            this.Load += new System.EventHandler(this.ctrlLDLApplicationList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApplications)).EndInit();
            this.cmsLDLApplicationList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epEmptyOrNull)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLDLApplications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Button btnAddApplication;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ErrorProvider epEmptyOrNull;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ContextMenuStrip cmsLDLApplicationList;
        private System.Windows.Forms.ToolStripMenuItem smiApplicationDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem smiEditApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem smiDeleteApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem smiScheduleTest;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem smiIssueDrivingLicesne;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem smiShowLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem smiShowPersonLicenseHistory;
        private System.Windows.Forms.ToolStripMenuItem smiVisionTest;
        private System.Windows.Forms.ToolStripMenuItem smiWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem smiStreetTest;
        private System.Windows.Forms.ToolStripMenuItem CancelApplication;
    }
}
