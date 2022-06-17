using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    class DigitSumWhile
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            int count = 0;

            while (num > 0)
            {
                int r = num % 10;
                sum = sum + r;
                count++;
                num = num / 10;
            }
            Console.WriteLine(sum+" "+count);
        }
    }
}
