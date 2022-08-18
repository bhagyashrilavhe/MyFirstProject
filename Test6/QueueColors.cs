using System;
using System.Collections.Generic;
using System.Text;

namespace Test6
{
    // WAP to create a Queue with some colors (String) using generics.
    class QueueColors
    {
        static void Main(string[] args)
        {
            Queue<string > colors = new Queue<string>();

            colors.Enqueue("Black");
            colors.Enqueue("Pink");
            colors.Enqueue("Red");
            colors.Enqueue("White");
            colors.Enqueue("Blue");
            colors.Enqueue("Orange");

            Console.WriteLine("Colors Elements : ");

            foreach(string s in colors)
            {
                Console.WriteLine(s);
            }
        }
    }
}
