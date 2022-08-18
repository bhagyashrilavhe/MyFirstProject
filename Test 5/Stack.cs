using System;
using System.Collections.Generic;
using System.Text;

namespace Test5
{
    class Stack
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            Console.WriteLine("Total elements in Stack : " + myStack.Count);
            foreach (object ob in myStack)
            {
                Console.WriteLine(ob);
            }

            myStack.Pop();
            Console.WriteLine("Number of elements  in Stack : " + myStack.Count);
            foreach (object ob in myStack)
            {
                Console.WriteLine(ob);
            }

            myStack.Peek();
            Console.WriteLine("Number of Peek elements in Stack " + myStack.Count);

        }
    }
}
