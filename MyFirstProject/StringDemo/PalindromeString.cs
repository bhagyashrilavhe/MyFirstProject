using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringDemo
{
    class PalindromeString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            string str = Console.ReadLine();

            //string[] s = str.Split(" ");

            string revers = "";

            for (int i=str.Length-1;i>=0;i--)
            {
                revers = str[i]+revers ;
            }
            
            if(revers==str)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
           
        }
    }
}
