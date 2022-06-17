using System;
using System.Collections.Generic;
using System.Text;

namespace Automorphic
{
    class PrimeNumber
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the number : ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for(int i=2;i<=10;i++)
            {
                int k = 2;
                int p = 1;

                while(k<i)
                {
                    if(i%k==0)
                    {
                        p = 0;
                        break;
                    }
                    k++;
                }
                if(p==1)
                {
                     sum = sum + i;
                }
            }
            Console.WriteLine("Sum of Prime Number : " + sum);
        }
    }
}
