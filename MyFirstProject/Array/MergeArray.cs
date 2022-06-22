using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class MergeArray
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 11, 22, 33, 44, 55 };
            int[] c = new int[a.Length + b.Length];
            int j = 0;

            for(int i=0;i<a.Length;i++)
            {
                c[j] = a[i];
                j++;
            }
            for(int i=0;i<b.Length;i++)
            {
                c[j] = b[i];
                j++;
            }
            Console.WriteLine("////////////////////////////");

            for(int i=0;i<c.Length;i++)
            {
                Console.WriteLine(c[i]);
            }

            Console.WriteLine("................");

            foreach(int x in c)
            {
                Console.WriteLine(x);
            }

           
        }
    }
}
