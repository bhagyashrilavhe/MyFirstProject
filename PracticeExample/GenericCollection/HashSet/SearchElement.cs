using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeExample.GenericCollection.HashSet
{
    class SearchElement
    {
        static void Main(string[] args)
        {
            HashSet<int> num = new HashSet<int>() { 1, 2, 3, 4, 5 };
            foreach(int i in num)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("**************************");
            // Search Element
            if (num.Contains(4))
            {
                Console.WriteLine("4 is found in the collection");
            }
            else
            {
                Console.WriteLine("4 is not found in the collection");
            }
            
        }
    }
}
