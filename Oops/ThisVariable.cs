using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    class ThisVariable
    {
        int x;

        public ThisVariable(int x)
        {
            this.x = x;
        }

        public void show()
        {
            Console.WriteLine(x);
        }
        static void Main(String[] args)
        {
            ThisVariable t = new ThisVariable(600);
            t.show();
        }
    }
}
