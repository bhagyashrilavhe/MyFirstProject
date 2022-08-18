using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeExample.GenericCollection.HashSet
{
    class DuplicateElement
    {
        static void Main(string[] args)
        {
            HashSet<string> cities = new HashSet<string>() { "Pune", "Baramati", "Mumbai", "Surat" };

            cities.Add("Pune");
            cities.Add("Baramati");
            cities.Add("Mumbai");
            cities.Add("Surat");

            foreach(string s in cities)
            {
                Console.WriteLine(s);
            }


        }
    }
}
