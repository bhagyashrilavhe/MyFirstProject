using System;
using System.Collections.Generic;
using System.Text;

namespace Test3
{
    class OddEvenInteger
    {
        static void Main(String[] args)
        {
            int even = 0, odd = 0;

            Console.WriteLine("Enter size : ");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the array elements : ");
            int[] a = new int[size];
            for (int i=0;i<size;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i < size; i++)
            {
                if (a[i] % 2 == 0)
                {
                  
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("Count the even number : "+even);
            Console.WriteLine("Count the odd number  : "+odd);
        }  
    }
}
