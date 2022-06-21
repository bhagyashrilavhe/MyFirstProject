using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class MergeArrayNotDuplicate
    {
        static void Main(String[] args)
        {
            int[] a = { 1, 2, 4, 5, 3 };
            int[] b = { 6, 3, 7, 1, 9 };
            int[] c = new int[a.Length + b.Length];
            int j = 0;
            

            for (int i = 0; i < a.Length; i++)
            {
                c[j] = a[i];
                j++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                c[j] = b[i];
                j++;
            }
          
        }
    }
}
