using System;
using System.Collections.Generic;
using System.Text;

namespace Test3
{
    class ReplaceZeroWithOne
    {
        static void Main(String [] args)
        {
            int[] arr = {26,0,67,45,0,78,54,34,10,0,34};
           
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i] = arr[i] + 1;
                }
                Console.WriteLine(arr[i]);
            }
        }
        
    }
}
