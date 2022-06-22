using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class PerimeterOfRectangle
    {
        static void Main(string[] args)
        {
            int l = 9, w = 7, p;
            Console.WriteLine("length of ractangle is " + l);
            Console.WriteLine("width of ractangle is " + w);
            p = 2 * ( l + w );
            Console.WriteLine("perimeter is " + p);
        }
    }
}
