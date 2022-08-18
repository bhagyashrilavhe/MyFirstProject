using System;
using System.Collections.Generic;
using System.Text;

namespace AdvTestPaper
{
  //WAP to draw the following pattern using . Note: Input is an odd number: [1M]*
   /* 12345
      ABCD
      123
      AB
      1
      AB
      123
      ABCD
      12345 */
    class Pattern
    {
        static void Main(string[] args)
        {
            for(int i=5;i>=1;i--)
            {
                for(int j=1;j<=i;j++)
                {
                    if(i%2==1)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write((char)(64 + j));
                    }
                }
                Console.WriteLine();
            }
            for (int i = 2; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % 2 == 1)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write((char)(64 + j));
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
