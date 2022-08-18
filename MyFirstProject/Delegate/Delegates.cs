using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Delegate
{
  //  Generic Delegates
 // 1.Func => If ur function has return value and takes 0 or more input parameters.
 // 2.Action=> If ur functions return type is void and it may take 0 or more input parameters.
 // 3.Predicate=> If ur function has bool return type and 
    class Delegates
    {
        static double m1(int r,char c)
        {
            return r * 3.4;
        }
        static void m2(byte a,string e)
        {
            Console.WriteLine("In m2" + (e + a));
        }
        static bool m3(long m,string s)
        {
            return true;
        }
        static void Main(string[] args)
        {
            Func<int, char,double> d1 = m1;
            double d= d1(7, 'b');

            Action<byte, string> d2 = m2;
            d2(200, "Bhagya");

            Func<long ,string,bool> d3 = m3;
            bool b = d3(10, "yes/no");
        }
    }
}
