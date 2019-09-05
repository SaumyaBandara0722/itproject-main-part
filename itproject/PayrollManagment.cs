using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itproject
{
    public partial class View : Form
    {

        public View()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=AMITH-PC;Initial Catalog=itproject;Integrated Security=True;");



        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtEmpName.Text == "" || cmbEmpID.Text == ""||
                Basic_txt.Text == "" || OTRate_txt.Text == "" || cmbOThours.Text == "" || txtTransport.Text == "" || txtSpecial.Text == "" || txtHoliday.Text == "" || txtAttendence.Text == "")
            {
                MessageBox.Show("filds cannot be emptly");
            }
            else
            {


                con.Open();
                String query = "INSERT INTO Payroll(EmployeeName,Section,OTHours,BasicSalary,PaySlipNo,EmployeeID,OTRate,Transport,Special,Holiday,Attendence,SalaryMonthFrom,SalaryMonthTo,GrossPay) VALUES('" + txtEmpName.Text + "','" + cmbSection.Text + "','" + Double.Parse(cmbOThours.Text) + "','" + Double.Parse(Basic_txt.Text) + "','" + txtPayslipNo.Text + "','" + cmbEmpID.Text + "','" + Double.Parse(OTRate_txt.Text) + "','" + Double.Parse(txtTransport.Text) + "','" + Double.Parse(txtSpecial.Text) + "','" + Double.Parse(txtHoliday.Text) + "','" + Double.Parse(txtAttendence.Text) + "','" + dateTimePicker1.Value + "','" + dateTimePicker2.Value + "','" + Double.Parse(txtGross.Text) + "')";
                // String query = "INSERT INTO tbl_Payroll(EmployeeName,Section,OTHours,BasicSalary,PaySlipNo,EmployeeID,OTRate,Transport,Special,Holiday,Attendence,SalaryMonthFrom,SalaryMonthTo,GrossPay) VALUES(@EmployeeName,@Section,@OTHours,@BasicSalary,@PaySlipNo,@EmployeeID,@OTRate,@Transport,@Special,@Holiday,@Attendence,@SalaryMonthFrom,@SalaryMonthTo,@GrossPay)";
                //SqlCommand sqlCommand = new SqlCommand(query, con);

                //      sqlCommand.Parameters.AddWithValue("@EmployeeName", txtEmpName.Text);
                //      sqlCommand.Parameters.AddWithValue("@Section", cmbSection.Text);
                //      sqlCommand.Parameters.AddWithValue("@OTHours", Double.Parse(cmbOThours.Text));
                //      sqlCommand.Parameters.AddWithValue("@BasicSalary", Double.Parse(Basic_txt.Text));
                //       sqlCommand.Parameters.AddWithValue("@PaySlipNo", txtPayslipNo.Text);
                /*     sqlCommand.Parameters.AddWithValue("@EmployeeID", cmbEmpID.Text);
                     sqlCommand.Parameters.AddWithValue("@OTRate", Double.Parse(OTRate_txt.Text));
                     sqlCommand.Parameters.AddWithValue("@Transport", Double.Parse(txtTransport.Text));
                     sqlCommand.Parameters.AddWithValue("@Special", Double.Parse(txtSpecial.Text));
                     sqlCommand.Parameters.AddWithValue("@Holiday", Double.Parse(txtHoliday.Text));
                     sqlCommand.Parameters.AddWithValue("@Attendence", Double.Parse(txtAttendence.Text));
                     sqlCommand.Parameters.AddWithValue("@SalaryMonthFrom", dateTimePicker1.Value);
                     sqlCommand.Parameters.AddWithValue("@SalaryMonthTo", dateTimePicker2.Value);
                     sqlCommand.Parameters.AddWithValue("@GrossPay", double.Parse(txtGross.Text));
                     */
                //con.Open();
                //.ExecuteNonQuery();
                SqlDataAdapter sd = new SqlDataAdapter(query, con);
                sd.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Save successfully!");
            }

        }

    
        private void Button3_Click_3(object sender, EventArgs e)
        {
            con.Open();
            String query = "SELECT * FROM Payroll";
            SqlDataAdapter sd = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE Payroll SET Section = '" + cmbSection.Text + "',OTHours = '" + cmbOThours.Text + "',BasicSalary ='" + Basic_txt.Text+ "', PaySlipNo = '" + txtPayslipNo.Text + "',EmployeeID ='"+ cmbEmpID.Text+"', OTRate = '"+ OTRate_txt.Text+"', Transport = '"+txtTransport.Text+"', Special = '"+txtSpecial.Text+"', Holiday = '"+ txtHoliday.Text+"', Attendence = '"+ txtAttendence.Text+"', SalaryMonthFrom = '"+ dateTimePicker1.Value+"',SalaryMonthTo = '"+ dateTimePicker2.Value+"' WHERE EmployeeName = '"+ txtEmpName.Text +"'";
            SqlDataAdapter sd = new SqlDataAdapter(query, con);
            sd.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("UPDATE SUCCESSFULY!!!!");
        }

        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            txtEmpName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            cmbSection.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            cmbOThours.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Basic_txt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtPayslipNo.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            cmbEmpID.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            OTRate_txt.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtTransport.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtSpecial.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtHoliday.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            txtAttendence.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Today;
            txtGross.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "DELETE  FROM Payroll WHERE EmployeeName = '" + txtEmpName.Text + "' ";
            SqlDataAdapter sd = new SqlDataAdapter(query, con);
            sd.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted!!");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            txtEmpName.Text = "";
            txtPayslipNo.Text = "";
            Basic_txt.Text = "";
            cmbOThours.Text = "";
            cmbSection.Text = "";
            cmbEmpID.Text = "";
            OTRate_txt.Text = "";
            txtTransport.Text = "";
            txtSpecial.Text = "";
            txtHoliday.Text = "";
            txtAttendence.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            txtGross.Text = "";


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OTRate_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Basic_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double bsal, otrate, s2, s3, s4,s5, result;
            int othours;
            if (Basic_txt.Text == "" || OTRate_txt.Text == "" || cmbOThours.Text == "" || txtTransport.Text == "" || txtSpecial.Text == "" || txtHoliday.Text == "" || txtAttendence.Text == "")
            {
                MessageBox.Show("filds cannot be empty");
            }
            else
            {


                bsal = double.Parse(Basic_txt.Text);
                otrate = double.Parse(OTRate_txt.Text);
                othours = int.Parse(cmbOThours.Text);
                s2 = double.Parse(txtTransport.Text);
                s3 = double.Parse(txtSpecial.Text);
                s4 = double.Parse(txtHoliday.Text);
                s5 = double.Parse(txtAttendence.Text);

                result = bsal + ((s2 + s3 + s4 + s5) + (otrate * othours));
                txtGross.Text = "" + result;
            }


        }

        private void TxtGross_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void LblUnits_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
           /// SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-COF6S90;Initial Catalog=Payroll;Integrated Security=True;") ;
           // DataTable dt = new DataTable();
           // object EmplpoyeeID = null;
           // SqlDataAdapter sd = new SqlDataAdapter("SELECT * FROM tbl_Payroll WHERE EmployeeID like " EmplpoyeeID.Parse(cmbEmpID.Text),con);
           // sd.Fill(dt);
           // dataGridView1.DataSource = dt;

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
