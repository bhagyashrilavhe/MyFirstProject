using System;
using System.Collections.Generic;
using System.Text;

namespace Automorphic
{
    class AutoMorphicNumber
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            int temp = num;
            while(num>0)
            {
                count++;
                num = num / 10;
            }

            //Console.WriteLine(count);

            num = temp;
            int sq = num * num;
            int power = 1;
            for(int i=1;i<=count;i++)
            {
                power = power * 10;
            }

            //Console.WriteLine(sq + "  " + power);

            int end = sq % power;

            Console.WriteLine(sq + " " + "end= " + end);

            if(end==num)
            {
                Console.WriteLine("Automorphic");
            }
            else
            {
                Console.WriteLine("Not");
            }
        }
    }
}
