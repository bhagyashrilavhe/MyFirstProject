using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class AreaOfEquilateralTriangle
    {
        static void Main(String[] args)
        {
            float a=5f;
            double area;
            Console.WriteLine("a is " + a);
           
            area = (1.73 * a * a)/4;
            Console.WriteLine("Area of Equilateral Triangle is " + area);
        }
    }
}
