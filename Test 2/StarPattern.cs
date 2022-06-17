using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    class StarPattern
    {

        //* * * * *
        // * * * *
        //  * * *
        //   * *
        //    *
        static void Main(String[] args)
        {
            int row = 5;
            for (int i = 0; i <=row-1; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= row - 1 - i; k++)
                {
                    Console.Write(" * ");
                }
                    Console.WriteLine();
            }

        }
    }
}
