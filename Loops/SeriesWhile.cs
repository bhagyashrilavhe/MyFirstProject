using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    class SeriesWhile
    {
        static void Main(String[] args)
        {
            //2,12,36,80
            /*int i=1;
           while(i<=10)
            {
                Console.Write(i * i + ( i * i * i ) +" ");
                i++;
            }*/

            //0,3,8,15,24

            /*int i = 1;
            while(i<=10)
            {
                Console.Write(i * i - 1);
                i++;
            }*/

            //2,5,10,17,26
            int i = 1;
            while (i <= 10)
            {
                Console.Write(i * i + 1 + " ");
                i++;
            }
        }
    }
}
