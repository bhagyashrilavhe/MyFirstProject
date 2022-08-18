using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Delegate
{
    public delegate void mydel1(int a, int b);
    public delegate int mydel2(int a);
    class Functions
    {
        static void Main(string[] args)
        {
            // anonymous function
            mydel1 d = delegate (int a, int b)
            {
                  Console.WriteLine("Product = " + (a * b));
            };
            d(9, 7);

            Console.WriteLine("********************");

            // Lamda 
            mydel1 d2 = (a,b) => Console.WriteLine("Area Of rect : " + (a * b));
            d2(11, 12);

            mydel2 dd = (a) =>
            {
                  return a * a;
            };
            int sq = dd(6);

            mydel2 dd1 = (a) => a * a;
            int sqq = dd1(7);
            Console.WriteLine("Square : " + sqq);
            



        }
    }
}
