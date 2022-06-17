using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    class EvenOddNegativeSquare
    {
        static void Main(String[] args)
        {
            int i = 1;
            while (i <= 50)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine("Number is even is   : " + i);
                }
               else
               {
                    Console.WriteLine("Number is odd is   : " + (i * i));
               }
                i++;

            }
        }
    }
}
