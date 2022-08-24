using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo.LINQToObject
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Salary} {City} ";
        }
    }
    class EmployeeDemo
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee {Id=1,Name="Bhagyashri",Salary=30000,City="Pune" },
                new Employee {Id=2,Name="Kartik",Salary=40000,City="Mumbai"},
                new Employee {Id=3,Name="Rutuja",Salary=35000,City="Pune"},
                new Employee {Id=4,Name="Omkar",Salary=45000,City="Kolkata"},
                new Employee {Id=5,Name="Sagar",Salary=34000,City="Baramati"},
                new Employee {Id=6,Name="Priya",Salary=44000,City="Pune"},
                new Employee {Id=7,Name="Pratiksha",Salary=55000,City="Mumbai"},
            };

            //LINQ Query

            //1. display all employees
            var result1 = from e in emp
                          select e;

            // 2.display employee with asending order by name
            var result2 = from e in emp
                          orderby e.Name ascending
                          select e;

            // 3.display employee whose salary is > 25000
            var result3 = from e in emp
                          where e.Salary > 25000
                          select e;

            //4.display employee whos from 'Pune' City
            var result4 = from e in emp
                          where e.City == "Pune"
                          select e;

            //5. display employee with desending order by salary
            var result5 = from e in emp
                          orderby e.Salary descending
                          select e;

            //6. display employee whose name start with 'P'
            var result6 = from e in emp
                          where e.Name.StartsWith("P")
                          select e;

            //7. display employee whose salary is > 25000 & emp is from 'Mumbai' city
            var result7 = from e in emp
                          where e.Salary > 2500 && e.City.Contains("Mumbai")
                          select e;

            // ************Lambda Expression*******************

            // 1.display all employees
            var res = emp.ToList();

            //2.display employee with asending order by name
            var res1 = emp.OrderBy(e => e.Name).ToList();

            //3.display employee whose salary is > 25000
            var res2 = emp.Where(e => e.Salary > 25000).ToList();

            //4.display employee whos from 'Pune' City
            var res3 = emp.Where(e => e.City == "Pune").ToList();

            //5.display employee with desending order by salary
            var res4 = emp.OrderByDescending(e => e.Salary).ToList();

            //6.display employee whose name start with 'P'
            var res5 = emp.Where(e => e.Name.StartsWith("P")).ToList();

            //7.display employee whose salary is > 25000 & emp is from 'Mumbai' city
            var res6 = emp.Where(e => e.Salary > 25000 && e.City.Contains("Mumbai")).ToList();



            foreach (Employee item in res6)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
