using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inheritance
{
    class Teacher
    {
        public int id;
        public string name;
        public void Display()
        {
            Console.WriteLine("Teacher");
        }
    }
    class Student : Teacher
    {
        public void show()
        {
            id = 1;
            name = "Bhagyashri";
            Console.WriteLine(id + "  " + name);
        }
    }
    class SingleInheritance
    {
        static void Main(String[] args)
        {
            Student s = new Student();
            s.Display();
            s.show();

        }
    }
}
