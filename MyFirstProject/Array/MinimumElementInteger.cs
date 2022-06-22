using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class MinimumElementInteger
    {
        static void Main(string [] args)
        {
            int[] a = { 2,4,6,3,7,9,1};
            int min = a[0];
            int x = 0;

            for (int i = 0; i < a.Length; i++)
            {
                x = a[i];
                Console.WriteLine(a[i]);
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine("Min = " + min);
        }
    }
}
