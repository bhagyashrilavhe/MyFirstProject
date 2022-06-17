using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    class SumEven1To10
    {
        static void Main(String[] args)
        {
            int sum = 0;
          
            for(int i =2;i<=10;i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;

                }
            }
            Console.WriteLine( sum);
        }
    }
}
