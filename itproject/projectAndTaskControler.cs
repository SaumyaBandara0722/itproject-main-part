using itproject.ProjectAndTaskClasses;
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
    public partial class projectAndTaskControler : Form
    {
        public projectAndTaskControler()
        {
            InitializeComponent();
        }
        ProjectAndTaskClass ptc = new ProjectAndTaskClass();
        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        { 
        }
        
        private void CmbBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void LblStatus_Click(object sender, EventArgs e)
        {

        }

        static string myConnString = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        int id;
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(myConnString);
            sqlConnection.Open();
            string sql = "SELECT PatternID, NeededQty FROM Orders WHERE OrderID=@OrderID";
            if (!int.TryParse(txtBoxOrderID.Text, out id))
            {
                MessageBox.Show("Invalid order id");
            }
            else
            {


                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@OrderID", Int32.Parse(txtBoxOrderID.Text));
                SqlDataReader dataReader = null;
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    ptc.PatternID = (dataReader["PatternID"].ToString());
                    ptc.NeededQty = Int32.Parse(dataReader["NeededQty"].ToString());

                }
                ptc.OrderID = int.Parse(txtBoxOrderID.Text);
                ptc.AddedDate = DateTime.Parse(datePickerAddedDate.Text);
                ptc.DeadlineDate = DateTime.Parse(datePickerDeadlineDate.Text);
                ptc.Description = txtBoxDescription.Text;
                ptc.Status = cmbBoxStatus.Text;
            }
            //validations
            if (txtBoxDescription.Text == "" || cmbBoxStatus.Text == "")
            {
                MessageBox.Show("Please Fullfill the required details correctly.");
            }
            /*else if (cmbBoxStatus.Text != "Pending" || cmbBoxStatus.Text != "Completed")
            {
                MessageBox.Show("The status should be Pending Or Completed.");
            }*/
            else 
            {
                //Inserting data into database using the Inserted method we created 
                bool success = ptc.Insert(ptc);
                if (success == true)
                {
                    //Successfully Inserted
                    MessageBox.Show("Successfully Created new Project");
                    //calling clear method
                    clear();
                }
                else
                {
                    //Failed to add project
                    MessageBox.Show("Failed to add a new project. Try agin.");
                }
                //load data on datagridview which is inside of the form
                DataTable dt = ptc.Select();
                dataGridViewInForm.DataSource = dt;
            }
        }

         private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //get data from textboxes
           //ptc.OrderID = int.Parse(txtBoxOrderID.Text);
            ptc.ProjectID = int.Parse(txtBoxProjectID.Text);
            ptc.AddedDate = DateTime.Parse(datePickerAddedDate.Text);
            ptc.DeadlineDate = DateTime.Parse(datePickerDeadlineDate.Text);
            ptc.Description = txtBoxDescription.Text;
            ptc.Status = cmbBoxStatus.Text;


            //Validations
            if (txtBoxDescription.Text == "" || cmbBoxStatus.Text == "")
            {
                MessageBox.Show("Please Fullfill the required details.");
            }
            /*else if (cmbBoxStatus.Text != "Pending" || cmbBoxStatus.Text != "Completed")
            {
                MessageBox.Show("The status should be Pending Or Completed.");
            }*/
            else
            {
                bool success = ptc.Update(ptc);
                if (success == true)
                {
                    MessageBox.Show("Successfully Updated");

                    //load data on datagridview which is inside of the form
                    DataTable dt = ptc.Select();
                    dataGridViewInForm.DataSource = dt;

                    clear();
                }
                else
                {
                    MessageBox.Show("Failed to Update.Try again");
                }
            }
        }

        private void TxtBoxProjectID_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            //call clear method
            clear();
        }

        private void ProjectAndTaskControler_Load(object sender, EventArgs e)
        {
            DataTable dt = ptc.Select();
            dataGridViewInForm.DataSource = dt;
        }
        public void clear()
        {
            txtBoxOrderID.Text = "";
            txtBoxProjectID.Text = "";
            datePickerAddedDate.Text = "";
            datePickerDeadlineDate.Text = "";
            txtBoxDescription.Text = "";
            cmbBoxStatus.Text = "";
        }

        private void DataGridViewInForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridViewInForm_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get data from dataGridView and load it to the textboxes respectively
            int rowIndex = e.RowIndex;

            txtBoxProjectID.Text = dataGridViewInForm.Rows[rowIndex].Cells[0].Value.ToString();
            txtBoxOrderID.Text = dataGridViewInForm.Rows[rowIndex].Cells[1].Value.ToString();
            txtBoxDescription.Text = dataGridViewInForm.Rows[rowIndex].Cells[2].Value.ToString();
            datePickerAddedDate.Text = dataGridViewInForm.Rows[rowIndex].Cells[5].Value.ToString();
            datePickerDeadlineDate.Text = dataGridViewInForm.Rows[rowIndex].Cells[6].Value.ToString();
            
            cmbBoxStatus.Text = dataGridViewInForm.Rows[rowIndex].Cells[7].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //Get data from textboxes
            ptc.ProjectID = Convert.ToInt32(txtBoxProjectID.Text);
            bool success = ptc.Delete(ptc);

            if(success == true)
            {
                MessageBox.Show("Project was Successfully Deleted.");
                //Refresh data in DataGrideview
                //load data on datagridview which is inside of the form
                DataTable dt = ptc.Select();
                dataGridViewInForm.DataSource = dt;

                //call clear method
                clear();
            }
            else
            {
                MessageBox.Show("Failed to Delete.Try Again.");
            }
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LblProjectID_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}