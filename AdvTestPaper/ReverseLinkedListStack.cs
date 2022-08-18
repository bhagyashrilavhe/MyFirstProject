using System;
using System.Collections.Generic;
using System.Text;

namespace AdvTestPaper
{
    // WAP to Reverse a linked list using Stack
    class ReverseLinkedListStack
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();
            Stack<int> rev = new Stack<int>();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Push(5);
            st.Push(6);

            Console.WriteLine("Current stack: ");
            foreach (int s in st)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            while (st.Count != 0)
            {
                rev.Push(st.Pop());
            }

            Console.WriteLine("*************************");

            Console.WriteLine("Reversed stack: ");
            foreach (int s in rev)
            {
                Console.Write(s + " ");
            }

        }
    }
}
