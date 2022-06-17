using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    class OverloadArithmaticOperation
    {
        public void show()
        {
            Console.WriteLine("Calculate Airthmatic Operation");
        }
        public void Calculate(float x,float y)
        {
            Console.WriteLine("Add : " +(x+y));
        }
        public void Calculate(int x,float y)
        {
            Console.WriteLine("Sub : " + (x - y));
        }
        public void Calculate(int x,int y)
        {
            Console.WriteLine("Mul : " + (x * y));
        }
        public void Calculate(float x,int y)
        {
            Console.WriteLine("Div : " + (x / y));
        }

        static void Main(String[] args)
        {
            OverloadArithmaticOperation a = new OverloadArithmaticOperation();

            a.show();
            a.Calculate(6.2f, 7.0f);
            a.Calculate(9, 4f);
            a.Calculate(10, 12);
            a.Calculate(15f, 3);
        }
    }
}
