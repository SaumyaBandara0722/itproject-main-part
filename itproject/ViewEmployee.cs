using itproject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            //get the value from textbox
            string keyword = textBox1.Text;

            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Employees WHERE EmpName LIKE '%" + keyword + "%' OR Department LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvEmployeeList.DataSource = dt;
        }
    }
}
