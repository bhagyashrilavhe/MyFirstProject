using System;
using System.Collections.Generic;
using System.Text;

namespace Ternary
{
    class Age
    {
        static void Main(String[] args)
        {
            int age;
            Console.WriteLine("Enter person age");
            age = int.Parse(Console.ReadLine());

            string teen = age >= 13 ? "Person is teenager" : age <= 19 ? "Person is not teenager" : "";
            Console.WriteLine(teen);
        }
    }
}
