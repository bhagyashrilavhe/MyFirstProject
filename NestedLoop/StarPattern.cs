using System;
using System.Collections.Generic;
using System.Text;

namespace NestedLoop
{
    class StarPattern
    {
        static void Main(String[] args)
        {
            /* for(int i=1;i<=4;i++)
              {
                  for(int j=1;j<=4;j++)
                  {
                      if(i==1||i==4||j==1||j==4)
                      {
                          Console.Write("*");
                      }
                      else
                      {
                          Console.Write(" ");
                      }

                  }
                  Console.WriteLine();

              }*/

            /*for (int i = 1; i <= 4; i++)
            {
                for(int k=4;k>=i;k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();

            }*/

            //Triangle

            /* for(int i=1;i<=4;i++)
             {
                 for(int j=i;j<=4;j++)
                 {
                     Console.Write(" ");
                 }
                 for(int k=1;k<=(2*i-1);k++)
                 {
                    // if (i == 4|| j == 1 || k == (2 * i - 1))
                     {
                         Console.Write("*");
                     }
                     Console.Write(" ");
                 }
                 Console.WriteLine();
             }*/

            // Left triangle

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j == 1 || i == j || i == 5)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            //Plus

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    if (j == 5 || i == 5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            // * * *
            // * * *
            // * * *

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("/////////////");

            // *
            // * *
            // * * *
            // * * * *

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("/////////////");

            // * * * *
            // * * *
            // * * 
            // *

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("/////////////");
        } 
    }
}
