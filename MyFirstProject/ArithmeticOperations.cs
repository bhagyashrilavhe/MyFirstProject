using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class ArithmeticOperations
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            num1 = 12;
            num2 = 7;

            /*Console.WriteLine("Enter the 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number");
            int num2 = int.Parse(Console.ReadLine());*/

            result = num1 + num2;
            Console.WriteLine("Addition = " +result);

            result = num1 - num2;
            Console.WriteLine("Subtaction = " +result);

            result = num1 * num2;
            Console.WriteLine("Multiplication = " +result);

            result = num1  / num2;
            Console.WriteLine("Division = " +result);

            result = num1 % num2;
            Console.WriteLine("Modulus = " +result);

        }
    }
}
