using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MyFirstProject.Threads
{
    class Demo
    {
        // Thread
        // Single thread environment
        static void m1()
        {
            for(int i=1;i<=100;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Starts");
            Demo ob = new Demo();
            Thread t1 = new Thread(m1);
            Thread t2 = new Thread(Demo.m1);
            Thread.Sleep(2000);

            t1.Start();
            for(int i=1;i<=100;i++)
            {
                Console.WriteLine("Gm");
            }
            Console.WriteLine("Main Ends");
        }
    }
}
