﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ADO.net
{
    class Disconnected
    {
        public static DataSet getAllStudent()
        {
            SqlConnection con = null;

            con = DBconnect.GetConnection();

            SqlDataAdapter sda = new SqlDataAdapter("Select * from Student", con);
            DataSet ds = new DataSet();//Collection of tables

            sda.Fill(ds, "Student");

            return ds;
        }
        static void Main(string[] args)
        {

            DataSet ds = getAllStudent();
            foreach (DataRow dr in ds.Tables["Student"].Rows)
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]);
            }
        }
    }
   /* class Emp
    {
        public static DataSet getAllEmp()
        {
            SqlConnection con = null;

            con = DBconnect.GetConnection();

            SqlDataAdapter sda = new SqlDataAdapter("Select * from Employee", con);
            DataSet ds = new DataSet();

            sda.Fill(ds, "Employee");

            return ds;
        }
        static void Main(string[] args)
        {

            DataSet ds = getAllEmp();
            foreach (DataRow dr in ds.Tables["Employee"].Rows)
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]);
                
            }
        }
    }*/
}
