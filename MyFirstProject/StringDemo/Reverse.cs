using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringDemo
{
    class Reverse
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Enter the string : ");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();

            string revers = "";
            for(int i=ch.Length-1;i>=0;i--)
            {
                revers = revers + ch[i];
            }
            Console.WriteLine(revers);
        }
    }
}
