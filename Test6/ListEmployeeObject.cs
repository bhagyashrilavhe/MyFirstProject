using System;
using System.Collections.Generic;
using System.Text;

namespace Test6
{
    // WAP to create a class Employee with(name,department,salary).Now create and add Employee objects elements to List.Print List.

    class Empp
    {
        string name;
        string department;
        int salary;

        public Empp(string name,string department, int salary)
        {
            this.name = name;
            this.department = department;
            this.salary = salary;
        }
        public override string ToString()
        {
            return "  Name : " + name + "     Department : " + department + "   Salary : " + salary;
        }

        public string Name { get => name; set => name = value; }
        public string Department { get => department; set => department = value; }
        public int Salary { get => salary; set => salary = value; }
    }
    class ListEmployeeObject
    {
        static void Main(string[] args)
        {
            List<Empp> lst = new List<Empp>();
            lst.Add(new Empp("Bhagyashri","IT ",50000));
            lst.Add(new Empp("Jyoti", "Sales ", 30000));
            lst.Add(new Empp("Sam", "Testing ",45000));
            lst.Add(new Empp("Supriya","HR ", 67000));
            lst.Add(new Empp("Priya", "Finance ",40000));

            foreach (Object ob in lst)
            {
                Console.WriteLine(ob);
            }
        }
    }
}
