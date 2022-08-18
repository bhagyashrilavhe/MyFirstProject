using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvTestPaper
{
  /* Given two LinkedList, we need to combine two LinkedList in such a way that the
     combined a List has alternate elements of both. If one list has extra element, then
     these elements are appended at the end of the combined list.[1M]
     Input : list1 = {1, 2, 3, 4, 5, 6}
     List2 = {11, 22, 33, 44}
     List3: {1, 11, 2, 22, 3, 33, 4, 44, 5, 6} */
    class CombineTwoLinkedList
    {
        static void Main(string[] args)
        {
            LinkedList<int> l1 = new LinkedList<int>();
            l1.AddLast(1);
            l1.AddLast(2);
            l1.AddLast(3);
            l1.AddLast(4);
            l1.AddLast(5);
            l1.AddLast(6);

            LinkedList<int> l2 = new LinkedList<int>();
            l2.AddLast(11);
            l2.AddLast(22);
            l2.AddLast(33);
            l2.AddLast(44);

            LinkedList<int> l3 = new LinkedList<int>();

            int i = 0;// new l1 add
            int k = 0;// common
            while(i<l1.Count+l2.Count)
            {
                if(k<l1.Count && k<l2.Count)
                {
                    l3.AddLast(l1.ElementAt(k));
                    l3.AddLast(l2.ElementAt(k));
                    k++;
                }
                else if(k<l1.Count)
                {
                    l3.AddLast(l1.ElementAt(k));
                    k++;
                }
                else
                {
                    l3.AddLast(l2.ElementAt(k));
                    k++;
                }
                i++;
            }
            foreach (int d in l1)
                Console.Write(d + " ");
            Console.WriteLine("*****************");

            foreach (int d in l2)
                Console.Write(d + " ");
            Console.WriteLine("*****************");

            foreach (int d in l3)
                Console.WriteLine(d + " ");
           
        }
    }
}
