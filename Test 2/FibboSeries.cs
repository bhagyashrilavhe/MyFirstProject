using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    class FibboSeries
    {
        static void Main(String[] args)
        {
            int n1 = 0, n2 = 1, n, i,terms=20;
            //Console.WriteLine("Enter the terms  :");
            //int number = int.Parse(Console.ReadLine());

            Console.WriteLine(n1 + " ");
            Console.WriteLine(n2 + " ");

            for (i = 2; i <= terms; i++)
            {
                n = n1 + n2;
                Console.WriteLine(n + " ");
                n1 = n2;
                n2 = n;
                
            }
            
        }
    }
}
