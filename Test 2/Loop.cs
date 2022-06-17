using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    class Loop
    {
        static void Main(String[] args)
        {
            int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);
            }
            while (b != 3);
            {

            }
        }
    }
}
