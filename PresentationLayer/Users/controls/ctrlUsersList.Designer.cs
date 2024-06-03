namespace PresentationLayer.Users
{
    partial class ctrlUsersList
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.cmsListUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.smiAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.smiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.smiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.smiChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.smiSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.smiCall = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.cbAccountStatus = new System.Windows.Forms.ComboBox();
            this.epEmptyOrNull = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.cmsListUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epEmptyOrNull)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeColumns = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.ContextMenuStrip = this.cmsListUsers;
            this.dgvUsers.GridColor = System.Drawing.Color.White;
            this.dgvUsers.Location = new System.Drawing.Point(3, 44);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(593, 262);
            this.dgvUsers.TabIndex = 0;
            // 
            // cmsListUsers
            // 
            this.cmsListUsers.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsListUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.addNewUserToolStripMenuItem,
            this.smiAddNew,
            this.smiEdit,
            this.smiDelete,
            this.smiChangePassword,
            this.toolStripMenuItem1,
            this.smiSendEmail,
            this.smiCall});
            this.cmsListUsers.Name = "contextMenuStrip1";
            this.cmsListUsers.Size = new System.Drawing.Size(181, 192);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.Details;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showToolStripMenuItem.Text = "Show Details";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.smiShowDetails_Click);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // smiAddNew
            // 
            this.smiAddNew.Image = global::PresentationLayer.Properties.Resources.AddPerson;
            this.smiAddNew.Name = "smiAddNew";
            this.smiAddNew.Size = new System.Drawing.Size(180, 22);
            this.smiAddNew.Text = "Add New User";
            this.smiAddNew.Click += new System.EventHandler(this.smiAddNew_Click);
            // 
            // smiEdit
            // 
            this.smiEdit.Image = global::PresentationLayer.Properties.Resources.Edit;
            this.smiEdit.Name = "smiEdit";
            this.smiEdit.Size = new System.Drawing.Size(180, 22);
            this.smiEdit.Text = "Edit";
            this.smiEdit.Click += new System.EventHandler(this.smiEdit_Click);
            // 
            // smiDelete
            // 
            this.smiDelete.Image = global::PresentationLayer.Properties.Resources.delete;
            this.smiDelete.Name = "smiDelete";
            this.smiDelete.Size = new System.Drawing.Size(180, 22);
            this.smiDelete.Text = "Delete";
            this.smiDelete.Click += new System.EventHandler(this.smiDelete_Click);
            // 
            // smiChangePassword
            // 
            this.smiChangePassword.Image = global::PresentationLayer.Properties.Resources.password;
            this.smiChangePassword.Name = "smiChangePassword";
            this.smiChangePassword.Size = new System.Drawing.Size(180, 22);
            this.smiChangePassword.Text = "Change Password";
            this.smiChangePassword.Click += new System.EventHandler(this.smiChangePassword_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // smiSendEmail
            // 
            this.smiSendEmail.Image = global::PresentationLayer.Properties.Resources.mail;
            this.smiSendEmail.Name = "smiSendEmail";
            this.smiSendEmail.Size = new System.Drawing.Size(180, 22);
            this.smiSendEmail.Text = "Send Email";
            this.smiSendEmail.Click += new System.EventHandler(this.smiSendEmail_Click);
            // 
            // smiCall
            // 
            this.smiCall.Image = global::PresentationLayer.Properties.Resources.phone;
            this.smiCall.Name = "smiCall";
            this.smiCall.Size = new System.Drawing.Size(180, 22);
            this.smiCall.Text = "Phone Call";
            this.smiCall.Click += new System.EventHandler(this.smiCall_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "#Records :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.Location = new System.Drawing.Point(102, 328);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(63, 24);
            this.lblRecordCount.TabIndex = 1;
            this.lblRecordCount.Text = "[???]";
            this.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Filter By :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BackColor = System.Drawing.Color.White;
            this.txtFilterValue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValue.Location = new System.Drawing.Point(255, 13);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(117, 22);
            this.txtFilterValue.TabIndex = 3;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFilterValue_KeyUp);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-204, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "[???]";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::PresentationLayer.Properties.Resources.close1;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(511, 328);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 24);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.Image = global::PresentationLayer.Properties.Resources.user_add;
            this.btnAddNewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewUser.Location = new System.Drawing.Point(511, 13);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(73, 25);
            this.btnAddNewUser.TabIndex = 5;
            this.btnAddNewUser.Text = "New";
            this.btnAddNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // cbFilters
            // 
            this.cbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilters.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilters.Items.AddRange(new object[] {
            "None",
            "UserID",
            "PersonID",
            "FullName",
            "isActive"});
            this.cbFilters.Location = new System.Drawing.Point(105, 13);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(117, 23);
            this.cbFilters.TabIndex = 7;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // cbAccountStatus
            // 
            this.cbAccountStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccountStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAccountStatus.Items.AddRange(new object[] {
            "All",
            "Active",
            "Disactive"});
            this.cbAccountStatus.Location = new System.Drawing.Point(255, 12);
            this.cbAccountStatus.Name = "cbAccountStatus";
            this.cbAccountStatus.Size = new System.Drawing.Size(117, 23);
            this.cbAccountStatus.TabIndex = 8;
            this.cbAccountStatus.Visible = false;
            this.cbAccountStatus.SelectedIndexChanged += new System.EventHandler(this.cbAccountStatus_SelectedIndexChanged);
            // 
            // epEmptyOrNull
            // 
            this.epEmptyOrNull.ContainerControl = this;
            // 
            // ctrlUsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbAccountStatus);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUsers);
            this.Name = "ctrlUsersList";
            this.Size = new System.Drawing.Size(603, 367);
            this.Load += new System.EventHandler(this.ctrlUsersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.cmsListUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epEmptyOrNull)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ContextMenuStrip cmsListUsers;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.ComboBox cbAccountStatus;
        private System.Windows.Forms.ErrorProvider epEmptyOrNull;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smiAddNew;
        private System.Windows.Forms.ToolStripMenuItem smiEdit;
        private System.Windows.Forms.ToolStripMenuItem smiDelete;
        private System.Windows.Forms.ToolStripMenuItem smiChangePassword;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem smiSendEmail;
        private System.Windows.Forms.ToolStripMenuItem smiCall;
    }
}
