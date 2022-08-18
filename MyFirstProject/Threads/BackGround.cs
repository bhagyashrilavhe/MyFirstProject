using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MyFirstProject.Threads
{
    class BackGround
    {
        public static void m1()
        {
          for(int i=1;i<=30;i=i+2)
          {
                Console.WriteLine("Odd : " + i + Thread.CurrentThread.Name);
          }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(m1);
            t1.IsBackground = true; // helper
            t1.Start();
        }
    }
}
