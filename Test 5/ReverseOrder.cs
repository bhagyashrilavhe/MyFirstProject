using System;
using System.Collections.Generic;
using System.Text;

namespace Test5
{
    // WAP to print list in reverse order .
    class ReverseOrder
    {
        static void Main(string[] args)
        {
            List<int> firstlist = new List<int>();

            for (int i = 1; i <= 5; i++)
            {
                firstlist.Add(i);
            }

            Console.WriteLine("Present in First List : ");

            foreach (int list in firstlist)
            {
                Console.WriteLine(list);
            }
            Console.WriteLine("***************************");

            Console.WriteLine("After Reversing List : ");

            firstlist.Reverse();

            foreach (int list in firstlist)
            {
                Console.WriteLine(list);
            }
        }
    }
}
