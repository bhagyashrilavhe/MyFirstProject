using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inheritance
{
    class Child
    {
        public void Display()
        {
            Console.WriteLine("Child .....");
        }
    }
    class Father:Child
    {
        public void Display1()
        {
            Console.WriteLine("Father .....");
        }
    }
    class GrandFather : Father
    {
      public void Display2()
        {
            Console.WriteLine("GrandFather .....");
        }
    }
    class MultilevelInheritance1
    {
        static void Main(string[] args)
        {
            GrandFather g = new GrandFather();
            g.Display2();
            g.Display1();
            g.Display();
        }
    }
}
