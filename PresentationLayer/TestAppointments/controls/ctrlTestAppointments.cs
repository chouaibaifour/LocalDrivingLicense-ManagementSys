using BusinessLayer;
using PresentationLayer.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.TestAppointments.controls
{
    public partial class ctrlTestAppointments : UserControl
    {
        public ctrlTestAppointments()
        {
            InitializeComponent();

        }
        private int _LDL_ApplicationID = -1;

        private int _TestTypeID = -1;

        private void _FillAppointmentTo_dgv()
        {
            DataTable dt = clsTestAppointment.GetAllTestAppointments(_LDL_ApplicationID, _TestTypeID);

            dgvAppointments.DataSource = dt;
            
            lblRecordCount.Text = dgvAppointments.RowCount.ToString();

        }
    
        public void LoadTestAppointmentInof(int _LDL_ApplicationID, int _TestTypeID)
        {
            this._TestTypeID = _TestTypeID;

            ctrlLDL_ApplicationInfo1.LoadLDLApplicationInfo(_LDL_ApplicationID);

            _FillAppointmentTo_dgv();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FindForm().Close();
        }


        private void btnAddTestAppointment_Click(object sender, EventArgs e)
        {
            if (clsTestAppointment.IsTestAppointmentExists(_LDL_ApplicationID, _TestTypeID))
            {
                if (clsTestAppointment.IsTestAppointmentUnLockedByLDL_App(_LDL_ApplicationID, _TestTypeID))
                {
                    MessageBox.Show("Person already has an active Appointment for this Test,\n You cannot add new Appointment");
                    return;
                }
                else
                {
                    if (clsTest.IsTestPassed(_LDL_ApplicationID, _TestTypeID))
                    {
                        MessageBox.Show("this Person is already pass this exam before,\n you can only retake Faild tests.");
                    }
                    else
                    {
                        // New Retake TestAppointment
                        frmAddUpdateTestAppointment frmAddUpdateTestAppointment = new frmAddUpdateTestAppointment(
                            -1,_LDL_ApplicationID,
                            _TestTypeID,
                            3);
                        frmAddUpdateTestAppointment.sendBackData += _FillAppointmentTo_dgv;
                        frmAddUpdateTestAppointment.ShowDialog();
                    }
                }
            }
            else
            {

                // New TestAppointment
                frmAddUpdateTestAppointment frmAddUpdateTestAppointment = new frmAddUpdateTestAppointment(
                    -1,
                    _LDL_ApplicationID,
                    _TestTypeID,
                    0);
                frmAddUpdateTestAppointment.sendBackData += _FillAppointmentTo_dgv;
                frmAddUpdateTestAppointment.ShowDialog();
            }

        }

        private void ctrlLDL_ApplicationInfo1_OnLDLD_ApplicationSelected(int obj)
        {
            this._LDL_ApplicationID = obj;
        }

        private void smiEditAppointment_Click(object sender, EventArgs e)
        {
            if (
                bool.TryParse(dgvAppointments.CurrentRow.Cells[3].Value.ToString(), out bool isLocked)
                &&
                int.TryParse(dgvAppointments.CurrentRow.Cells[0].Value.ToString(), out int AppointmentID)
                ) 
            {
                if (isLocked)
                {
                    frmAddUpdateTestAppointment frmAddUpdateTestAppointment = new frmAddUpdateTestAppointment(
                        AppointmentID,
                        _LDL_ApplicationID,
                        _TestTypeID,
                        2);
                    frmAddUpdateTestAppointment.sendBackData += _FillAppointmentTo_dgv;
                    frmAddUpdateTestAppointment.ShowDialog();
                    return;
                }
                else
                {

                    frmAddUpdateTestAppointment frmAddUpdateTestAppointment = new frmAddUpdateTestAppointment(
                        AppointmentID,
                        _LDL_ApplicationID,
                        _TestTypeID,
                        1);
                    frmAddUpdateTestAppointment.sendBackData += _FillAppointmentTo_dgv;
                    frmAddUpdateTestAppointment.ShowDialog();

                }

            }
            else
                MessageBox.Show("Ooops! something went Wrong.");
        }

        private void smiTakeTest_Click(object sender, EventArgs e)
        {
            if (
                bool.TryParse(dgvAppointments.CurrentRow.Cells[3].Value.ToString(), out bool isLocked)
                &&
                int.TryParse(dgvAppointments.CurrentRow.Cells[0].Value.ToString(), out int AppointmentID)
                )
            {
                if (isLocked)
                {

                    MessageBox.Show("this Person is already pass this exam before,\n you can only retake Faild tests.");
                    return;
                   
                }
                else
                {

                    frmAddUpdateTest frmAddUpdateTest = new frmAddUpdateTest(-1, AppointmentID);
                    frmAddUpdateTest.SendDataBack += _FillAppointmentTo_dgv;
                    frmAddUpdateTest.ShowDialog();

                }

            }
            else
                MessageBox.Show("Ooops! something went Wrong.");
        }
    }
}
