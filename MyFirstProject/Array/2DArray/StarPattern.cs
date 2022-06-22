using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array._2DArray
{
    class StarPattern
    {
        static void Main(string[] args)
        {
            char[,] a = new char[4, 4];

            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    if (j == 0 || i == j || j == a.GetUpperBound(1))
                    {
                        a[i, j] = '*';
                    }
                    else
                    {
                        a[i, j] = ' ';
                    }
                }

            }
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
