using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itproject.Classes
{
    class ClassPattern
    {
        public int Pid { get; set; }
        public string PatternID { get; set; }
        public string PatternName { get; set; }
        public double unitPrice { get; set; }
        public string Description { get; set; }

        /////////////////////////////////////////////////////////////////////////// Connection with SQL ///////////////////////////////////////////////////////
        
        static string myid = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        /////////////////////////////////////////////////////////////////////////// Search ///////////////////////////////////////////////////////
        public DataTable Select()
        {
            SqlConnection conn1 = new SqlConnection(myid);
            DataTable dt1 = new DataTable();

            try
            {
                string sql1 = "SELECT * FROM Patterns";
                SqlCommand cmd1 = new SqlCommand(sql1, conn1);
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);

                conn1.Open();

                adapter1.Fill(dt1);
            }

            catch (Exception)
            {

            }

            finally
            {
                conn1.Close();
            }
            return dt1;
        }

        /////////////////////////////////////////////////////////////////////////// Insert ///////////////////////////////////////////////////////
        public bool Insert(ClassPattern y)
        {
            bool isSuccess = false;

            SqlConnection conn1 = new SqlConnection(myid);
            try
            {
                string sql1 = "INSERT INTO Patterns(PatternID, PatternName, unitPrice, Description) VALUES(@PatternID, @PatternName, @unitPrice, @Description)";

                SqlCommand cmd1 = new SqlCommand(sql1, conn1);

                cmd1.Parameters.AddWithValue("@PatternID", y.PatternID);
                cmd1.Parameters.AddWithValue("@PatternName", y.PatternName);
                cmd1.Parameters.AddWithValue("@unitPrice", y.unitPrice);
                cmd1.Parameters.AddWithValue("@Description", y.Description);

                conn1.Open();

                int rows = cmd1.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }

            catch (Exception)
            {
            }
            finally
            {
                conn1.Close();
            }

            return isSuccess;
        }


        /////////////////////////////////////////////////////////////////////////// Update ///////////////////////////////////////////////////////
        public bool Update(ClassPattern y)
        {
            bool isSuccess = false;

            SqlConnection conn1 = new SqlConnection(myid);

            try
            {
                string sql1 = "UPDATE Patterns SET PatternID=@PatternID, PatternName=@PatternName, unitPrice=@unitPrice, Description=@Description WHERE Pid=@Pid";

                SqlCommand cmd1 = new SqlCommand(sql1, conn1);

                cmd1.Parameters.AddWithValue("@Pid", y.Pid);
                cmd1.Parameters.AddWithValue("@PatternID", y.PatternID);
                cmd1.Parameters.AddWithValue("@PatternName", y.PatternName);
                cmd1.Parameters.AddWithValue("@unitPrice", y.unitPrice);
                cmd1.Parameters.AddWithValue("@Description", y.Description);

                conn1.Open();

                int rows = cmd1.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception)
            {

            }

            finally
            {
                conn1.Close();
            }
            return isSuccess;
        }

        /////////////////////////////////////////////////////////////////////////// Delete ///////////////////////////////////////////////////////
        public bool Delete(ClassPattern y)
        {
            bool isSuccess = false;

            SqlConnection conn1 = new SqlConnection(myid);

            try
            {

                string sql1 = "DELETE FROM Patterns WHERE Pid=@Pid";

                SqlCommand cmd1 = new SqlCommand(sql1, conn1);

                cmd1.Parameters.AddWithValue("@Pid", y.Pid);

                conn1.Open();

                int rows = cmd1.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }

            catch (Exception)
            {

            }

            finally
            {
                conn1.Close();
            }
            return isSuccess;
        }

        /////////////////////////////////////////////////////////////////////////// Exporting as PDF ///////////////////////////////////////////////////////


        public bool exportDtatTableToPdf(DataGridView dataGridViewpattern, String y)
        {

            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dataGridViewpattern.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            foreach (DataGridViewColumn column in dataGridViewpattern.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);

                pdftable.AddCell(cell);

            }

            foreach (DataGridViewRow row in dataGridViewpattern.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {

                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }


            var savefiledialoge = new System.Windows.Forms.SaveFileDialog();
            savefiledialoge.FileName = y;
            savefiledialoge.DefaultExt = ".pdf";

            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);

                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();


                }
            }
            return true;
        }

    }
}
