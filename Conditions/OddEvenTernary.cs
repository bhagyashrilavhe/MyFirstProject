using System;
using System.Collections.Generic;
using System.Text;

namespace Conditions
{
    class OddEvenTernary
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            String result = num % 2 == 0 ? "Even" : "Odd";
            Console.WriteLine(result);
        }
    }
}
