using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchCase
{
    class OddEven
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any Number :");
            int num = int.Parse(Console.ReadLine());

            switch(num%2)
            {
                case 0:
                    Console.WriteLine(num + " is even Number");
                    break;
                case 1:
                    Console.WriteLine(num + "  is odd Number");
                    break;
                default:
                    Console.WriteLine("Invalid ");
                    break;

            }
        }
    }
}
