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
    public partial class PatternAndStockMangementSystem : Form
    {
        public PatternAndStockMangementSystem()
        {
            InitializeComponent();
        }

        private void Buttonpattern_Click(object sender, EventArgs e)
        {
            Pattern pattern = new Pattern();
            pattern.ShowDialog();
        }

        private void Buttonstock_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.ShowDialog();
        }

        private void Btnemail_Click(object sender, EventArgs e)
        {
            Mail mail = new Mail();
            mail.ShowDialog();
        }

        private void Pictureboxpatternclose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Btnmaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
