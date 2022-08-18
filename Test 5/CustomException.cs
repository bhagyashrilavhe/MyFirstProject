using System;
using System.Collections.Generic;
using System.Text;

namespace Test5
{
    // WAP to create custom Exception and show use of throw keyword
    public class OddNumberException : Exception
    {
        public override string Message
        {
            get
            {
                return "divisor cannot be odd number";
            }
        }
    }
    class CustomException
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Enter two number : ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            try
            {
                if (y % 2 != 0)
                {
                    throw new OddNumberException();
                }
                z = x / y;
                Console.WriteLine(z);
            }
            catch (OddNumberException one)
            {
                Console.WriteLine(one.Message);
            }
           
        }
    }
}
