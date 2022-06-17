using System;
using System.Collections.Generic;
using System.Text;

namespace Conditions
{
    class DivisibleTwoNumber
    {
        static void Main(String[] args)
        {
            int i;
            Console.WriteLine("Enter any number ");
            i = int.Parse(Console.ReadLine());

            if(i % 3 == 0  &&  i % 9 == 0)
            {
                Console.WriteLine("Number is divisible by 3 and 9");
            }
            else
            {
                Console.WriteLine("Number is not  divisible by 3 and 9 ");
            }

            
        }
    }
}
