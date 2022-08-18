using System;
using System.Collections.Generic;
using System.Text;

namespace Test6
{
//WAP to add user defined objects of type Employee in a HashSet employee object.Make sure if I create
//2 different objects with samedata the other one should not be added as hashset stores unique objects.
    class Empp1
    {
        string name;
        string department;
        int salary;

        public Empp1(string name, string department, int salary)
        {
            this.name = name;
            this.department = department;
            this.salary = salary;
        }

        public override bool Equals(object obj)
        {
            return obj is Empp1 employee &&
                  name == employee.name &&
                  department == employee.department &&
                  salary == employee.salary;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, department, salary);
        }
        public override string ToString()
        {
            return "  Name : " + name + "     Department : " + department + "   Salary : " + salary;
        }

        public string Name { get => name; set => name = value; }
        public string Department { get => department; set => department = value; }
        public int Salary { get => salary; set => salary = value; }
    }
    class HashSetEx
    {
        static void Main(string[] args)
        {
            HashSet<Empp1> hs = new HashSet<Empp1>();
            hs.Add(new Empp1("Bhagyashri", "IT ", 50000));
            hs.Add(new Empp1("Jyoti", "Sales ", 30000));
            hs.Add(new Empp1("Sam", "Testing ", 45000));
            hs.Add(new Empp1("Supriya", "HR ", 67000));
            hs.Add(new Empp1("Priya", "Finance ", 40000));

            foreach(Empp1 e in hs)
            {
                Console.WriteLine(e);
            }

            


        }
    }
}
