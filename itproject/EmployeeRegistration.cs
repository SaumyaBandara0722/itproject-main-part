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
    public partial class EmployeeRegistration : Form
    {
        public EmployeeRegistration()
        {
            InitializeComponent();
        }

        Employee c = new Employee();

        private void EmployeeRegistration_Load(object sender, EventArgs e)
        {
            //Display details of a paticular employee in the datagrid when the application is loaded
            DataTable dt = c.SelectView();
            dataGridViewDetails.DataSource = dt;

            //change datagridView header colour
            for (int i = 0; i < dataGridViewDetails.Columns.Count; i++)
            {
                dataGridViewDetails.Columns[i].HeaderCell.Style.Font = new Font("Sitka Text", 10, FontStyle.Bold);
                dataGridViewDetails.Columns[i].HeaderCell.Style.BackColor = Color.Plum;
                dataGridViewDetails.EnableHeadersVisualStyles = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //get the value from input field
            c.EmpName = txtempName.Text;
            c.Bdy = txtBdy.Text;
            c.Gender = comboBox1.Text;
            c.Address = txtAdd.Text;
            c.Phone = txtNum.Text;
            c.Email = txtEmail.Text;
            c.Dept = comboBox2.Text;
            c.Date = txtJoinedDate.Text;
            c.Salary = double.Parse(txtSal.Text);

            //insert data into database using the method created
            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("New Employee Successfully Inserted");

                //Display details of a paticular employee in the datagrid
                DataTable dt = c.SelectView();
                dataGridViewDetails.DataSource = dt;

                //call the clear method
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to add new employee.Try again");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //get data from textboxes
            c.EmpId = int.Parse(txtempId.Text);
            c.EmpName = txtempName.Text;
            c.Bdy = txtBdy.Text;
            c.Gender = comboBox1.Text;
            c.Address = txtAdd.Text;
            c.Phone = txtNum.Text;
            c.Email = txtEmail.Text;
            c.Dept = comboBox2.Text;
            c.Date = txtJoinedDate.Text;
            c.Salary = double.Parse(txtSal.Text);

            bool success = c.Update(c);
            if (success == true)
            {
                MessageBox.Show("Employee details are successfully updated");

                DataTable dt = c.SelectView();
                dataGridViewDetails.DataSource = dt;

                Clear();
            }
            else
            {
                MessageBox.Show("Failed to update details");
            }
        }

        //method to clear data in the fields
        public void Clear()
        {
            txtempId.Text = "";
            txtempName.Text = "";
            txtBdy.Text = "";
            comboBox1.Text = "";
            txtAdd.Text = "";
            txtNum.Text = "";
            txtEmail.Text = "";
            comboBox2.Text = "";
            txtJoinedDate.Text = "";
            txtSal.Text = "";
        }

        private void LblGender_Click(object sender, EventArgs e)
        {

        }

        private void DataGridViewDetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the data from data gridView and load them to the textboxes respectively

            //identify the row which is clicked by mouse
            int rowIndex = e.RowIndex;
            txtempId.Text = dataGridViewDetails.Rows[rowIndex].Cells[0].Value.ToString();
            txtempName.Text = dataGridViewDetails.Rows[rowIndex].Cells[1].Value.ToString();
            txtBdy.Text = dataGridViewDetails.Rows[rowIndex].Cells[2].Value.ToString();
            comboBox1.Text = dataGridViewDetails.Rows[rowIndex].Cells[3].Value.ToString();
            txtAdd.Text = dataGridViewDetails.Rows[rowIndex].Cells[4].Value.ToString();
            txtNum.Text = dataGridViewDetails.Rows[rowIndex].Cells[5].Value.ToString();
            txtEmail.Text = dataGridViewDetails.Rows[rowIndex].Cells[6].Value.ToString();
            comboBox2.Text = dataGridViewDetails.Rows[rowIndex].Cells[7].Value.ToString();
            txtJoinedDate.Text = dataGridViewDetails.Rows[rowIndex].Cells[8].Value.ToString();
            txtSal.Text = dataGridViewDetails.Rows[rowIndex].Cells[9].Value.ToString();
        }

        private void DataGridViewDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
