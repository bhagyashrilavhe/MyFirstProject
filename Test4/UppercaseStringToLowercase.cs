using System;
using System.Collections.Generic;
using System.Text;

namespace Test4
{
    // Write a program to convert uppercase string to lowercase.
    class UppercaseStringToLowercase
    {
        public static string Convertstr(string str)
        {
            string newstring = "";

            for(int i=0;i<str.Length;i++)
            {
                if(char.IsUpper(str[i]))
                {
                    newstring = newstring + char.ToLower(str[i]);
                }
                /*else if(char.IsLower(str[i]))
                {
                    newstring = newstring + char.ToUpper(str[i]);
                }*/
                else
                {
                    newstring = newstring + str[i];
                }
            }
            return newstring;
        }
        static void Main(string [] args)
        {

            Console.WriteLine("Enter the string : ");
            string s = Console.ReadLine();

            Console.WriteLine(Convertstr(s));
        }
    }
}
