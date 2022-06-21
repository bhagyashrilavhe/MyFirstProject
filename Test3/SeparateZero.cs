using System;
using System.Collections.Generic;
using System.Text;

namespace Test3
{
    class SeparateZero
    {
        static void Main(String[] args)
        {
            int[] inputArray = { 12, 0, 7, 0, 8, 0, 3 };
            Console.WriteLine("After Input Array : ");
          
            int count = 0;

            for(int i=0;i<inputArray.Length;i++)
            {
                if(inputArray[i]!=0)
                {
                    inputArray[count] = inputArray[i];
                    count++;
                }
            }
            while(count<inputArray.Length)
            {
                inputArray[count] = 0;
                count++;
            }
            Console.WriteLine("Input Array After moving zero to end  : ");
            Console.WriteLine(string.Join(" ", inputArray));
        }
    }
}
