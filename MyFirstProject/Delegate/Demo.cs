using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Delegate
{
    public delegate void mydele();
    class Demo
    {
       
        public delegate int mydel2(int a, int b);

        public static int Add(int a,int b)
        {
            Console.WriteLine("Add = " + (a + b));
            return a + b;
        }
        static void greet()
        {
            Console.WriteLine("Good evening");
        }
        static void Main(string[] args)
        {
            mydele d1 = greet;
            d1();

            mydel2 d2 = Add;
            int r = d2(10, 20);
        }
    }
}
