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
    public partial class PatternReportForm : Form
    {
        public PatternReportForm()
        {
            InitializeComponent();
        }

        private void PatternReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itproject_newDataSetPatternReport.Patterns' table. You can move, or remove it, as needed.
            this.PatternsTableAdapter.Fill(this.itproject_newDataSetPatternReport.Patterns);

            this.reportViewer1.RefreshReport();
        }
    }
}
