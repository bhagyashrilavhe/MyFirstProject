using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class OddEvenNum
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any number : ");
            int num = int.Parse(Console.ReadLine());

            if(num%2==0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}
