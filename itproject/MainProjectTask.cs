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
    public partial class MainProjectTask : Form
    {
        public MainProjectTask()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ProjectsReportsGenerater rep = new ProjectsReportsGenerater();
            rep.ShowDialog();
        }

        private void BtnADDPROJECTS_Click(object sender, EventArgs e)
        {
            projectAndTaskControler pro = new projectAndTaskControler();
            pro.ShowDialog();
        }
    }
}
