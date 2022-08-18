using System;
using System.Collections.Generic;
using System.Text;

namespace Test5
{
    // WAP to sort the elements of List that contains String objects. Print List.
    class SortList
    {
        static void Main(string[] args)
        {
            List<string> sort = new List<string>();

            sort.Add("Omkar");
            sort.Add("Bhagya");
            sort.Add("Nilesh");
            sort.Add("Tushar");
            sort.Add("Nikita");

            Console.WriteLine("Before Sort Element : ");

            foreach (string ob in sort)
            {
                Console.WriteLine(ob);
            }
            Console.WriteLine("***************************");

            Console.WriteLine("ArrayList after sort:");

            sort.Sort();

            foreach (string ob in sort)
            {
                Console.WriteLine(ob);
            }
            Console.WriteLine((sort.Contains("Priya")));
        }
    }
}
