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
    public partial class PayRollReportForm : Form
    {
        public PayRollReportForm()
        {
            InitializeComponent();
        }

        private void PayRollReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itproject_newDataSetPayRoll.Payroll' table. You can move, or remove it, as needed.

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            this.PayrollTableAdapter.Fill(this.itproject_newDataSetPayRoll.Payroll, textBox1.Text.ToString());

            this.reportViewer1.RefreshReport();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
