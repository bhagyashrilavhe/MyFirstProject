using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringDemo
{
    class StringInPattern
    {
        public static void pattern(string str1)
        {
            string[] str2 = str1.Split(" ");

            for(int i=0;i<str2.Length;i++)
            {
                string s = "";

                for(int j=0;j<=i; j++)
                {
                    s = s + " " + str2[j];
                }
                Console.WriteLine(s);
            }
        }
        static void Main(string [] args)
        {
            Console.WriteLine("Enter the String : ");
            string str = Console.ReadLine();

            pattern(str);
        }
    }
}
