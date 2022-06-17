using System;
using System.Collections.Generic;
using System.Text;

namespace NestedLoop
{
    class CharPattern
    {
        static void Main(String[] args)
        {

            //A A A A
            //B B B B
            //C C C C
            //D D D D

            for(char ch='A';ch<='D';ch++)
            {
                for(char ch2='A';ch2<='D';ch2++)
                {
                    Console.Write(ch + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("///////////////////");

            //A B C D 
            //A B C D 
            //A B C D
            //A B C D

            for (char ch = 'A'; ch <= 'D'; ch++)
            {
                for (char ch2 = 'A'; ch2 <= 'D'; ch2++)
                {
                    Console.Write(ch2 + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("///////////////////");

            //A 
            //B B 
            //C C C
            //D D D D

            for (char ch = 'A'; ch <= 'D'; ch++)
            {
                for (char ch2 = 'A'; ch2 <= ch ; ch2++)
                {
                    Console.Write(ch + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("///////////////////");


        }
    }
}
