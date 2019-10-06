using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management
{
    class AttendanceClass
    {

        public int AttendId;

        public int EmployeeId;

        public string Date;

        public string ArrivedTime;

        public string LeftTime;



        static string myConnectionString = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public bool Insert(AttendanceClass a)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myConnectionString);

            try
            {
                string sql = "INSERT INTO Attendance(EmpID,date,inTime) VALUES (@EmpID,@date,@inTime)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@AttendID", a.AttendId);
                cmd.Parameters.AddWithValue("@EmpID", a.EmployeeId);
                cmd.Parameters.AddWithValue("@date", a.Date);
                cmd.Parameters.AddWithValue("@inTime", a.ArrivedTime);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {

            }
            return isSuccess;
        }


        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myConnectionString);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT AttendID,EmpID,date,inTime,outTime  FROM Attendance";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();

            }
            return dt;
        }
        public DataTable SelectByID(int id)
        {
            SqlConnection conn = new SqlConnection(myConnectionString);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT AttendID,EmpID,date,inTime,outTime  FROM Attendance WHERE AttendID = " + id;
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();

            }
            return dt;
        }

       
        public DataTable SortByID(int sortID)
        {
            SqlConnection conn = new SqlConnection(myConnectionString);
           
            DataTable dt = new DataTable();

            try
            {
               // SqlDataAdapter adapter = new SqlDataAdapter("SELECT AttendID,EmpID,date,inTime,outTime FROM Attendance WHERE AttendID = " + sortID);
                string sql = "SELECT EmpID,date,inTime,outTime  FROM Attendance WHERE EmpID = " + sortID;
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd);
                conn.Open();
                adapter2.Fill(dt);

                

               // return dt;

            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();

            }
            return dt;
        }

        public DataTable SortByDate(string date)
        {
            SqlConnection conn = new SqlConnection(myConnectionString);

            DataTable dt = new DataTable();

            try
            {
                // SqlDataAdapter adapter = new SqlDataAdapter("SELECT AttendID,EmpID,date,inTime,outTime FROM Attendance WHERE AttendID = " + sortID);
                string sql = "SELECT EmpID,date,inTime,outTime  FROM Attendance WHERE date = '" + date + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd);
                conn.Open();
                adapter2.Fill(dt);



                // return dt;

            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();

            }
            return dt;
        }

        public DataTable SortByIDDate(String month,String year)
        {

            String sampleDate = month + "-" + year;

            SqlConnection conn = new SqlConnection(myConnectionString);
            DataTable dt = new DataTable();

            try
            {
                String mystring = "SELECT EmpID,date,inTime,outTime FROM Attendance WHERE date LIKE '%" + sampleDate + "'";
                SqlCommand cmd = new SqlCommand(mystring, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();

            }
            return dt;
        }

        public bool Update(AttendanceClass a,int id,String minutes)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myConnectionString);

            try
            {
                string sql = "UPDATE Attendance SET EmpID=@EmpID,date=@date,inTime=@inTime,outTime=@outTime,hoursWorked=@workedTime WHERE AttendID=@AttendID";
                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@EmpID", a.EmployeeId);
                cmd.Parameters.AddWithValue("@date", a.Date);
                cmd.Parameters.AddWithValue("@inTime", a.ArrivedTime);
                cmd.Parameters.AddWithValue("@outTime", a.LeftTime);
                cmd.Parameters.AddWithValue("@AttendID", id);
                cmd.Parameters.AddWithValue("@workedTime", Int32.Parse(minutes));


                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;

                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool Delete(int id)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myConnectionString);

            try
            {
                string sql = "DELETE FROM Attendance WHERE AttendID=@AttendID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@AttendID", id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;

                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

     
        public bool createPDF(DataTable dataTable, string destinationPath)
        {
            try
            {
                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(destinationPath, FileMode.Create));
                document.Open();

                PdfPTable table = new PdfPTable(dataTable.Columns.Count);
                table.WidthPercentage = 100;

                //Set columns names in the pdf file
                for (int k = 0; k < dataTable.Columns.Count; k++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(dataTable.Columns[k].ColumnName));

                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                    cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
                    //cell.BackgroundColor = new iTextSharp.text.BaseColor(51, 102, 102);

                    table.AddCell(cell);
                }

                //Add values of DataTable in pdf file
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(dataTable.Rows[i][j].ToString()));

                        //Align the cell in the center
                        cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                        cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;

                        table.AddCell(cell);
                    }
                }

                document.Add(table);
                document.Close();


                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


    }
}







