using System;
using System.Collections.Generic;
using System.Text;

namespace Test5
{
    //  WAP to create a Queue to add 5 objects and also remove first two and iterate over it.
    class QueueAdd
    {
        static void Main(string[] args)
        {
            Queue<int> myQueue = new Queue<int>();

            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Enqueue(5);

            foreach (Object obj in myQueue)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("**************************");

            Console.WriteLine("Remove First Two Element : ");

            myQueue.Dequeue();
            myQueue.Dequeue();

            foreach (Object obj in myQueue)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
