using System;
using System.Collections.Generic;
using System.Text;

namespace Test4
{
    class ReverseArray
    {
        // WAP to reverse the array itself, don’t print array in reverse – I want current array reverse.
       // Means e.g.arr[] = [3, 90, 45, 29, 37, 78] so your same array must be [78, 37, 29, 45, 90, 3]without using temporary array
        static void Main(string[] args)
        {
            int[] arr = { 3,90,45,29,37,78 };

            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i] + " ");
                
            }
            Console.WriteLine();
          
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
