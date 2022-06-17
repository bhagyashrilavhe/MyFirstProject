using System;
using System.Collections.Generic;
using System.Text;

namespace Test11
{
    class VowelOrConsonent1
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter Char");
            char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                    Console.WriteLine("Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Consonent");
                    break;
            }

        }
    }
}
