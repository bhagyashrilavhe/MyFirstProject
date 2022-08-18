using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace ADO.net
{
    class SelectDemo
    {
        static void Main(string[] args)
        {
            string str = "server=DESKTOP-IGG1K0T\\SQLEXPRESS;Database=HR;Integrated Security=True";
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(str);
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("select Sid,Sname,marks from Student", con);
                SqlDataReader dr = sqlCommand.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine("Id = " + dr[0] +  "  Name = "+dr["Sname"] + "  Marks  = " + dr["marks"]);
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
