using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

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

        static string myid2 = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;


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
    }
}
