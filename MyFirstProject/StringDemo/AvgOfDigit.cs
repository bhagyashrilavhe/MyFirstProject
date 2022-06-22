using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringDemo
{
    class AvgOfDigit
    {
        public static void CheckAvg(string s)
        {
            int avg = 0, sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                {
                    int x = (int)Char.GetNumericValue(s[i]);
                    sum = sum + x;

                }
                avg = sum / 3;
                
            }

            Console.WriteLine(avg);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String : ");
            string str = Console.ReadLine();

            CheckAvg(str);

        } 
    }    
}
