using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace ADO.net.AdoDotNetTest
{
    // Write a C# program to delete a record ?(Connected architecture)?
    static class Dbconnected
    {
        public static SqlConnection GetConnection()
        {
            string str = "server=DESKTOP-IGG1K0T\\SQLEXPRESS;Database=ThinkQPortal;Integrated Security=True";
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(str);
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return conn;
        }
    }
    class ConnectedArchDeleteRe
    {
        static void Main(string[] args)
        {
            SqlConnection conn = Dbconnected.GetConnection();

            Console.WriteLine("Enter rollno,sname,age,addr,dob,mobileno");
            int rollno = int.Parse(Console.ReadLine());
            string sname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string addr = Console.ReadLine();
            string dob = Console.ReadLine();
            string mobileno = Console.ReadLine();

            SqlCommand cmd = new SqlCommand("delete from stud where rollno = @rollno", conn);
            cmd.Parameters.AddWithValue("@rollno", rollno);
            cmd.Parameters.AddWithValue("@sname", sname);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@addr", addr);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@mobileno", mobileno);

            int i = cmd.ExecuteNonQuery();

            if (i > 0)
                Console.WriteLine("Record Deleted Successfully");
        }
    }
}
