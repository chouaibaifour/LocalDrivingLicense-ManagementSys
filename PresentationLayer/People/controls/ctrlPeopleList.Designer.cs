using System.Windows.Forms;

namespace PresentationLayer
{
    partial class ctrlPeopleList
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
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.smiShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.smiAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.smiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.smiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.smiCall = new System.Windows.Forms.ToolStripMenuItem();
            this.smiSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.epEmptyOrNull = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epEmptyOrNull)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.AllowUserToResizeColumns = false;
            this.dgvPeople.AllowUserToResizeRows = false;
            this.dgvPeople.BackgroundColor = System.Drawing.Color.White;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPeople.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPeople.Location = new System.Drawing.Point(0, 60);
            this.dgvPeople.MultiSelect = false;
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.ReadOnly = true;
            this.dgvPeople.Size = new System.Drawing.Size(1148, 376);
            this.dgvPeople.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiShowDetails,
            this.smiAddNew,
            this.smiEdit,
            this.smiDelete,
            this.toolStripMenuItem1,
            this.smiCall,
            this.smiSendEmail});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 142);
            // 
            // smiShowDetails
            // 
            this.smiShowDetails.Image = global::PresentationLayer.Properties.Resources.Details;
            this.smiShowDetails.Name = "smiShowDetails";
            this.smiShowDetails.Size = new System.Drawing.Size(150, 22);
            this.smiShowDetails.Text = "Show Details";
            this.smiShowDetails.Click += new System.EventHandler(this.smiShowDetails_Click);
            // 
            // smiAddNew
            // 
            this.smiAddNew.Image = global::PresentationLayer.Properties.Resources.AddPerson;
            this.smiAddNew.Name = "smiAddNew";
            this.smiAddNew.Size = new System.Drawing.Size(150, 22);
            this.smiAddNew.Text = "Add New";
            this.smiAddNew.Click += new System.EventHandler(this.smiAddNew_Click);
            // 
            // smiEdit
            // 
            this.smiEdit.Image = global::PresentationLayer.Properties.Resources.Edit;
            this.smiEdit.Name = "smiEdit";
            this.smiEdit.Size = new System.Drawing.Size(150, 22);
            this.smiEdit.Text = "Edit";
            this.smiEdit.Click += new System.EventHandler(this.smiEdit_Click);
            // 
            // smiDelete
            // 
            this.smiDelete.Image = global::PresentationLayer.Properties.Resources.delete;
            this.smiDelete.Name = "smiDelete";
            this.smiDelete.Size = new System.Drawing.Size(150, 22);
            this.smiDelete.Text = "Delete";
            this.smiDelete.Click += new System.EventHandler(this.smiDelete_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 6);
            // 
            // smiCall
            // 
            this.smiCall.Image = global::PresentationLayer.Properties.Resources.phone;
            this.smiCall.Name = "smiCall";
            this.smiCall.Size = new System.Drawing.Size(150, 22);
            this.smiCall.Text = "Call";
            this.smiCall.Click += new System.EventHandler(this.smiCall_Click);
            // 
            // smiSendEmail
            // 
            this.smiSendEmail.Image = global::PresentationLayer.Properties.Resources.mail;
            this.smiSendEmail.Name = "smiSendEmail";
            this.smiSendEmail.Size = new System.Drawing.Size(150, 22);
            this.smiSendEmail.Text = "Send Mail";
            this.smiSendEmail.Click += new System.EventHandler(this.smiSendEmail_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter By :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "# Records :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.Location = new System.Drawing.Point(152, 450);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(65, 23);
            this.lblRecordCount.TabIndex = 2;
            this.lblRecordCount.Text = "[???]";
            this.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbFilters
            // 
            this.cbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilters.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No",
            "First Name",
            "Second Name",
            "Third Name",
            "LastName",
            "Gender",
            "Nationality",
            "Phone",
            "Email"});
            this.cbFilters.Location = new System.Drawing.Point(152, 24);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(121, 25);
            this.cbFilters.TabIndex = 3;
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValue.Location = new System.Drawing.Point(303, 24);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(144, 25);
            this.txtFilterValue.TabIndex = 5;
            this.txtFilterValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFilterValue_KeyUp);
            this.txtFilterValue.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingEmptyOrNulltxt);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::PresentationLayer.Properties.Resources.close1;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1049, 447);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 29);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddNewPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewPerson.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewPerson.Image = global::PresentationLayer.Properties.Resources.AddPerson;
            this.btnAddNewPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewPerson.Location = new System.Drawing.Point(1021, 19);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(75, 29);
            this.btnAddNewPerson.TabIndex = 4;
            this.btnAddNewPerson.Text = "New";
            this.btnAddNewPerson.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // epEmptyOrNull
            // 
            this.epEmptyOrNull.ContainerControl = this;
            // 
            // ctrlPeopleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddNewPerson);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPeople);
            this.Name = "ctrlPeopleList";
            this.Size = new System.Drawing.Size(1148, 490);
            this.Load += new System.EventHandler(this.ctrlPeopleList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epEmptyOrNull)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem smiShowDetails;
        private ToolStripMenuItem smiDelete;
        private ToolStripMenuItem smiEdit;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem smiCall;
        private ToolStripMenuItem smiSendEmail;
        private ToolStripMenuItem smiAddNew;
        private ErrorProvider epEmptyOrNull;
    }
}
