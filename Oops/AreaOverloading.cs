using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    class AreaOverloading
    {

        public void Area(double radius)
        {
            double pi = 3.14;
            double result = pi * radius * radius;
            Console.WriteLine("Area of Circle : " + result);
        }
        public void Area(int length, int breadth)
        {
            int result = length * breadth;
            Console.WriteLine("Area of Rectangle : " + result);
        }
        public void Area(double Base, double height)
        {
            double result = (Base * height) / 2;
            Console.WriteLine("Area of Triangle : " + result);
        }
        public void Area(int side)
        {
            int result = side * side;
            Console.WriteLine("Area of Square : " + result);
        }
        static void Main(String[] args)
        {
            AreaOverloading obj = new AreaOverloading();
            obj.Area(9.5);
            obj.Area(10, 12);
            obj.Area(9.5, 2.0);
            obj.Area(15);
        }

       
    }
}
