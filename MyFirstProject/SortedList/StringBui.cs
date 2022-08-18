using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.SortedList
{
    class myStringBuilderSort:IComparer<StringBuilder>
    {
        public int Compare(StringBuilder x,StringBuilder y)
        {
            return x.ToString().CompareTo(y.ToString());
        }
    }
    class StringBui
    {
        static void Main(string[] args)
        {
            SortedList<StringBuilder, int> sb = new SortedList<StringBuilder, int>(new myStringBuilderSort());
            sb.Add(new StringBuilder("Amit"), 90000);
            sb.Add(new StringBuilder("Smit"), 90000);
            sb.Add(new StringBuilder("Meet"), 90000);
            sb.Add(new StringBuilder("Amita"), 90000);
            sb.Add(new StringBuilder("Siya"), 90000);

            foreach(KeyValuePair<StringBuilder,int> kv in sb)
            {
                Console.WriteLine(kv.Key+" ===> " + kv.Value);
            }

            Dictionary<StringBuilder, int> dd = new Dictionary<StringBuilder, int>(sb);
        }
        
    }
}
