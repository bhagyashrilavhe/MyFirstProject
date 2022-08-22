using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AdoDotNetTest
{
    class ConnectedArchDatabaseDisp
    {
        static void Main(string[] args)
        {
            string str = "server=DESKTOP-IGG1K0T\\SQLEXPRESS;Database=HR;Integrated Security=True";
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(str);
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("select first_name,salary from employees", con);
                SqlDataReader dr = sqlCommand.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine("Name = " + dr["first_name"] + "   Salary  = " + dr[1]);
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
