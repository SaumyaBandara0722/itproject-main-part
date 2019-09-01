﻿using System;
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
    public partial class LoanUserControl : UserControl
    {
        public LoanUserControl()
        {
            InitializeComponent();
        }

        public static string empID = "";
        public static string loanAmount = "";
        public static string installment = "";
        public static DateTime startDate;
        public static DateTime endDate;

        LoanClass loan = new LoanClass();

        private void Button1_Click(object sender, EventArgs e)
        {
            loan.EmpID = Int32.Parse(textBoxEmployeeID.Text);

            empID = textBoxEmployeeID.Text;
            loanAmount = textBoxAmount.Text;
            installment = textBoxInstallment.Text;
            startDate = dateTimePicker1.Value;
            endDate = dateTimePicker2.Value;

            FormLoanConfirm formLoanConfirm = new FormLoanConfirm();
            formLoanConfirm.Show();
        }
    }
}
