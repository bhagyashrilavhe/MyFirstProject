using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    class FibSeries
    {
        static void Main(String[] args)
        {
            int n1 = 0, n2 = 1, n, i;
            Console.WriteLine("Enter the number  :");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(n1 + " ");
            Console.WriteLine(n2 + " ");

            for(i=2;i<number;i++)
            {
                n = n1 + n2;
                Console.WriteLine(n + " ");
                n1 = n2;
                n2 = n;
            }
        }
    }
}
