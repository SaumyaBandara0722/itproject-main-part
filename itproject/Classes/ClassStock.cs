using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace itproject.Classes
{
    class ClassStock
    {
        public int Sid { get; set; }
        public string PatternID { get; set; }
        public string PatternName { get; set; }
        public int AvailableQty { get; set; }
        public int AddedQty { get; set; }
        public DateTime AddedDate { get; set; }

        /////////////////////////////////////////////////////////////////////////// Connection with SQL ///////////////////////////////////////////////////////

        static string myid2 = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        /////////////////////////////////////////////////////////////////////////// Search ///////////////////////////////////////////////////////
        public DataTable Select()
        {
            SqlConnection conn2 = new SqlConnection(myid2);
            DataTable dt2 = new DataTable();

            try
            {
                string sql2 = "SELECT * FROM Stocks";
                SqlCommand cmd2 = new SqlCommand(sql2, conn2);
                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);

                conn2.Open();

                adapter2.Fill(dt2);
            }

            catch (Exception)
            {

            }

            finally
            {
                conn2.Close();
            }
            return dt2;
        }

        /////////////////////////////////////////////////////////////////////////// Insert ///////////////////////////////////////////////////////
        public bool Insert(ClassStock z)
        {
            bool isSuccess = false;

            SqlConnection conn2 = new SqlConnection(myid2);

            try
            {
                string sql2 = "INSERT INTO Stocks(PatternID, PatternName, AvailableQty, AddedQty, AddedDate) VALUES(@PatternID, @PatternName, @AvailableQty, @AddedQty, @AddedDate)";

                SqlCommand cmd2 = new SqlCommand(sql2, conn2);

                //cmd2.Parameters.AddWithValue("@Sid", z.Sid);
                cmd2.Parameters.AddWithValue("@PatternID", z.PatternID);
                cmd2.Parameters.AddWithValue("@PatternName", z.PatternName);
                cmd2.Parameters.AddWithValue("@AvailableQty", z.AvailableQty);
                cmd2.Parameters.AddWithValue("@AddedQty", z.AddedQty);
                cmd2.Parameters.AddWithValue("@AddedDate", z.AddedDate);

                conn2.Open();

                int rows = cmd2.ExecuteNonQuery();

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
                conn2.Close();
            }

            return isSuccess;
        }

        /////////////////////////////////////////////////////////////////////////// Update ///////////////////////////////////////////////////////
        public bool Update(ClassStock z)
        {
            bool isSuccess = false;

            SqlConnection conn2 = new SqlConnection(myid2);

            try
            {
                string sql2 = "UPDATE Stocks SET PatternID=@PatternID, PatternName=@PatternName, AvailableQty=@AvailableQty, AddedQty=@AddedQty, AddedDate=@AddedDate WHERE Sid=@Sid";

                SqlCommand cmd2 = new SqlCommand(sql2, conn2);

                cmd2.Parameters.AddWithValue("@Sid", z.Sid);
                cmd2.Parameters.AddWithValue("@PatternID", z.PatternID);
                cmd2.Parameters.AddWithValue("@PatternName", z.PatternName);
                cmd2.Parameters.AddWithValue("@AvailableQty", z.AvailableQty);
                cmd2.Parameters.AddWithValue("@AddedQty", z.AddedQty);
                cmd2.Parameters.AddWithValue("@AddedDate", z.AddedDate);

                conn2.Open();

                int rows = cmd2.ExecuteNonQuery();

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
                conn2.Close();
            }
            return isSuccess;
        }


       /////////////////////////////////////////////////////////////////////////// Delete ///////////////////////////////////////////////////////
        public bool Delete(ClassStock z)
        {
            bool isSuccess = false;

            SqlConnection conn2 = new SqlConnection(myid2);

            try
            {
                string sql2 = "DELETE FROM Stocks WHERE Sid=@Sid";

                SqlCommand cmd2 = new SqlCommand(sql2, conn2);

                cmd2.Parameters.AddWithValue("@Sid",z.Sid);

                conn2.Open();

                int rows = cmd2.ExecuteNonQuery();

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
                conn2.Close();
            }
            return isSuccess;
        }

        /////////////////////////////////////////////////////////////////////////// Exporting as PDF ///////////////////////////////////////////////////////

        public bool exportDtatTableToPdfSTOCK(DataGridView datagridviewstock, String v)
        {

            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            PdfPTable pdftable = new PdfPTable(datagridviewstock.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            foreach (DataGridViewColumn column in datagridviewstock.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                pdftable.AddCell(cell);

            }

            foreach (DataGridViewRow row in datagridviewstock.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {

                    pdftable.AddCell(new Phrase(cell.ToString(), text));
                    
                }
            }


            var savefiledialoge = new System.Windows.Forms.SaveFileDialog();
            savefiledialoge.FileName = v;
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
