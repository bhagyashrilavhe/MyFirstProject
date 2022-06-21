using System;
using System.Collections.Generic;
using System.Text;

namespace Test3
{
    class BuzzFizz
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Display number from 1 to 50 :  ");
      
            for(int i = 1;i <= 50; i++)
            {
                if(i%3==0)
                {
                    Console.WriteLine("buzz");
                }
                else if(i%5==0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 3 == 0  && i % 5 == 0)
                {
                    Console.WriteLine("buzzfizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
