using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    class Mystrey
    {
        static void Main(String[] args)
        {
            for(int i=5;i>0;i--)
            {
                int mysteryInt = 100;
                mysteryInt -= i;
                Console.WriteLine(mysteryInt);
            }
        }
    }
}
