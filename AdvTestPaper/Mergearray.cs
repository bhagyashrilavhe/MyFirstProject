using System;
using System.Collections.Generic;
using System.Text;

namespace AdvTestPaper
{
//Write a program to merge two sorted array of number such that new array is sorted
   // array and there should be no duplicate in new array.
    class Mergearray
    {
        static void Main(string[] args)
        {
            int[] a = { 1,2,3,4,5,6,7};
            int[] b = { 7,8,2,9,10,5,11 };
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
