using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainAdminAttendance
{
    class AdminReport
    {
        
        static string myConnectionString = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myConnectionString);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT EmpID,date,inTime,outTime  FROM Attendance";
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
    }
}
