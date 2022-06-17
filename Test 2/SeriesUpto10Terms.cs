using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    class SeriesUpto10Terms
    {
        static void Main(String[] args)
        {
            for (int num = 1; num <= 10; num++)
            {
                Console.WriteLine(( num*num)+(num*num*num));
            }
            Console.WriteLine("    ");
        }
    
    }
}
