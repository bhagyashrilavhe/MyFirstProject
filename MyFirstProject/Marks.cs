using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Marks
    {
        static void Main(string[] args)
        {
            int maths = 89 ,english = 67 ,marathi = 77 ,hindi = 65 ,science = 66;
            float avg;
            avg = (maths + english + marathi + hindi + science) / 5;
            Console.WriteLine("Average of 5 subject marks " + avg);

        }
    }
}
