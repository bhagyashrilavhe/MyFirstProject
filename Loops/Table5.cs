using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    class Table5
    {
        static void Main(String[] args)
        {
         
            Console.WriteLine("Enter the number :");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Multiplication table from 1 to 10");

            for(int i=1;i<=10;i++)
            {

                Console.WriteLine("{0} X {1} = {2}",num , i,num*i);
            }
        }
    }
}
