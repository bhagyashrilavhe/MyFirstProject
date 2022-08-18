using System;
using System.Collections.Generic;
using System.Text;

namespace Test4
{
    // Create an array of 10 names sort in descending order.
    class SortedArrayDescendingOrder
    {
        static void Main(string [] args)
        {
            string [] arr = new string[] { "bhgyashri", "rutuja", "priya", "sushma","omkar","karan","avi","kartik","tushar","nilesh"};
            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].CompareTo(arr[j]) == -1)
                    {
                        string temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
