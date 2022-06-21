using System;
using System.Collections.Generic;
using System.Text;

namespace Test3
{
    class MinimumFrequencyChar
    {
        static void Main(String [] args)
        {
            char[] c = { 'a', 'b', 'b', 'c', 'c','b' };
           
            char min = c[0];
            int x = 0;

            for(int i=0;i<c.Length;i++)
            {
                x = c[i];
                Console.WriteLine(c[i] + "  :  " + x);
                if(c[i]<min)
                {
                    min = c[i];
                }
            }
            Console.WriteLine("Min : " + min);
        }
    }
}
