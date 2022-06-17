using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    class VariableDemo
    {
        public int x;

        public void Accept()
        {
            x = 101;
        }
        public void Display()
        {
            Console.WriteLine(x);
        }
        static void Main(String[] args)
        {
            VariableDemo v = new VariableDemo();
            v.Accept();
            v.Display();
        }
    }
    class VariableDemo2
    {
        public int x;

        public void Readvalue(int id)
        {
            x = id;
        }
        public void Show()
        {
            Console.WriteLine(x);
        }
        static void Main(String[] args)
        {
            VariableDemo2 v1 = new VariableDemo2();
            v1.Readvalue(123);
            v1.Show();
        }
    }

}
