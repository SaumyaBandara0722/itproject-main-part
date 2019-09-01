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
    class CustomerClass
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string PhoneNumber { get; set; }


        static string mylali2 = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;


        public DataTable Select()
        {
            SqlConnection c1 = new SqlConnection(mylali2);
            DataTable d1 = new DataTable();

            try
            {
                string s1 = "SELECT * FROM Customers";

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



        public bool Insert(CustomerClass c)
        {
            bool isSuccess = false;

            SqlConnection c1 = new SqlConnection(mylali2);

            try
            {
               string s = "INSERT INTO Customers(CustomerName, CustomerAddress, PhoneNumber) VALUES (@CustomerName, @CustomerAddress, @PhoneNumber)";

                SqlCommand c2 = new SqlCommand(s, c1);
                 
                c2.Parameters.AddWithValue("@CustomerName", c.CustomerName);
                c2.Parameters.AddWithValue("@CustomerAddress", c.CustomerAddress);
                c2.Parameters.AddWithValue("@PhoneNumber", c.PhoneNumber);

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


        public bool Update(CustomerClass c)
        {
            bool isSuccess = false;

            SqlConnection c1 = new SqlConnection(mylali2);

            try
            {
                string s = "UPDATE Customers SET CustomerName=@CustomerName, CustomerAddress=@CustomerAddress, PhoneNumber=@PhoneNumber WHERE CustomerID=@CustomerID";
                SqlCommand c2 = new SqlCommand(s, c1);

                c2.Parameters.AddWithValue("@CustomerName", c.CustomerName);
                c2.Parameters.AddWithValue("@CustomerAddress",c.CustomerAddress);
                c2.Parameters.AddWithValue("@PhoneNumber", c.PhoneNumber);
                c2.Parameters.AddWithValue("@CustomerID", c.CustomerID);
            

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

        public bool Delete(CustomerClass c)
        {
            bool isSuccess = false;

            SqlConnection c1 = new SqlConnection(mylali2);

            try
            {
              
                string s1 = "DELETE FROM Customers WHERE CustomerID=@CustomerID";

                SqlCommand c2 = new SqlCommand(s1, c1);

                c2.Parameters.AddWithValue("@CustomerID", c.CustomerID);

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
