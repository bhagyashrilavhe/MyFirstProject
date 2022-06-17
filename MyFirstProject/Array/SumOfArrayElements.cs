using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class SumOfArrayElements
    {
        static void Main(String[] args)
        {
            int[] a = { 1, 3, 5, 7,4};
            Console.WriteLine(string.Join(" ", a));
            Console.WriteLine();
            int sum = 0;
            for(int i = 0; i<a.Length;i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine("Sum Of Array Elements : " + sum);
        }
    }
}
