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
        SqlConnection con = new SqlConnection(@"Data Source=AMITH-PC;Initial Catalog=itproject_new;Integrated Security=True;");
        private object downloadingDataTable;

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
                String query = "INSERT INTO Payroll(EmployeeName,Section,OTHours,BasicSalary,PaySlipNo,EmployeeID,OTRate,Transport,Special,Holiday,Attendance,SalaryMonthFrom,SalaryMonthTo,GrossPay) VALUES('" + txtEmpName.Text + "','" + cmbSection.Text + "','" + Double.Parse(cmbOThours.Text) + "','" + Double.Parse(Basic_txt.Text) + "','" + txtPayslipNo.Text + "','" + cmbEmpID.Text + "','" + Double.Parse(OTRate_txt.Text) + "','" + Double.Parse(txtTransport.Text) + "','" + Double.Parse(txtSpecial.Text) + "','" + Double.Parse(txtHoliday.Text) + "','" + Double.Parse(txtAttendence.Text) + "','" + dateTimePicker1.Value + "','" + dateTimePicker2.Value + "','" + Double.Parse(txtGross.Text) + "')";
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

        private void CmbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

	private void TxtId_TextChanged(object sender, EventArgs e)
    	{
            String keyword = txtId.Text;

            con.Open();
            String query = "SELECT * FROM Payroll WHERE EmployeeID LIKE '" + keyword + "%'";
            SqlDataAdapter sd = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            //String keyword = txtId.Text;



        }

	private void View_Load(object sender, EventArgs e)
    	{
            // TODO: This line of code loads data into the 'itproject_newDataSetPayRoll.Payroll' table. You can move, or remove it, as needed.
            this.PayrollTableAdapter.Fill(this.itproject_newDataSetPayRoll.Payroll);

                  con.Open();
                  String query = "SELECT * FROM Payroll";
                  SqlDataAdapter sd = new SqlDataAdapter(query, con);
                  DataTable dt = new DataTable();
                  sd.Fill(dt);
                  dataGridView1.DataSource = dt;
                  con.Close();
            this.reportViewer1.RefreshReport();
        }

        private void BtnGetData_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT EmpName, BasicSal, Department FROM Employees WHERE EmpID=@EmpID";

            SqlCommand sqlCommand = new SqlCommand(sql, con);
            sqlCommand.Parameters.AddWithValue("@EmpID", Int32.Parse(cmbEmpID.Text));
            SqlDataReader dataReader = null;

            dataReader = sqlCommand.ExecuteReader();

            while (dataReader.Read())
            {
                Basic_txt.Text = dataReader["BasicSal"].ToString();
                txtEmpName.Text = dataReader["EmpName"].ToString();
                cmbSection.Text = dataReader["Department"].ToString();
            }

            con.Close();

            con.Open();
            string sql2 = "SELECT hoursWorked FROM Attendance WHERE EmpID=@EmpID";
            SqlCommand sqlCommand2 = new SqlCommand(sql2, con);
            sqlCommand2.Parameters.AddWithValue("@EmpID", Int32.Parse(cmbEmpID.Text));
            SqlDataReader dataReader2 = null;

            dataReader2 = sqlCommand2.ExecuteReader();

            while (dataReader2.Read())
            {
                int workedHours = Int32.Parse(dataReader2["hoursWorked"].ToString());
                int shouldWorked = 8 * 20 * 60;
                float ot = (workedHours - shouldWorked) / 60;
                cmbOThours.Text = ot.ToString();
            }
            con.Close();
        }

        private void Label20_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
        }

        private void Button7_Click_1(object sender, EventArgs e)
        {

            con.Open();
            string query = "UPDATE Payroll SET Section = '" + cmbSection.Text + "',OTHours = '" + cmbOThours.Text + "',BasicSalary ='" + Basic_txt.Text + "', PaySlipNo = '" + txtPayslipNo.Text + "',EmployeeID ='" + cmbEmpID.Text + "', OTRate = '" + OTRate_txt.Text + "', Transport = '" + txtTransport.Text + "', Special = '" + txtSpecial.Text + "', Holiday = '" + txtHoliday.Text + "', Attendance = '" + txtAttendence.Text + "', SalaryMonthFrom = '" + dateTimePicker1.Value + "',SalaryMonthTo = '" + dateTimePicker2.Value + "' WHERE EmployeeName = '" + txtEmpName.Text + "'";
            SqlDataAdapter sd = new SqlDataAdapter(query, con);
            sd.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("UPDATE SUCCESSFULY!!!!");
        }

        private void Button4_Click(object sender, EventArgs e)
        {

            if(downloadingDataTable == null)
            {
                MessageBox.Show("Cannot create any report because data set is Empty");
                return;
            }
            DataTable dataTable = new DataTable();
          //  if(dataTable.createPDF(downloadingDataTable,))
        }

        private void Buttongenarate_Click(object sender, EventArgs e)
        {
            //       DataTable dataTable = new DataTable();

            //        dataGridView2.DataSource = null;
            //        downloadingDataTable = null;



        }

        //validations
        private void Basic_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void OTRate_txt_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void TxtTransport_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void TxtHoliday_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void TxtAttendence_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void TxtSpecial_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void TxtGross_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void TxtPayslipNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
