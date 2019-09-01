using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itproject
{
    class OrderClass
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public String PatternID { get; set; }
        public int Quantity { get; set; }

        public DateTime  OrderDate { get; set; }

        public DateTime ExpectedDate { get; set; }

        static string mylali = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;



        public DataTable Select()
        {
            SqlConnection c1 = new SqlConnection(mylali);
            DataTable d1 = new DataTable();

            try
            {
                string s1 = "SELECT * FROM Orders";

                SqlCommand c2 = new SqlCommand(s1, c1);

                SqlDataAdapter adapter = new SqlDataAdapter(c2);

                c1.Open();

                adapter.Fill(d1);
            }

            catch (Exception)
            {

            }

            finally
            {
                c1.Close();
            }
            return d1;
        }



        public bool Insert(OrderClass o)
        {
            bool isSuccess = false;

            SqlConnection c1 = new SqlConnection(mylali);

            try
            {
                string s = "INSERT INTO Orders(CustomerID, PatternID, Quantity, OrderDate, ExpectedDate) VALUES(@CustomerID, @PatternID, @Quantity, @OrderDate, @ExpectedDate)";

                SqlCommand c2 = new SqlCommand(s, c1);

             //   c2.Parameters.AddWithValue("@OrderID",o.OrderID);
                c2.Parameters.AddWithValue("@CustomerID", o.CustomerID);
                c2.Parameters.AddWithValue("@PatternID", o.PatternID);
                c2.Parameters.AddWithValue("@Quantity", o.Quantity);
                c2.Parameters.AddWithValue("@OrderDate", o.OrderDate);
                c2.Parameters.AddWithValue("@ExpectedDate", o.ExpectedDate);

                c1.Open();

                int rows = c2.ExecuteNonQuery();

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
                c1.Close();
            }

            return isSuccess;
        }


        public bool Update(OrderClass o)
        {
            bool isSuccess = false;

            SqlConnection c1 = new SqlConnection(mylali);

            try
            {
                string s = "UPDATE Orders SET CustomerID=@CustomerID , PatternID=@PatternID, Quantity=@Quantity, OrderDate=@OrderDate, ExpectedDate=@ExpectedDate WHERE OrderID=@OrderID";
                SqlCommand c2 = new SqlCommand(s, c1);

                c2.Parameters.AddWithValue("@CustomerID", o.CustomerID);
                c2.Parameters.AddWithValue("@PatternID", o.PatternID);
                c2.Parameters.AddWithValue("@Quantity", o.Quantity);
                c2.Parameters.AddWithValue("@OrderDate", o.OrderDate);
                c2.Parameters.AddWithValue("@ExpectedDate", o.ExpectedDate);
                c2.Parameters.AddWithValue("@OrderID", o.OrderID);

                c1.Open();

                int rows = c2.ExecuteNonQuery();

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
                c1.Close();
            }
            return isSuccess;
        }

        public bool Delete(OrderClass o)
        {
            bool isSuccess = false;

            SqlConnection c1 = new SqlConnection(mylali);

            try
            {

                string s1 = "DELETE FROM Orders WHERE OrderID=@OrderID";

                SqlCommand c2 = new SqlCommand(s1, c1);

                c2.Parameters.AddWithValue("@OrderID",o.OrderID);

                c1.Open();

                int rows = c2.ExecuteNonQuery();

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
                c1.Close();
            }
            return isSuccess;
        }


    }

}

       
    
