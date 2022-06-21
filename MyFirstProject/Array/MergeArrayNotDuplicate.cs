using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class MergeArrayNotDuplicate
    {
        static void Main(String[] args)
        {
            int[] a = { 1, 22, 3, 44, 5 ,22};
            int[] b = { 11, 22, 2,33, 44, 5 ,55};
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
                for(int k=j-1;k>=0;k--)
                {
                    if(c[k]==b[i])
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

            Console.WriteLine("................");

            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]+"    ");
            }
            Console.WriteLine();

            Console.WriteLine("................");

        }
    }
}
