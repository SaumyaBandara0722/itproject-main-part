using iTextSharp.text;
using iTextSharp.text.pdf;
using itproject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;


namespace itproject
{
    public partial class PatternAndStockMangementSystem : Form
    {
        public PatternAndStockMangementSystem()
        {
            InitializeComponent();
        }
        private void PatternAndStockMangementSystem_Load(object sender, EventArgs e)
        {

        }

        /////////////////////////////////////////////////////////////////////////// Button Pattern ///////////////////////////////////////////////////////
        private void Buttonpattern_Click(object sender, EventArgs e)
        {
            Pattern pattern = new Pattern();
            pattern.ShowDialog();
        }

        /////////////////////////////////////////////////////////////////////////// Button Stock ///////////////////////////////////////////////////////
        private void Buttonstock_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.ShowDialog();
        }

        private void Btnemail_Click(object sender, EventArgs e)
        {
        }


        /////////////////////////////////////////////////////////////////////////// Button Close ///////////////////////////////////////////////////////
        private void Pictureboxpatternclose_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        /////////////////////////////////////////////////////////////////////////// Button Minimaize ///////////////////////////////////////////////////////
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


        /////////////////////////////////////////////////////////////////////////// Button Maximaize ///////////////////////////////////////////////////////
        private void Btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
