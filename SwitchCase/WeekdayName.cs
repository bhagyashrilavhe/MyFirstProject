using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchCase
{
    class WeekdayName
    {
        static void Main(String[] args)
        {
            int wday;
            Console.WriteLine("Enter weekday number(1-7):");
            wday = int.Parse(Console.ReadLine());

            switch(wday)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid Name ");
                    break;

            }
        }
    }
}
