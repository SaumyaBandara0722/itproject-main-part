using itproject.Classes;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.Threading;

namespace itproject
{
    public partial class Stock : Form
    {

        Thread th;

        public Stock()
        {
            InitializeComponent();
        }


        ClassStock z = new ClassStock();


        private void Buttonstockadd1_Click(object sender, EventArgs e)
        {
            try {
                if (textstockpatternid.Text!="" && textstockpatternname.Text != "" && textstockavailablequantity.Text != "" && textstockaddedquantity.Text != "" ) 
                {

                    z.PatternID = textstockpatternid.Text;
                    z.PatternName = textstockpatternname.Text;
                    z.AvailableQty = int.Parse(textstockavailablequantity.Text);
                    z.AddedQty = int.Parse(textstockaddedquantity.Text);
                    z.AddedDate = DateTime.Parse(dateTimestockaddeddate.Text);


                    bool success = z.Insert(z);

                    if (success == true)
                    {
                        MessageBox.Show("Successfully inserting.", "Inserted.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed !.", "Try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    DataTable dt2 = z.Select();
                    datagridviewstock.DataSource = dt2;
                }
                else
                {
                    MessageBox.Show("Mendatory fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception" + ex);
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        
        private void Stock_Load(object sender, EventArgs e)
        {

            DataTable dt2 = z.Select();
            datagridviewstock.DataSource = dt2;


            datagridviewstock.BorderStyle = BorderStyle.None;
            datagridviewstock.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            datagridviewstock.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            datagridviewstock.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            datagridviewstock.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            datagridviewstock.EnableHeadersVisualStyles = false;
            datagridviewstock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            datagridviewstock.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            datagridviewstock.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            datagridviewstock.Columns["Sid"].HeaderText = "Number";
            datagridviewstock.Columns["PatternID"].HeaderText = "ID";
            datagridviewstock.Columns["PatternName"].HeaderText = "Name";
            datagridviewstock.Columns["AvailableQty"].HeaderText = "Available";
            datagridviewstock.Columns["AddedQty"].HeaderText = "Added Amont";
            datagridviewstock.Columns["AddedDate"].HeaderText = "Date";



        }

        private void Buttonstockupdate_Click(object sender, EventArgs e)
        {

            try
            {
                if (textstockpatternid.Text != "" && textstockpatternname.Text != "" && textstockavailablequantity.Text != "" && textstockaddedquantity.Text != "")
                {
                    z.Sid = int.Parse(txtsnumber.Text);
                    z.PatternID = textstockpatternid.Text;
                    z.PatternName = textstockpatternname.Text;
                    z.AvailableQty = int.Parse(textstockavailablequantity.Text);
                    z.AddedQty = int.Parse(textstockaddedquantity.Text);
                    z.AddedDate = DateTime.Parse(dateTimestockaddeddate.Text);

                    bool success = z.Update(z);

                    if (success == true)
                    {
                        MessageBox.Show("Successfully updating.", "Updated.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                        DataTable dt2 = z.Select();
                        datagridviewstock.DataSource = dt2;

                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed !.", "Try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Mendatory fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception" + ex);
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Buttonstockdelete_Click(object sender, EventArgs e)
        {

            z.Sid = int.Parse(txtsnumber.Text);

            bool success = z.Delete(z);

            if (success == true)
            {
                MessageBox.Show("Successfully deleting.", "Delete.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                DataTable dt2 = z.Select();
                datagridviewstock.DataSource = dt2;

                Clear();
            }
            else
           {
                MessageBox.Show("Failed !.", "Try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buttonstockclear_Click(object sender, EventArgs e)
        {
           Clear();   
        }


        public void Clear()
        {
            txtsnumber.Text = "";
            textstockpatternname.Text = "";
            textstockpatternid.Text = "";
            textstockavailablequantity.Text = "";
            textstockaddedquantity.Text = "";
            dateTimestockaddeddate.Text = "";
        }


        private void Datagridviewstock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt2 = z.Select();
            datagridviewstock.DataSource = dt2;
        }

        private void Datagridviewstock_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            txtsnumber.Text = datagridviewstock.Rows[rowIndex].Cells[0].Value.ToString();
            textstockpatternid.Text = datagridviewstock.Rows[rowIndex].Cells[1].Value.ToString();
           
            textstockpatternname.Text = datagridviewstock.Rows[rowIndex].Cells[2].Value.ToString();
           textstockavailablequantity.Text = datagridviewstock.Rows[rowIndex].Cells[3].Value.ToString();
           textstockaddedquantity.Text = datagridviewstock.Rows[rowIndex].Cells[4].Value.ToString();
          dateTimestockaddeddate.Text = datagridviewstock.Rows[rowIndex].Cells[5].Value.ToString();
        }


        static string myconnstr2 = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void Textstocksearch_TextChanged(object sender, EventArgs e)
            {
            string keyword = textstocksearch.Text;
          
            SqlConnection conn2 = new SqlConnection(myconnstr2);

            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT * FROM Stocks WHERE PatternID LIKE '%"+keyword+"%' OR PatternName LIKE '%"+keyword+"%' OR AvailableQty LIKE '%"+keyword+"%' OR AddedQty LIKE '%"+keyword+"%' OR  AddedDate LIKE '%"+keyword+"%'", conn2);
          
            DataTable dt2 = new DataTable();

            sda2.Fill(dt2);

            datagridviewstock.DataSource = dt2;
        }

        private void Buttonpattern2_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach(Form f in Application.OpenForms)
            {
                if (f.Text == "Pattern")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if(Isopen == false)
            {
                // Pattern ps = new Pattern();
                //ps.Show();

                this.Close();

                th = new Thread(openPattern);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();


            }

        }

        private void openPattern()
        {
            Application.Run(new Pattern());
        }

        private void Pictureboxstockclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnmaximize_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Pictureboxstockclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnminimize_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;

        }

      

        private void Textstockpatternid_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                    e.Handled = true;
            else
                e.Handled = false;
        }
        private void Textstockpatternname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void Textstockaddedquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void Textstockavailablequantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void Labelstock_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Stock sreport = new Stock();
            sreport.ShowDialog();
        }
    }
}
