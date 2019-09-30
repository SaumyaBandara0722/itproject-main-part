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
    public partial class LoanReportForm : Form
    {
        public LoanReportForm()
        {
            InitializeComponent();
        }

        private void LoanReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itproject_newDataSet.Loans' table. You can move, or remove it, as needed.
            // this.LoansTableAdapter.Fill(this.itproject_newDataSet.Loans);

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itproject_newDataSet.Loans' table. You can move, or remove it, as needed.
            this.LoansTableAdapter.Fill(this.itproject_newDataSet.Loans, dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());

            this.reportViewer1.RefreshReport();
        }
    }
}
