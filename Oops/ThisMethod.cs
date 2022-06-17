using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    class ThisMethod
    {
        int x;
        public void get(int x)
        {
            this.x = x;
            //this.show();
        }

        public void show()
        {
            this.get(17);
            Console.WriteLine(x);
        }
        static void Main(String[] args)
        {
            ThisMethod t = new ThisMethod();
            //t.get(16);
            t.show();
        }
    }
}
