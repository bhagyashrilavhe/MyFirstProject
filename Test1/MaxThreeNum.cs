using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class MaxThreeNum
    {
        static void Main(String[] args)
        {
             Console.WriteLine("Enter the num1 ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num2 ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num3 ");
            int num3 = int.Parse(Console.ReadLine());


            if(num1>num2 && num1>num3)
            {
                Console.WriteLine("Num1 is largest");
            }
            else if(num2>num3)
            {
                Console.WriteLine("Num2 is largest");
            }
            else
            {
                Console.WriteLine("Num3 is largest");
            }
        }
    }
}
