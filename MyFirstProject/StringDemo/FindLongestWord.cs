using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringDemo
{
    class FindLongestWord
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Enter the string : ");
            string str = Console.ReadLine();

            string[] s = str.Split(" ");

            int maxLength = 0;
          //  string longestword = "";

            for(int i=0;i<s.Length;i++)
            {
                if(s[i].Length>maxLength)
                {
                    maxLength = s[i].Length;
                    //longestword = s[i];
                }
            }
            for(int i=0;i<s.Length;i++)
            {
                if(maxLength==s[i].Length)
                {
                    Console.WriteLine(s[i]);
                }
            }

          //  Console.WriteLine(longestword + " " + maxLength);
        }
    }
}
