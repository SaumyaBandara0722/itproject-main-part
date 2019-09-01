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
    public partial class Customers : UserControl
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            orders order = new orders();
            order.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CustomerRegistration cr = new CustomerRegistration();
            cr.ShowDialog();
        }
    }
}
