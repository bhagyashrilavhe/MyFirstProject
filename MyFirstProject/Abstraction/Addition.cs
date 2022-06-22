using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Abstraction
{
    public interface IFirstable
    {
        static int x = 50;
       
    }
    abstract class Second
    {
        public static int y = 40;
    }
    class Addition:Second,IFirstable
    {
      public void Add()
        {
            Console.WriteLine("Addition is  " + (IFirstable.x + Second.y));
        }
        static void Main(string [] args)
        {
            Addition a = new Addition();
            a.Add();
            

        }
    }
}
