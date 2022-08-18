using System;
using System.Collections.Generic;
using System.Text;

namespace Test4
{
    // Write a program to check whether two strings are anagram or not?
    class AnagramOrNotTwoString
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Enter the first string : ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter the second string : ");
            string s2 = Console.ReadLine();

            char[] a1 = s1.ToLower().ToCharArray();
            char[] a2 = s2.ToLower().ToCharArray();

            Array.Sort(a1);
            Array.Sort(a2);

            string str1 = new string(a1);
            string str2 = new string(a2);

            if(str1==str2)
            {
                Console.WriteLine("String are Anagram");
            }
            else
            {
                Console.WriteLine("String are Not Anagram");
            }
        }
    }
}
