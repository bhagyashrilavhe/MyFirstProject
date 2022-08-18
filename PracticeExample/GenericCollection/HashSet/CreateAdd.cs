using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeExample.GenericCollection.HashSet
{
    class CreateAdd
    {
        static void Main(string[] args)
        {
            HashSet<string> name = new HashSet<string>() { "Bhagyashri", "Priya", "Sushma", "Rutuja" };

            /*name.Add("Bhagyashri");
            name.Add("Supriya");
            name.Add("Sam");
            name.Add("Rizz");*/

            // new add element
            name.Add("Nik");

            // Remove Element
            name.Remove("Bhagyashri");

            foreach(string s in name)
            {
                Console.WriteLine(s);
            }
        }
    }
}
