using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class ReversArray
    {
        static void Main(String [] args)
        {
            int[] a = { 3, 9, 4, 5, 1 };
            int j = a.Length - 1;
            Console.WriteLine(string.Join(" ", a));

            for(int i=0;i<a.Length/2;i++)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;
            }
            Console.WriteLine();
            Console.WriteLine(string.Join(" ", a));
        }
    }
}
