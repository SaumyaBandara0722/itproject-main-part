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
    public partial class ProjectsReportsGenerater : Form
    {
        public ProjectsReportsGenerater()
        {
            InitializeComponent();
        }
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        ProjectReports pr = new ProjectReports();
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProjectsReportsGenerater_Load(object sender, EventArgs e)
        {
            //projectReportsBindingSource.Add(new ProjectReports() { ProjectID = 1, OrderID = 1, AddedDate = "2019-08-31", DeadlineDate = "2019-09-07", Status = "Pending" });
            /*           for (int i = 0; i < dataGridViewForReports.Columns.Count; i++)
                       {
                           dataGridViewForReports.Columns[i].HeaderCell.Style.Font = new Font("Sitka Text", 10, FontStyle.Bold);
                           dataGridViewForReports.Columns[i].HeaderCell.Style.BackColor = Color.MintCream;
                           dataGridViewForReports.EnableHeadersVisualStyles = false;
                       }*/
            
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            this.Projects_TasksTableAdapter.Fill(this.itproject_newDataSet1.Projects_Tasks, dateTimePicker1.Value.Date.ToShortDateString(), dateTimePicker2.Value.Date.ToShortDateString());
            this.reportViewer1.RefreshReport();
        }

        /*       private void TxtBoxSearchByAddedDate_TextChanged(object sender, EventArgs e)
               {
                   //Get the value from textbox
                   string keyword = txtBoxSearchByAddedDate.Text;

                   SqlConnection conn = new SqlConnection(myconnstrng);

                   SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Projects_Tasks WHERE AddedDate LIKE '%"+keyword+"%' OR DeadLineDate LIKE '%"+keyword+"%' OR ProjectID Like '%"+keyword+"%'",conn);
                   DataTable dt = new DataTable();
                   sda.Fill(dt);
                   dataGridViewForReports.DataSource = dt;
               }*/
    }
}
