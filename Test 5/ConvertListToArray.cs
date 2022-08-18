using System;
using System.Collections.Generic;
using System.Text;

namespace Test5
{
    // WAP to convert List to array.
    class ConvertListToArray
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>();
           
            number.Add(1);
            number.Add(2);
            number.Add(3);
            number.Add(4);
            number.Add(5);
            number.Add(6);
            number.Add(7);
            number.Add(8);
            number.Add(9);
            number.Add(10);

            int[] a = number.ToArray();

            Console.WriteLine("The array elements are : ");

            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
