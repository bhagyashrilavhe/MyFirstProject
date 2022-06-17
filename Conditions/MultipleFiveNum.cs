using System;
using System.Collections.Generic;
using System.Text;

namespace Conditions
{
    class MultipleFiveNum
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

             if(num % 5 == 0)
             {
                 Console.WriteLine("Number is multiple of 5");
             }
             else
             {
                 Console.WriteLine("Number is not multiple of 5");
             }

            
        }
    }
}
