using System;
using System.Collections.Generic;
using System.Text;

namespace Ternary
{
    class FriendAge
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter your age");
            int your = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter friend age");
            int friend = int.Parse(Console.ReadLine());

            string age = your > friend ? "Hiii" : your < friend ? "Good Morning" : "How are you";
            Console.WriteLine(age);
        }
    }
}
