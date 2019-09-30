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
    public partial class EmployeeReport : Form
    {
        public EmployeeReport()
        {
            InitializeComponent();
        }

        private void EmployeeReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itproject_newDataSet4.Employees' table. You can move, or remove it, as needed.
            
        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            this.EmployeesTableAdapter.Fill(this.itproject_newDataSet4.Employees, textBoxDepartment.Text.ToString());

            this.reportViewer1.RefreshReport();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
