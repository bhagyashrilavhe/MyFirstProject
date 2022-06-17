using System;
using System.Collections.Generic;
using System.Text;

namespace Ternary
{
    class MultipleFiveNumber
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            string mul = num % 5 == 0 ? "Number is multiple of 5" : "Number is not multiple of 5";
            Console.WriteLine(mul);
        }
    }
}
