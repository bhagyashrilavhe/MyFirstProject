﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Conditions
{
    class LeapYear
    {
        static void Main(String[] args)
        {
            int year;
            Console.WriteLine("Enter year:");

            year = int.Parse(Console.ReadLine());

            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("Not leap year");
            }

        }
    }
}
