using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class OperatorMath
    {
        static void Main(String[] args)
        {
            int a, b, c;
            a = 5;
            b = 4;
            c = 3;

            Console.WriteLine(a++ + b * ++c);
            Console.WriteLine("a=" + a + "b=" + b + "c=" + c);
            Console.WriteLine(b * 5 / a + b++ + b);
            Console.WriteLine("a=" + a + "b=" + b + "c=" + c);
        }
    }
}
