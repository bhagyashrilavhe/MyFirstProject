using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Swapping
    {
        static void Main(string[] args)
        {
            int num1 = 6;
            int num2 = 8, temp;
            Console.WriteLine("Enter the value of num1 is " +num1);
            Console.WriteLine("Enter the value of num2 is " +num2);
                temp = num1;
                num1 = num2;
                num2 = temp;
            Console.WriteLine("After Swapping value of num1 is "+num1);
            Console.WriteLine("After Swapping value of num2 is " +num2);
        }
    }
}
