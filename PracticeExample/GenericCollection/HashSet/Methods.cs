using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeExample.GenericCollection.HashSet
{
    class Methods
    {
        static void Main(string[] args)
        {
            HashSet<string> names1 = new HashSet<string>() { "Sam", "Bhagya", "Pritam", "Nik" };
            HashSet<string> names2 = new HashSet<string>() { "Rizz", "Nik", "Sayali", "Bhagya","supriya" };

            // *****UnionWith*****
            //names1.UnionWith(names2);

            // *****IntersectWith*****
            //names1.IntersectWith(names2);

            //*****ExceptWith*****
            names1.ExceptWith(names2);

            foreach (string s in names1)
            {
                Console.WriteLine(s);
            }
        }
    }
}
