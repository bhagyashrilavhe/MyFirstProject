using System;
using System.Collections.Generic;
using System.Text;

namespace AdvTestPaper
{
 //Reverse middle words of a string .
 //Given a string str, print reverse all words except the first and last words.
   // Examples:
    //Input : Hi how are you students
    //Output : Hi woh era uoy students
    //Input : I am fine
    //Output : I ma fine
    class ReverseMiddleWords
    {
        public static void revers(String str)
        {
            // Print first word
            int i = 0;
            for (i = 0; i < str.Length && str[i] != ' '; i++)
                Console.Write(str[i]);

            // Print middle words
            String word = "";

            for (; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    word += str[i];
                }
                else
                {
                    word = reverse(word);
                    Console.Write(new StringBuilder(word).ToString() + " ");
                    word = "";
                }
            }
            // Print last word
            Console.Write(word + " ");
        }
        static String reverse(String input)
        {
            char[] temparray = input.ToCharArray();
            int left, right = 0;
            right = temparray.Length - 1;

            for (left = 0; left < right; left++, right--)
            {
                // Swap values of left and right
                char temp = temparray[left];
                temparray[left] = temparray[right];
                temparray[right] = temp;
            }
            return String.Join("", temparray);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String : ");
            string str = Console.ReadLine();

            revers(str);
        }
    }
}
