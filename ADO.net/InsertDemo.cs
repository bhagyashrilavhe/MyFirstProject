using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace ADO.net
{
    static class DBconnect
    {
        public static SqlConnection GetConnection()
        {
            string str = "server=DESKTOP-IGG1K0T\\SQLEXPRESS;Database=HR;Integrated Security=True";
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(str);
                con.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return con;
        }
    }
    class InsertDemo
    {
        static void Main(string[] args)
        {
            SqlConnection con = DBconnect.GetConnection();
            Console.WriteLine("Enter id,nm,marks");
            int rollno = int.Parse(Console.ReadLine());
            string nm = Console.ReadLine();
            int marks = int.Parse(Console.ReadLine());
            SqlCommand cmd = new SqlCommand("insert into student values( @id, @nm, @mk)", con);
            cmd.Parameters.AddWithValue("@id", rollno);
            cmd.Parameters.AddWithValue("@nm", nm);
            cmd.Parameters.AddWithValue("@mk", marks);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                Console.WriteLine("Record inserted");

        }
    }
}
