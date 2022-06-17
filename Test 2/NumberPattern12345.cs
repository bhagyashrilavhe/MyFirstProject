using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    class NumberPattern12345
    {

        // 1 2 3 4 5 
        //   1 2 3 4
        //     1 2 3
        //       1 2
        //         1
        static void  Main(String[] args)
        {
             
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k+" ");
                }
                    Console.WriteLine();
            }

        }
    }
}
