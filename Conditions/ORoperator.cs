using System;
using System.Collections.Generic;
using System.Text;

namespace Conditions
{
    class ORoperator
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the number");
            char ch = Convert.ToChar(Console.ReadLine());

            if(ch=='a'||ch=='e'||ch=='i'||ch=='o'||ch=='u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonent");
            }
        }
    }
}
