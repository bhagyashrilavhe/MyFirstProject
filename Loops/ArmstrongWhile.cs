using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    class ArmstrongWhile
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the numbe");
            int num = int.Parse(Console.ReadLine());

            int sum = 0, r, temp;

            temp = num;

            while(num>0)
            {
                r = num % 10;
                sum = sum + (r * r * r);
                num = num / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine("Armstrong number");
            }
            else
            {
                Console.WriteLine("Not armstrong number");
            }
        }
    }
}
