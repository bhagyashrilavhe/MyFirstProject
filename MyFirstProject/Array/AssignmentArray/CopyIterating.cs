using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array.AssignmentArray
{
    class CopyIterating
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] a2 = new int[5];

            for(int i=0;i<a1.Length;i++)
            {
                a2[i] = a1[i];
            }

            Console.WriteLine("First array element : ");

            for(int i=0;i<a1.Length;i++)
            {
                Console.Write(a1[i]+"  ");
            }
            Console.WriteLine();

            Console.WriteLine("Copy array element : ");

            for (int i = 0; i < a1.Length; i++)
            {
                Console.Write(a2[i]+"  ");
            }
            Console.WriteLine();

        }
    }
}
