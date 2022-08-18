using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Dictionary
{
    class Add
    {
        static void Main(string [] args)
        {
            // Key should be unique

            Dictionary<string, int> dd = new Dictionary<string, int>();

            dd.Add("Bhagyashri", 90);
            dd.Add("PT", 90);
            dd.Add("Rutu", 91);
            // dd.Add("PT", 92);

            Console.WriteLine(dd["PT"]);
            dd["Bhagyashri"] = 94;
        }
    }
}
