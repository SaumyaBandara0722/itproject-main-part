using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using itproject.Classes;

namespace itproject
{
    public partial class LoanUserControl1 : UserControl
    {
        public LoanUserControl1()
        {
            InitializeComponent();
        }

        public static string empID = "";
        public static string loanAmount = "";
        public static string installment = "";
        public static DateTime startDate;
        public static DateTime endDate;

        LoanClass loan = new LoanClass();

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LabelStartDate_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
//            loan.EmpID = Int32.Parse(textBoxEmployeeID.Text);

  //          empID = textBoxEmployeeID.Text;
    //        loanAmount = textBoxAmount.Text;
      //      installment = textBoxInstallment.Text;
        //    startDate = dateTimePicker1.Value;
          //  endDate = dateTimePicker2.Value;

         //   FormLoanConfirm formLoanConfirm = new FormLoanConfirm();
           // formLoanConfirm.Show();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void LoanUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
