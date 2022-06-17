using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    class Employee
    {
        int id;
        string name;
        int salary;

        public Employee(int eid,string ename,int esalary)
        {
            //initilization of instance variable
            id = eid;
            name = ename;
            salary = esalary;
        }

        public void Display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }


        static void Main(String[] args)
        {
            Employee e = new Employee(101, "Bhagyashri", 40000);
            e.Display();
        }
    }
}
