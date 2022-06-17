using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    class StaticConstructor
    {
        static StaticConstructor()
        {
            Console.WriteLine("Calling Static Constructor");
        }

        static void Main(String[] args)
        {
            StaticConstructor s = new StaticConstructor();
            Console.WriteLine("Call that Constructor");
            Console.ReadLine();
        }
    }

    
    
    /////////////////////////////////////////////////////
    

    static class StaticClassDemo
    {
        static int x = 10;


        static void Main(String[] args)
        {
            Console.WriteLine(x);
        }
    }
}
