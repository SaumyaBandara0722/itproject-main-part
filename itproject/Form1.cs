using mainAdminAttendance;
using System;
using System.Windows.Forms;

namespace itproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            employeeDetailsUserControl1.BringToFront();
        }

        private void AddEmployeeUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void ButtonEmployees_Click(object sender, EventArgs e)
        {
            employeeDetailsUserControl1.BringToFront();
        }

        private void ButtonLoan_Click(object sender, EventArgs e)
        {
            ProcessLoan processLoan = new ProcessLoan();
            processLoan.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonStocks_Click(object sender, EventArgs e)
        {
            PatternAndStockMangementSystem pass = new PatternAndStockMangementSystem();
            pass.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void PatternAndStockManagement1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonPayroll_Click(object sender, EventArgs e)
        {
            new View().Show();
        }

        private void ButtonProjectsAndTasks_Click(object sender, EventArgs e)
        {
            MainProjectTask mainPro = new MainProjectTask();
            mainPro.ShowDialog();
        }

        private void ButtonCustomers_Click(object sender, EventArgs e)
        {
            customers1.BringToFront();
        }

        private void LoanUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void ProcessLoanUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonViewAttendance_Click(object sender, EventArgs e)
        {
            //   Attendance attendance = new Attendance();
            //  attendance.Show();

            ShowAttendance showAttendance = new ShowAttendance();
            showAttendance.Show();
        }

        private void ButtonLeaveManagement_Click(object sender, EventArgs e)
        {
            LeaveManagementForm leaveManagementForm = new LeaveManagementForm();
            leaveManagementForm.Show();
        }
    }
}
