using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array._2DArray
{
    class RowSum
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 1, 4, 7 } };


            for (int i = 0; i < a.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum = sum + a[i, j];
                    Console.Write(a[i, j] + " ");

                }
                Console.WriteLine(" Sum of Row : " + sum);
                Console.WriteLine();
            }

        }
    }
}
