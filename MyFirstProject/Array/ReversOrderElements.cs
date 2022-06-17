using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class ReversOrderElements
    {
        static void Main(String[] args)
        {
            int[] a = { 5, 7, 3, 2 };
            Console.WriteLine(string.Join(" ", a));
            Console.WriteLine();
            for(int i=a.Length-1;i>=0;i--)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
