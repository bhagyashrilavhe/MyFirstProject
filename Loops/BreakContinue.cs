using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    class BreakContinue
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter");

            /*  for(int i=1;i<=5;i++)
              {
                  if(i==3)
                  {
                      break;
                  }
                  Console.WriteLine(i);  //1 2
              } */


            for (int i = 1; i <= 10; i++)
            {
                if (i == 3 || i == 7 || i == 9)
                {
                    continue;
                }
                Console.WriteLine(i);  //1 2 4 5 6 8 10
            }
            


        }
    }
}
