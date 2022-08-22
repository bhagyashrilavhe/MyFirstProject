using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ADO.net.AdoDotNetTest
{
    // Write a C# program to read data from database and display (Disconnected architecture)?
    class DisconnectedArchDBDisp
    {
        public static DataSet getAllEmployee()
        {
            SqlConnection conn = null;

            conn = DBconnected.GetConnection();

            SqlDataAdapter sda = new SqlDataAdapter("Select * from empp", conn);
            DataSet ds = new DataSet();

            sda.Fill(ds, "empp");

            return ds;
        }
        static void Main(string[] args)
        {

            DataSet ds = getAllEmployee();
            foreach (DataRow dr in ds.Tables["empp"].Rows)
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]);
            }
        }
    }
}
