using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    class ConstructorDemo
    {

        public ConstructorDemo()
        {
            Console.WriteLine("Default");
        }

        public ConstructorDemo(int x)
        {
            Console.WriteLine(x);
        }

        public void get()
        {

        }

        static void Main(String[] args)
        {
            ConstructorDemo c = new ConstructorDemo();

            ConstructorDemo c1 = new ConstructorDemo(123);

            c.get();
        }
    }
}
