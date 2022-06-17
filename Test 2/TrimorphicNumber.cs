using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    class TrimorphicNumber
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            int temp = num;
            while (num > 0)
            {
                count++;
                num = num / 10;
            }
            num = temp;
            int cube = num * num * num ;
            int power = 1;

            for (int i = 1; i <= count; i++)
            {
                power = power * 10;
            }

            int end = cube % power;

            Console.WriteLine(cube + "     " + "end= " + end);

            if (end == num)
            {
                Console.WriteLine("Trimorphic Number");
            }
            else
            {
                Console.WriteLine("Not Trimorphic Number");
            }
        }
    }
}
