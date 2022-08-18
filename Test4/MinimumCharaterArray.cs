using System;
using System.Collections.Generic;
using System.Text;

namespace Test4
{
    // WAP to find min character in character array. Means e.g. arr[] = [‘A’, ‘D’, ‘E’, ‘x’, ‘z’, ‘R’], so min character is ‘A’.
    class MinimumCharaterArray
    {
        static void Main(string[] args)
        {
            char[] c = {'A','D','E','x','z','R' };
            char min = c[0];
            int x = 0;

            for (int i = 0; i < c.Length; i++)
            {
                x = c[i];
                Console.WriteLine(c[i]);
                if (c[i] < min)
                {
                    min = c[i];
                }
            }
            Console.WriteLine("Min character is = " + min);
        }
    }
}
