using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class SumOfEvenElement
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 3, 8, 4, 1, 5, 10 };
            int Sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Sum = Sum + a[i];
                }
            }
            Console.WriteLine("Sum of Even Element : " + Sum);
        }
    }
}
