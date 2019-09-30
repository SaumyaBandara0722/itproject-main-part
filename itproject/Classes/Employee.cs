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
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Bdy { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Dept { get; set; }
        public string Date { get; set; }
        public double Salary { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //select data from database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                //command to select data
                string sql = "SELECT * from Employees";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //select data of a paticular employee from database and display on data grid
        public DataTable SelectView()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                //command to select data
                string sql = "SELECT TOP 1 * FROM Employees ORDER BY EmpId DESC";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //insert data into database
        public bool Insert(Employee c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //command to insert data
                string sql = "INSERT INTO Employees (EmpName, Bdy, Gender, Address, Phone, Email, Department, JoinedDate, BasicSal) VALUES(@EmpName, @Bdy, @Gender, @Address, @Phone, @Email, @Department, @JoinedDate, @BasicSal)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add data
                cmd.Parameters.AddWithValue("@EmpName", c.EmpName);
                cmd.Parameters.AddWithValue("@Bdy", c.Bdy);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Phone", c.Phone);
                cmd.Parameters.AddWithValue("@Email", c.Email);
                cmd.Parameters.AddWithValue("@Department", c.Dept);
                cmd.Parameters.AddWithValue("@JoinedDate", c.Date);
                cmd.Parameters.AddWithValue("@BasicSal", c.Salary);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfull then the value of rows will be greater than zero else the value will ne 0
                if (rows > 0)
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

        //update data in the database
        public bool Update(Employee c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //command to updata data
                string sql = "UPDATE Employees SET EmpName=@EmpName, Bdy=@Bdy, Gender=@Gender, Address=@Address, Phone=@Phone, Email=@Email, Department=@Department, JoinedDate=@JoinedDate, BasicSal=@BasicSal WHERE EmpId=@EmpId";
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create parameters to add data               
                cmd.Parameters.AddWithValue("@EmpName", c.EmpName);
                cmd.Parameters.AddWithValue("@Bdy", c.Bdy);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Phone", c.Phone);
                cmd.Parameters.AddWithValue("@Email", c.Email);
                cmd.Parameters.AddWithValue("@Department", c.Dept);
                cmd.Parameters.AddWithValue("@JoinedDate", c.Date);
                cmd.Parameters.AddWithValue("@BasicSal", c.Salary);
                cmd.Parameters.AddWithValue("EmpId", c.EmpId);
               
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
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //delete data from database
        public bool Delete(Employee c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //command to delete data
                string sql = "DELETE FROM Employees WHERE EmpId=@EmpId";
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create parameters to delete data
                cmd.Parameters.AddWithValue("@EmpId", c.EmpId);

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
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //Add new department
        public bool InsertDepartment(Employee c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //command to insert data
                string sql = "INSERT INTO Department (depName) VALUES(@depName)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add data
                cmd.Parameters.AddWithValue("@depName", c.Dept);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfull then the value of rows will be greater than zero else the value will ne 0
                if (rows > 0)
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

        //Remove a department
        public bool DeleteDepartment(Employee c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //command to delete data
                string sql = "DELETE FROM Department WHERE depName=@depName";
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create parameters to delete data
                cmd.Parameters.AddWithValue("@depName", c.Dept);

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
            catch (Exception ex)
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
