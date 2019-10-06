using Employee_Management;
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
    public partial class AttendanceForm : Form
    {
        public static int ID;
        public static int sortID;
        public static string date;
        public static String month;
        public static String year;
        public static String clickedSortType = null;
        public AttendanceForm()
        {
            InitializeComponent();
        }

        private void btnSortByEmployeeId_Click(object sender, EventArgs e)
        {
            clickedSortType = "EmpID";
            sortID = Int32.Parse(txtEmpIDReport.Text);

            DisplayAttendanceReport display = new DisplayAttendanceReport();
            display.ShowDialog();
        }

        private void btnSortByDate_Click(object sender, EventArgs e)
        {
            clickedSortType = "Date";
            date = txtDateReport.Text;

            DisplayAttendanceReport display = new DisplayAttendanceReport();
            display.ShowDialog();
        }

        private void btnSortByMonthYear_Click(object sender, EventArgs e)
        {
            clickedSortType = "MonthYear";
            month = lblMonthReport.Text;
            year = lblYearReport.Text;

            DisplayAttendanceReport display = new DisplayAttendanceReport();
            display.ShowDialog();
        }
        AttendanceClass a = new AttendanceClass();
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            DataTable dt = a.Select();
            dataGridView.DataSource = dt;
        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            AttendanceClass a = new AttendanceClass();
            DataTable dt = a.Select();
            dataGridView.DataSource = dt;
        }
    }
}
