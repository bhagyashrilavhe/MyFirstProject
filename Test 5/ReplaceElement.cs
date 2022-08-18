using System;
using System.Collections.Generic;
using System.Text;

namespace Test5
{
   // WAP to replace the second element of an List with the specified element
    class ReplaceElement
    {

        static void Main(string[] args)
        {
            List<string> lst = new List<string>();

            lst.Add("Bhagyashri");
            lst.Add("Rutuja");
            lst.Add("Sushma");
            lst.Add("Priya");

            Console.WriteLine("Original List  : ");
            foreach (string list in lst)
            {
                Console.WriteLine(list);
            }

            //lst.rep(1, "Rutu");
            Console.WriteLine(lst);
        }
    }
}
