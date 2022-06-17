using System;
using System.Collections.Generic;
using System.Text;

namespace Automorphic
{
    class KaprekarNumber
    {

        public void check(int num)
        {
            int temp = num;

            int sq = num * num;
            int count = 0;
            while(num>0)
            {
                count++;
                num = num / 10;
            }
            int power = 1;
            for(int i=1;i<=count;i++)
            {
                power = power * 10;
            }

            int division = sq / power;
            int reminder = sq % power;

            int sum = division + reminder;
            if(sum==temp)
            {
                Console.WriteLine("Kaprekar");
            }
            else
            {
                Console.WriteLine("Not Kaprekar");
            }
        }

        static void Main(String[] args)
        {
            KaprekarNumber kn = new KaprekarNumber();
            kn.check(10);
        }
    }
}
