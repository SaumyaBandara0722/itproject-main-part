using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management
{
   
    public partial class DisplayAttendanceReport : Form
    {

        public static DataTable getReport;
        public DisplayAttendanceReport()
        {
            InitializeComponent();
        }
        
       
        private void DisplayAttendanceReport_Load(object sender, EventArgs e)
        {
           
           if(itproject.AttendanceForm.clickedSortType.Equals("EmpID"))
            {
                AttendanceClass a = new AttendanceClass();
                DataTable dts = a.SortByID(itproject.AttendanceForm.sortID);
                dataGridView.DataSource = dts;
                getReport = dts;
            }
           else if(itproject.AttendanceForm.clickedSortType.Equals("Date"))
            {
                AttendanceClass a = new AttendanceClass();
                DataTable dt = a.SortByDate(itproject.AttendanceForm.date);
                dataGridView.DataSource = dt;
                getReport = dt;
            }
            else if(itproject.AttendanceForm.clickedSortType.Equals("MonthYear"))
            {
                AttendanceClass a = new AttendanceClass();
                DataTable dt = a.SortByIDDate(itproject.AttendanceForm.month, itproject.AttendanceForm.year);
                dataGridView.DataSource = dt;
                getReport = dt;
            }

        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            if (getReport == null)
            {
                MessageBox.Show("No data for a report");
                return;
            }
            AttendanceClass reports = new AttendanceClass();
            if (reports.createPDF(getReport, "D:\\Reports\\AdminAttendaceReport.pdf"))
            {
                MessageBox.Show("Report was downloaded");
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        
    }
    }
}
