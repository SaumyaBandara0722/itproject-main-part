using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itproject
{
    public partial class PatternAndStockManagement : UserControl
    {
        public PatternAndStockManagement()
        {
            InitializeComponent();
        }

        private void Buttonstock_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
 //           Mail mail = new Mail();
//            mail.Show();
        }

        private void Buttonpattern_Click(object sender, EventArgs e)
        {
            Pattern p = new Pattern();
            p.ShowDialog();
        }
    }
}
