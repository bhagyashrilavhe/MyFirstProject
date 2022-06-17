using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class DivisibleBy5or11
    {
        static void Main(String[] args)
        {
            int i;
            Console.WriteLine("Enter any number ");
            i = int.Parse(Console.ReadLine());

            if (i % 5 == 0 && i % 11 == 0)
            {
                Console.WriteLine("Number is divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine("Number is not  divisible by 5 and 11 ");
            }


        }
    }
}
