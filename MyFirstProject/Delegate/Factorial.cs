using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Delegate
{
    public delegate void mydel(int n);
    class Factorial
    {
        static void Main(string[] args)
        {
            mydel d = (n) =>
            {
                  int fact = 1;
                  for (int i = 1; i <= n; i++)
                  {
                      fact = fact * 1;
                  }
                Console.WriteLine("Factorial is : " + fact);
            };
            d(6);
           
        }
    }
}
