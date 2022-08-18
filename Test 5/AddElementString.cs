using System;
using System.Collections.Generic;
using System.Text;

namespace Test5
{
    // WAP add elements to List<String>,insert at specifies=d position ,update and delete a element.
    class AddElementString
    {
        static void Main(string[] args)
        {
            List<string> lst = new List<string>();

            lst.Add("A");
            lst.Add("B");
            lst.Add("C");
            lst.Add("E");
            lst.Add("Y");
            lst.Add("F");

            lst.Insert(3,"D");

            Console.WriteLine("Count of elements (updated) = " + lst.Count);
           
            lst.Remove("Y");

            Console.WriteLine("Element List : ");

            foreach (string  x in lst)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Count of elements (updated) = " + lst.Count);
        }
    }
}
