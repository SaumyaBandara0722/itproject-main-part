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


            //change datagridView header colour
            for(int i=0; i<dgvEmployeeList.Columns.Count; i++)
            {
                dgvEmployeeList.Columns[i].HeaderCell.Style.Font = new Font("Sitka Text", 10, FontStyle.Bold);
                dgvEmployeeList.Columns[i].HeaderCell.Style.BackColor = Color.Plum;
                dgvEmployeeList.EnableHeadersVisualStyles = false;
            }
            this.reportViewer1.RefreshReport();
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
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Employees WHERE EmpId LIKE '%" + keyword + "%' OR EmpName LIKE '%" + keyword + "%' OR Department LIKE '%" + keyword + "%' OR JoinedDate LIKE '%" + keyword + "%' OR BasicSal LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvEmployeeList.DataSource = dt;
        }

        //update details of a selected employee
        private void Button1_Click(object sender, EventArgs e)
        {
            //get the employee ID from application
            c.EmpId = Convert.ToInt32(txtId.Text);

            //navigate to employee registration form to update details
            EmployeeRegistration empReg = new EmployeeRegistration();

            empReg.txtempId.Text = dgvEmployeeList.CurrentRow.Cells[0].Value.ToString();
            empReg.txtempName.Text = dgvEmployeeList.CurrentRow.Cells[1].Value.ToString();
            empReg.txtBdy.Text = dgvEmployeeList.CurrentRow.Cells[2].Value.ToString();
            empReg.comboBox1.Text = dgvEmployeeList.CurrentRow.Cells[3].Value.ToString();
            empReg.txtAdd.Text = dgvEmployeeList.CurrentRow.Cells[4].Value.ToString();
            empReg.txtNum.Text = dgvEmployeeList.CurrentRow.Cells[5].Value.ToString();
            empReg.txtEmail.Text = dgvEmployeeList.CurrentRow.Cells[6].Value.ToString();
            empReg.comboBox2.Text = dgvEmployeeList.CurrentRow.Cells[7].Value.ToString();
            empReg.txtJoinedDate.Text = dgvEmployeeList.CurrentRow.Cells[8].Value.ToString();
            empReg.txtSal.Text = dgvEmployeeList.CurrentRow.Cells[9].Value.ToString();

            empReg.ShowDialog();

            DataTable dt = c.Select();
            dgvEmployeeList.DataSource = dt;
        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblSelectedEmp_Click(object sender, EventArgs e)
        {

        }
    }
}
