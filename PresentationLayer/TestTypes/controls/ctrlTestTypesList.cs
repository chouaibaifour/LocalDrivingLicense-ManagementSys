using BusinessLayer;
using PresentationLayer.TestTypes;
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
    public partial class ctrlTestTypesList : UserControl
    {
        public ctrlTestTypesList()
        {
            InitializeComponent();
        }

       
        private void ctrlTestTypesList_Load(object sender, EventArgs e)
        {
            _FillAllTestTypesTo_dgv();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

       

        private void _FillAllTestTypesTo_dgv()
        {
            DataTable dt = clsTestType.GetAllTestTypes();

            dgvTestTypes.DataSource = dt;

            lblRecordCount.Text = dgvTestTypes.RowCount.ToString();

        }

        private void smiEditTestType_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dgvTestTypes.CurrentRow.Cells[0].Value.ToString(), out int TestTypeID)) {

                frmUpdateTestType frmUpdateTestType = new frmUpdateTestType(TestTypeID);

                frmUpdateTestType.sendBackData += _FillAllTestTypesTo_dgv;
                frmUpdateTestType.ShowDialog();

            }
        }
    }
}
