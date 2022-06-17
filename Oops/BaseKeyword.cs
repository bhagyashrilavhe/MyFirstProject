using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    class Person
    {
       public  int id = 101;
        public int salarys =30000;

        public Person(string name, string dept)
        {
            Console.WriteLine("Id-  " + id + "    Name-   " + name+"  Department- "+dept);
        }
    }
    class Employe : Person
    {
        public int salarys = 36000;
        public Employe():base("Bhagyashri","HR")
        {
            Console.WriteLine("Employee  "+salarys+ "  "+salarys);
        }
    }
    
    class BaseKeyword
    {
        static void Main(String[] args)
        {
            Employe e = new Employe();

        }
    }
}
