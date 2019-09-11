using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itproject
{
    public partial class EmployeeDetailsMenu : Form
    {
        public EmployeeDetailsMenu()
        {
            InitializeComponent();
        }

        private void BtnRgister_Click(object sender, EventArgs e)
        {
            EmployeeRegistration empRtr = new EmployeeRegistration();
            empRtr.ShowDialog();
        }

        private void BtnViewEmp_Click(object sender, EventArgs e)
        {
            ViewEmployee viewEmp = new ViewEmployee();
            viewEmp.ShowDialog();
        }
    }
}
