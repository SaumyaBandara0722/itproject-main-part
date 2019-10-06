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
    public partial class UpdateAttendance : Form
    {
        public UpdateAttendance()
        {
            InitializeComponent();
        }

        AttendanceClass a = new AttendanceClass();
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
           
            // int id = AttendanceUserControl.ID;
            //DataTable dt = a.Select();

            try
            {
                a.EmployeeId = Int32.Parse(txtUpdateEmpID.Text);
            }
            catch (Exception esd)
            {
                MessageBox.Show("Enter a numeric value");
                return;
            }

            
            a.Date = dateTimePickerUpdate.Text;
            a.ArrivedTime = lblInTime.Text;
            lblLeftTime.Text = DateTime.Now.ToString("HH:mm");
            a.LeftTime = lblLeftTime.Text;

            DateTime date1 = DateTime.Parse(lblInTime.Text);
            DateTime date2 = DateTime.Parse(lblLeftTime.Text);
            string minutes = (date2.Subtract(date1).TotalMinutes).ToString();

         



            

            bool success = a.Update(a,AttendanceUserControl1.ID,minutes);

            if (success == true)
            {
                MessageBox.Show("Updated successfully");
            }
            else
            {
                MessageBox.Show("Unsucessful Update");
            }
            this.Hide();


        }

        private void UpdateAttendance_Load(object sender, EventArgs e)
        {

            dateTimePickerUpdate.Format = DateTimePickerFormat.Custom;
            dateTimePickerUpdate.CustomFormat = "dd-MM-yyyy";


            lblOutTime.Text = DateTime.Now.ToString("HH:mm");
            a.LeftTime = lblOutTime.Text;

            AttendanceClass cl = new AttendanceClass();
            DataTable dt = cl.SelectByID(AttendanceUserControl1.ID);

            foreach (DataRow row in dt.Rows)
            {
                try
                {
                    txtUpdateEmpID.Text = row["EmpID"].ToString();
                    lblInTime.Text = row["inTime"].ToString();
                    //lblLeftTime.Text = row["outTime"].ToString();
                    dateTimePickerUpdate.Text = row["date"].ToString();

                }
                catch (Exception exx)
                {

                }
            
        
                    

            }
           
           

          

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool buttonWasClicked = false;
        private void BtnConfirmLeftTime_Click(object sender, EventArgs e)
        {
          

            buttonWasClicked = true;
          
        }
    }
}
