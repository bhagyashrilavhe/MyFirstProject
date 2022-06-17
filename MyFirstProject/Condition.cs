using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Condition
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any Number");
            int num = int.Parse(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine("Number is +ve");
            }
            else
            {
                Console.WriteLine("Number is -ve");
            }
        }
    }
}
