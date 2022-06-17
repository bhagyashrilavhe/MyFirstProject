using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    class OddNum15To30
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Odd number from 15to 30");

            for (int i = 15; i < 30; i++)
            {
               if(i%2!=0)
                {
                    Console.WriteLine(i);
                }
                

                
            }
        }
            
    }
}
