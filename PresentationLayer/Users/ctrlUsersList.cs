﻿using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Users
{
    public partial class ctrlUsersList : UserControl
    {
        public ctrlUsersList()
        {
            InitializeComponent();
        }

        string Filter;

        DataView dataView = clsUser.GetAllUsers().DefaultView;

        private void ctrlUsersList_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            cbAccountStatus.SelectedIndex = 0;
            _FillAllUsersTo_dgv();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();    
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddNewUpdateUser addNewUpdateUser = new frmAddNewUpdateUser(-1);

            addNewUpdateUser.SendDataBack += _FillAllUsersTo_dgv;

            addNewUpdateUser.ShowDialog();

        }

        private void _FillAllUsersTo_dgv()
        {
            DataTable dt = clsUser.GetAllUsers();
           
            dgvUsers.DataSource = dt;

            lblRecordCount.Text = dgvUsers.RowCount.ToString();

        }

        private void _getClomnName(int index)
        {
            Filter = "";

            string[] Filters = {
            "UserID",
            "PersonID",
            "FullName"};

            if (Filters.Length <= index && 0 > index)
                return;

            Filter = @Filters[index - 1];
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (0 != cbFilters.SelectedIndex)
            {
                if (cbFilters.SelectedItem.ToString().Equals("isActive"))
                {
                    txtFilterValue.Visible = false;

                    btnFindRow.Visible = false;

                    cbAccountStatus.Visible = true;
                    return;
                }
                txtFilterValue.Visible = true;

                btnFindRow.Visible = true;


                return;
            }

            txtFilterValue.Visible = false;

            btnFindRow.Visible = false;

            dgvUsers.DataSource = dataView;

        }

        private void txtFilterValue_KeyUp(object sender, KeyEventArgs e)
        {

            _getClomnName(cbFilters.SelectedIndex);
            Filter=Filter.Replace(" ", "");

            if (!"UserID".Equals(Filter))
            {
                Filter += @" LIKE '%" + txtFilterValue.Text + "%'";
            }
            else
            {
                if (!int.TryParse(txtFilterValue.Text, out int UserID))
                {

                    txtFilterValue.Text = string.Empty;
                    Filter += @"=0";

                }
                else
                {

                    Filter += @"=" + UserID.ToString();
                }

            }

            try
            {
                dataView.RowFilter = Filter;

            }
            catch (Exception)
            {

            }

            dgvUsers.DataSource = dataView.ToTable();

            lblRecordCount.Text = dgvUsers.RowCount.ToString();
        }

        private void ValidatingEmptyOrNulltxt(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                    e.Cancel = true;

                epEmptyOrNull.SetError(textBox, "Invalid input try again !");
            }
            else
            {
                e.Cancel = false;
                epEmptyOrNull.SetError(textBox, "");
            }
        }

        private void smiShowDetails_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dgvUsers.CurrentRow.Cells[0].Value.ToString(), out int UserID))
            {
                //frmUserInfo frmUserInfo = new frmUserInfo(UserID);
                //frmUserInfo.ShowDialog();
            }

        }

        private void smiEdit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dgvUsers.CurrentRow.Cells[0].Value.ToString(), out int UserID))
            {
                //frmAddNewUpdateUser frmUpdateUser = new frmAddNewUpdateUser(UserID);
                //frmUpdateUser.SendDataBack += _FillAllUsersTo_dgv;
                //frmUpdateUser.ShowDialog();
            }

        }

        private void smiDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dgvUsers.CurrentRow.Cells[0].Value.ToString(), out int UserID))
            {
                if (clsUser.IsUserExists(UserID))
                {
                    if (clsUser.DeleteUser(UserID))
                    {
                        MessageBox.Show("User Deleted Successfully.");
                    }
                    else
                    {
                        MessageBox.Show("User is Not Deleted.");
                    }
                }
                else
                {
                    MessageBox.Show("User is Not Deleted.");
                }
                _FillAllUsersTo_dgv();
            }
        }

        private void smiAddNew_Click(object sender, EventArgs e)
        {

            //frmAddNewUpdateUser frmUpdateUser = new frmAddNewUpdateUser(-1);
            //frmUpdateUser.SendDataBack += _FillAllUsersTo_dgv;
            //frmUpdateUser.ShowDialog();

        }

        private void smiCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this Feature is not implemented Yet !");
        }

        private void smiSendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this Feature is not implemented Yet !");
        }

        private void cbAccountStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if(cbAccountStatus.SelectedIndex==1)
                    dataView.RowFilter = "IsActive = 1";
                else if(cbAccountStatus.SelectedIndex==2)
                    dataView.RowFilter = "IsActive = 0";
                else
                    dataView.RowFilter = "IsActive = 0 or IsActive = 1";

            }
            catch (Exception)
            {
                
            }

            dgvUsers.DataSource = dataView.ToTable();

            lblRecordCount.Text = dgvUsers.RowCount.ToString();
        }


    }
}
