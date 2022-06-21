using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class FrequencyOfEachElement
    {
        static void Main(String[] args)
        {
            int[] a = { 4, 1, 3, 1, 5, 2, 4 };

            for(int i=0;i<a.Length;i++)
            {
                int count = 1;
                bool isvisited = false;

                for(int k=i-1;k>=0;k--)
                {
                    if(a[i]==a[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for(int j=i+1;j<a.Length;j++)
                    {
                        if(a[i]==a[j])
                        {
                            count++;
                        }
                    }
                  //  Console.WriteLine(a[i] + " " + count);//display  all frequency

                    /*if (count == 1)//display minimum one frequency
                    {
                        Console.WriteLine(a[i] + " " + count);
                    }*/

                    if(count>1) /// display maximun Frequency
                    {
                        Console.WriteLine(a[i] + " " + count);
                    }
                }
            }
        }
    }
}
