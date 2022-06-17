using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchCase
{
    class Area
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Area of Circle");
            Console.WriteLine("Area of Triangle");
            Console.WriteLine("Area of Rectangle");
            Console.WriteLine("Area of Square");
            Console.WriteLine("Enter your choice");
            char ch = Convert.ToChar(Console.ReadLine());

            int r, l, w, b, h,s;
            double area, pi = 3.14;
            
            switch (ch)
            {
                case 'C':
                         Console.WriteLine("radius of circle is :");
                         r = int.Parse(Console.ReadLine());
                         area = pi * r * r;
                         Console.WriteLine("area is " + area);
                      break;

                case 'T':
                         Console.WriteLine("base of triangle is :");
                         b = int.Parse(Console.ReadLine());
                         Console.WriteLine("hight of triangle is :");
                         h = int.Parse(Console.ReadLine());
                         area = 0.5 * b * h;
                         Console.WriteLine("area is " + area);
                      break;

                case 'R':
                         Console.WriteLine("length of rectangle is :");
                         l = int.Parse(Console.ReadLine());
                         Console.WriteLine("width of rectangle is :");
                         w = int.Parse(Console.ReadLine());
                         area = l * w;
                         Console.WriteLine("area is " + area);
                       break;

                case 'S':
                         Console.WriteLine("side of square is :");
                         s = int.Parse(Console.ReadLine());
                         area = s * s;
                         Console.WriteLine("area is " + area);
                       break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
