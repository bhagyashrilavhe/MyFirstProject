using System;
using System.Collections.Generic;
using System.Text;

namespace Conditions
{
    class AgeIfElse
    {
        static void Main(String[] args)
        {
            int age;
            Console.WriteLine("Enter person age");
            age = int.Parse(Console.ReadLine());

             if(age>=13 && age<=19)
             {
                  Console.WriteLine("Person is teenager");

             }
              else
             {
                 Console.WriteLine("Person is not teenager");
             }

        }
    }
}
