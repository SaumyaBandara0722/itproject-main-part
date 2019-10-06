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
    public partial class orders : Form
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        public orders()
        {
            InitializeComponent();
        }
        OrderClass o = new OrderClass();
        private void Orders_Load(object sender, EventArgs e)
        {
            DataTable dt = o.Select();
            ogride.DataSource = dt;
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Oadd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            conn.Open();
            string sql = "SELECT AvailableQty FROM Stocks WHERE PatternID=@PatternID";

            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.Parameters.AddWithValue("@PatternID", pid.Text.ToString());
            SqlDataReader dataReader = null;

            dataReader = sqlCommand.ExecuteReader();
            
            int availQty = 0, neededQty = 0;
            while (dataReader.Read())
            {
                availQty = int.Parse(dataReader["AvailableQty"].ToString());
            }
            
            if (availQty > int.Parse(qua.Text))
            {
                SqlConnection conn1 = new SqlConnection(myconnstrng);
                conn1.Open();
                neededQty = 0;
                availQty = availQty - neededQty;
                string sql1 = "UPDATE Stocks SET AvailableQty=@qty WHERE PatternID=@PatternID";
                SqlCommand sqlCommand1 = new SqlCommand(sql1, conn1);
                sqlCommand1.Parameters.AddWithValue("@qty", availQty-neededQty);
                sqlCommand1.Parameters.AddWithValue("@PatternID", pid.Text);

                sqlCommand1.ExecuteNonQuery();
                conn1.Close();
            }
            else
            {
                neededQty = int.Parse(qua.Text) - availQty;
            }
            conn.Close();
            try
            {
                if (cid.Text != "" && pid.Text != "" && qua.Text != "")
                {


                    o.CustomerID = int.Parse(cid.Text);
                    o.PatternID = pid.Text;
                    o.Quantity = int.Parse(qua.Text);
                    //o.Quantity = neededQty;
                    o.OrderDate = DateTime.Parse(odate.Text);
                    o.ExpectedDate = DateTime.Parse(edate.Text);
                    o.NeededQty = neededQty;


                    bool success = o.Insert(o);
                    if (success == true)
                    {
                        MessageBox.Show("New Order Successully Added", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //clearall();
                    }
                    else
                    {
                        MessageBox.Show("New Order adding failed", "Try Again! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    DataTable dt = o.Select();
                    ogride.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Mandotory Failed!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception" + ex);
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Oid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Oupdate_Click(object sender, EventArgs e)
        {
            o.OrderID = int.Parse(oid.Text);
            o.CustomerID = int.Parse(cid.Text);
            o.PatternID = pid.Text;
            o.Quantity = int.Parse(qua.Text);
            o.OrderDate = DateTime.Parse(odate.Text);
            o.ExpectedDate = DateTime.Parse(edate.Text);

            bool success = o.Update(o);
            if (success == true)
            {
                MessageBox.Show("Successfully Updated");

                DataTable dt = o.Select();
                ogride.DataSource = dt;

               // clearall();
            }
            else
            {
                MessageBox.Show("Update Failed!!!");
            }
        }

        private void Ogride_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ogride_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            oid.Text = ogride.Rows[rowIndex].Cells[0].Value.ToString();
            cid.Text = ogride.Rows[rowIndex].Cells[1].Value.ToString();
            pid.Text = ogride.Rows[rowIndex].Cells[2].Value.ToString();
            qua.Text = ogride.Rows[rowIndex].Cells[3].Value.ToString();
            odate.Text = ogride.Rows[rowIndex].Cells[4].Value.ToString();
            edate.Text = ogride.Rows[rowIndex].Cells[5].Value.ToString();
            
        }

        private void Odate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Odelete_Click(object sender, EventArgs e)
        {
            o.OrderID = Convert.ToInt32(oid.Text);
            bool success = o.Delete(o);
            if (success == true)
            {
                MessageBox.Show("Delete Successfully");
                DataTable dt = o.Select();
                ogride.DataSource = dt;
               // clearall();
            }
            else
            {
                MessageBox.Show("Delete Failed!!!");
            }

        }
        public void clearall()
        {
            oid.Text = "";
            pid.Text = "";
            qua.Text = "";
            cid.Text = "";
            odate.Text = "";
            edate.Text = "";

        }

        private void Oclear_Click(object sender, EventArgs e)
        {
            clearall();
        }
        static string mylali = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void Osearch_TextChanged(object sender, EventArgs e)
        {

            string keyword = osearch.Text;

            SqlConnection c1 = new SqlConnection(mylali);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Orders WHERE CustomerID LIKE '%" + keyword + "%' OR PatternID LIKE '%" + keyword + "%' OR Quantity LIKE '%" + keyword + "%'", c1);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ogride.DataSource = dt;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            OrderReport orderReport = new OrderReport();
            orderReport.Show();
        }
    }
}
