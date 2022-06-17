using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class VowelorConsonant
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the Choice");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'A' || ch == 'a' || ch == 'E'||ch=='e'||ch=='I'||ch=='i'||ch=='O'||ch=='o'||ch=='U'||ch=='u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
        }
    }
}
