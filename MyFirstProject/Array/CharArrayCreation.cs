using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class CharArrayCreation
    {
        static void Main(String[] args)
        {
            Console.WriteLine("enter the Array element : ");

            char[] ch1 = new char[4];
            for(int i=0;i<ch1.Length;i++)
            {
                ch1[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("/////////////////");

            for(int i=0;i<ch1.Length;i++)
            {
                Console.Write(ch1[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("/////////////////");

            foreach(int x in ch1)
            {
                Console.WriteLine(ch1);
            }
            Console.WriteLine("/////////////////");

            Console.WriteLine(string.Join(" ", ch1));
        }
    }
}
