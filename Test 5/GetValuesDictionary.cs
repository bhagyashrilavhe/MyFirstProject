using System;
using System.Collections.Generic;
using System.Text;

namespace Test5
{
    // WAP to get only the Values from a Dictionary.
    class GetValuesDictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> num = new Dictionary<string, int>();

            num.Add("One",1);
            num.Add("Two",2);
            num.Add("Three",3);
            num.Add("Four",4);
            num.Add("Five",5);
            num.Add("Six",6);
            num.Add("Seven",7);
            num.Add("Eight",8);
            num.Add("Nine", 9);
            num.Add("Ten", 10);

            List<int> values = new List<int>(num.Values);
            Console.WriteLine("Displaying values...");

            foreach (int value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
