using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    class NumberPattern12344
    {
        //        1
        //      2 2 2
        //   3 3 3 3 3
        // 4 4 4 4 4 4 4
        static void Main(String[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 0;j <= 4-i-i;j++)
                {
                    Console.Write(" ");
                    
                }
                for (int k = 1; k <=i*2-1; k++)
                {
                    Console.Write(i+" ");
                }

                    Console.WriteLine();
            }
        }
    }
}
