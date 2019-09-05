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
using itproject.Properties;

namespace itproject
{
    public partial class CustomerRegistration : Form
    {
        public CustomerRegistration()
        {
            InitializeComponent();
        }
        CustomerClass c = new CustomerClass();

        private void Delete_Click(object sender, EventArgs e)
        {
            c.CustomerID = Convert.ToInt32(cid.Text);
            bool success = c.Delete(c);
            if (success == true)
            {
                MessageBox.Show("Delete Successfully");
                DataTable dt = c.Select();
                cgride.DataSource = dt;
                clearall();
            }
            else
            {
                MessageBox.Show("Delete Failed!!!");
            }
        }

        private void CustomerRegistration_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            cgride.DataSource = dt;
        }

        private void Cgride_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = c.Select();
            cgride.DataSource = dt;
        }

        private void Cadd_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (cname.Text != "" && cno.Text != "" && cadd.Text != "")
                {
                    c.CustomerName = cname.Text;
                    c.PhoneNumber = cno.Text;
                    c.CustomerAddress = cadd.Text;
                   
                    int num =0;
                    bool success = false;
                    if (cno.TextLength != 10)
                    {
                        MessageBox.Show("Invalid phone number");
                    }
                    else if (!int.TryParse(cno.Text, out num))
                    {
                        MessageBox.Show("Phone number requires integers only");
                    } else
                    {
                        success = c.Insert(c);
                    }
                   
  
                    if (success == true)
                    {
                        MessageBox.Show("New Customer Successully Added","Insert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        clearall();
                    }
                    else
                    {
                        MessageBox.Show("New Customer adding failed", "Try Again! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   

                    DataTable dt = c.Select();
                    cgride.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Mandotory Failed!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception" + ex);
            }
        }


        private void Cname_TextChanged(object sender, EventArgs e)
            {

            }

        private void Update_Click(object sender, EventArgs e)
        {
            c.CustomerID = int.Parse(cid.Text);
            c.CustomerName = cname.Text;
            c.PhoneNumber = cno.Text;
            c.CustomerAddress = cadd.Text;


            bool success = false;
            int num = 0;
            if (cno.TextLength != 10)
            {
                MessageBox.Show("Invalid phone number");
            }
            else if (!int.TryParse(cno.Text, out num))
            {
                MessageBox.Show("Phone number requires integers only");
            }
            else
            {
                success = c.Update(c);
            }
            if (success == true)
            {
                MessageBox.Show("Successfully Updated");

                DataTable dt = c.Select();
                cgride.DataSource = dt;

                clearall();
            }
            else
            {
                MessageBox.Show("Update Failed!!!");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void Cgride_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            cid.Text = cgride.Rows[rowIndex].Cells[0].Value.ToString();
            cname.Text = cgride.Rows[rowIndex].Cells[1].Value.ToString();
            cadd.Text = cgride.Rows[rowIndex].Cells[2].Value.ToString();
            cno.Text = cgride.Rows[rowIndex].Cells[3].Value.ToString();
        }

        public void clearall()
        {
            cname.Text = "";
            cno.Text = "";
            cadd.Text = "";

        }

        static string mylali2 = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void Search_TextChanged(object sender, EventArgs e)
        {
            string keyword = search.Text;

            SqlConnection c1 = new SqlConnection(mylali2);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Customers WHERE CustomerName LIKE '%"+keyword+"%' OR PhoneNumber LIKE '%"+keyword+"%' OR CustomerAddress LIKE '%"+keyword+"%'", c1);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cgride.DataSource = dt;
        }
    }
}
