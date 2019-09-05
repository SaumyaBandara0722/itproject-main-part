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
    public partial class FormLoanConfirm : Form
    {
        public FormLoanConfirm()
        {
            InitializeComponent();
        }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        Employee employee = new Employee();
        LoanClass loan = new LoanClass();

        private void Splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormLoanConfirm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            conn.Open();
            string sql = "SELECT EmpName, Department, BasicSal FROM Employees WHERE EmpID=@EmpID";

            SqlCommand sqlCommand = new SqlCommand(sql, conn);

            sqlCommand.Parameters.AddWithValue("@EmpID", Int32.Parse(ProcessLoan.empID));
            SqlDataReader dataReader = null;

            dataReader = sqlCommand.ExecuteReader();

            textBox1.Text = ProcessLoan.empID;

            while (dataReader.Read())
            {
                textBox3.Text = dataReader["EmpName"].ToString();
                textBox4.Text = dataReader["Department"].ToString();
                textBox5.Text = dataReader["BasicSal"].ToString();
            }



            textBox6.Text = ProcessLoan.loanAmount;
            textBox7.Text = ProcessLoan.installment;
            dateTimePicker1.Value = ProcessLoan.startDate;
            dateTimePicker2.Value = ProcessLoan.endDate;

            if (textBox3.Text == "")
            {
                MessageBox.Show("Invalid Employee");
                this.Close();
            }
            else if (Double.Parse(textBox5.Text) < Double.Parse(textBox7.Text))
            {
                MessageBox.Show("Installment should be less than Basic Salary");
                this.Close();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            loan.EmpID = Int32.Parse(textBox1.Text);
            loan.EmpName = textBox3.Text;
            loan.EmpDepartment = textBox4.Text;
            loan.BasicSalary = Double.Parse(textBox5.Text);
            loan.LoanAmount = Double.Parse(textBox6.Text);
            loan.Installment = Double.Parse(textBox7.Text);
            loan.StartDate = dateTimePicker1.Value;
            loan.EndDate = dateTimePicker2.Value;

            bool success = loan.Insert(loan);

            if(success == true)
            {
                MessageBox.Show("Loan details added successfully!");
                this.Close();
            } 
            else
            {
                MessageBox.Show("Failed to add loan details");
            }
        }
    }
}
