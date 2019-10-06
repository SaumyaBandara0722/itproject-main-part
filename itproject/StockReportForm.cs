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
    public partial class StockReportForm : Form
    {
        public StockReportForm()
        {
            InitializeComponent();
        }

        private void StockReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itproject_newDataSet3.Stocks' table. You can move, or remove it, as needed.
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.StocksTableAdapter.Fill(this.itproject_newDataSet3.Stocks, textBox1.Text.ToString());

            this.reportViewer1.RefreshReport();
        }
    }
}
