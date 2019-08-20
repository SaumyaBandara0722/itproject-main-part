using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itproject
{
    public partial class EmployeeDetailsUserControl: UserControl
    {
        public EmployeeDetailsUserControl()
        {
            InitializeComponent();
        }

        private void BtnRgister_Click(object sender, EventArgs e)
        {
            //Hide the user control
            //this.Hide();
            EmployeeRegistration empRtr = new EmployeeRegistration();
            empRtr.ShowDialog();
        }

        private void BtnViewEmp_Click(object sender, EventArgs e)
        {
            ViewEmployee viewEmp = new ViewEmployee();
            viewEmp.ShowDialog();
        }

        private void EmployeeDetailsUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
