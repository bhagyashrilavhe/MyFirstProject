using System;
using System.Collections.Generic;
using System.Text;

namespace Test5
{
    // WAP of swap two elements in an List
    class SwapTwoElement
    {
        static void Main(string [] args)
        {
            List<string> ll = new List<string>() { "Bhagya", "Rutuja", "Priya", "Sushma" };

            string temp = ll[1];
            ll[1] = ll[2];
            ll[2] = temp;

            foreach(String s in ll)
            {
                Console.WriteLine(s);
            }
        }
    }
}
