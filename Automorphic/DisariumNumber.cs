using System;
using System.Collections.Generic;
using System.Text;

namespace Automorphic
{
    class DisariumNumber
    {
        public static int CalculateLength(int n)
        {
              int length = 0;

              while(n!=0)
              {
                  length = length + 1;
                  n = n / 10;
               
              }

             return length;
        }

        public static int SumOfDigit(int num)
        {
            int sum = 0, rem = 0;
            int len = CalculateLength(num);


            while (num > 0)
            {
                rem = num % 10;
                sum = sum + (int)Math.Pow(rem, len);
                num = num / 10;
                len--;
            }
            return sum;
        }

        static void Main(String[] args)
        {
            int result = 0;
            
             Console.WriteLine("Disarium Number");
           
            for(int i=1;i<=1000;i++)
            {
                result = SumOfDigit(i);

                if(result==i)
                {
                    Console.Write(i + " ");
                }
            }

        }

    }
}
