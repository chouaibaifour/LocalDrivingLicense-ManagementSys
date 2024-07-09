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

namespace PresentationLayer.Licenses.controls
{
    public partial class ctrlPersonLicenseHistory : UserControl
    {
        public ctrlPersonLicenseHistory()
        {
            InitializeComponent();
        }

        private int _PersonID;
        private DataSet dtInternationalLicense;
       

        

        public void LoadPersonLicenseHistory(string NationalNumber)
        {
            ctrlFindPerson1.LoadPersonInfo(NationalNumber,false);
            _Fill_dgvLocalLicenses();
            _Fill_dgvInternationalLicenses();
        }

        private void _Fill_dgvLocalLicenses()
        {
              DataTable dtLocalLicense= clsLicense.GetAllLicensesOfPerson(_PersonID);

            dgvLocalLicenses.DataSource = dtLocalLicense;
            lblLocalLicensesCount.Text = dgvLocalLicenses.RowCount.ToString();
            
        }

        private void _Fill_dgvInternationalLicenses()
        {
            throw new NotImplementedException();
        }

        private void ctrlFindPerson1_OnPersonSelected(int obj)
        {
            _PersonID = obj;
        }
    }
}
