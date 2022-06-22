using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class EvenElements
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 7, 2, 3, 6, 1 };
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]%2==0)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
    }
}
