using System;
using System.Collections.Generic;
using System.Text;

namespace Test6
{
 // WAP to create SortedList<Employee,stringg>where key is of Employee type and value is
 //departmentname(string) he works in. SortedList should maintain data in descending order of salary.
    class Employee: IComparable<Employee>
    {
        int eno;
        string name;
        int salary;

        public Employee(int eno, string name, int salary)
        {
            this.eno = eno;
            this.name = name;
            this.salary = salary;
        }
        public int CompareTo(Employee other)
        {
            return this.salary.CompareTo(other.salary);
        }

        public override string ToString()
        {
            return " Eno : " + eno + "  Name : " + name + "  Salary : " + salary;
        }

        public int Eno { get => eno; set => eno = value; }
        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }

        
    }
    class EmployeeSortedList
    {
        static void Main(string[] args)
        {
            SortedList<Employee, string> sl = new SortedList<Employee,string>();

            sl.Add(new Employee(6, "Kartik", 67000), "HR");
            sl.Add(new Employee(4, "Omkar", 30000), "IT");
            sl.Add(new Employee(1, "Karan", 45000), "Testing");
            sl.Add(new Employee(3, "Tushar", 35000), "Finance");
            sl.Add(new Employee(2, "Prashant", 50000), "Sales");
            sl.Add(new Employee(7, "Sagar", 60000), "Testing");


            for (int i = 0; i < sl.Count; i++)
            {
                Console.WriteLine(sl.Keys[i] + " ==> " + sl.Values[i]);
            }

            /*foreach (KeyValuePair<Employee, string> kv in sl)
            {
                Console.WriteLine(kv.Key + "  ==>  " + kv.Value);
            }*/
        }
    }
}
