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
            loanUserControl11.BringToFront();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
