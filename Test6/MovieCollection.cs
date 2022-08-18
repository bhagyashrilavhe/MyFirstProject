using System;
using System.Collections.Generic;
using System.Text;

namespace Test6
{
//Make use of such collection that stores moviename such that last entered movie is first deleted and accordingly previous one.
    class MovieCollection
    {
        static void Main(string[] args)
        {
            Stack<string> s = new Stack<string>();
            s.Push("RAW");
            s.Push("Natsamrat");
            s.Push("K.G.F");
            s.Push("Deool Band");
            s.Pop();

            foreach(string obj in s)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
