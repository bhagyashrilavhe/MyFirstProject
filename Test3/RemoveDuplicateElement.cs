using System;
using System.Collections.Generic;
using System.Text;

namespace Test3
{
    class RemoveDuplicateElement
    {
        static void Main(String[] args)
        {
            
            int[] arr = { 4, 3, 2, 4, 9, 2 };
            Console.WriteLine(string.Join(" ", arr));

            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[arr[i]]++;
                if (arr[arr[i]] == 1)
                {
                    Console.WriteLine("Array elements after removing duplicates : "+arr[i]);
                }
            }
        }
    }
}
