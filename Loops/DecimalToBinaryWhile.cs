using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    class DecimalToBinaryWhile
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the Decimal number");
            int num = int.Parse(Console.ReadLine());

            int  r;
            int bin = 0,i=1;

            while(num>0)
            {
                r = num % 2;
                bin = bin + r * i;
                num = num / 2;
                i = i * 10;
            }
            Console.WriteLine(bin);
        }

    }
}
