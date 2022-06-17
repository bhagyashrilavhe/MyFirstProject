using System;
using System.Collections.Generic;
using System.Text;

namespace Conditions
{
    class CheckNumberDivisible
    {
        static void Main(String[] args)
        {
            int i;
            Console.WriteLine("Enter any Number");
            i = int.Parse(Console.ReadLine());

            if (i % 10 == 0)
            {
                Console.WriteLine("Number is divisible by 10");
            }
            else
            {
                Console.WriteLine("Number is not divisible by 10");
            }
        }
    }
}
