using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace ADO.net.Assignment03_09_22
{
    class SelectConn
    {
        static void Main(string[] args)
        {
            string str = "server=DESKTOP-IGG1K0T\\SQLEXPRESS;Database=TQ;Integrated Security=True";
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(str);
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("select CourseId,CourseName,Fees,Duration from Course", con);
                SqlDataReader dr = sqlCommand.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine("CourseId = " + dr[0] + "  CourseName = " + dr["CourseName"] + "  Fees  = " + dr["Fees"] + "  Duration  = " + dr["Duration"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
    }
}
