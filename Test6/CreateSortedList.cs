using System;
using System.Collections.Generic;
using System.Text;


namespace Test6
{
//WAP to create SortedList where key is of Integer type and value string and print all key-value pairs.
    class CreateSortedList
    {
        static void Main(string[] args)
        {
            SortedList<int,string> number = new SortedList<int,string>();
            
            number.Add(4, "Four");
            number.Add(1, "One");
            number.Add(3, "Three");
            number.Add(7, "Seven");
            number.Add(5, "Five");
            number.Add(6, "Six");
            number.Add(9, "Nine");
            number.Add(2, "Two");
            number.Add(10, "Ten");
            number.Add(8, "Eight");

            Console.WriteLine("Create SortedList : ");

            foreach (KeyValuePair<int,string> kv in number)
            {
                Console.WriteLine(kv.Key + " ==> " + kv.Value);
            }


        }
    }
}
