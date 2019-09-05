using Employee_Management.Classes;
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
    public partial class LeaveManagementForm : Form
    {
        public LeaveManagementForm()
        {
            InitializeComponent();
        }

        DatabaseHelper db = new DatabaseHelper();
        static string myConnString = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void LeaveManagementForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = db.Select();
            dataGridView1.DataSource = dataTable;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxEmpID_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(myConnString);

                string sql = "UPDATE LeaveRequests SET Status=@Status WHERE ReqID=@RedID";

                SqlCommand sqlCommand = new SqlCommand(sql, conn);

                sqlCommand.Parameters.AddWithValue("@Status", "Confirm");
                sqlCommand.Parameters.AddWithValue("@RedID", Int32.Parse(textBoxLeaveID.Text));

                conn.Open();

                int rows = sqlCommand.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Leave accepted");

                    DataTable dataTable = db.Select();
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Error accepting request");
                }

                conn.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            textBoxEmpID.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxLeaveID.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
        }

        private void ButtonDecline_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(myConnString);

                string sql = "UPDATE LeaveRequests SET Status=@Status WHERE ReqID=@RedID";

                SqlCommand sqlCommand = new SqlCommand(sql, conn);

                sqlCommand.Parameters.AddWithValue("@Status", "Decline");
                sqlCommand.Parameters.AddWithValue("@RedID", Int32.Parse(textBoxLeaveID.Text));

                conn.Open();

                int rows = sqlCommand.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Leave declined");

                    DataTable dataTable = db.Select();
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Error declining request");
                }

                conn.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            String keyword = textBoxSearch.Text;

            SqlConnection sqlConnection = new SqlConnection(myConnString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM LeaveRequests WHERE EmpID LIKE '%" + keyword + "%'", sqlConnection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}
