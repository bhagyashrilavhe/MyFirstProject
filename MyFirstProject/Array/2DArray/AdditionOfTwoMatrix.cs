using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array._2DArray
{
    class AdditionOfTwoMatrix
    {
        static void Main(string[] args)
        {
            int[,] a1 = new int[2, 2] { { 2, 4 }, { 6, 8 } };
            int[,] a2 = new int[2, 2] { { 1, 3, }, { 5, 7 } };
            int[,] a3 = new int[2, 2];

            Console.WriteLine("The First Matrix : ");
            for(int i=0;i<=a1.GetUpperBound(0);i++)
            {
                for(int j=0;j<=a2.GetUpperBound(1);j++)
                {
                    Console.Write(a1[i, j]+" ");

                }
                Console.WriteLine();
            }

            Console.WriteLine("**********************");

            Console.WriteLine("The Second Matrix : ");
            for (int i = 0; i <= a1.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a2.GetUpperBound(1); j++)
                {
                    Console.Write(a2[i, j] +"  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("**********************");

            for (int i = 0; i <= a1.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a2.GetUpperBound(1); j++)
                {
                   a3[i, j] = a1[i, j] + a2[i, j];
                }
                Console.WriteLine("Addition of two Matrix : " );
            }


            for (int i = 0; i <= a1.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a2.GetUpperBound(1); j++)
                {
                    Console.Write(a3[i, j]+"  ");
                }
                Console.WriteLine();
            }
        }
    }
}
