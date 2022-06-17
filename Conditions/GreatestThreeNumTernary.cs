using System;
using System.Collections.Generic;
using System.Text;

namespace Conditions
{
    class GreatestThreeNumTernary
    {
        static void Main(String[] args)
        {

            Console.WriteLine("Enter the 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 3rd number");
            int num3 = int.Parse(Console.ReadLine());

            int temp = num1 > num2 ? num1 : num2;
            int max = num3 > temp ? num3 : temp;

            Console.WriteLine(max);

            /*int max = (num1 > num2) ? num1 > num3 ? num1 : num3 : num2 > num3 ? num2 : num3;
            Console.WriteLine(max);*/

            //OROperator
           /* int max = (num1 > num2 && num1 > num3) ? num1 : (num2 > num3) ? num2 : num3;
            Console.WriteLine(max);*/

        }
    }
}
