using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace ADO.net.Assignment03_09_22
{
    class DeleteConn
    {
        
        
            static void Main(string[] args)
            {
                SqlConnection conn = DBCONNECT.GetConnection();

                Console.WriteLine("Enter CourseId,CourseName,Fees,Duration");
                int CourseID = int.Parse(Console.ReadLine());
                string CourseName = Console.ReadLine();
                int Fees = int.Parse(Console.ReadLine());
                string Duration = Console.ReadLine();

                SqlCommand cmd = new SqlCommand("delete from course where CourseId = @CourseId", conn);

                cmd.Parameters.AddWithValue("@CourseID", CourseID);
                cmd.Parameters.AddWithValue("@CourseName", CourseName);
                cmd.Parameters.AddWithValue("@Fees", Fees);
                cmd.Parameters.AddWithValue("@Duration", Duration);
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                    Console.WriteLine("Record Deleted Successfully");
            }
        
    }
}
