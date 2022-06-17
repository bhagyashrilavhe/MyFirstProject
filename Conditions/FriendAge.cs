using System;
using System.Collections.Generic;
using System.Text;

namespace Conditions
{
    class FriendAge
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter your age");
            int your = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter friend age");
            int friend = int.Parse(Console.ReadLine());

             if(your>friend)
             {
                 Console.WriteLine("Hiiii");
             }
             else if(your<friend)
             {
                 Console.WriteLine("Good Morning ");
             }
             else
             {
                 Console.WriteLine("How are you ?");
             }

            
        }
    }
}
