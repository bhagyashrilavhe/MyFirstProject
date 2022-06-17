using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Factorial
    {
        static void Main(String[] args)
        {
            //Console.WriteLine("Enter the Number : ");
            //int number = int.Parse(Console.ReadLine());

            int num = 5;

            int factorial = 1;
            for (int i = 1; i <= 5; i++)
            {
                factorial = factorial * i;
            }
            Console.Write($"Factorial of number  is: {factorial}");


        }
    }
}
