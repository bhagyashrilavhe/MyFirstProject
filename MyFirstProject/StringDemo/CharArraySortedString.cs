using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringDemo
{
    class CharArraySortedString
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Enter the string : ");
            string str = Console.ReadLine();
            //char[] ch = str.ToCharArray();
            string[] s = str.Split(" ");

            for(int i=0;i<s.Length;i++)
            {
                for(int j=i+1;j<s.Length;j++)
                {
                    if(s[i].CompareTo(s[j])==-1)
                    {
                        string temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", s));
        }
    }
}
