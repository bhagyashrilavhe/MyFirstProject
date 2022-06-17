using System;
using System.Collections.Generic;
using System.Text;

namespace NestedLoop
{
    class NumCharPattern
    {
        static void Main(String[] args)
        {
            int c = 64;

            for(int i=1;i<5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    if(i%2==0)
                    {
                        Console.Write((char)(c+j));
                    }
                    else
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
