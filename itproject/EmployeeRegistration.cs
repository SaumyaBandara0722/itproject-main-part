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

            //Display departments in combobox2
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable d = new DataTable();
            string sql = "SELECT * from Department";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            adapter.Fill(d);
            comboBox2.ValueMember = "depName";
            comboBox2.DataSource = d;
            conn.Close();

            txtEnterDep.Text = "";
        }
        int num = 0;
        double sal = 0.0;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtempName.Text == "" || txtBdy.Text == "" || comboBox1.Text == "" || txtAdd.Text == "" || txtNum.Text == "" || txtEmail.Text == "" || comboBox2.Text == "" || txtJoinedDate.Text == "" || txtSal.Text == "")
            {
                MessageBox.Show("Cannot keep empty fields");
            }
            else if (txtNum.TextLength != 10)
            {
                MessageBox.Show("Invalid phone number");
            }
            else if (!int.TryParse(txtNum.Text, out num))
            {
                MessageBox.Show("Phone number requires integers only");
            }
            else if (!double.TryParse(txtSal.Text, out sal))
            {
                MessageBox.Show("Invalid Salary Type");
            }
            else
            {
                //get the value from input field
                c.EmpName = txtempName.Text;
                c.Bdy = txtBdy.Value.ToString();
                c.Gender = comboBox1.Text;
                c.Address = txtAdd.Text;
                c.Phone = txtNum.Text;
                c.Email = txtEmail.Text;
                c.Dept = comboBox2.Text;
                c.Date = txtJoinedDate.Value.ToString();
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
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (txtempName.Text == "" || txtBdy.Text == "" || comboBox1.Text == "" || txtAdd.Text == "" || txtNum.Text == "" || txtEmail.Text == "" || comboBox2.Text == "" || txtJoinedDate.Text == "" || txtSal.Text == "")
            {
                MessageBox.Show("Cannot keep empty fields");
            }
            else if (txtNum.TextLength != 10)
            {
                MessageBox.Show("Invalid phone number");
            }
            else if (!int.TryParse(txtNum.Text, out num))
            {
                MessageBox.Show("Phone number requires integers only");
            }
            else if (!double.TryParse(txtSal.Text, out sal))
            {
                MessageBox.Show("Invalid Salary Type");
            }
            else
            {
                //get data from textboxes
                c.EmpId = int.Parse(txtempId.Text);
                c.EmpName = txtempName.Text;
                c.Bdy = txtBdy.Value.ToString();
                c.Gender = comboBox1.Text;
                c.Address = txtAdd.Text;
                c.Phone = txtNum.Text;
                c.Email = txtEmail.Text;
                c.Dept = comboBox2.Text;
                c.Date = txtJoinedDate.Value.ToString();
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

        private void TxtNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void b(object sender, EventArgs e)
        {

        }

        private void TxtAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (!rEmail.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Invalid Email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.SelectAll();
                e.Cancel = true;
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblSal_Click(object sender, EventArgs e)
        {

        }

        private void TxtEnterDep_TextChanged(object sender, EventArgs e)
        {

        }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void BtnAddNewDep_Click(object sender, EventArgs e)
        {
            //get the value from input field
            c.Dept = txtEnterDep.Text;

            //insert data into database using the method created
            bool success = c.InsertDepartment(c);
            if (success == true)
            {
                MessageBox.Show("New Department Successfully Inserted");
            }
            else
            {
                MessageBox.Show("Failed to add new department.Try again");
            }

            //Display departments in combobox2
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable d = new DataTable();
            string sql = "SELECT * from Department";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            adapter.Fill(d);
            comboBox2.ValueMember = "depName";
            comboBox2.DataSource = d;
            conn.Close();

            txtEnterDep.Text = "";
        }

        //Display the combobox selected department in textbox  
        private void ComboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            txtEnterDep.Text = comboBox2.Text;
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            //get the value from input field
            c.Dept = txtEnterDep.Text;

            //insert data into database using the method created
            bool success = c.DeleteDepartment(c);
            if (success == true)
            {
                MessageBox.Show("Department Successfully Deleted");
                txtEnterDep.Text = "";
            }
            else
            {
                MessageBox.Show("Failed to delete department.Try again");
            }

            //Display departments in combobox2
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable d = new DataTable();
            string sql = "SELECT * from Department";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            adapter.Fill(d);
            comboBox2.ValueMember = "depName";
            comboBox2.DataSource = d;
            conn.Close();

            txtEnterDep.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }     
}
