using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    class OddNumFind1To20
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Odd number from 1 to 20");

            for (int i = 1; i < 20; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
