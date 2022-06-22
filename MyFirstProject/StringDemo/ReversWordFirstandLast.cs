using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringDemo
{
    class ReversWordFirstandLast
    {
        public static void revers(string s)
        {
            string[] s1 = s.Split(" ");
            string rev = " ";

            for(int i=0;i<s1.Length;i++)
            {
                if(i==0 || i==s1.Length-1)
                {
                    rev = rev + " " + s1[i];
                }
                else
                {
                    string word = s1[i];
                    string revs = " ";

                    for(int j=word.Length-1;j>=0;j--)
                    {
                        revs = revs + word[j];
                    }
                    rev = rev + " " + revs;
                }
            }
            Console.WriteLine(rev);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String : ");
            string str = Console.ReadLine();

            revers(str);
        }
    }
}
