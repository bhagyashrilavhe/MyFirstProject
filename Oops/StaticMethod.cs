using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    class StaticMethod
    {
       
        public StaticMethod()
        {
            Console.WriteLine("Show Overloading");
        }
       
        public StaticMethod(double x)
        {
            Console.WriteLine("Double : " + x);
        }
        public StaticMethod(int x,int y,int z)
        {
            Console.WriteLine("Add : " + (x + y + z));
        }
        public StaticMethod(string str)
        {
            Console.WriteLine("Name : " + str);
        }
        static void Main(String[] args)
        {
            StaticMethod s = new StaticMethod();
            StaticMethod s1 = new StaticMethod(20.0);
            StaticMethod s2 = new StaticMethod(7,8,10);
            StaticMethod s3 = new StaticMethod("Bhagyashri");
        }
    }
}
