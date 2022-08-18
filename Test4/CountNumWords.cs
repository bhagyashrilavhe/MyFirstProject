using System;
using System.Collections.Generic;
using System.Text;

namespace Test4
{
    // Write a program to count the number of words in a string.
    class CountNumWords
    {
        public static void Countwords(string s)
        {
            string[] s1 = s.Split(" ");
            int count = 0;

            for (int i = 0; i < s1.Length; i++)
            {
                count++;
            }
            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the String : ");
            string str = Console.ReadLine();

            Countwords(str);
        }
    }
}
