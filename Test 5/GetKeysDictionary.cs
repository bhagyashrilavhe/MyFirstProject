using System;
using System.Collections.Generic;
using System.Text;

namespace Test5
{
    // WAP to get only the Keys from a Dictionary.
    class GetKeysDictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> sub = new Dictionary<string, int>();

            sub.Add("Maths", 95);
            sub.Add("English", 90);
            sub.Add("Chemistry", 91);
            sub.Add("Biology", 87);
            sub.Add("Physics", 80);

            List<string> keys = new List<string>(sub.Keys);
            Console.WriteLine("Displaying keys...");

            foreach (string key in keys)
            {
                Console.WriteLine(key);
            }
        }
    }
}
