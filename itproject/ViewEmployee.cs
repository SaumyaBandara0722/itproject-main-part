using itproject.Classes;
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
    public partial class ViewEmployee : Form
    {
        public ViewEmployee()
        {
            InitializeComponent();
        }

        Employee c = new Employee();

        private void DgvEmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {
            //Load data into data GridView
            DataTable dt = c.Select();
            dgvEmployeeList.DataSource = dt;
        }
    }
}
