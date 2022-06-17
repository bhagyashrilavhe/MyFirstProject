using System;
using System.Collections.Generic;
using System.Text;

namespace Conditions
{
    class OddEvenNumber
    {
        static void Main(String[] args)
        {
            int i;
            Console.WriteLine("Enter any Number");
            i = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
            

        }
    }
}
