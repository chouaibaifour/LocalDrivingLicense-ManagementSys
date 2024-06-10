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

namespace PresentationLayer.TestTypes
{
    public partial class frmUpdateTestType : Form
    {
        public delegate void SendBackData();

        public event SendBackData sendBackData;

        public frmUpdateTestType(int TestTypeID)
        {
            InitializeComponent();

            _TestTypeID = TestTypeID;

        }

        private int _TestTypeID;

        private clsTestType _TestType;
        
        private void frmUpdateTestType_Load(object sender, EventArgs e)
        {
            _LoadTestType();
        }

        private void _LoadTestType()
        {
            if (-1 == _TestTypeID)
            {
                MessageBox.Show("this Form will be closed because no Test Type with this ID = " + _TestTypeID.ToString());
                return;
            }
            _TestType = clsTestType.Find(_TestTypeID);

            if( _TestType != null )
            {
                lblTestID.Text = _TestType.TestTypeID.ToString();
                txtTitle.Text = _TestType.TestTypeTitle.ToString();
                rtbDescription.Text = _TestType.TestTypeDescription.ToString();
                txtFees.Text = _TestType.TestFees.ToString();

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        { 
            GetTestTypeInfoFromForm();

            if (_TestType.Save())
            {
                MessageBox.Show("Test Type Updated Successfully");                
            }
            else
            {
                MessageBox.Show("Error : Data is not Saved Successfully.");
                return;
            }
        }

        private void GetTestTypeInfoFromForm()
        {
            _TestType.TestTypeTitle = txtTitle.Text;
            _TestType.TestTypeDescription = rtbDescription.Text;

            if (int.TryParse(txtFees.Text, out int Fees))

                _TestType.TestFees = Fees;

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
