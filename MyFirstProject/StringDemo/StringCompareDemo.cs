using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringDemo
{
    class StringCompareDemo
    {
        static void Main(string [] args)
        {
            string s = " hello";
            string str = "Hello";
            Console.WriteLine(s == str);

            Console.WriteLine(s.Equals(str));

            Console.WriteLine(s.CompareTo(str));
        }
    }
}
