using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    class ReversNumWhile
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            int revers = 0;

            while(num>0)
            {
                int r = num % 10;
                revers = revers * 10 + r;
                num = num / 10;
            }
            Console.WriteLine(revers);
        }
    }
}
