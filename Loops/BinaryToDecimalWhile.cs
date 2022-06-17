using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    class BinaryToDecimalWhile
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the binary number");
            int num = int.Parse(Console.ReadLine());

            int r;
            int sum = 0, p = 0;

            while (num > 0)
            {
                r = num % 10;
                int power = (int)(Math.Pow(2, p));
                sum = sum + (power * r);
                num = num / 10;
                p++;
            }
            Console.WriteLine(sum);
        }
    }
}
