using System;
using System.Collections.Generic;
using System.Text;

namespace Test4
{
    // WAP to print all unique elements in the array
    class UniqueElementArray
    {
        static void Main(string[] args)
        {
            int[] a = { 10,20,30,40,50,10,20,30,100,200 };

            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;
                bool isvisited = false;

                for (int k = i - 1; k >= 0; k--)
                {
                    if (a[i] == a[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                    if (count == 1)
                    {
                        Console.WriteLine("Unique elements in the array : "+a[i]);
                    }
                }
            }
        }
    }
}
