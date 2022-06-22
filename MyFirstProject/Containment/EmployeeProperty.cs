using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    class EmployeeProperty
    {
        private int id;
        private string name;
        private double salary;

        public int EId
        {
            get { return id; }
            set { id = value; }
        }
        public string Ename
        {
            get { return name; }
            set { name = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        static void Main(string[] args)
        {
            EmployeeProperty e = new EmployeeProperty();
            e.EId = 1;
            e.Ename = "Bhagyashri";
            e.Salary = 35000.0;
            int number = e.EId;
            Console.WriteLine(number);

            Console.WriteLine(e.Ename + " " + e.Salary);
        }
    }
}
