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
    public partial class ProcessLoan : Form
    {
        public ProcessLoan()
        {
            InitializeComponent();
        }

        public static string empID = "";
        public static string loanAmount = "";
        public static string installment = "";
        public static DateTime startDate;
        public static DateTime endDate;

        LoanClass loan = new LoanClass();
        private void ProcessLoan_Load(object sender, EventArgs e)
        {

        }

        private void ButtonProcess_Click(object sender, EventArgs e)
        {
            if(textBoxEmpID.Text == "" || textBoxAmount.Text == "" || textBoxInstallment.Text == "")
            {
                MessageBox.Show("Fields cannot be empty");
                
            }
            else
            {
                loan.EmpID = Int32.Parse(textBoxEmpID.Text);

                empID = textBoxEmpID.Text;
                loanAmount = textBoxAmount.Text;
                installment = textBoxInstallment.Text;
                startDate = dateTimePicker1.Value;
                endDate = dateTimePicker2.Value;

                FormLoanConfirm formLoanConfirm = new FormLoanConfirm();
                formLoanConfirm.Show();
            }

        }

        private void ButtonView_Click(object sender, EventArgs e)
        {
            ViewLoans viewLoans = new ViewLoans();
            viewLoans.Show();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
