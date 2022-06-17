using System;
using System.Collections.Generic;
using System.Text;

namespace Conditions
{
    class PositiveNegativeTernary
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            string str = num > 0 ? "Positive" : num < 0 ? "Negative" : "Zero";
            Console.WriteLine(str);
        }
    }
}
