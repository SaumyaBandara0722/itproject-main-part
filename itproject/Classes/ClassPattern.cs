using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace itproject.Classes
{
    class ClassPattern
    {
        public int Pid { get; set; }
        public string PatternID { get; set; }
        public string PatternName { get; set; }
        public double unitPrice { get; set; }
        public string Description { get; set; }

        static string myid = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

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


        public bool Delete(ClassPattern y)
        {
            bool isSuccess = false;

            SqlConnection conn1 = new SqlConnection(myid);

            try
            {

                string sql1 = "DELETE FROM Patterns WHERE Pid=@Pid";

                SqlCommand cmd1 = new SqlCommand(sql1, conn1);

                cmd1.Parameters.AddWithValue("@Pid",y.Pid);

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
    }
}
