using System;
using System.Collections.Generic;
using System.Text;

namespace Test4
{
    // WAP to replace all the 0’s with 1’s in your array. Your array is [26, 0, 67,45, 0, 78, 54, 34, 10, 0, 34].
    class Replace0To1
    {
        static void Main(string [] args)
        {
            int[] arr = {26,0,67,45,0,78,54,34,10,0,34 };

            for (int i=0;i<arr.Length;i++)
            {
                if(arr[i]==0)
                {
                    arr[i] = arr[i] + 1;
                }
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
