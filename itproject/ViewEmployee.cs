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

        private void Button4_Click(object sender, EventArgs e)
        {
            //get the employee ID from application
            c.EmpId = Convert.ToInt32(txtId.Text);

            bool success = c.Delete(c);
            if(success == true)
            {
                MessageBox.Show("Employee details deleted successfully");
                //refresh data gridView with updated details
                DataTable dt = c.Select();
                dgvEmployeeList.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to delete employee details.Try again");
            }
     
        }

        private void DgvEmployeeList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtId.Text = dgvEmployeeList.Rows[rowIndex].Cells[0].Value.ToString();
        }
    }
}
