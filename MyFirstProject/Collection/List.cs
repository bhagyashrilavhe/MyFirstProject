using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Collection
{
    class List
    {
        static void Main(string [] args)
        {
            
            List<int> lst = new List<int>();
            //Add Remove replace
            lst.Add(100);
            lst.Add(200);
            lst.Add(300);
            lst.Add(400);
            lst.Add(500);
            lst.Add(300);
            lst.Add(300);
            lst.Add(300);
            lst.Add(300);
            lst.Remove(300);

            lst[0] = 1000;
            Console.WriteLine(lst.Count);
            Console.WriteLine(lst.Capacity);
            //Console.WriteLine(lst);
            for (int i = 0; i < lst.Count; i++)
                Console.WriteLine(lst[i]);

            foreach (int data in lst)
                Console.WriteLine(data);


            //lst.Clear();
            Console.WriteLine((lst.Contains(90)));

            Console.WriteLine("indexOf" + lst.IndexOf(309));

            List<int> lst2 = new List<int>() { 111, 112, 113 };
            //lst2.AddRange(lst);
            lst2.InsertRange(1, lst);

            for (int i = 0; i < lst2.Count; i++)
                Console.Write(lst2[i] + " ");
        }
    }
}
