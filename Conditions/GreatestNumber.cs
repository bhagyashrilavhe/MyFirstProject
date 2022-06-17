using System;
using System.Collections.Generic;
using System.Text;

namespace Conditions
{
    class GreatestNumber
    {
        static void Main(String[] args)
        {
            int num1=77,num2=98, num3=65;


            if(num1>num2 && num1<num3)
            {
                Console.WriteLine("greatest number is num1 ");
            }
            else if(num2>num1 && num2>num3)
            {
                Console.WriteLine("greatest number is num2");
            }
            else if(num3>num1 && num3>num2)
            {
                Console.WriteLine("greatest number is num3");
            }
            else
            {
                Console.WriteLine("all are equals");
            }

            /*if(num1>num2)
            {
                if(num1>num3)
                {
                    Console.WriteLine("greatest number is num1");
                }
                
               else
                {
                    Console.WriteLine("greatest number is num3");
                }
            }
            else if(num2>num3)
            {
                Console.WriteLine("greatest number is num2");
            }
            else
            {
                Console.WriteLine("all are equals");
            }*/
     


        }
    }
}
