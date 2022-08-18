using System;
using System.Collections.Generic;
using System.Text;

namespace Test5
{
    class CreateList
    {
        // WAP to create a new List, add some colors (string) and print the collection.
        static void Main(string[] args)
        {
            List<string> color = new List<string>();

            color.Add("Pink");
            color.Add("Red");
            color.Add("Yellow");
            color.Add("Blue");
            color.Add("Black");
            color.Add("White");
            color.Add("Green");
            color.Add("Orange");

            Console.WriteLine("List  of Collection : ");
            foreach (string list in color)
            {
                Console.WriteLine(list);
            }

        }
    }
}
