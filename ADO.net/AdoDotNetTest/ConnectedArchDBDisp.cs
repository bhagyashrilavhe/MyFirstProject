using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace ADO.net.AdoDotNetTest
{
    // Write a C# program to read data from database and display(Connected architecture)?
    class ConnectedArchDBDisp
    {
        static void Main(string[] args)
        {
            string str = "server=DESKTOP-IGG1K0T\\SQLEXPRESS;Database=ThinkQPortal;Integrated Security=True";
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("select rollno,sname,age,dob from stud", conn);
                SqlDataReader dr = sqlCommand.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine("RollNo = " + dr[0] + "  Sname  = " + dr[1] + "   Age  = " + dr[2] + "   DOB  = " + dr[3]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
