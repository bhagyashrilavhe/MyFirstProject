using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class FrequencyOfElement
    {
        static void Main(string [] args)
        {
            int[] a = { 4, 1, 3, 1, 5, 1, 4 };
            Console.WriteLine("Enter Element : ");
            int num = int.Parse(Console.ReadLine());
            int count = 0;

            for(int i=0;i<a.Length;i++)
            {
                if(num==a[i])
                {
                    count++;
                }
            }
            Console.WriteLine("Occurance of " + num + "Given Number = " + count);
        }
    }
}
