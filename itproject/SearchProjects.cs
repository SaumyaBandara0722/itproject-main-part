using itproject.ReportRelatedClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itproject
{
    public partial class SearchProjects : Form
    {
        public SearchProjects()
        {
            InitializeComponent();
        }
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        ProjectReports pr = new ProjectReports();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtBoxSearch.Text;
            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Projects_Tasks WHERE AddedDate LIKE '%"+keyword+"%' OR DeadLineDate LIKE '%"+keyword+"%' OR ProjectID LIKE '%"+keyword+"%'",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewSearch.DataSource = dt;
        }

        private void SearchProjects_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewSearch.Columns.Count; i++)
            {
                dataGridViewSearch.Columns[i].HeaderCell.Style.Font = new Font("Sitka Text", 10, FontStyle.Bold);
                dataGridViewSearch.Columns[i].HeaderCell.Style.BackColor = Color.MintCream;
                dataGridViewSearch.EnableHeadersVisualStyles = false;
            }
        }
    }
}
