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
    public partial class ViewLoans : Form
    {
        public ViewLoans()
        {
            InitializeComponent();
        }
        LoanClass loan = new LoanClass();

        static string myConnString = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LabelEndDate_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ViewLoans_Load(object sender, EventArgs e)
        {
            DataTable dataTable = loan.Select();
            dataGridView1.DataSource = dataTable;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            textBoxEmpID.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxLoanID.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxAmount.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            textBoxInstallment.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
            dateTimePicker1.Value =  DateTime.Parse(dataGridView1.Rows[rowIndex].Cells[8].Value.ToString());
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            loan.LoanID = Int32.Parse(textBoxLoanID.Text);
            loan.LoanAmount = Int32.Parse(textBoxAmount.Text);
            loan.Installment = Int32.Parse(textBoxInstallment.Text);
            loan.EndDate = dateTimePicker1.Value;

            bool success = loan.Update(loan);

            if(success)
            {
                MessageBox.Show("Loan details successfully updated!");

                DataTable dataTable = loan.Select();
                dataGridView1.DataSource = dataTable;
            } 
            else
            {
                MessageBox.Show("Unable to update loan details");
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            loan.LoanID = Int32.Parse(textBoxLoanID.Text);

            bool success = loan.Delete(loan);

            if(success)
            {
                MessageBox.Show("Loan details successfully deleted!");

                DataTable dataTable = loan.Select();
                dataGridView1.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Unable to delete loan details");
            }
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxSearch.Text;

            SqlConnection conn = new SqlConnection(myConnString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Loans WHERE EmpID LIKE '%" + keyword + "%' OR EmpName LIKE '%" + keyword +"%'", conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}
