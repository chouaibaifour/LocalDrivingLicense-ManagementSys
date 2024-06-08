using BusinessLayer;
using PresentationLayer.ApplicationTypes;
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
    public partial class ctrlApplicationTypesList : UserControl
    {
        public ctrlApplicationTypesList()
        {
            InitializeComponent();
        }

       
        private void ctrlApplicationTypesList_Load(object sender, EventArgs e)
        {
            _FillAllApplicationTypesTo_dgv();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

       

        private void _FillAllApplicationTypesTo_dgv()
        {
            DataTable dt = clsApplicationType.GetAllApplicationTypes();

            dgvApplicationTypes.DataSource = dt;

            lblRecordCount.Text = dgvApplicationTypes.RowCount.ToString();

        }

        private void smiEditApplicationType_Click(object sender, EventArgs e)
        {

        }
    }
}
