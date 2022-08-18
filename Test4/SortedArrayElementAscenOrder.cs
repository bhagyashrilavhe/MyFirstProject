using System;
using System.Collections.Generic;
using System.Text;

namespace Test4
{
    // WAP sort array elements in ascending order.
    class SortedArrayElementAscenOrder
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 9,2,1,4,6,8,3,10,5,7};

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
