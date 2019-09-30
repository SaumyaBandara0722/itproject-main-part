using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management.Classes
{
    public class DatabaseHelper
    {
       

        public DatabaseHelper()
        {
           
        }
        
        public bool insert(string id,string date,int hours,string department,string description)
        {
            string conn = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            bool isSuccess = false;
            SqlConnection c = new SqlConnection(conn);
            DataTable dt = new DataTable();

            try
            {
                string sql = "INSERT INTO LeaveRequests(EmpID,Date,LeaveHours,Description,Department) VALUES(@EmpID,@Date,@LeaveHours,@Description,@Department)";

                SqlCommand cmd = new SqlCommand(sql, c);
                cmd.Parameters.AddWithValue("@EmpID", id);
                cmd.Parameters.AddWithValue("@LeaveHours", hours);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Department", department);
                cmd.Parameters.AddWithValue("@Date", date);

                c.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception )
            {

            }
            finally
            {
                c.Close();
            }
            return isSuccess;
            
        }

        public DataTable Select()
        {
            string conn = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            SqlConnection c = new SqlConnection(conn);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT ReqID,EmpID,Date,LeaveHours,Description,Department,Status FROM LeaveRequests";
                SqlCommand cmd = new SqlCommand(sql,c);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                c.Open();
                adapter.Fill(dt);
            }
            catch(Exception e)
            {

            }
            finally
            {
                c.Close();
            }
            return dt;
        }
        public int getRequestId(int id)
        {

            int count = 0;
            DataTable dt = Select();
            foreach (DataRow row in dt.Rows)
            {
                int name = int.Parse(row["ReqID"].ToString());
                if (count == id)
                {
                    return name;
                }
                count++;
            }

            return 0;
        }
        public int getRequestIdWhenSearching(string Eid,int position)
        {

            int count = 0;
            DataTable dt = Select();
            foreach (DataRow row in dt.Rows)
            {
                string name = row["EmpID"].ToString();
                if(name.Equals(Eid))
                {
                    if (count == position)
                    {
                        return int.Parse(row["ReqID"].ToString());
                    }
                    count++;
                }
               
            }

            return 0;
        }
        public bool deleteRow(int id)
        {
            string conn = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            SqlConnection c = new SqlConnection(conn);
          

            try
            {
                
                string sql = "DELETE FROM LeaveRequests WHERE ReqID = @ReqID";

                SqlCommand cmd = new SqlCommand(sql, c);
                cmd.Parameters.AddWithValue("@ReqID", id);
        
                c.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception e)
            {

            }
            finally
            {
                c.Close();
            }
            return false;
        }
        public int getNumberOfRows()
        {
            int count = 0;
            DataTable dt = Select();
            foreach (DataRow row in dt.Rows)
            {
                count++;
            }

            return count;
        }
        public DataTable search(string id)
        {
            string conn = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            SqlConnection c = new SqlConnection(conn);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT ReqID,EmpID,Date,LeaveHours,Description,Department,Status FROM LeaveRequests WHERE EmpID = '" + id + "'";
                SqlCommand cmd = new SqlCommand(sql, c);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                c.Open();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {

            }
            finally
            {
                c.Close();
            }
            return dt;
        }
        public DataTable getRequestDetails(int id)
        {
            string conn = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            SqlConnection c = new SqlConnection(conn);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT ReqID,EmpID,Date,LeaveHours,Description,Department,Status FROM LeaveRequests WHERE ReqID = '" + id + "'";
                SqlCommand cmd = new SqlCommand(sql, c);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                c.Open();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {

            }
            finally
            {
                c.Close();
            }
            return dt;
        }
        public bool update(int id,string empid,string date,string department,string description,int hours)
        {
            string conn = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            bool isSuccess = false;
            SqlConnection c = new SqlConnection(conn);
            DataTable dt = new DataTable();

            try
            {
                string sql = "UPDATE LeaveRequests SET EmpID = @EmpID,LeaveHours = @LeaveHours,Date = @Date, Description = @Description, Department = @Department WHERE ReqID = " + id;

                SqlCommand cmd = new SqlCommand(sql, c);
                cmd.Parameters.AddWithValue("@EmpID", empid);
                cmd.Parameters.AddWithValue("@LeaveHours", hours);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Department", department);
                cmd.Parameters.AddWithValue("@Date", date);

                c.Open();
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
                c.Close();
            }
            return isSuccess;
        }

      


    }
}
