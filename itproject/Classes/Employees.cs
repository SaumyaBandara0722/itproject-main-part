using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itproject.Classes
{
    class Employees
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; }
        public DateTime JoinedDate {get; set;}
        public double BasicSalary { get; set; }
        public double TransportAllowance { get; set; }

        static string myConnStrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myConnStrng);

            DataTable dataTable = new DataTable();

            try
            {
                string sql = "SELECT * FROM Employees";

                SqlCommand sqlCommand = new SqlCommand(sql, conn);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                conn.Open();
                sqlDataAdapter.Fill(dataTable);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return dataTable;
        }

        public bool insert(Employees e)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myConnStrng);

            try
            {
                string sql = "INSERT INTO Employees(EmpID, EmpName, EmpAddress, EmpPhone, EmpDepartment, JoinedDate, BasicSalary, TransportAllowance) VALUES (@EmpID, @EmpName, @EmpAddress, @EmpPhone, @EmpDepartment, @JoinedDate, @BasicSalary, @TransportAllowance)";

                SqlCommand sqlCommand = new SqlCommand(sql, conn);

                sqlCommand.Parameters.AddWithValue("@EmpID", e.EmpID);
                sqlCommand.Parameters.AddWithValue("@EmpName", e.Name);
                sqlCommand.Parameters.AddWithValue("@EmpAddress", e.Address);
                sqlCommand.Parameters.AddWithValue("@EmpPhone", e.Phone);
                sqlCommand.Parameters.AddWithValue("@EmpDepartment", e.Department);
                sqlCommand.Parameters.AddWithValue("@JoinedDate", e.JoinedDate.Date);
                sqlCommand.Parameters.AddWithValue("@BasicSalary", e.BasicSalary);
                sqlCommand.Parameters.AddWithValue("@TransportAllowance", e.TransportAllowance);

                conn.Open();

                int rows = sqlCommand.ExecuteNonQuery(); 

                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool Update(Employees e)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myConnStrng);

            try
            {
                string sql = "UPDATE Employees SET EmpName=@EmpName, EmpAddress=@EmpAdress, EmpPhone=@EmpPhone, EmpDepartment=@EmpDepartment, BasicSalary=@BasicSalary, TransportAllowance=@TransportAllowance WHERE EmpID=@EmpID";

                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                
                sqlCommand.Parameters.AddWithValue("@EmpName", e.Name);
                sqlCommand.Parameters.AddWithValue("@EmpAddress", e.Address);
                sqlCommand.Parameters.AddWithValue("@EmpPhone", e.Phone);
                sqlCommand.Parameters.AddWithValue("@EmpDepartment", e.Department);
                sqlCommand.Parameters.AddWithValue("@BasicSalary", e.BasicSalary);
                sqlCommand.Parameters.AddWithValue("@TransportAllowance", e.TransportAllowance);
                sqlCommand.Parameters.AddWithValue("@EmpID", e.EmpID);

                conn.Open();


                int rows = sqlCommand.ExecuteNonQuery();

                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool Delete(Employees e)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myConnStrng);

            try
            {
                string sql = "DELETE FROM Employees WHERE EmpID=@EmpID";

                SqlCommand sqlCommand = new SqlCommand(sql, conn);

                sqlCommand.Parameters.AddWithValue("@EmpID", e.EmpID);

                conn.Open();

                int rows = sqlCommand.ExecuteNonQuery();

                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
    }
}
