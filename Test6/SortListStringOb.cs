using System;
using System.Collections.Generic;
using System.Text;

namespace Test6
{
    // WAP to sort the elements of List that contains String objects. Print List.
    class SortListStringOb
    {
        static void Main(string[] args)
        {
            List<string> sort = new List<string>();

            sort.Add("Sam");
            sort.Add("Nik");
            sort.Add("Sayali");
            sort.Add("Rizz");
            sort.Add("Puja");

            Console.WriteLine("Before Sort Element : ");

            foreach (string ob in sort)
            {
                Console.WriteLine(ob);
            }
            Console.WriteLine("***************************");

            Console.WriteLine("after sort:");

            sort.Sort();

            foreach (string ob in sort)
            {
                Console.WriteLine(ob);
            }

            Console.WriteLine("******Contains********");
            Console.WriteLine((sort.Contains("Priya")));
            Console.WriteLine((sort.Contains("Sam")));
        }
    }
}
