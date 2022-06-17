using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
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
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter num1:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2 :");
            int b = int.Parse(Console.ReadLine());
            int result;

            switch (num)
            {
                case 1:
                    result = a + b;
                    Console.WriteLine(result);
                    break;
                case 2:
                    result = a - b;
                    Console.WriteLine(result);
                    break;
                case 3:
                    result = a * b;
                    Console.WriteLine(result);
                    break;
                case 4:
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
