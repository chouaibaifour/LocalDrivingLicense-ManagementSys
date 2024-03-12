using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmAddNewUpdatePerson : Form
    {
        public delegate void DataBackEventHandler();
        public event DataBackEventHandler SendDataBack;

        private int _PersonID;
        public frmAddNewUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _PersonID=PersonID;
           
        }

        private void frmAddNewUpdatePerson_Load(object sender, EventArgs e)
        {
            ctrlAddNewUpdatePerson1.Load_PersonInfo(_PersonID);

        }

        private void frmAddNewUpdatePerson_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Invoke(SendDataBack);
        }
    }
}
