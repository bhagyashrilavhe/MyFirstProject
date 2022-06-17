using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    class Output2
    {
        static void Main(String[] args)
        {
            int i = 1, k = 1;
            while(i++<=5)
            {
                k *= i;
            }
            Console.WriteLine("k = " + k + " i = " + i);
        }
    }
}
