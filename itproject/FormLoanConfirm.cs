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
            string sql = "SELECT EmpName, EmpDepartment, BasicSalary FROM Employees WHERE EmpID=@EmpID";

            SqlCommand sqlCommand = new SqlCommand(sql, conn);

            sqlCommand.Parameters.AddWithValue("@EmpID", Int32.Parse(LoanUserControl1.empID));
            SqlDataReader dataReader = null;

            dataReader = sqlCommand.ExecuteReader();

            textBox1.Text = LoanUserControl1.empID;

            while (dataReader.Read())
            {
                textBox3.Text = dataReader["EmpName"].ToString();
                textBox4.Text = dataReader["EmpDepartment"].ToString();
                textBox5.Text = dataReader["BasicSalary"].ToString();
            }

            textBox6.Text = LoanUserControl1.loanAmount;
            textBox7.Text = LoanUserControl1.installment;
            dateTimePicker1.Value = LoanUserControl1.startDate;
            dateTimePicker2.Value = LoanUserControl1.endDate;
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
