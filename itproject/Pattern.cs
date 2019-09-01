﻿using itproject.Classes;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
//using System.Data.Linq;
//using System.Web.UI.WebControls;
using BorderStyle = System.Windows.Forms.BorderStyle;
using System.Threading;

namespace itproject
{
    public partial class Pattern : Form
    {
        Thread th;

        public Pattern()
        {
            InitializeComponent();
        }

        ClassPattern y = new ClassPattern();
        private void Buttonpatternadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (textpatternpatternid.Text != "" && textpatternpatternname.Text != "" && textpatternunitprice.Text != "") {

                    //input fields
                    y.PatternName = textpatternpatternname.Text;
                    y.unitPrice = double.Parse(textpatternunitprice.Text);
                    y.Description = textpatterndescription.Text;
                    y.PatternID = textpatternpatternid.Text;

                    //inserting data to database
                    bool success = y.Insert(y);

                    if (success == true)
                    {
                        MessageBox.Show("Successfully inserting.", "Inserted.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed !.", "Try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    DataTable dt = y.Select();
                    dataGridViewpattern.DataSource = dt;
                    

                }
                else {
                    MessageBox.Show("Mendatory fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception" + ex);
            }





        }

        private void Pattern_Load(object sender, EventArgs e)
        {


           DataTable dt = y.Select();
            dataGridViewpattern.DataSource = dt;

            dataGridViewpattern.BorderStyle = BorderStyle.None;
            dataGridViewpattern.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewpattern.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewpattern.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewpattern.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            dataGridViewpattern.EnableHeadersVisualStyles = false;
            dataGridViewpattern.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewpattern.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewpattern.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridViewpattern.Columns["Pid"].HeaderText = "Number";
            dataGridViewpattern.Columns["PatternID"].HeaderText = "ID";
            dataGridViewpattern.Columns["PatternName"].HeaderText = "Name";
            dataGridViewpattern.Columns["unitPrice"].HeaderText = "Price";
            dataGridViewpattern.Columns["Description"].HeaderText = "Description";
        
        }

        private void DataGridViewpattern_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textPNumber.Text = dataGridViewpattern.Rows[rowIndex].Cells[0].Value.ToString();
            textpatternpatternid.Text = dataGridViewpattern.Rows[rowIndex].Cells[1].Value.ToString();
            textpatternpatternname.Text = dataGridViewpattern.Rows[rowIndex].Cells[2].Value.ToString();
            textpatternunitprice.Text = dataGridViewpattern.Rows[rowIndex].Cells[3].Value.ToString();
            textpatterndescription.Text = dataGridViewpattern.Rows[rowIndex].Cells[4].Value.ToString();
          
        }
        private void Clear()
        {
            textPNumber.Text = "";
          textpatternpatternname.Text = "";
          textpatternpatternid.Text = "";
          textpatternunitprice.Text = "";
          textpatterndescription.Text = "";
        }

        private void Buttonpatternclear_Click(object sender, EventArgs e)
        {
           Clear();
        }

         private void Buttonpatternupdate_Click(object sender, EventArgs e)
        {

            try {
                if (textpatternpatternid.Text != "" && textpatternpatternname.Text != "" && textpatternunitprice.Text != "")
                {
                    y.Pid = int.Parse(textPNumber.Text);
                    y.PatternID = textpatternpatternid.Text;
                    y.PatternName = textpatternpatternname.Text;
                    y.unitPrice = double.Parse(textpatternunitprice.Text);
                    y.Description = textpatterndescription.Text;

                    bool success = y.Update(y);

                    if (success == true)
                    {
                        MessageBox.Show("Successfully updating.","Updated.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        DataTable dt = y.Select();
                        dataGridViewpattern.DataSource = dt;

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
            }

        }

       private void Buttonpatterndelete_Click(object sender, EventArgs e)
        {

            y.Pid = Convert.ToInt32(textPNumber.Text);

                bool success = y.Delete(y);

                 if (success == true)
            {
                MessageBox.Show("Successfully deleting.", "Delete.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                DataTable dt = y.Select();
                dataGridViewpattern.DataSource = dt;

               Clear();
            }
            else
            {
                MessageBox.Show("Failed !.", "Try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       }

        private void DataGridViewpattern_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          DataTable dt = y.Select();
             dataGridViewpattern.DataSource = dt;
        }

        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void Textpatternsearch_TextChanged(object sender, EventArgs e)
        {

            string keyword = textpatternsearch.Text;

            SqlConnection conn = new SqlConnection(myconnstr);

             SqlDataAdapter sda3 = new SqlDataAdapter("SELECT * FROM Patterns1 WHERE PatternName LIKE '%"+keyword+"%' OR unitPrice LIKE '%"+keyword+"%' OR Description LIKE '%"+keyword+"%' OR PatternID LIKE'%"+keyword+"%'", conn);

            DataTable dt1 = new DataTable();

            sda3.Fill(dt1);

            dataGridViewpattern.DataSource = dt1;
        }

        private void Buttonstock2_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Stock")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (Isopen == false)
            {
                this.Close();

                //  Stock sp = new Stock();
                //sp.Show();

               

                th = new Thread(openStock);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
               
            }


        }

        private void openStock()
        {
            Application.Run(new Stock());
        } 

        private void Pictureboxpatternclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void Pictureboxpatternclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

       

      private void TextPNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void Textpatternpatternid_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                   e.Handled = true;
            else
                e.Handled = false;
        }
        private void Textpatternpatternname_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) 
                e.Handled = true;
            else
                e.Handled = false;
        }

      

        private void Textpatternunitprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void Textpatterndescription_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void TextPNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
