using System;
using System.Collections.Generic;
using System.Text;

namespace AdvTestPaper
{
 /* WAP to accept a number and check whether it is binary or not.If not throw custom
    exception InvalidBinaryNumber. */

    class InvalidBinaryNumberException:ApplicationException
    {
        public InvalidBinaryNumberException(string msg):base(msg)
        {

        }
    }
    class BinaryNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Binary Number : ");
            int bin = int.Parse(Console.ReadLine());
            bool isbinary = true;

            while(bin>0)
            {
                int digit = bin % 10;
                if(digit>1)
                {
                    throw new InvalidBinaryNumberException("Binary Number show have 0 or 1 only");
                }
                bin = bin / 10;
            }
        }
    }
}
