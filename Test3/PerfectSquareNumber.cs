using System;
using System.Collections.Generic;
using System.Text;

namespace Test3
{
    class PerfectSquareNumber
    {
        static void Main(String [] args)
        {
            int[] arr = { 23,43,25,49,12,9,78,66,39,0 };
            Console.WriteLine(string.Join(" ", arr));

            for(int i=0;i<arr.Length;i++)
            {
                if (Math.Sqrt(arr[i]) == (int)Math.Sqrt(arr[i]))
                    Console.Write(arr[i]+" ");
            }
            
        }
    }
}
