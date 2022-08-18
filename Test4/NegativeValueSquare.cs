using System;
using System.Collections.Generic;
using System.Text;

namespace Test4
{
    // WAP to replace all negative value with its immediate left elements square. Means arr[] =[12, 3, -19, 29, 5, -61, 44, 7, -9] Output array will be[12, 3, 9, 29, 5, 25, 44, 7, 49].
    class NegativeValueSquare
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 3, -19, 29, 5, -61, 44, 7, -9 };

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = arr[i] + (arr[i]*arr[i]);

                    
                }
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
