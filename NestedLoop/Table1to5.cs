using System;
using System.Collections.Generic;
using System.Text;

namespace NestedLoop
{
    class Table1to5
    {
        static void Main(String[] args)
        {
            int num,result;
            for(int i=1;i<=5;i++)
            {
                num = i;
                for(int j=1;j<=10;j++)
                {
                    result = num * j;
                    Console.WriteLine(result);
                }
                Console.WriteLine(" ");
            }
        }
    }
}
