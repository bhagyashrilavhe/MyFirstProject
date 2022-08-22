using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ADO.net.AdoDotNetTest
{
// Write a C# program to add a record to database? Accept data from console and insert.(Disconnected architecture)?
    class DisconnectedArchInserted
        
    {
            static SqlDataAdapter sda = null;
            static DataSet ds = null;
            public static DataSet getAllEmployee()
            {
                SqlConnection con = null;

                con = DBconnected.GetConnection();

                sda = new SqlDataAdapter("select * from empp", con);
                
                sda.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                ds = new DataSet();
                sda.Fill(ds);


                return ds;
            }

            static public void AddEmployee()
            {
                Console.WriteLine("Enter eid,ename,mobile");
                int eid = int.Parse(Console.ReadLine());
                string ename = Console.ReadLine();
                string mobile = Console.ReadLine();

                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                DataRow dr = ds.Tables[0].NewRow();
                dr[0] = eid;
                dr[1] = ename;
                dr[2] = mobile;
                ds.Tables[0].Rows.Add(dr);

            }

            public static void showAllEmployee()
            {
                getAllEmployee();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]);
                }
            }
            static void Main(string[] args)
            {
                getAllEmployee();
                AddEmployee();
                sda.Update(ds);
                showAllEmployee();

            }
        
    }
}
