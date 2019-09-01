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
            con.Open();
            String query = "INSERT INTO Payroll(EmployeeName,Section,OTHours,BasicSalary,PaySlipNo,EmployeeID,OTRate,Transport,Special,Holiday,Attendence,SalaryMonthFrom,SalaryMonthTo) VALUES('" + txtEmpName.Text + "','" + cmbSection.Text + "','" + cmbOThours.Text +  "','" + Basic_txt.Text + "','" + txtPayslipNo.Text + "','"+cmbEmpID.Text+"','"+OTRate_txt.Text+"','"+txtTransport.Text+"','"+ txtSpecial.Text+"','"+ txtHoliday.Text+"','"+ txtAttendence.Text+"','"+ dateTimePicker1.Value+"','"+ dateTimePicker2.Value+"')";
            SqlDataAdapter sd = new SqlDataAdapter(query, con);
            sd.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Save successfully!");

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
    }
}
