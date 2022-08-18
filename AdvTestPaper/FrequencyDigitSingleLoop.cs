using System;
using System.Collections.Generic;
using System.Text;

namespace AdvTestPaper
{
// WAP to find out frequency of each digit in given mobile number using only single loop.
    
    class FrequencyDigitSingleLoop
    {
        static void Main(string[] args)
        {
            long mb = 9876542310;
            string s = mb.ToString();
            char[] arr = s.ToCharArray();

            Dictionary<char, int> d = new Dictionary<char, int>();

            foreach(char c in arr)
            {
                if(d.ContainsKey(c))
                {
                    int oldval = d[c];
                    d[c] = oldval + 1;
                }
                else
                {
                    d.Add(c, 1);
                }
            }
            foreach (char c in arr)
            {
                Console.WriteLine(c);
            }
        }
    }
}
