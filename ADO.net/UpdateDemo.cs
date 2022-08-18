using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace ADO.net
{
    static class dbconnect
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return con;
        }
    }
    class UpdateDemo
    {
        static void Main(string[] args)
        {
            SqlConnection con = dbconnect.GetConnection();
            Console.WriteLine("Enter id,marks");
            int Sid = int.Parse(Console.ReadLine());
            string Sname = Console.ReadLine();
            int marks = int.Parse(Console.ReadLine());
            SqlCommand cmd = new SqlCommand("update student set Sname = @nm  where Sid= @id ", con);
            cmd.Parameters.AddWithValue("@id", Sid);
            cmd.Parameters.AddWithValue("@nm", Sname);
            cmd.Parameters.AddWithValue("@mk", marks);
            
            int i=cmd.ExecuteNonQuery();
            if (i > 0)
               Console.WriteLine("Record updated");

        }
    }
}
