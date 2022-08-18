using System;
using System.Collections.Generic;
using System.Text;

namespace Test6
{
// WAP to create Dictionary where key is of string type and value of float type and print all key-value pairs.
    class CreateDictionary
    {
        static void Main(string[] args)
        {
            Dictionary<String, float> dd = new Dictionary<string, float>();

            dd.Add("Bhagyashri", 90.1f);
            dd.Add("Priya", 88.2f);
            dd.Add("Saloni", 77.5f);
            dd.Add("Manisha", 92.4f);

            Console.WriteLine("Create Dictionary : ");

            foreach (KeyValuePair<string, float> kvp in dd)
            {
                Console.WriteLine(kvp.Key + " ==> " + kvp.Value);
            }
        }
    }
}
