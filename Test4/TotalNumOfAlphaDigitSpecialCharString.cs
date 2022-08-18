using System;
using System.Collections.Generic;
using System.Text;

namespace Test4
{
    // Write a program to find total number of alphabets, digits or special character in a string.
    class TotalNumOfAlphaDigitSpecialCharString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            string str = Console.ReadLine();
           
            int alpha = 0, digit = 0, specialchar = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z' || str[i] >= 'a' && str[i] <= 'z')
                {
                    alpha++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    specialchar++;
                }
            }
            Console.WriteLine("Number of Alphabet : " +alpha);
            Console.WriteLine("Number of Digit : "+digit);
            Console.WriteLine("Number of Special Character : "+specialchar);
        }
    }
}
