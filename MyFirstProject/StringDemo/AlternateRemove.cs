using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringDemo
{
    class AlternateRemove
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            string str = Console.ReadLine();
            int i = 0;
            int length = str.Length;
            while(i!=length)
            {
                for(int j=i;j<=str.Length-1;j++)
                {
                    if(str[i]!=str[j])
                    {
                        str = str.Remove(j, 1);
                        break;
                    }
                }
               // length = str.Length;
                i++;
            }
            Console.WriteLine(str);
        }
    }
}
