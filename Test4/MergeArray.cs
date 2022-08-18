using System;
using System.Collections.Generic;
using System.Text;

namespace Test4
{
    // WAP to merge 2 arrays to 3rd array. 3rd array should not have elements of same value.
    class MergeArray
    {
        static void Main(string[] args)
        {
            int[] a = { 77,11,10,22,09,55,66,10 };
            int[] b = { 11,12,22,33,44,05,55,12 };
            int[] c = new int[a.Length + b.Length];
            int j = 0;

            for (int i = 0; i < a.Length; i++)
            {
                bool isPresent = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (c[k] == a[i])
                    {
                        isPresent = true;
                        break;
                    }
                }
                if (isPresent == false)
                {
                    c[j] = a[i];
                    j++;
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                bool isPresent = false;
                for (int k = j - 1; k >= 0; k--)
                {
                    if (c[k] == b[i])
                    {
                        isPresent = true;
                        break;
                    }
                }
                if (isPresent == false)
                {
                    c[j] = b[i];
                    j++;
                }
            }
            Console.WriteLine(string.Join(" ", a));

            Console.WriteLine();

            Console.WriteLine(string.Join(" ", b));

            Console.WriteLine("********************************");

            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + "  ");
            }
            Console.WriteLine();

        }
    }
}
