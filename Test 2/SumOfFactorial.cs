using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    class SumOfFactorial
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the Number : ");
            int num = int.Parse(Console.ReadLine());

            int fact = 1, sum = 0;

            for(int i=1;i<=num;i++)
            {
                fact = fact * i;
                sum = sum + fact;   
            }
            Console.WriteLine("Sum Of Factorial : "+sum);

        }
    }
}
