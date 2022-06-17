using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    class ThisConstructor
    {
        
        int x;

        public ThisConstructor(int x)
        {
            this.x = x;
            this.show();
        }
        public ThisConstructor():this(66)
        {
            Console.WriteLine("Default");
        }
        public void show()
        {
            Console.WriteLine(x);
        }
        
        static void Main(string[] args)
        {
            ThisConstructor t = new ThisConstructor();
        }
    }
}
