using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    class MagicNumber
    {
        static void Main (String[] args)
        {
            int magicnumber = 77;

            for(; ; )
            {
                Console.WriteLine("Enter the number");
                int num = int.Parse(Console.ReadLine());

                if(num<magicnumber)
                {
                    Console.WriteLine("Number is less than magicnumber pls try again.....");
                    continue;
                }
                else if(num>magicnumber)
                {
                    Console.WriteLine("Number is greater pls try again......");
                    continue;
                }
                else
                {
                    Console.WriteLine("Congratulation Number is match....");
                    break;
                }
            }
        }
    }
}
