using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array._2DArray
{
    class NumberPattern
    {
        static void Main(string [] args)
        {
            int[,] a = new int[4, 4] { { 1,2,3,4 }, { 5,6,7,8 }, { 3,7,7,1 },{ 2,1,6,8} };

            for(int i=0;i<=a.GetUpperBound(0);i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++) 
                {
                    if (j == 0  || i == j || j == a.GetUpperBound(1))
                    {
                        Console.Write(a[i, j]+"  ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
          
        }
    }
}
