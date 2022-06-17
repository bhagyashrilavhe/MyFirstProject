using System;
using System.Collections.Generic;
using System.Text;

namespace Conditions
{
    class Grade
    {
        static void Main(String[] args)
        {
            double m1, m2, m3, m4, m5, perc;

            Console.WriteLine("Enter marks of 1st subject out of 100");
            m1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks of 2nd subject out of 100");
            m2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks of 3rd subject out of 100");
            m3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks of 4th subject out of 100");
            m4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks of 5th subject out of 100");
            m5 = double.Parse(Console.ReadLine());

            perc = ((m1 + m2 + m3 + m4 + m5) / 500) * 100;
            
            if(perc>=70)
            {
                Console.WriteLine("Distinction");
            }
            else if(perc>=60 && perc<70)
            {
                Console.WriteLine("First Class");
            }
            else if(perc>=40 && perc<60)
            {
                Console.WriteLine("Second Class");
            }
            else if(perc==35 && perc<40)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }

        }
    }
}
