using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inheritance
{
    class Mobile
    {
        public string storage = "64 GB ";
    }
    class Samsung : Mobile
    {
        public string RAM = "8 GB";
    }
    class Redmi : Mobile
    {
        public string Model = " M1908C3II";
    }
    class Iphone : Mobile
    {
        public string color = " White";
    }
    class HierarchicalInheritance
    {
        static void Main(String[] args)
        {
            Samsung s = new Samsung();
            Console.WriteLine("Samsung     " + s.storage + "   " + s.RAM);
            Redmi r = new Redmi();
            Console.WriteLine("Redmi     " + r.storage + "   " + r.Model);
            Iphone i = new Iphone();
            Console.WriteLine("Iphone     " + i.storage + "   " + i.color);
        }
    }
}
