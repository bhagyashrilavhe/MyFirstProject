using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Circle
    {
        static void Main(String[] args)
        {
            double radius = 2, area;
            double pi = 3.14;
            Console.WriteLine("radius of cirle is " +radius);
            Console.WriteLine("pi of circle is " + pi);
            area = pi * radius * radius;
            Console.WriteLine("area is " + area);
        }
    }
}
