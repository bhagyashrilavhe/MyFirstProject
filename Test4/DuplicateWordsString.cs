using System;
using System.Collections.Generic;
using System.Text;

namespace Test4
{
    // Write a program to find the duplicate words and their number of occurrences in a string.
    class DuplicateWordsString
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Enter the string : ");
            string s = Console.ReadLine();

            string[] str = s.Split(" ");

            for (int i = 0; i < str.Length; i++)
            {
                int count = 1;
                bool isvisited = false;

                for (int k = i - 1; k >= 0; k--)
                {
                    if (str[i] == str[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < str.Length; j++)
                    {
                        if (str[i] == str[j])
                        {
                            count++;
                        }
                    }
                    if (count > 1) /// display maximun Frequency
                    {
                        Console.WriteLine(str[i]);
                    }
                }
            }
        }
    }
}
