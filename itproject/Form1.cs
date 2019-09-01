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
            //  loanUserControl11.BringToFront();
            //loanUserControl1.BringToFront();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonStocks_Click(object sender, EventArgs e)
        {
            patternAndStockManagement1.BringToFront();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Pattern pattern = new Pattern();
            pattern.ShowDialog();
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
    }
}
