using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.ApplicationTypes
{
    public partial class frmUpdateApplicationType : Form
    {
        public delegate void SendBackData();

        public event SendBackData sendBackData;

        public frmUpdateApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();

            _ApplicationTypeID = ApplicationTypeID;

        }

        private int _ApplicationTypeID;

        private clsApplicationType _ApplicationType;
        
        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {
            _LoadApplicationType();
        }

        private void _LoadApplicationType()
        {
            if (-1 == _ApplicationTypeID)
            {
                MessageBox.Show("this Form will be closed because no Application Type with this ID = " + _ApplicationTypeID.ToString());
                return;
            }
            _ApplicationType = clsApplicationType.Find(_ApplicationTypeID);

            if( _ApplicationType != null )
            {
                lblApplicationID.Text = _ApplicationType.ApplicationTypeID.ToString();
                txtTitle.Text = _ApplicationType.ApplicationTypeTitle.ToString();
                txtFees.Text = _ApplicationType.ApplicationFees.ToString();

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        { 
            GetApplicationTypeInfoFromForm();

            if (_ApplicationType.Save())
            {
                MessageBox.Show("Application Type Updated Successfully");                
            }
            else
            {
                MessageBox.Show("Error : Data is not Saved Successfully.");
                return;
            }
        }

        private void GetApplicationTypeInfoFromForm()
        {
            _ApplicationType.ApplicationTypeTitle = txtTitle.Text;

            if (int.TryParse(txtFees.Text, out int Fees))

                _ApplicationType.ApplicationFees = Fees;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
