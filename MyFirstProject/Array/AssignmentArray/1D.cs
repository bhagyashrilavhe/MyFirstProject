using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array.AssignmentArray
{
    class _1D
    {
        static void Main(string [] args)
        {
            int[] a = new int[5];

            Console.WriteLine("Enter the array elememt  : ");

            for (int i=0;i<a.Length;i++)
            {
              
                Console.Write(a[i]+" ");
                 a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine("Print elements from 1D array  : ");

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "  ");
            }

            Console.WriteLine();

        }
    }
}
