using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Delegate
{
    class OverloadDelegate
    {
        public delegate void mydel3(int a);

        public static void m1(int a)
        {
            Console.WriteLine("In m1 " + a);
        }
        public static void square(int n)
        {
            Console.WriteLine("Square " + (n * n));
        }
        static void Main(string[] args)
        {
            // SingleCast
            mydel3 d1 = square;

            // MultiCast - Holding reference of more than one function.
            mydel3 d2 = square;
                ;
            d2 = d2 + m1;
            d2(9);
        }
    }
}
