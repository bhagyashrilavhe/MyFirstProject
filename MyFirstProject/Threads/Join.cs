using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace MyFirstProject.Threads
{
    class Join
    {
        public static void m1()
        {
            for (int i = 1; i <= 20; i = i + 2)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Starts : ");
            Thread t1 = new Thread(m1);
            t1.Start();

            //The currently thread which is executing the method will wait till t1 thread
            //Completes thread its logic.
            t1.Join();

            for(int i=200;i<=220;i=i+2)
            {
                Console.WriteLine("Main : " + i);
            }

        }
    }
}
