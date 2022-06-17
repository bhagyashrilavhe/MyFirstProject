using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    class SpyNumber
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the Number : ");
            int num = int.Parse(Console.ReadLine());

            int sum = 0, product = 1, rem;

            while (num != 0)
            {
                rem = num % 10;
                sum = sum + rem;
                product = product * rem;
                num = num / 10;
            }
            if (sum == product)
            {
                Console.WriteLine("Spy Number");
            }
            else
            {
                Console.WriteLine("Not spy number");
            }

        }
    }
}
