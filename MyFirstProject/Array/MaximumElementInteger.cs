using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class MaximumElementInteger
    {
        static void Main(string[] args)
        {
            int[] a = { 4,5,2,6,9,10,1,7 };
            int max = a[0];
            int x = 0;

            for(int i=0;i<a.Length;i++)
            {
                x = a[i];
                Console.WriteLine(a[i]);
                if(a[i]>max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine("Max = " + max);
        }
    }
}
