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
    public partial class OrderReport : Form
    {
        public OrderReport()
        {
            InitializeComponent();
        }

        private void OrderReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itproject_newDataSetOrderss.Orders' table. You can move, or remove it, as needed.
  
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            this.OrdersTableAdapter.Fill(this.itproject_newDataSetOrderss.Orders, dateTimePicker1.Value.Date.ToShortDateString(), dateTimePicker2.Value.Date.ToShortDateString());

            this.reportViewer1.RefreshReport();
        }
    }
}
