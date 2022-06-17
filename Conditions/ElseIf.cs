using System;
using System.Collections.Generic;
using System.Text;

namespace Conditions
{
    class ElseIf
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter Char");
            char ch = Console.ReadLine()[0];

            if(ch>='a')
            {
                if(ch<='z')
                {
                    Console.WriteLine("alphabet");
                }
            }
            else if(ch>='A' && ch<='Z')
            {
                Console.WriteLine("Alphabet");
            }
            else if (ch>='0' && ch<='9')
            {
                Console.WriteLine("Digit");
            }
            else
            {
                Console.WriteLine("Symbol");
            }
        }
    }
}
