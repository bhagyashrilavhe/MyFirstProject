using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Delegate
{
    class DelegateExample
    {
        static void m1(int a,float b)
        {
            Console.WriteLine("In m1 " + (a + b));
        }
        static void m2(string msg)
        {
            Console.WriteLine("Welcome " + msg);
        }
        static int cube(int x)
        {
            Console.WriteLine("Cube : " + (x*x*x));
            return x * x * x;
        }
        static float AreaOfCircle(int r)
        {
            Console.WriteLine("AreaOfCircle : " + (3.14f * r * r));
            return 3.14f * r * r;
        }
        static bool isEven(int x)
        {
            Console.WriteLine("IsEven : " + (x%2==0));
            return x % 2 == 0;
        }
        static void Main(string[] args)
        {

            Action<int, float> d1 = m1;
            d1(11, 2.3f);

            Action<string> d2 = m2;
            d2("Good Evening");

            Func<int,int> d3 = cube;
            int c = d3(3);

            Func<int, float> d4 = AreaOfCircle;
            float area = d4(4);

            //bool- Func and Predication
            Func<int, bool> d5 = isEven;
            bool e = d5(7);

            Predicate<int> d6 = isEven;
            bool b = d6(8);

        }
    }
}
