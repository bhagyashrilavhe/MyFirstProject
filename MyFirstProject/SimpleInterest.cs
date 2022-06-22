using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class SimpleInterest
    {
        static void Main(string[] args)
        {
            int p = 500,t = 2,r = 4,si;
            Console.WriteLine("Principal amount is " + p);
            Console.WriteLine("Time  " + t); 
            Console.WriteLine("Rate " + r);
            si= p * t * r;
            Console.WriteLine("Simple Interest is " + si);
        }
    }
}
