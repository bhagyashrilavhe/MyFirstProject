using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class SimpleCalculator
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("Addition");
            Console.WriteLine("Substraction");
            Console.WriteLine("Multiplication");
            Console.WriteLine("Division");
            Console.WriteLine("Enter Choice 1 to 4");
            char ch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter A :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter B :");
            int b = int.Parse(Console.ReadLine());

            int result;

            switch (ch)
            {
                case '+':
                    result = a + b;
                    Console.WriteLine(result);
                    break;
                case '-':
                    result = a - b;
                    Console.WriteLine(result);
                    break;
                case '*':
                    result = a * b;
                    Console.WriteLine(result);
                    break;
                case '/':
                    result = a / b;
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
