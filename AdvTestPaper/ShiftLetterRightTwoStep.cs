using System;
using System.Collections.Generic;
using System.Text;

namespace AdvTestPaper
{
    /* WAP to accept a string and make following changes [1M]
        1. Shift each letter right by two step eg A ->C ,Y->A,Z->B
        2. Each digit by next higher digit.
        3. Space by underscore */
    class ShiftLetterRightTwoStep
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string : ");
            string str = Console.ReadLine().ToUpper();
            int step = 2;
            int newchar = 0;

            foreach(char ch in str)
            {
                if(char.IsLetter(ch))
                {
                    newchar = ch + step;
                    if(newchar > 90)
                    {
                        newchar = newchar - 26;
                    }
                }
                else if(char.IsDigit(ch))
                {
                    newchar = ch;
                    newchar++;
                }
                Console.Write((char)newchar);
            }
        }
    }
}
