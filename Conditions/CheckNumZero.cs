using System;
using System.Collections.Generic;
using System.Text;

namespace Conditions
{
    class CheckNumZero
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any Number");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Number is +ve");
            }
            else if (num < 0)
            {
                Console.WriteLine("Number is -ve");
            }
            else
            {
                Console.WriteLine("Number is zero");
            }
        }
    }
}

