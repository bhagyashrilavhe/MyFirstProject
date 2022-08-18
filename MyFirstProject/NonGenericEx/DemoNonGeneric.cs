using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace MyFirstProject.NonGenericEx
{
    class DemoNonGeneric
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>() { 1, 2, 3, 4 };

            ArrayList al = new ArrayList();

            Hashtable ht = new Hashtable();
            ht.Add(90, "A");
            ht.Add("Om",900);
            ht.Add(9.4f,78);
            
            foreach(DictionaryEntry kv in ht)
            {
                Console.WriteLine(kv.Key + "==>" + kv.Value);
            }

           /* SortedList sl = new SortedList();
            sl.Add("Ora", "Oracle");
            sl.Add("vb", 90);
            sl.Add("Cs", 7.8f);*/
           




        }
    }
}
