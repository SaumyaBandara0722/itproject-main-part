using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itproject.ProjectAndTaskClasses
{
    class ProjectAndTaskClass
    {
     //Getter and Setter properties
        //Act as data carrier in our application
        public int ProjectID { get; set; }
        public int OrderID { get; set; }
        public string PatternID { get; set; }
        public int NeededQty { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime DeadlineDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        ///Selecting Data from database
        public DataTable Select()
        {
            //step1 : Database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //step2 : writing Sql quary
                string sql = "SELECT * FROM Projects_Tasks";
                //string sql = "SELECT pt.ProjectID, pt.OrderID, pt.AddedDate, pt.DeadlineDate, pt.Description, pt.Status, o.PatternID, o.NeededQty FROM Projects_Tasks pt, Order o";


                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                

                //Creating SQL dataAdapter using cmd
                SqlDataAdapter dataAdap = new SqlDataAdapter(cmd);
               
                conn.Open();
                dataAdap.Fill(dt);
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

        ///Inserting data into data base
        public bool Insert(ProjectAndTaskClass ptc)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //step1 : Database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //step2 : writing Sql quary to insert data
                string sql = "INSERT INTO Projects_Tasks (OrderID, AddedDate, DeadlineDate, Description, Status,PatternID,NeededQty) VALUES (@OrderID, @AddedDate, @DeadlineDate, @Description, @Status, @PatternID, @NeededQty)";
                //string sql2 = "INSERT INTO Projects_Tasks p (p.OrderID) FROM Orders o WHERE o.OrderID = p.OrderID VALUES (@OrderID)";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //SqlCommand cmd2 = new SqlCommand(sql2, conn);
                //create parameters to add data
                cmd.Parameters.AddWithValue("@OrderID", ptc.OrderID);
                cmd.Parameters.AddWithValue("@AddedDate", ptc.AddedDate);
                cmd.Parameters.AddWithValue("@DeadlineDate", ptc.DeadlineDate);
                cmd.Parameters.AddWithValue("@Description", ptc.Description);
                cmd.Parameters.AddWithValue("@Status", ptc.Status);
                cmd.Parameters.AddWithValue("@PatternID", ptc.PatternID);
                cmd.Parameters.AddWithValue("@NeededQty", ptc.NeededQty);

                //Open Database connection hear
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //If the quary runs successfully the value of rows will be grater than zero and else its value will be 0
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

        //Method to update data in database from using our application
        public bool Update(ProjectAndTaskClass ptc)
        {

            //Create a default return type and set its default value to false 
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //SQl to update data in database
                string sql = "UPDATE Projects_Tasks SET AddedDate=@AddedDate, DeadlineDate=@DeadlineDate, Description=@Description, Status=@Status WHERE ProjectID=@ProjectID";

                //Creating SQL command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create parameters to add values
                //cmd.Parameters.AddWithValue("@OrderID", ptc.OrderID);
                cmd.Parameters.AddWithValue("@AddedDate", ptc.AddedDate);
                cmd.Parameters.AddWithValue("@DeadlineDate", ptc.DeadlineDate);
                cmd.Parameters.AddWithValue("@Description", ptc.Description);
                cmd.Parameters.AddWithValue("@Status", ptc.Status);
                cmd.Parameters.AddWithValue("ProjectID", ptc.ProjectID);

                //Open Database connection hear
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //If the quary runs successfully the value of rows will be grater than zero and else its value will be 0
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

        //Method to delete data from our database
        public bool Delete(ProjectAndTaskClass ptc)
        {

            //Create a default return typr and set its value to false
            bool isSuccess = false;

            //Create SQL connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //SQL to delete data
                string sql = "DELETE FROM Projects_Tasks WHERE ProjectID = @ProjectID";

                //Creating SQL command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProjectID", ptc.ProjectID);

                //Open the database connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //If the quary runs successfully the value of rows will be grater than zero and else its value will be 0
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
                conn.Close();
            }
            return isSuccess;
        }
        
    }
}
