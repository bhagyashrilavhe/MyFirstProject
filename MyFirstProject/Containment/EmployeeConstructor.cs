using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    class Department
    {
        int did;
        string dname;

        public Department(int did,string dname)
        {
            this.did = did;
            this.dname = dname;
        }
        public void show()
        {
            Console.WriteLine(did + " " + dname);
        }
    }
    class EmployeeConstructor
    {
        int eid;
        string name;
        Department dept;

        EmployeeConstructor(int eid,string name,Department dept)
        {
            this.eid = eid;
            this.name = name;
            this.dept = dept;
        }

        void display()
        {
            Console.WriteLine(eid + " " + name);
            dept.show();
        }

        static void Main(string [] args)
        {
            EmployeeConstructor e = new EmployeeConstructor(1, "Priya", new Department(101, "HR"));
            e.display();
        }
    }
}
