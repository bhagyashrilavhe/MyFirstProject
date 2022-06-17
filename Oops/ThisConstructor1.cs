using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    class ThisConstructor1
    {
        public ThisConstructor1():this(67)
        {
            Console.WriteLine("Default");
        }

        public ThisConstructor1(int x)
        {
            Console.WriteLine("x= " + x);
        }

        public ThisConstructor1(string city):this()
        {
            Console.WriteLine(city);
        }
        static void Main(String[] args)
        {
            ThisConstructor1 t = new ThisConstructor1("pune");
        }
    }
}
