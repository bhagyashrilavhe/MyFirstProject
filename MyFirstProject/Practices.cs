using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Practices
    {
       
       public  static void Main(string []args)
       {
            int i, j;
            i = 100;
            j = 200;
            while (++i < --j) ;
            {
                Console.WriteLine("Midpoint is = " + i);
            }
       }
    }

   
}
