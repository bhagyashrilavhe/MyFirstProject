using System;
using System.Collections.Generic;
using System.Text;

namespace NestedLoop
{
    class NumberPattern
    {
        static void Main(String[] args)
        {

            //1 2 3 4
            //2 3 4
            //3 4
            //4

             for (int i = 1; i <= 4; i++)
              {
                  for (int j = i; j <= 4; j++)
                  {
                      Console.Write(j+" ");

                  }
                  Console.WriteLine();
              }
            Console.WriteLine("/////////////");


            //1 2 3 4 
            //1 2 3
            //1 2
            //1

            for (int i = 4; i >= 1; i--)
             {
                 for (int j = 1; j <= i; j++)
                 {
                     Console.Write(j+" ");
                 }
                 Console.WriteLine();
             }
            Console.WriteLine("/////////////");



            //4 3 2 1 
            //4 3 2 
            //4 3
            //4

            for (int i = 1; i <= 4; i++)
             {
                 for (int j = 4; j >= i; j--)
                 {
                     Console.Write(j + " ");

                 }
                 Console.WriteLine();
            }
            Console.WriteLine("/////////////");

            //1
            //2 3
            //4 5 6

            int k = 1;

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(k+ " ");
                    k++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("/////////////");

            //1
            //1 0
            //1 0 1
            //1 0 1 0

            int max = 4;
            int count = max + 1;
            for(int i=1 ; i<=max ; i++)
            {
                for(int j=1 ; j<=i ; j++)
                {
                    if(j%2!=0)
                    {
                        Console.Write(" 1 ");
                    }
                    else
                    {
                        Console.Write(" 0 ");
                    }
                }
                count--;
                Console.WriteLine();
            }
            Console.WriteLine("/////////////");

            //1 2 3 4
            //1 2 3 4
            //1 2 3 4
            //1 2 3 4

            for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=4;j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("/////////////");

            //1 1 1 1
            //2 2 2 2
            //3 3 3 3
            //4 4 4 4

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("/////////////");

            //1
            //1 2
            //1 2 3
            //1 2 3 4

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("/////////////");



            



        }
    }
    
}
