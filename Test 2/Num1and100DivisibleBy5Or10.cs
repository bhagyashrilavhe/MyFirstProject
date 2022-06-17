using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    class Num1and100DivisibleBy5Or10
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Divisible by 5 or 10 : ");
            for(int i=1;i<=100;i++)
            {
                if(i%5==0 && i%10==0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();
        }
    }
}
