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
    class LoanClass
    {
        public int EmpID { get; set; }
        public int LoanID { get; set; }
        public string EmpName { get; set; }
        public string EmpDepartment { get; set; }
        public double BasicSalary { get; set; }
        public double LoanAmount { get; set; }
        public double Installment { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        static string myConnString = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myConnString);
            DataTable dataTable = new DataTable();

            try
            {
                string sql = "SELECT * FROM Loans";
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

        public bool Insert(LoanClass loan)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myConnString);

            try
            {
                string sql = "INSERT INTO Loans(EmpID, EmpName, EmpDepartment, BasicSalary, LoanAmount, Installment, StartDate, EndDate) VALUES(@EmpID, @EmpName, @EmpDepartment, @BasicSalary, @LoanAmount, @Installment, @StartDate, @EndDate)";
                SqlCommand sqlCommand = new SqlCommand(sql, conn);

                sqlCommand.Parameters.AddWithValue("@EmpID", loan.EmpID);
                sqlCommand.Parameters.AddWithValue("@EmpName", loan.EmpName);
                sqlCommand.Parameters.AddWithValue("@EmpDepartment", loan.EmpDepartment);
                sqlCommand.Parameters.AddWithValue("@BasicSalary", loan.BasicSalary);
                sqlCommand.Parameters.AddWithValue("@LoanAmount", loan.LoanAmount);
                sqlCommand.Parameters.AddWithValue("@Installment", loan.Installment);
                sqlCommand.Parameters.AddWithValue("@StartDate", loan.StartDate);
                sqlCommand.Parameters.AddWithValue("@EndDate", loan.EndDate);

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

        public bool Update(LoanClass loan)
        {
            bool isSuccess = false;

           SqlConnection conn = new SqlConnection(myConnString);

            try
            {
                string sql = "UPDATE Loans SET LoanAmount=@LoanAmount, Installment=@Installment, EndDate=@EndDate WHERE LoanID=@LoanID";

                SqlCommand sqlCommand = new SqlCommand(sql, conn);

                sqlCommand.Parameters.AddWithValue("@LoanAmount", loan.LoanAmount);
                sqlCommand.Parameters.AddWithValue("@Installment", loan.Installment);
                sqlCommand.Parameters.AddWithValue("@EndDate", loan.EndDate);
                sqlCommand.Parameters.AddWithValue("@LoanID", loan.LoanID);

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

        public bool Delete(LoanClass loan)
        {
            bool isSuccess = false;

           SqlConnection conn = new SqlConnection(myConnString);

            try
            {
                string sql = "DELETE FROM Loans WHERE LoanID=@LoanID";

                SqlCommand sqlCommand = new SqlCommand(sql, conn);

                sqlCommand.Parameters.AddWithValue("@LoanID", loan.LoanID);

                conn.Open();

                int rows = sqlCommand.ExecuteNonQuery(); 

                if(rows > 0)
                {
                    isSuccess = true;
                } else
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
