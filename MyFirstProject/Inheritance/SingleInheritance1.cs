using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inheritance
{
    class Vehicle 
    {
        public int wheels ;
        public string name;

        public void Display()
        {
            Console.WriteLine("Vehicle is Car : ");
        }
    }
    class Car:Vehicle
    {
        public void show()
        {
            wheels = 4;
            name = " BMW";
            Console.WriteLine("Wheels : "+ wheels + "  Name : " + name);
        }
    }
    class SingleInheritance1
    {
        static void Main(String[] args)
        {
            Car c = new Car();
            c.Display();
            c.show();
        }
    }
}
