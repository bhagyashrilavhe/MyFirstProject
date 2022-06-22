using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringDemo
{
    class CountNumofWords
    {
        public static void words(string s)
        {
            string[] s1 = s.Split(" ");
            int count = 0;

            for(int i=0;i<s1.Length;i++)
            {
                count++;
            }
            Console.WriteLine(count);
        }
        static void Main(string [] args)
        {

            Console.WriteLine("Enter the String : ");
            string str = Console.ReadLine();

            words(str); 
        }
    }
}
